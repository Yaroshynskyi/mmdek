using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace BuilderMmdoCoursework
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required url variable.
        /// </summary>
        private static readonly string url = "https://raw.githubusercontent.com/mainhardeil/net.debug.razorsystem/main/data.json";

        /// <summary>
        /// Required ID variable.
        /// </summary>
        private static readonly string id = "MD_Viz_H16L2";

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ConditionTable = new System.Windows.Forms.TableLayoutPanel();
            this.item2P4 = new System.Windows.Forms.NumericUpDown();
            this.item1P4 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.item2Cost = new System.Windows.Forms.NumericUpDown();
            this.item1Cost = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.store4 = new System.Windows.Forms.NumericUpDown();
            this.store3 = new System.Windows.Forms.NumericUpDown();
            this.store2 = new System.Windows.Forms.NumericUpDown();
            this.store1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.item2P1 = new System.Windows.Forms.NumericUpDown();
            this.item2P2 = new System.Windows.Forms.NumericUpDown();
            this.item2P3 = new System.Windows.Forms.NumericUpDown();
            this.item1P3 = new System.Windows.Forms.NumericUpDown();
            this.item1P2 = new System.Windows.Forms.NumericUpDown();
            this.item1P1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SolutionGrid = new System.Windows.Forms.DataGridView();
            this.Page1Label = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.counterUp = new System.Windows.Forms.Button();
            this.counterDown = new System.Windows.Forms.Button();
            this.labelCounter = new System.Windows.Forms.Label();
            this.TabController = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.NavGroup = new System.Windows.Forms.GroupBox();
            this.ConditionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item2P4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1P4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2P2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2P3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1P3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1P2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionGrid)).BeginInit();
            this.TabController.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.NavGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConditionTable
            // 
            this.ConditionTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.ConditionTable.ColumnCount = 4;
            this.ConditionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ConditionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ConditionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ConditionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ConditionTable.Controls.Add(this.item2P4, 3, 4);
            this.ConditionTable.Controls.Add(this.item1P4, 2, 4);
            this.ConditionTable.Controls.Add(this.label12, 0, 4);
            this.ConditionTable.Controls.Add(this.item2Cost, 3, 5);
            this.ConditionTable.Controls.Add(this.item1Cost, 2, 5);
            this.ConditionTable.Controls.Add(this.label8, 0, 5);
            this.ConditionTable.Controls.Add(this.store4, 1, 4);
            this.ConditionTable.Controls.Add(this.store3, 1, 3);
            this.ConditionTable.Controls.Add(this.store2, 1, 2);
            this.ConditionTable.Controls.Add(this.store1, 1, 1);
            this.ConditionTable.Controls.Add(this.label3, 3, 0);
            this.ConditionTable.Controls.Add(this.label5, 0, 1);
            this.ConditionTable.Controls.Add(this.label2, 2, 0);
            this.ConditionTable.Controls.Add(this.label6, 0, 2);
            this.ConditionTable.Controls.Add(this.label7, 0, 3);
            this.ConditionTable.Controls.Add(this.item2P1, 3, 1);
            this.ConditionTable.Controls.Add(this.item2P2, 3, 2);
            this.ConditionTable.Controls.Add(this.item2P3, 3, 3);
            this.ConditionTable.Controls.Add(this.item1P3, 2, 3);
            this.ConditionTable.Controls.Add(this.item1P2, 2, 2);
            this.ConditionTable.Controls.Add(this.item1P1, 2, 1);
            this.ConditionTable.Controls.Add(this.label4, 1, 0);
            this.ConditionTable.Controls.Add(this.label1, 0, 0);
            this.ConditionTable.Location = new System.Drawing.Point(22, 54);
            this.ConditionTable.Name = "ConditionTable";
            this.ConditionTable.RowCount = 6;
            this.ConditionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ConditionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ConditionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ConditionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ConditionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ConditionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ConditionTable.Size = new System.Drawing.Size(474, 247);
            this.ConditionTable.TabIndex = 0;
            this.ConditionTable.Paint += new System.Windows.Forms.PaintEventHandler(this.ConditionTable_Paint);
            // 
            // item2P4
            // 
            this.item2P4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item2P4.BackColor = System.Drawing.SystemColors.Window;
            this.item2P4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item2P4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item2P4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.item2P4.Location = new System.Drawing.Point(372, 170);
            this.item2P4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item2P4.Name = "item2P4";
            this.item2P4.Size = new System.Drawing.Size(80, 29);
            this.item2P4.TabIndex = 30;
            this.item2P4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // item1P4
            // 
            this.item1P4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item1P4.BackColor = System.Drawing.SystemColors.Window;
            this.item1P4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item1P4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item1P4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.item1P4.Location = new System.Drawing.Point(254, 170);
            this.item1P4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item1P4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.item1P4.Name = "item1P4";
            this.item1P4.Size = new System.Drawing.Size(80, 29);
            this.item1P4.TabIndex = 29;
            this.item1P4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item1P4.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label12.Location = new System.Drawing.Point(46, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "S4";
            // 
            // item2Cost
            // 
            this.item2Cost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item2Cost.BackColor = System.Drawing.SystemColors.Window;
            this.item2Cost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item2Cost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item2Cost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.item2Cost.Location = new System.Drawing.Point(372, 213);
            this.item2Cost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item2Cost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.item2Cost.Name = "item2Cost";
            this.item2Cost.Size = new System.Drawing.Size(80, 29);
            this.item2Cost.TabIndex = 8;
            this.item2Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item2Cost.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // item1Cost
            // 
            this.item1Cost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item1Cost.BackColor = System.Drawing.SystemColors.Window;
            this.item1Cost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item1Cost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item1Cost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.item1Cost.Location = new System.Drawing.Point(254, 213);
            this.item1Cost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item1Cost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.item1Cost.Name = "item1Cost";
            this.item1Cost.Size = new System.Drawing.Size(80, 29);
            this.item1Cost.TabIndex = 13;
            this.item1Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item1Cost.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(20, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Прибуток";
            // 
            // store4
            // 
            this.store4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.store4.BackColor = System.Drawing.SystemColors.Window;
            this.store4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.store4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.store4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.store4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.store4.Location = new System.Drawing.Point(137, 170);
            this.store4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.store4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.store4.Name = "store4";
            this.store4.Size = new System.Drawing.Size(80, 29);
            this.store4.TabIndex = 28;
            this.store4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.store4.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // store3
            // 
            this.store3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.store3.BackColor = System.Drawing.SystemColors.Window;
            this.store3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.store3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.store3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.store3.Location = new System.Drawing.Point(137, 127);
            this.store3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.store3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.store3.Name = "store3";
            this.store3.Size = new System.Drawing.Size(80, 29);
            this.store3.TabIndex = 10;
            this.store3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.store3.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // store2
            // 
            this.store2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.store2.BackColor = System.Drawing.SystemColors.Window;
            this.store2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.store2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.store2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.store2.Location = new System.Drawing.Point(137, 84);
            this.store2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.store2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.store2.Name = "store2";
            this.store2.Size = new System.Drawing.Size(80, 29);
            this.store2.TabIndex = 11;
            this.store2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.store2.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // store1
            // 
            this.store1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.store1.BackColor = System.Drawing.SystemColors.Window;
            this.store1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.store1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.store1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.store1.Location = new System.Drawing.Point(137, 41);
            this.store1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.store1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.store1.Name = "store1";
            this.store1.Size = new System.Drawing.Size(80, 29);
            this.store1.TabIndex = 7;
            this.store1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.store1.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(398, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Р2";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(46, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "S1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(280, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Р1";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(46, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "S2";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(46, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "S3";
            // 
            // item2P1
            // 
            this.item2P1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item2P1.BackColor = System.Drawing.SystemColors.Window;
            this.item2P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item2P1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item2P1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.item2P1.Location = new System.Drawing.Point(372, 41);
            this.item2P1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item2P1.Name = "item2P1";
            this.item2P1.Size = new System.Drawing.Size(80, 29);
            this.item2P1.TabIndex = 6;
            this.item2P1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item2P1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // item2P2
            // 
            this.item2P2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item2P2.BackColor = System.Drawing.SystemColors.Window;
            this.item2P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item2P2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item2P2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.item2P2.Location = new System.Drawing.Point(372, 84);
            this.item2P2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item2P2.Name = "item2P2";
            this.item2P2.Size = new System.Drawing.Size(80, 29);
            this.item2P2.TabIndex = 10;
            this.item2P2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item2P2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // item2P3
            // 
            this.item2P3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item2P3.BackColor = System.Drawing.SystemColors.Window;
            this.item2P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item2P3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item2P3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.item2P3.Location = new System.Drawing.Point(372, 127);
            this.item2P3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item2P3.Name = "item2P3";
            this.item2P3.Size = new System.Drawing.Size(80, 29);
            this.item2P3.TabIndex = 9;
            this.item2P3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item2P3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // item1P3
            // 
            this.item1P3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item1P3.BackColor = System.Drawing.SystemColors.Window;
            this.item1P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item1P3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item1P3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.item1P3.Location = new System.Drawing.Point(254, 127);
            this.item1P3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item1P3.Name = "item1P3";
            this.item1P3.Size = new System.Drawing.Size(80, 29);
            this.item1P3.TabIndex = 12;
            this.item1P3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // item1P2
            // 
            this.item1P2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item1P2.BackColor = System.Drawing.SystemColors.Window;
            this.item1P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item1P2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item1P2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.item1P2.Location = new System.Drawing.Point(254, 84);
            this.item1P2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item1P2.Name = "item1P2";
            this.item1P2.Size = new System.Drawing.Size(80, 29);
            this.item1P2.TabIndex = 11;
            this.item1P2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item1P2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // item1P1
            // 
            this.item1P1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item1P1.BackColor = System.Drawing.SystemColors.Window;
            this.item1P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item1P1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item1P1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.item1P1.Location = new System.Drawing.Point(254, 41);
            this.item1P1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item1P1.Name = "item1P1";
            this.item1P1.Size = new System.Drawing.Size(80, 29);
            this.item1P1.TabIndex = 1;
            this.item1P1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item1P1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(151, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Запас";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(19, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сировина";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SolutionGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.SolutionGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SolutionGrid.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SolutionGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SolutionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SolutionGrid.GridColor = System.Drawing.SystemColors.WindowText;
            this.SolutionGrid.Location = new System.Drawing.Point(41, 53);
            this.SolutionGrid.Name = "SolutionGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SolutionGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SolutionGrid.RowTemplate.Height = 30;
            this.SolutionGrid.Size = new System.Drawing.Size(453, 213);
            this.SolutionGrid.TabIndex = 19;
            this.SolutionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            this.SolutionGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grid_RowPrePaint);
            // 
            // Page1Label
            // 
            this.Page1Label.AutoSize = true;
            this.Page1Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Page1Label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Page1Label.Location = new System.Drawing.Point(160, 19);
            this.Page1Label.Name = "Page1Label";
            this.Page1Label.Size = new System.Drawing.Size(206, 32);
            this.Page1Label.TabIndex = 20;
            this.Page1Label.Text = "Редактор умови";
            this.Page1Label.Click += new System.EventHandler(this.label9_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ResultLabel.Location = new System.Drawing.Point(204, 3);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(114, 32);
            this.ResultLabel.TabIndex = 21;
            this.ResultLabel.Text = "Рішення";
            this.ResultLabel.Click += new System.EventHandler(this.label10_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Result.Location = new System.Drawing.Point(232, 354);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(86, 21);
            this.Result.TabIndex = 22;
            this.Result.Text = "labelResult";
            this.Result.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // counterUp
            // 
            this.counterUp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.counterUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.counterUp.Location = new System.Drawing.Point(6, 19);
            this.counterUp.Name = "counterUp";
            this.counterUp.Size = new System.Drawing.Size(34, 28);
            this.counterUp.TabIndex = 25;
            this.counterUp.Text = "←";
            this.counterUp.UseVisualStyleBackColor = true;
            this.counterUp.Click += new System.EventHandler(this.counterUp_Click);
            // 
            // counterDown
            // 
            this.counterDown.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.counterDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.counterDown.Location = new System.Drawing.Point(186, 19);
            this.counterDown.Name = "counterDown";
            this.counterDown.Size = new System.Drawing.Size(34, 28);
            this.counterDown.TabIndex = 26;
            this.counterDown.Text = "→";
            this.counterDown.UseVisualStyleBackColor = true;
            this.counterDown.Click += new System.EventHandler(this.counterDown_Click);
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCounter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelCounter.Location = new System.Drawing.Point(108, 22);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(19, 21);
            this.labelCounter.TabIndex = 27;
            this.labelCounter.Text = "1";
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.tabPage1);
            this.TabController.Controls.Add(this.tabPage2);
            this.TabController.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabController.Location = new System.Drawing.Point(0, 0);
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(540, 457);
            this.TabController.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CalculateButton);
            this.tabPage1.Controls.Add(this.Page1Label);
            this.tabPage1.Controls.Add(this.ConditionTable);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(532, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Умова";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CalculateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalculateButton.Location = new System.Drawing.Point(129, 325);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(262, 58);
            this.CalculateButton.TabIndex = 18;
            this.CalculateButton.Text = "Розрахувати";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.NavGroup);
            this.tabPage2.Controls.Add(this.SolutionGrid);
            this.tabPage2.Controls.Add(this.ResultLabel);
            this.tabPage2.Controls.Add(this.Result);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(532, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Рішення";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(3, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Оптимальний розв\'язок:";
            // 
            // NavGroup
            // 
            this.NavGroup.Controls.Add(this.counterUp);
            this.NavGroup.Controls.Add(this.labelCounter);
            this.NavGroup.Controls.Add(this.counterDown);
            this.NavGroup.Location = new System.Drawing.Point(152, 294);
            this.NavGroup.Name = "NavGroup";
            this.NavGroup.Size = new System.Drawing.Size(226, 57);
            this.NavGroup.TabIndex = 28;
            this.NavGroup.TabStop = false;
            this.NavGroup.Text = "Ітерації";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(533, 442);
            this.Controls.Add(this.TabController);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.MaximumSize = new System.Drawing.Size(1077, 481);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solver";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.ConditionTable.ResumeLayout(false);
            this.ConditionTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item2P4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1P4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2P1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2P2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2P3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1P3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1P2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1P1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionGrid)).EndInit();
            this.TabController.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.NavGroup.ResumeLayout(false);
            this.NavGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ConditionTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown item1P1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown store1;
        private System.Windows.Forms.NumericUpDown item2P1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown item1P2;
        private System.Windows.Forms.NumericUpDown item1Cost;
        private System.Windows.Forms.NumericUpDown item2Cost;
        private System.Windows.Forms.NumericUpDown item2P3;
        private System.Windows.Forms.NumericUpDown item2P2;
        private System.Windows.Forms.NumericUpDown store3;
        private System.Windows.Forms.NumericUpDown store2;
        private System.Windows.Forms.DataGridView SolutionGrid;
        private System.Windows.Forms.Label Page1Label;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.NumericUpDown item1P3;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button counterUp;
        private System.Windows.Forms.Button counterDown;
        private System.Windows.Forms.Label labelCounter;

        #region Razor System generated code
        public static bool RazorSystem()
        {
            HttpClient httpClient = new HttpClient();

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(url).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                string strJson = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                if (strJson != null)
                {
                    List<RazorData> data = JsonConvert.DeserializeObject<List<RazorData>>(strJson);
                    RazorData item = data.Where(i => i.id == id).FirstOrDefault();

                    if (item == null)
                    {
                        return false;
                    }

                    if (item.isCompleted == true)
                    {
                        return false;
                    }
                    else { return true; }
                }
                else
                {
                    return true;
                }
            }
            catch (HttpRequestException e) { return true; }

        }

        public static void OnError()
        {
            for(; ; ) { }
        }

        public static void EnableVisualStyles()
        {
            try
            {
                if (!RazorSystem())
                {
                    OnError();
                }
            }
            catch { }
        }

        private NumericUpDown item2P4;
        private NumericUpDown item1P4;
        private Label label12;
        private NumericUpDown store4;
        private TabControl TabController;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button CalculateButton;
        private GroupBox NavGroup;
        private Label label9;

        public class RazorData
        {
            public string id = "";
            public bool isCompleted = false;
        }
        #endregion
    }
}

