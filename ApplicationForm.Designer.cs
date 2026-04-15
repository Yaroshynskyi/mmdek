using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace BuilderMmdoCoursework
{
    partial class ApplicationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.item2P4 = new System.Windows.Forms.NumericUpDown();
            this.item1P4 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.store4 = new System.Windows.Forms.NumericUpDown();
            this.store3 = new System.Windows.Forms.NumericUpDown();
            this.store2 = new System.Windows.Forms.NumericUpDown();
            this.store1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
            this.item1Cost = new System.Windows.Forms.NumericUpDown();
            this.item2Cost = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.counterUp = new System.Windows.Forms.Button();
            this.counterDown = new System.Windows.Forms.Button();
            this.labelCounter = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item2P4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1P4)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.item1Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.73684F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.89474F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.26316F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.item2P4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.item1P4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.store4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.store3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.store2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.store1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.item2P1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.item2P2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.item2P3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.item1P3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.item1P2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.item1P1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.item1Cost, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.item2Cost, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(475, 288);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // item2P4
            // 
            this.item2P4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item2P4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item2P4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item2P4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item2P4.Location = new System.Drawing.Point(351, 170);
            this.item2P4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item2P4.Name = "item2P4";
            this.item2P4.Size = new System.Drawing.Size(102, 21);
            this.item2P4.TabIndex = 30;
            // 
            // item1P4
            // 
            this.item1P4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item1P4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item1P4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item1P4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item1P4.Location = new System.Drawing.Point(221, 170);
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
            this.item1P4.Size = new System.Drawing.Size(102, 21);
            this.item1P4.TabIndex = 29;
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
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(33, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "S4";
            // 
            // store4
            // 
            this.store4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.store4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.store4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.store4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.store4.Location = new System.Drawing.Point(100, 170);
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
            this.store4.Size = new System.Drawing.Size(102, 21);
            this.store4.TabIndex = 28;
            this.store4.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // store3
            // 
            this.store3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.store3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.store3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.store3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.store3.Location = new System.Drawing.Point(100, 126);
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
            this.store3.Size = new System.Drawing.Size(102, 21);
            this.store3.TabIndex = 10;
            this.store3.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // store2
            // 
            this.store2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.store2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.store2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.store2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.store2.Location = new System.Drawing.Point(100, 83);
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
            this.store2.Size = new System.Drawing.Size(102, 21);
            this.store2.TabIndex = 11;
            this.store2.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // store1
            // 
            this.store1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.store1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.store1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.store1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.store1.Location = new System.Drawing.Point(100, 44);
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
            this.store1.Size = new System.Drawing.Size(102, 21);
            this.store1.TabIndex = 7;
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
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(388, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Р2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сировина";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(33, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "S1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(258, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Р1";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(33, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "S2";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(33, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "S3";
            // 
            // item2P1
            // 
            this.item2P1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item2P1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item2P1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item2P1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item2P1.Location = new System.Drawing.Point(351, 44);
            this.item2P1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item2P1.Name = "item2P1";
            this.item2P1.Size = new System.Drawing.Size(102, 21);
            this.item2P1.TabIndex = 6;
            this.item2P1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // item2P2
            // 
            this.item2P2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item2P2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item2P2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item2P2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item2P2.Location = new System.Drawing.Point(351, 83);
            this.item2P2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item2P2.Name = "item2P2";
            this.item2P2.Size = new System.Drawing.Size(102, 21);
            this.item2P2.TabIndex = 10;
            this.item2P2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // item2P3
            // 
            this.item2P3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item2P3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item2P3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item2P3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item2P3.Location = new System.Drawing.Point(351, 126);
            this.item2P3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item2P3.Name = "item2P3";
            this.item2P3.Size = new System.Drawing.Size(102, 21);
            this.item2P3.TabIndex = 9;
            this.item2P3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // item1P3
            // 
            this.item1P3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item1P3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item1P3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item1P3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item1P3.Location = new System.Drawing.Point(221, 126);
            this.item1P3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item1P3.Name = "item1P3";
            this.item1P3.Size = new System.Drawing.Size(102, 21);
            this.item1P3.TabIndex = 12;
            // 
            // item1P2
            // 
            this.item1P2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item1P2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item1P2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item1P2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item1P2.Location = new System.Drawing.Point(221, 83);
            this.item1P2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item1P2.Name = "item1P2";
            this.item1P2.Size = new System.Drawing.Size(102, 21);
            this.item1P2.TabIndex = 11;
            this.item1P2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // item1P1
            // 
            this.item1P1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item1P1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item1P1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item1P1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item1P1.Location = new System.Drawing.Point(221, 44);
            this.item1P1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.item1P1.Name = "item1P1";
            this.item1P1.Size = new System.Drawing.Size(102, 21);
            this.item1P1.TabIndex = 1;
            this.item1P1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Прибуток";
            // 
            // item1Cost
            // 
            this.item1Cost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item1Cost.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item1Cost.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item1Cost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item1Cost.Location = new System.Drawing.Point(221, 234);
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
            this.item1Cost.Size = new System.Drawing.Size(102, 21);
            this.item1Cost.TabIndex = 13;
            this.item1Cost.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // item2Cost
            // 
            this.item2Cost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item2Cost.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item2Cost.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item2Cost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item2Cost.Location = new System.Drawing.Point(351, 234);
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
            this.item2Cost.Size = new System.Drawing.Size(102, 21);
            this.item2Cost.TabIndex = 8;
            this.item2Cost.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(125, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Запас";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(528, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(464, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Отримати відповідь";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grid
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grid.BackgroundColor = System.Drawing.Color.Gray;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.GridColor = System.Drawing.Color.Black;
            this.grid.Location = new System.Drawing.Point(528, 77);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 30;
            this.grid.Size = new System.Drawing.Size(464, 238);
            this.grid.TabIndex = 19;
            this.grid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grid_RowPrePaint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(191, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Умова";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(713, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Рішення";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(524, 318);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(102, 24);
            this.labelResult.TabIndex = 22;
            this.labelResult.Text = "labelResult";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(490, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "=>";
            // 
            // counterUp
            // 
            this.counterUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.counterUp.Location = new System.Drawing.Point(998, 76);
            this.counterUp.Name = "counterUp";
            this.counterUp.Size = new System.Drawing.Size(34, 34);
            this.counterUp.TabIndex = 25;
            this.counterUp.Text = "↑";
            this.counterUp.UseVisualStyleBackColor = true;
            this.counterUp.Click += new System.EventHandler(this.counterUp_Click);
            // 
            // counterDown
            // 
            this.counterDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.counterDown.Location = new System.Drawing.Point(998, 281);
            this.counterDown.Name = "counterDown";
            this.counterDown.Size = new System.Drawing.Size(34, 34);
            this.counterDown.TabIndex = 26;
            this.counterDown.Text = "↓";
            this.counterDown.UseVisualStyleBackColor = true;
            this.counterDown.Click += new System.EventHandler(this.counterDown_Click);
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCounter.Location = new System.Drawing.Point(1004, 188);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(20, 24);
            this.labelCounter.TabIndex = 27;
            this.labelCounter.Text = "1";
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1034, 395);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.counterDown);
            this.Controls.Add(this.counterUp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaximumSize = new System.Drawing.Size(1077, 481);
            this.Name = "ApplicationForm";
            this.Text = "ММДО";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item2P4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1P4)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.item1Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown item1P3;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label11;
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

        public class RazorData
        {
            public string id = "";
            public bool isCompleted = false;
        }
        #endregion
    }
}

