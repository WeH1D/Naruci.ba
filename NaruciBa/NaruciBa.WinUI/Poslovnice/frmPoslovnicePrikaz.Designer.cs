
namespace NaruciBa.WinUI.Poslovnice
{
    partial class frmPoslovnicePrikaz
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDgv = new System.Windows.Forms.Panel();
            this.dgvPoslovnice = new System.Windows.Forms.DataGridView();
            this.LanacPoslovnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovnice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDgv
            // 
            this.pnlDgv.BackColor = System.Drawing.Color.Transparent;
            this.pnlDgv.Controls.Add(this.dgvPoslovnice);
            this.pnlDgv.Location = new System.Drawing.Point(0, 80);
            this.pnlDgv.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDgv.Name = "pnlDgv";
            this.pnlDgv.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.pnlDgv.Size = new System.Drawing.Size(830, 420);
            this.pnlDgv.TabIndex = 1;
            // 
            // dgvPoslovnice
            // 
            this.dgvPoslovnice.AllowUserToAddRows = false;
            this.dgvPoslovnice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            this.dgvPoslovnice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPoslovnice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPoslovnice.BackgroundColor = System.Drawing.Color.White;
            this.dgvPoslovnice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPoslovnice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPoslovnice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPoslovnice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPoslovnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoslovnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LanacPoslovnica,
            this.Adresa,
            this.Grad,
            this.KontaktEmail,
            this.KontaktTel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPoslovnice.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPoslovnice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPoslovnice.EnableHeadersVisualStyles = false;
            this.dgvPoslovnice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPoslovnice.Location = new System.Drawing.Point(20, 0);
            this.dgvPoslovnice.Name = "dgvPoslovnice";
            this.dgvPoslovnice.ReadOnly = true;
            this.dgvPoslovnice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvPoslovnice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPoslovnice.RowHeadersWidth = 20;
            this.dgvPoslovnice.RowTemplate.DividerHeight = 1;
            this.dgvPoslovnice.RowTemplate.Height = 40;
            this.dgvPoslovnice.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPoslovnice.Size = new System.Drawing.Size(790, 400);
            this.dgvPoslovnice.TabIndex = 0;
            // 
            // LanacPoslovnica
            // 
            this.LanacPoslovnica.DataPropertyName = "trgovackiLanacID";
            this.LanacPoslovnica.HeaderText = "Lanac poslovnica";
            this.LanacPoslovnica.Name = "LanacPoslovnica";
            this.LanacPoslovnica.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "adresa";
            this.Adresa.HeaderText = "Adresa poslovnice";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "GradID";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // KontaktEmail
            // 
            this.KontaktEmail.DataPropertyName = "kontaktEmail";
            this.KontaktEmail.HeaderText = "Kontakt email";
            this.KontaktEmail.Name = "KontaktEmail";
            this.KontaktEmail.ReadOnly = true;
            // 
            // KontaktTel
            // 
            this.KontaktTel.DataPropertyName = "kontaktTel";
            this.KontaktTel.HeaderText = "Kontakt telefon";
            this.KontaktTel.Name = "KontaktTel";
            this.KontaktTel.ReadOnly = true;
            // 
            // frmPoslovnicePrikaz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(830, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPoslovnicePrikaz";
            this.Text = "frmPoslovnicePrikaz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPoslovnicePrikaz_Load);
            this.SizeChanged += new System.EventHandler(this.frmPoslovnicePrikaz_SizeChanged);
            this.pnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovnice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlDgv;
        private System.Windows.Forms.DataGridView dgvPoslovnice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanacPoslovnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktTel;
    }
}