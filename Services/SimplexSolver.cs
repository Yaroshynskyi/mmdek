using Mmdo.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderMmdoCoursework.src.Calculator
{
    public enum StepResult { Unbounded, Found, NotYetFound }

    public class SimplexSolver
    {
        ObjectiveFunction _function;
        double[] _objectiveCoeffs;
        double[][] _tableau;
        double[] _bValues;
        bool[] _isArtificial;
        double[] _mRow;
        double[] _zRow;
        int[] _basicVars;
        bool _artificialPhaseComplete = false;

        public SimplexSolver(ObjectiveFunction function, LinearConstraint[] constraints)
        {
            _function = function;

            InitializeTableau(constraints);
            SetupObjectiveFunction();
            CalculateEvaluations();

            for (int i = 0; i < _zRow.Length; i++)
            {
                _zRow[i] = -_objectiveCoeffs[i];
            }
        }

        public SimplexSolver(SimplexSnapshot screenshot, ObjectiveFunction function)
        {
            _bValues = screenshot.b;
            _tableau = screenshot.matrix;
            _mRow = screenshot.M;
            _zRow = screenshot.F;
            _basicVars = screenshot.C;
            _objectiveCoeffs = screenshot.fVars;
            _isArtificial = screenshot.m;
            _function = function;

            SetupObjectiveFunction();
            CalculateEvaluations();

            for (int i = 0; i < _zRow.Length; i++)
            {
                _zRow[i] = -_objectiveCoeffs[i];
            }
        }

        public ObjectiveFunction GetFunction() { return _function; }

        public List<SimplexStep> GetResultTable()
        {
            var iterations = new List<SimplexStep>();

            var initialSnapshot = new SimplexSnapshot(_bValues, _tableau, _mRow, _zRow, _basicVars, _objectiveCoeffs, _artificialPhaseComplete, _isArtificial);
            iterations.Add(new SimplexStep(initialSnapshot, StepResult.NotYetFound));

            PivotCoordinates pivot = FindPivot();
            int iterationLimit = 0;

            while (pivot.Status == StepResult.NotYetFound && iterationLimit < 100)
            {
                PerformPivot(pivot.Position);
                SimplexSnapshot currentSnapshot = new SimplexSnapshot(_bValues, _tableau, _mRow, _zRow, _basicVars, _objectiveCoeffs, _artificialPhaseComplete, _isArtificial);
                pivot = FindPivot();

                iterations.Add(new SimplexStep(currentSnapshot, pivot.Status));
                iterationLimit++;
            }

            return iterations;
        }

        void PerformPivot(Tuple<int, int> pivotCoords)
        {
            int pivotCol = pivotCoords.Item1;
            int pivotRow = pivotCoords.Item2;

            // В оригіналі матриця зберігається як [стовпець][рядок]
            double pivotValue = _tableau[pivotCol][pivotRow];

            double[][] nextTableau = new double[_tableau.Length][];
            _basicVars[pivotRow] = pivotCol;

            double[] normalizedRow = new double[_tableau.Length];
            for (int i = 0; i < _tableau.Length; i++)
            {
                normalizedRow[i] = _tableau[i][pivotRow] / pivotValue;
            }

            double[] nextBValues = new double[_bValues.Length];
            for (int i = 0; i < _bValues.Length; i++)
            {
                if (i == pivotRow)
                {
                    nextBValues[i] = _bValues[i] / pivotValue;
                }
                else
                {
                    nextBValues[i] = _bValues[i] - (_bValues[pivotRow] / pivotValue) * _tableau[pivotCol][i];
                }
            }

            _bValues = nextBValues;

            for (int i = 0; i < _tableau.Length; i++)
            {
                nextTableau[i] = new double[_basicVars.Length];
                for (int j = 0; j < _basicVars.Length; j++)
                {
                    if (j == pivotRow)
                    {
                        nextTableau[i][j] = normalizedRow[i];
                    }
                    else
                    {
                        nextTableau[i][j] = _tableau[i][j] - normalizedRow[i] * _tableau[pivotCol][j];
                    }
                }
            }

            _tableau = nextTableau;
            CalculateEvaluations();
        }

        void CalculateEvaluations()
        {
            _mRow = new double[_tableau.Length];
            _zRow = new double[_tableau.Length];

            for (int i = 0; i < _tableau.Length; i++)
            {
                double sumZ = 0;
                double sumM = 0;

                for (int j = 0; j < _tableau.First().Length; j++)
                {
                    if (_isArtificial[_basicVars[j]])
                    {
                        sumM -= _tableau[i][j];
                    }
                    else
                    {
                        sumZ += _objectiveCoeffs[_basicVars[j]] * _tableau[i][j];
                    }
                }

                _mRow[i] = _isArtificial[i] ? sumM + 1 : sumM;
                _zRow[i] = sumZ - _objectiveCoeffs[i];
            }
        }

        PivotCoordinates FindPivot()
        {
            int enteringColM = GetEnteringVariable(_mRow);

            if (_artificialPhaseComplete || enteringColM == -1)
            {
                _artificialPhaseComplete = true;
                int enteringColZ = GetEnteringVariable(_zRow);

                if (enteringColZ != -1)
                {
                    int leavingRow = GetLeavingVariable(_tableau[enteringColZ], _bValues);
                    if (leavingRow != -1)
                        return new PivotCoordinates(new Tuple<int, int>(enteringColZ, leavingRow), StepResult.NotYetFound);
                    else
                        return new PivotCoordinates(null, StepResult.Unbounded);
                }
                else
                    return new PivotCoordinates(null, StepResult.Found);
            }
            else
            {
                int leavingRow = GetLeavingVariable(_tableau[enteringColM], _bValues);

                if (leavingRow != -1)
                {
                    return new PivotCoordinates(new Tuple<int, int>(enteringColM, leavingRow), StepResult.NotYetFound);
                }
                else
                {
                    return new PivotCoordinates(null, StepResult.Unbounded);
                }
            }
        }

        int GetEnteringVariable(double[] evaluations)
        {
            int bestIndex = -1;

            for (int i = 0; i < evaluations.Length; i++)
            {
                if (evaluations[i] < 0)
                {
                    if (!_artificialPhaseComplete || (_artificialPhaseComplete && !_isArtificial[i]))
                    {
                        if (bestIndex == -1)
                        {
                            bestIndex = i;
                        }
                        else if (Math.Abs(evaluations[i]) > Math.Abs(evaluations[bestIndex]))
                        {
                            bestIndex = i;
                        }
                    }
                }
            }
            return bestIndex;
        }

        int GetLeavingVariable(double[] column, double[] bounds)
        {
            int bestIndex = -1;

            for (int i = 0; i < column.Length; i++)
            {
                if (column[i] > 0 && bounds[i] > 0)
                {
                    if (bestIndex == -1)
                    {
                        bestIndex = i;
                    }
                    else if (bounds[i] / column[i] < bounds[bestIndex] / column[bestIndex])
                    {
                        bestIndex = i;
                    }
                }
            }

            return bestIndex;
        }

        public void SetupObjectiveFunction()
        {
            double[] expandedVars = new double[_tableau.Length];
            for (int i = 0; i < _tableau.Length; i++)
            {
                expandedVars[i] = i < _function.Variables.Length ? _function.Variables[i] : 0;
            }
            _objectiveCoeffs = expandedVars;
        }

        double[][] AddColumn(double[][] matrix, double[] column)
        {
            double[][] resultMatrix = new double[matrix.Length + 1][];
            for (int i = 0; i < matrix.Length; i++)
            {
                resultMatrix[i] = matrix[i];
            }
            resultMatrix[matrix.Length] = column;
            return resultMatrix;
        }

        T[] AddElement<T>(T[] array, T element)
        {
            T[] resultArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                resultArray[i] = array[i];
            }
            resultArray[array.Length] = element;
            return resultArray;
        }

        double[] CreateUnitVector(double value, int position, int length)
        {
            double[] vector = new double[length];
            for (int k = 0; k < length; k++)
            {
                vector[k] = k == position ? value : 0;
            }
            return vector;
        }

        public void InitializeTableau(LinearConstraint[] constraints)
        {
            double[][] tempMatrix = new double[constraints.First().Coefficients.Length][];

            for (int i = 0; i < constraints.First().Coefficients.Length; i++)
            {
                tempMatrix[i] = new double[constraints.Length];
                for (int j = 0; j < constraints.Length; j++)
                {
                    tempMatrix[i][j] = constraints[j].Coefficients[i];
                }
            }

            double[][] slackMatrix = new double[0][];
            double[] bounds = new double[constraints.Length];

            for (int i = 0; i < constraints.Length; i++)
            {
                bounds[i] = constraints[i].Limit;
                slackMatrix = AddColumn(slackMatrix, CreateUnitVector(1, i, constraints.Length));
            }

            double[][] fullMatrix = new double[constraints.First().Coefficients.Length + slackMatrix.Length][];

            for (int i = 0; i < constraints.First().Coefficients.Length; i++)
            {
                fullMatrix[i] = tempMatrix[i];
            }

            for (int i = constraints.First().Coefficients.Length; i < constraints.First().Coefficients.Length + slackMatrix.Length; i++)
            {
                fullMatrix[i] = slackMatrix[i - constraints.First().Coefficients.Length];
            }

            bool[] isBasicFound = new bool[constraints.Length];
            for (int i = 0; i < constraints.Length; i++)
            {
                isBasicFound[i] = false;
            }

            _basicVars = new int[constraints.Length];

            int basicCount = 0;
            for (int i = 0; i < fullMatrix.Length; i++)
            {
                bool onlyZeros = true;
                bool hasOne = false;
                Tuple<int, int> onePos = new Tuple<int, int>(0, 0);

                for (int j = 0; j < constraints.Length; j++)
                {
                    if (fullMatrix[i][j] == 1)
                    {
                        if (hasOne)
                        {
                            onlyZeros = false;
                            break;
                        }
                        else
                        {
                            hasOne = true;
                            onePos = new Tuple<int, int>(i, j);
                        }
                    }
                    else if (fullMatrix[i][j] != 0)
                    {
                        onlyZeros = false;
                        break;
                    }
                }

                if (onlyZeros && hasOne)
                {
                    isBasicFound[onePos.Item2] = true;
                    _basicVars[basicCount] = onePos.Item1;
                    basicCount++;
                }
            }

            _isArtificial = new bool[fullMatrix.Length];
            for (int i = 0; i < fullMatrix.Length; i++)
            {
                _isArtificial[i] = false;
            }

            for (int i = 0; i < constraints.Length; i++)
            {
                if (!isBasicFound[i])
                {
                    double[] artificialCol = new double[constraints.Length];
                    for (int j = 0; j < constraints.Length; j++)
                    {
                        artificialCol[j] = j == i ? 1 : 0;
                    }

                    fullMatrix = AddColumn(fullMatrix, artificialCol);
                    _isArtificial = AddElement(_isArtificial, true);
                    _basicVars[basicCount] = fullMatrix.Length - 1;
                    basicCount++;
                }
            }

            _bValues = bounds;
            _tableau = fullMatrix;
        }
    }
}