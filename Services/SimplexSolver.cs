using Mmdo.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderMmdoCoursework.src.Calculator
{
    public enum TypeIteration { Unbounded, Found, NotYetFound }

    public class SimplexSolver
    {
        ObjectiveFunction function;

        double[] functionVariables;
        double[][] _tableau;
        double[] xVals;
        bool[] isMarr;
        double[] Mcal;
        double[] _zRow;
        int[] xData;
        bool mFound = false;


        public SimplexSolver(ObjectiveFunction function, LinearConstraint[] constraints)
        {
            this.function = function;


            BuildInitialTableau(constraints);
            getFunctionArray();
            CalculateDeltas();

            for (int i = 0; i < _zRow.Length; i++)
            {
                _zRow[i] = -functionVariables[i];
            }

        }

        public SimplexSolver(SimplexSnapshot screenshot, ObjectiveFunction function)
        {
            this.xVals = screenshot.b;
            this._tableau = screenshot.matrix;
            this.Mcal = screenshot.M;
            this._zRow = screenshot.F;
            this.xData = screenshot.C;
            this.functionVariables = screenshot.fVars;
            this.isMarr = screenshot.m;

            this.function = function;


            getFunctionArray();
            CalculateDeltas();

            for (int i = 0; i < _zRow.Length; i++)
            {
                _zRow[i] = -functionVariables[i];
            }
        }

        public ObjectiveFunction GetFunction() { return function; }


        public List<SimplexStep> GetResultTable()
        {
            var allTables = new List<SimplexStep>();

            var initialTable = new SimplexSnapshot(xVals, _tableau, Mcal, _zRow, xData, functionVariables, mFound, isMarr);
            SimplexStep tableData = (new SimplexStep(initialTable, TypeIteration.NotYetFound));
            allTables.Add(tableData);

            PivotCoordinates result = FindPivotElement();

            int iterationCount = 0;
            while (result.result == TypeIteration.NotYetFound && iterationCount < 100)
            {
                PerformPivotOperation(result.index);
                SimplexSnapshot table = new SimplexSnapshot(xVals, _tableau, Mcal, _zRow, xData, functionVariables, mFound, isMarr);
                result = FindPivotElement();

                tableData = (new SimplexStep(table, result.result));

                allTables.Add(tableData);
                iterationCount++;
            }

            return allTables;
        }

        void PerformPivotOperation(Tuple<int, int> cellCoordinates)
        {
            double[][] newMatrix = new double[_tableau.Length][];

            xData[cellCoordinates.Item2] = cellCoordinates.Item1;

            double[] newJRow = new double[_tableau.Length];

            for (int i = 0; i < _tableau.Length; i++)
            {
                newJRow[i] = _tableau[i][cellCoordinates.Item2] / _tableau[cellCoordinates.Item1][cellCoordinates.Item2];
            }

            double[] newB = new double[xVals.Length];

            for (int i = 0; i < xVals.Length; i++)
            {
                if (i == cellCoordinates.Item2)
                {
                    newB[i] = xVals[i] / _tableau[cellCoordinates.Item1][cellCoordinates.Item2];
                }
                else
                {
                    newB[i] = xVals[i] - xVals[cellCoordinates.Item2] / _tableau[cellCoordinates.Item1][cellCoordinates.Item2] * _tableau[cellCoordinates.Item1][i];
                }
            }

            xVals = newB;

            for (int i = 0; i < _tableau.Length; i++)
            {
                newMatrix[i] = new double[xData.Length];
                for (int j = 0; j < xData.Length; j++)
                {
                    if (j == cellCoordinates.Item2)
                    {
                        newMatrix[i][j] = newJRow[i];
                    }
                    else
                    {
                        newMatrix[i][j] = _tableau[i][j] - newJRow[i] * _tableau[cellCoordinates.Item1][j];
                    }
                }
            }

            _tableau = newMatrix;
            CalculateDeltas();
        }


        void CalculateDeltas()
        {
            Mcal = new double[_tableau.Length];
            _zRow = new double[_tableau.Length];

            for (int i = 0; i < _tableau.Length; i++)
            {
                double sumF = 0;
                double sumM = 0;

                for (int j = 0; j < _tableau.First().Length; j++)
                {
                    if (isMarr[xData[j]])
                    {
                        sumM -= _tableau[i][j];
                    }
                    else
                    {
                        sumF += functionVariables[xData[j]] * _tableau[i][j];
                    }
                }

                Mcal[i] = isMarr[i] ? sumM + 1 : sumM;
                _zRow[i] = sumF - functionVariables[i];
            }
        }


        PivotCoordinates FindPivotElement()
        {
            int columnM = GetEnteringVariable(Mcal);

            if (mFound || columnM == -1)
            {
                mFound = true;
                int f = GetEnteringVariable(_zRow);

                if (f != -1)
                {
                    int row = GetLeavingVariable(_tableau[f], xVals);
                    if (row != -1)
                        return new PivotCoordinates(new Tuple<int, int>(f, row), TypeIteration.NotYetFound);
                    else
                        return new PivotCoordinates(null, TypeIteration.Unbounded);
                }
                else
                    return new PivotCoordinates(null, TypeIteration.Found);
            }
            else
            {
                int row = GetLeavingVariable(_tableau[columnM], xVals);

                if (row != -1)
                {
                    return new PivotCoordinates(new Tuple<int, int>(columnM, row), TypeIteration.NotYetFound);
                }
                else
                {
                    return new PivotCoordinates(null, TypeIteration.Unbounded);
                }
            }
        }

        int GetEnteringVariable(double[] array)
        {
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    if (!mFound || mFound && !isMarr[i])
                    {
                        if (index == -1)
                        {
                            index = i;
                        }
                        else if (Math.Abs(array[i]) > Math.Abs(array[index]))
                        {
                            index = i;
                        }
                    }

                }
            }
            return index;
        }

        int GetLeavingVariable(double[] column, double[] b)
        {
            int index = -1;

            for (int i = 0; i < column.Length; i++)
            {
                if (column[i] > 0 && b[i] > 0)
                {
                    if (index == -1)
                    {
                        index = i;
                    }
                    else if (b[i] / column[i] < b[index] / column[index])
                    {
                        index = i;
                    }
                }
            }

            return index;
        }


        public void getFunctionArray()
        {
            double[] funcVars = new double[_tableau.Length];
            for (int i = 0; i < _tableau.Length; i++)
            {
                funcVars[i] = i < function.variables.Length ? function.variables[i] : 0;
            }
            this.functionVariables = funcVars;
        }

        double[][] appendColumn(double[][] matrix, double[] column)
        {
            double[][] newMatrix = new double[matrix.Length + 1][];
            for (int i = 0; i < matrix.Length; i++)
            {
                newMatrix[i] = matrix[i];
            }
            newMatrix[matrix.Length] = column;
            return newMatrix;
        }

        T[] append<T>(T[] array, T element)
        {
            T[] newArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = element;
            return newArray;
        }

        double[] getColumn(double value, int place, int length)
        {
            double[] newColumn = new double[length];

            for (int k = 0; k < length; k++)
            {
                newColumn[k] = k == place ? value : 0;
            }

            return newColumn;
        }

        public void BuildInitialTableau(LinearConstraint[] constraints)
        {
            double[][] matrix = new double[constraints.First().vars.Length][];

            for (int i = 0; i < constraints.First().vars.Length; i++)
            {
                matrix[i] = new double[constraints.Length];
                for (int j = 0; j < constraints.Length; j++)
                {
                    matrix[i][j] = constraints[j].vars[i];
                }
            }

            double[][] appendixMatrix = new double[0][];
            double[] Bs = new double[constraints.Length];

            for (int i = 0; i < constraints.Length; i++)
            {
                LinearConstraint current = constraints[i];

                Bs[i] = current.b;

                {
                    appendixMatrix = appendColumn(appendixMatrix, getColumn(1, i, constraints.Length));
                }
            }

            double[][] newMatrix = new double[constraints.First().vars.Length + appendixMatrix.Length][];

            for (int i = 0; i < constraints.First().vars.Length; i++)
            {
                newMatrix[i] = matrix[i];
            }

            for (int i = constraints.First().vars.Length; i < constraints.First().vars.Length + appendixMatrix.Length; i++)
            {
                newMatrix[i] = appendixMatrix[i - constraints.First().vars.Length];
            }

            bool[] hasBasicVar = new bool[constraints.Length];

            for (int i = 0; i < constraints.Length; i++)
            {
                hasBasicVar[i] = false;
            }

            xData = new int[constraints.Length];

            int ci = 0;
            for (int i = 0; i < newMatrix.Length; i++)
            {


                bool hasOnlyNulls = true;
                bool hasOne = false;
                Tuple<int, int> onePosition = new Tuple<int, int>(0, 0);
                for (int j = 0; j < constraints.Length; j++)
                {


                    if (newMatrix[i][j] == 1)
                    {
                        if (hasOne)
                        {
                            hasOnlyNulls = false;
                            break;
                        }
                        else
                        {
                            hasOne = true;
                            onePosition = new Tuple<int, int>(i, j);
                        }
                    }
                    else if (newMatrix[i][j] != 0)
                    {
                        hasOnlyNulls = false;
                        break;
                    }


                }

                if (hasOnlyNulls && hasOne)
                {
                    hasBasicVar[onePosition.Item2] = true;
                    xData[ci] = onePosition.Item1;
                    ci++;
                }

            }

            isMarr = new bool[newMatrix.Length];

            for (int i = 0; i < newMatrix.Length; i++)
            {
                isMarr[i] = false;
            }

            for (int i = 0; i < constraints.Length; i++)
            {

                if (!hasBasicVar[i])
                {

                    double[] basicColumn = new double[constraints.Length];

                    for (int j = 0; j < constraints.Length; j++)
                    {
                        basicColumn[j] = j == i ? 1 : 0;
                    }

                    newMatrix = appendColumn(newMatrix, basicColumn);
                    isMarr = append(isMarr, true);
                    xData[ci] = newMatrix.Length - 1;
                    ci++;
                }

            }

            this.xVals = Bs;
            this._tableau = newMatrix;
        }
    }
}
