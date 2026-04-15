using Mmdo.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderMmdoCoursework.src.Calculator
{
    public enum TypeIteration { Unbounded, Found, NotYetFound }

    public class SimplexSolver
    {
        TargetFunction function;

        double[] functionVariables;
        double[][] matrixData;
        double[] xVals;
        bool[] isMarr;
        double[] Mcal;
        double[] funcRow;
        int[] xData;
        bool mFound = false;


        public SimplexSolver(TargetFunction function, Constraint[] constraints)
        {
            this.function = function;


            getMatrix(constraints);
            getFunctionArray();
            CountFuncRowValues();

            for (int i = 0; i < funcRow.Length; i++)
            {
                funcRow[i] = -functionVariables[i];
            }

        }

        public SimplexSolver(SimplexSnapshot screenshot, TargetFunction function)
        {
            this.xVals = screenshot.b;
            this.matrixData = screenshot.matrix;
            this.Mcal = screenshot.M;
            this.funcRow = screenshot.F;
            this.xData = screenshot.C;
            this.functionVariables = screenshot.fVars;
            this.isMarr = screenshot.m;

            this.function = function;


            getFunctionArray();
            CountFuncRowValues();

            for (int i = 0; i < funcRow.Length; i++)
            {
                funcRow[i] = -functionVariables[i];
            }
        }

        public TargetFunction GetFunction() { return function; }


        public List<IterationData> GetResultTable()
        {
            var allTables = new List<IterationData>();

            var initialTable = new SimplexSnapshot(xVals, matrixData, Mcal, funcRow, xData, functionVariables, mFound, isMarr);
            IterationData tableData = (new IterationData(initialTable, TypeIteration.NotYetFound));
            allTables.Add(tableData);

            VectorElement result = SelectElement();

            int iterationCount = 0;
            while (result.result == TypeIteration.NotYetFound && iterationCount < 100)
            {
                SolveMatrix(result.index);
                SimplexSnapshot table = new SimplexSnapshot(xVals, matrixData, Mcal, funcRow, xData, functionVariables, mFound, isMarr);
                result = SelectElement();

                tableData = (new IterationData(table, result.result));

                allTables.Add(tableData);
                iterationCount++;
            }

            return allTables;
        }



        #region GOMORY
        public Tuple<SimplexSnapshot, TypeIteration> GetOneIterationForGomory()
        {
            // TableScreenshot snap = new TableScreenshot(gomoryTable.B, gomoryTable.Matrix, gomoryTable.M,
            //      gomoryTable.F, gomoryTable.C, gomoryTable.fVars, gomoryTable.mCompleted, gomoryTable.m);


            //ResultColIndex result = nextStep();
            CountFuncRowValues();
            VectorElement result = nextStepGomory();

            if (result.result == TypeIteration.NotYetFound)
            {
                SolveMatrix(result.index);
            }


            SimplexSnapshot resultSnap = new SimplexSnapshot(xVals, matrixData, Mcal, funcRow, xData, functionVariables, mFound, isMarr);
            return new Tuple<SimplexSnapshot, TypeIteration>(resultSnap, result.result);


        }

        public IterationData GetOneGomoryIteration()
        {
            CountFuncRowValues();
            VectorElement result = nextStepGomory();

            if (result.result == TypeIteration.NotYetFound)
            {
                SolveMatrix(result.index);
            }


            SimplexSnapshot resultSnap = new SimplexSnapshot(xVals, matrixData, Mcal, funcRow, xData, functionVariables, mFound, isMarr);
            return new IterationData(resultSnap, result.result);
        }




        protected VectorElement nextStepGomory()
        {

            int rowID = FindColumn(xVals);

            if (rowID != -1)
            {
                //M doesn't have negative values
                //mCompleted = true;

                //if (columnF != -1) //Has at least 1 negative value
                {
                    double[] xRow = GetCol(matrixData, rowID);
                    int c = getIndexOfMinimalRatioGomory(xRow, funcRow); //matrix[rowID]

                    if (c != -1)
                    {
                        //double test = matrix[rowID][c];
                        return new VectorElement(new Tuple<int, int>(c, rowID), TypeIteration.NotYetFound);
                    }
                    else
                    {
                        return new VectorElement(null, TypeIteration.Unbounded);
                    }
                }

            }
            else
                return new VectorElement(null, TypeIteration.Found);
        }


        public double[] GetCol(double[][] jaggedArray, int columnIndex)
        {
            double[] column = new double[jaggedArray.Length];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                column[i] = jaggedArray[i][columnIndex];
            }

            return column;
        }



        int getIndexOfMinimalRatioGomory(double[] column, double[] b)
        {
            int index = -1;

            for (int i = 0; i < column.Length; i++)
            {

                if (column[i] < 0 /*&& b[i] != 0*/)
                {
                    if (index == -1)
                    {
                        index = i;
                    }
                    else if (Math.Abs(b[i] / column[i]) < Math.Abs(b[index] / column[index]))
                    {
                        index = i;
                    }
                }

            }

            return index;
        }


        #endregion


        void SolveMatrix(Tuple<int, int> cellCoordinates)
        {
            double[][] newMatrix = new double[matrixData.Length][];

            xData[cellCoordinates.Item2] = cellCoordinates.Item1;

            double[] newJRow = new double[matrixData.Length];

            for (int i = 0; i < matrixData.Length; i++)
            {
                newJRow[i] = matrixData[i][cellCoordinates.Item2] / matrixData[cellCoordinates.Item1][cellCoordinates.Item2];
            }

            double[] newB = new double[xVals.Length];

            for (int i = 0; i < xVals.Length; i++)
            {
                if (i == cellCoordinates.Item2)
                {
                    newB[i] = xVals[i] / matrixData[cellCoordinates.Item1][cellCoordinates.Item2];
                }
                else
                {
                    newB[i] = xVals[i] - xVals[cellCoordinates.Item2] / matrixData[cellCoordinates.Item1][cellCoordinates.Item2] * matrixData[cellCoordinates.Item1][i];
                }
            }

            xVals = newB;

            for (int i = 0; i < matrixData.Length; i++)
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
                        newMatrix[i][j] = matrixData[i][j] - newJRow[i] * matrixData[cellCoordinates.Item1][j];
                    }
                }
            }

            matrixData = newMatrix;
            CountFuncRowValues();
        }


        void CountFuncRowValues()
        {
            Mcal = new double[matrixData.Length];
            funcRow = new double[matrixData.Length];

            for (int i = 0; i < matrixData.Length; i++)
            {
                double sumF = 0;
                double sumM = 0;

                for (int j = 0; j < matrixData.First().Length; j++)
                {
                    if (isMarr[xData[j]])
                    {
                        sumM -= matrixData[i][j];
                    }
                    else
                    {
                        sumF += functionVariables[xData[j]] * matrixData[i][j];
                    }
                }

                Mcal[i] = isMarr[i] ? sumM + 1 : sumM;
                funcRow[i] = sumF - functionVariables[i];
            }
        }


        VectorElement SelectElement()
        {
            int columnM = FindColumn(Mcal);

            if (mFound || columnM == -1)
            {
                mFound = true;
                int f = FindColumn(funcRow);

                if (f != -1)
                {
                    int row = FindRow(matrixData[f], xVals);
                    if (row != -1)
                        return new VectorElement(new Tuple<int, int>(f, row), TypeIteration.NotYetFound);
                    else
                        return new VectorElement(null, TypeIteration.Unbounded);
                }
                else
                    return new VectorElement(null, TypeIteration.Found);
            }
            else
            {
                int row = FindRow(matrixData[columnM], xVals);

                if (row != -1)
                {
                    return new VectorElement(new Tuple<int, int>(columnM, row), TypeIteration.NotYetFound);
                }
                else
                {
                    return new VectorElement(null, TypeIteration.Unbounded);
                }
            }
        }

        int FindColumn(double[] array)
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

        int FindRow(double[] column, double[] b)
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
            double[] funcVars = new double[matrixData.Length];
            for (int i = 0; i < matrixData.Length; i++)
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

        public void getMatrix(Constraint[] constraints)
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
                Constraint current = constraints[i];

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
            this.matrixData = newMatrix;
        }
    }
}
