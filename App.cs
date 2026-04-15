using BuilderMmdoCoursework.src.Calculator;
using Mmdo.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BuilderMmdoCoursework
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            labelCounter.Text = "";
            Result.Text = "";
        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            TabController.SelectedIndex = 1;
            BuildExpression();

        }


        public List<SimplexStep> AllIterations = new List<SimplexStep>();
        public SimplexStep selectedTable;

        void BuildExpression()
        {
            CurrentId = 0;
            AllIterations.Clear();
            selectedTable = null;

            List<LinearConstraint> constraints = new List<LinearConstraint>
            {
                new LinearConstraint( new double[] { Convert(item1P1.Value), Convert(item2P1.Value) }, Convert(store1.Value)),
                new LinearConstraint( new double[] { Convert(item1P2.Value), Convert(item2P2.Value) }, Convert(store2.Value)),
                new LinearConstraint( new double[] { Convert(item1P3.Value), Convert(item2P3.Value) }, Convert(store3.Value)),
                new LinearConstraint( new double[] { Convert(item1P4.Value), Convert(item2P4.Value) }, Convert(store4.Value)),
            };

            double[] functionVariables = new double[] { Convert(item1Cost.Value), Convert(item2Cost.Value) };

            ObjectiveFunction function = new ObjectiveFunction(functionVariables);
            SimplexSolver simplex = new SimplexSolver(function, constraints.ToArray());

            var simplexRes = simplex.GetResultTable();

            AllIterations = simplexRes;
            SetIteration(0);

            ShowFinalAnswer();
        }

        double Convert(decimal d)
        {
            return (double)d;
        }

        void ShowTable()
        {
            SolutionGrid.Rows.Clear();
            SimplexSnapshot snap = selectedTable.table;

            int addRows = 3;

            SolutionGrid.ColumnCount = snap.matrix.Length + addRows;
            SolutionGrid.RowHeadersVisible = false;
            SolutionGrid.ColumnHeadersVisible = false;

            for (int i = 0; i < snap.matrix.Length + addRows; i++)
            {
                SolutionGrid.Columns[i].Width = 50;
                SolutionGrid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            string[] row1 = new string[snap.matrix.Length + addRows];

            row1[0] = "";
            row1[1] = "Базис";
            row1[2] = "A0";


            for (int i = addRows; i < snap.matrix.Length + addRows; i++)
            {
                row1[i] = $"A{i - (addRows - 1)}";
            }

            SolutionGrid.Rows.Add(row1);

            for (int i = 0; i < snap.C.Length; i++)
            {
                string[] row = new string[snap.matrix.Length + addRows];
                for (int j = 0; j < snap.matrix.Length + addRows; j++)
                {
                    if (j == 0)
                    {
                        row[j] = snap.m[snap.C[i]] ? "-M" : $"{snap.fVars[snap.C[i]]}";
                    }
                    else if (j == 1)
                    {
                        row[j] = $"X{snap.C[i] + 1}";
                    }
                    else if (j == 2)
                    {
                        row[j] = Round(snap.b[i]).ToString();
                    }
                    else
                    {
                        row[j] = Round(snap.matrix[j - addRows][i]).ToString();
                    }
                }
                SolutionGrid.Rows.Add(row);
            }
            string[] fRow = new string[snap.matrix.Length + addRows];
            fRow[1] = "F";
            fRow[2] = Round(snap.fValue).ToString();
            for (int i = addRows; i < snap.matrix.Length + addRows; i++)
            {
                fRow[i] = Round(snap.F[i - addRows]).ToString();
            }
            SolutionGrid.Rows.Add(fRow);
        }


        void ShowFinalAnswer()
        {
            if (AllIterations.Last().resType != TypeIteration.Found)
            {
                Result.Text = "Рішення не знайдено";
            }
            else
            {
                Result.Text =
                    $"\nX1 = {Round(GetX(0))}, X2 = {Round(GetX(1))}, " +
                    $"Fmax = {Math.Abs(Round(AllIterations.Last().table.fValue))}";
            }
        }

        double Round(double a)
        {
            return Math.Round(a, 2);
        }


        double GetX(int id)
        {
            SimplexSnapshot result = AllIterations.Last().table;
            for (int i = 0; i < result.C.Length; i++)
            {
                if (result.C[i] == id)
                {
                    return result.b[i];
                }
            }
            return 0;
        }

        int __currentId;
        int CurrentId
        {
            get
            {
                return __currentId;
            }
            set
            {
                if (AllIterations != null && value < AllIterations.Count && value >= 0)
                {
                    __currentId = value;
                }
            }
        }
        private void grid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            SolutionGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.MenuHighlight;
            SolutionGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            SolutionGrid.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(SolutionGrid.Font, FontStyle.Bold);
            SolutionGrid.AllowUserToResizeColumns = false;
            SolutionGrid.AllowUserToResizeRows = false;
        }

        private void counterUp_Click(object sender, EventArgs e)
        {
            SetIteration(--CurrentId);
        }

        void SetIteration(int id)
        {
            if (AllIterations != null && id < AllIterations.Count && id >= 0)
            {
                selectedTable = AllIterations[id];
                labelCounter.Text = (id + 1).ToString();
                ShowTable();
            }
        }

        private void counterDown_Click(object sender, EventArgs e)
        {
            SetIteration(++CurrentId);

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ConditionTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
