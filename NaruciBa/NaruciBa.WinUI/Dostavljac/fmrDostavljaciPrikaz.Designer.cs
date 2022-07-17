
namespace NaruciBa.WinUI.Dostavljac
{
    partial class fmrDostavljaciPrikaz
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajDostavljaca = new System.Windows.Forms.Button();
            this.pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovnice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDgv
            // 
            this.pnlDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDgv.BackColor = System.Drawing.Color.Transparent;
            this.pnlDgv.Controls.Add(this.dgvPoslovnice);
            this.pnlDgv.Location = new System.Drawing.Point(0, 51);
            this.pnlDgv.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDgv.Name = "pnlDgv";
            this.pnlDgv.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.pnlDgv.Size = new System.Drawing.Size(800, 399);
            this.pnlDgv.TabIndex = 2;
            // 
            // dgvPoslovnice
            // 
            this.dgvPoslovnice.AllowUserToAddRows = false;
            this.dgvPoslovnice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPoslovnice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPoslovnice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.ID,
            this.Ime,
            this.Prezime,
            this.Email,
            this.Telefon,
            this.Adresa,
            this.Grad});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPoslovnice.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPoslovnice.EnableHeadersVisualStyles = false;
            this.dgvPoslovnice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPoslovnice.Location = new System.Drawing.Point(20, 3);
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
            this.dgvPoslovnice.Size = new System.Drawing.Size(760, 376);
            this.dgvPoslovnice.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "korisnikID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "adresa";
            this.Adresa.HeaderText = "Adresa";
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
            // btnDodajDostavljaca
            // 
            this.btnDodajDostavljaca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajDostavljaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDodajDostavljaca.FlatAppearance.BorderSize = 0;
            this.btnDodajDostavljaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajDostavljaca.ForeColor = System.Drawing.Color.White;
            this.btnDodajDostavljaca.Location = new System.Drawing.Point(650, 12);
            this.btnDodajDostavljaca.Name = "btnDodajDostavljaca";
            this.btnDodajDostavljaca.Size = new System.Drawing.Size(130, 32);
            this.btnDodajDostavljaca.TabIndex = 1;
            this.btnDodajDostavljaca.Text = "Dodaj dostavljaca";
            this.btnDodajDostavljaca.UseVisualStyleBackColor = false;
            this.btnDodajDostavljaca.Click += new System.EventHandler(this.btnDodajDostavljaca_Click);
            // 
            // fmrDostavljaciPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnDodajDostavljaca);
            this.Controls.Add(this.pnlDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fmrDostavljaciPrikaz";
            this.Text = "fmrDostavljaciPrikaz";
            this.Load += new System.EventHandler(this.fmrDostavljaciPrikaz_LoadAsync);
            this.pnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovnice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDgv;
        private System.Windows.Forms.DataGridView dgvPoslovnice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.Button btnDodajDostavljaca;
    }
}