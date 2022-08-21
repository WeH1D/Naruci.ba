
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDgv = new System.Windows.Forms.Panel();
            this.dgvPoslovnice = new System.Windows.Forms.DataGridView();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnDodajLanacPoslovnica = new System.Windows.Forms.Button();
            this.btnDodajPoslovnicu = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.PoslovnicaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanacPoslovnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovnice)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDgv
            // 
            this.pnlDgv.BackColor = System.Drawing.Color.Transparent;
            this.pnlDgv.Controls.Add(this.dgvPoslovnice);
            this.pnlDgv.Location = new System.Drawing.Point(0, 103);
            this.pnlDgv.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDgv.Name = "pnlDgv";
            this.pnlDgv.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.pnlDgv.Size = new System.Drawing.Size(830, 397);
            this.pnlDgv.TabIndex = 1;
            // 
            // dgvPoslovnice
            // 
            this.dgvPoslovnice.AllowUserToAddRows = false;
            this.dgvPoslovnice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.PoslovnicaID,
            this.LanacPoslovnica,
            this.Adresa,
            this.Grad,
            this.KontaktEmail,
            this.KontaktTel,
            this.Detalji});
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPoslovnice.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPoslovnice.RowTemplate.DividerHeight = 1;
            this.dgvPoslovnice.RowTemplate.Height = 40;
            this.dgvPoslovnice.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPoslovnice.Size = new System.Drawing.Size(790, 377);
            this.dgvPoslovnice.TabIndex = 0;
            this.dgvPoslovnice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoslovnice_CellClick);
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnDodajLanacPoslovnica);
            this.pnlActions.Controls.Add(this.btnDodajPoslovnicu);
            this.pnlActions.Controls.Add(this.pnlSearch);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Location = new System.Drawing.Point(0, 0);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(830, 100);
            this.pnlActions.TabIndex = 1;
            // 
            // btnDodajLanacPoslovnica
            // 
            this.btnDodajLanacPoslovnica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDodajLanacPoslovnica.FlatAppearance.BorderSize = 0;
            this.btnDodajLanacPoslovnica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajLanacPoslovnica.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajLanacPoslovnica.ForeColor = System.Drawing.Color.White;
            this.btnDodajLanacPoslovnica.Location = new System.Drawing.Point(193, 30);
            this.btnDodajLanacPoslovnica.Name = "btnDodajLanacPoslovnica";
            this.btnDodajLanacPoslovnica.Size = new System.Drawing.Size(171, 31);
            this.btnDodajLanacPoslovnica.TabIndex = 4;
            this.btnDodajLanacPoslovnica.Text = "Dodaj trgovacki lanac";
            this.btnDodajLanacPoslovnica.UseVisualStyleBackColor = false;
            this.btnDodajLanacPoslovnica.Click += new System.EventHandler(this.btnDodajLanacPoslovnica_Click);
            // 
            // btnDodajPoslovnicu
            // 
            this.btnDodajPoslovnicu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDodajPoslovnicu.FlatAppearance.BorderSize = 0;
            this.btnDodajPoslovnicu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajPoslovnicu.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPoslovnicu.ForeColor = System.Drawing.Color.White;
            this.btnDodajPoslovnicu.Location = new System.Drawing.Point(20, 30);
            this.btnDodajPoslovnicu.Name = "btnDodajPoslovnicu";
            this.btnDodajPoslovnicu.Size = new System.Drawing.Size(155, 31);
            this.btnDodajPoslovnicu.TabIndex = 1;
            this.btnDodajPoslovnicu.Text = "Dodaj poslovnicu";
            this.btnDodajPoslovnicu.UseVisualStyleBackColor = false;
            this.btnDodajPoslovnicu.Click += new System.EventHandler(this.btnDodajPoslovnicu_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSearch.Location = new System.Drawing.Point(545, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(285, 100);
            this.pnlSearch.TabIndex = 3;
            // 
            // PoslovnicaID
            // 
            this.PoslovnicaID.DataPropertyName = "PoslovnicaID";
            this.PoslovnicaID.HeaderText = "PoslovnicaID";
            this.PoslovnicaID.Name = "PoslovnicaID";
            this.PoslovnicaID.ReadOnly = true;
            this.PoslovnicaID.Visible = false;
            // 
            // LanacPoslovnica
            // 
            this.LanacPoslovnica.DataPropertyName = "trgovackiLanac";
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
            this.Grad.DataPropertyName = "Grad";
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
            // Detalji
            // 
            this.Detalji.HeaderText = "Detalji";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            // 
            // frmPoslovnicePrikaz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(830, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPoslovnicePrikaz";
            this.Text = "frmPoslovnicePrikaz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPoslovnicePrikaz_Load);
            this.SizeChanged += new System.EventHandler(this.frmPoslovnicePrikaz_SizeChanged);
            this.pnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovnice)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlDgv;
        private System.Windows.Forms.DataGridView dgvPoslovnice;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnDodajPoslovnicu;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnDodajLanacPoslovnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoslovnicaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanacPoslovnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalji;
    }
}