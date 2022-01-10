
namespace NaruciBa.WinUI.Poslovnice
{
    partial class fmrDodajLanacPoslovnica
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
            this.lblDodajtrgovackiLanac = new System.Windows.Forms.Label();
            this.pbTrgovackiLanac = new System.Windows.Forms.PictureBox();
            this.lblDodajSliku = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrgovackiLanac)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDodajtrgovackiLanac
            // 
            this.lblDodajtrgovackiLanac.AutoSize = true;
            this.lblDodajtrgovackiLanac.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodajtrgovackiLanac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDodajtrgovackiLanac.Location = new System.Drawing.Point(23, 23);
            this.lblDodajtrgovackiLanac.Name = "lblDodajtrgovackiLanac";
            this.lblDodajtrgovackiLanac.Size = new System.Drawing.Size(182, 21);
            this.lblDodajtrgovackiLanac.TabIndex = 3;
            this.lblDodajtrgovackiLanac.Text = "Dodaj trgovacki lanac";
            // 
            // pbTrgovackiLanac
            // 
            this.pbTrgovackiLanac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTrgovackiLanac.Location = new System.Drawing.Point(47, 71);
            this.pbTrgovackiLanac.Name = "pbTrgovackiLanac";
            this.pbTrgovackiLanac.Size = new System.Drawing.Size(170, 163);
            this.pbTrgovackiLanac.TabIndex = 5;
            this.pbTrgovackiLanac.TabStop = false;
            // 
            // lblDodajSliku
            // 
            this.lblDodajSliku.AutoSize = true;
            this.lblDodajSliku.Font = new System.Drawing.Font("Montserrat Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodajSliku.ForeColor = System.Drawing.Color.Red;
            this.lblDodajSliku.Location = new System.Drawing.Point(92, 246);
            this.lblDodajSliku.Name = "lblDodajSliku";
            this.lblDodajSliku.Size = new System.Drawing.Size(66, 15);
            this.lblDodajSliku.TabIndex = 4;
            this.lblDodajSliku.Text = "Dodaj sliku";
            this.lblDodajSliku.Click += new System.EventHandler(this.lblDodajSliku_Click);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Montserrat Light", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(256, 132);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(47, 18);
            this.lblNaziv.TabIndex = 6;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Montserrat Light", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(309, 129);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(168, 23);
            this.txtNaziv.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(402, 169);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 29);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog";
            // 
            // fmrDodajLanacPoslovnica
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 299);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblDodajtrgovackiLanac);
            this.Controls.Add(this.pbTrgovackiLanac);
            this.Controls.Add(this.lblDodajSliku);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmrDodajLanacPoslovnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrDodajLanacPoslovnica";
            this.Load += new System.EventHandler(this.fmrDodajLanacPoslovnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrgovackiLanac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDodajtrgovackiLanac;
        private System.Windows.Forms.PictureBox pbTrgovackiLanac;
        private System.Windows.Forms.Label lblDodajSliku;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}