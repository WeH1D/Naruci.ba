﻿
namespace NaruciBa.WinUI.Kategorije
{
    partial class frmKategorijePrikaz
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flpKategorije = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvIdk = new System.Windows.Forms.DataGridView();
            this.LanacPoslovnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFlow = new System.Windows.Forms.Panel();
            this.flpKategorije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdk)).BeginInit();
            this.pnlFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpKategorije
            // 
            this.flpKategorije.AutoScroll = true;
            this.flpKategorije.AutoSize = true;
            this.flpKategorije.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpKategorije.BackColor = System.Drawing.Color.Transparent;
            this.flpKategorije.Controls.Add(this.dgvIdk);
            this.flpKategorije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKategorije.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpKategorije.Location = new System.Drawing.Point(10, 10);
            this.flpKategorije.Name = "flpKategorije";
            this.flpKategorije.Size = new System.Drawing.Size(493, 390);
            this.flpKategorije.TabIndex = 3;
            this.flpKategorije.WrapContents = false;
            this.flpKategorije.Layout += new System.Windows.Forms.LayoutEventHandler(this.flpKategorije_Layout);
            // 
            // dgvIdk
            // 
            this.dgvIdk.AllowUserToAddRows = false;
            this.dgvIdk.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Transparent;
            this.dgvIdk.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvIdk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIdk.BackgroundColor = System.Drawing.Color.White;
            this.dgvIdk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIdk.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvIdk.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIdk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvIdk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LanacPoslovnica});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIdk.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvIdk.EnableHeadersVisualStyles = false;
            this.dgvIdk.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvIdk.Location = new System.Drawing.Point(3, 3);
            this.dgvIdk.Name = "dgvIdk";
            this.dgvIdk.ReadOnly = true;
            this.dgvIdk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvIdk.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvIdk.RowHeadersWidth = 20;
            this.dgvIdk.RowTemplate.DividerHeight = 1;
            this.dgvIdk.RowTemplate.Height = 40;
            this.dgvIdk.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIdk.Size = new System.Drawing.Size(754, 0);
            this.dgvIdk.TabIndex = 1;
            // 
            // LanacPoslovnica
            // 
            this.LanacPoslovnica.DataPropertyName = "trgovackiLanacID";
            this.LanacPoslovnica.HeaderText = "Kategorija";
            this.LanacPoslovnica.Name = "LanacPoslovnica";
            this.LanacPoslovnica.ReadOnly = true;
            // 
            // pnlFlow
            // 
            this.pnlFlow.BackColor = System.Drawing.Color.White;
            this.pnlFlow.Controls.Add(this.flpKategorije);
            this.pnlFlow.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFlow.Location = new System.Drawing.Point(267, 20);
            this.pnlFlow.Name = "pnlFlow";
            this.pnlFlow.Padding = new System.Windows.Forms.Padding(10);
            this.pnlFlow.Size = new System.Drawing.Size(513, 410);
            this.pnlFlow.TabIndex = 4;
            // 
            // frmKategorijePrikaz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlFlow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKategorijePrikaz";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "frmKategorijePrikaz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKategorijePrikaz_Load);
            this.flpKategorije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdk)).EndInit();
            this.pnlFlow.ResumeLayout(false);
            this.pnlFlow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flpKategorije;
        private System.Windows.Forms.Panel pnlFlow;
        private System.Windows.Forms.DataGridView dgvIdk;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanacPoslovnica;
    }
}