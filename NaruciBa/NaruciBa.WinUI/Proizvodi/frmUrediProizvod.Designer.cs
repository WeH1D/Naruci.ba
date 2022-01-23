
namespace NaruciBa.WinUI.Proizvodi
{
    partial class frmUrediProizvod
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKM = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.lblSifra = new System.Windows.Forms.Label();
            this.cbKomad = new System.Windows.Forms.CheckBox();
            this.cbKg = new System.Windows.Forms.CheckBox();
            this.lblDodajSliku = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.cbPodkategorija = new System.Windows.Forms.ComboBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblValidacija = new System.Windows.Forms.Label();
            this.lblCijenaPo = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lblPodkategorija = new System.Windows.Forms.Label();
            this.lblUrediProizvod = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblKM);
            this.panel1.Controls.Add(this.txtSifra);
            this.panel1.Controls.Add(this.lblSifra);
            this.panel1.Controls.Add(this.cbKomad);
            this.panel1.Controls.Add(this.cbKg);
            this.panel1.Controls.Add(this.lblDodajSliku);
            this.panel1.Controls.Add(this.pbSlika);
            this.panel1.Controls.Add(this.cbPodkategorija);
            this.panel1.Controls.Add(this.txtCijena);
            this.panel1.Controls.Add(this.txtNaziv);
            this.panel1.Controls.Add(this.lblValidacija);
            this.panel1.Controls.Add(this.lblCijenaPo);
            this.panel1.Controls.Add(this.btnSacuvaj);
            this.panel1.Controls.Add(this.lblNaziv);
            this.panel1.Controls.Add(this.lblOpis);
            this.panel1.Controls.Add(this.txtOpis);
            this.panel1.Controls.Add(this.lblCijena);
            this.panel1.Controls.Add(this.lblPodkategorija);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 342);
            this.panel1.TabIndex = 19;
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKM.Location = new System.Drawing.Point(521, 128);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(29, 18);
            this.lblKM.TabIndex = 27;
            this.lblKM.Text = "KM";
            // 
            // txtSifra
            // 
            this.txtSifra.Font = new System.Drawing.Font("Montserrat Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifra.Location = new System.Drawing.Point(387, 19);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(163, 24);
            this.txtSifra.TabIndex = 25;
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifra.Location = new System.Drawing.Point(233, 22);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(37, 18);
            this.lblSifra.TabIndex = 24;
            this.lblSifra.Text = "Sifra";
            // 
            // cbKomad
            // 
            this.cbKomad.AutoSize = true;
            this.cbKomad.Font = new System.Drawing.Font("Montserrat Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKomad.Location = new System.Drawing.Point(387, 189);
            this.cbKomad.Name = "cbKomad";
            this.cbKomad.Size = new System.Drawing.Size(86, 24);
            this.cbKomad.TabIndex = 23;
            this.cbKomad.Text = "komadu";
            this.cbKomad.UseVisualStyleBackColor = true;
            this.cbKomad.CheckedChanged += new System.EventHandler(this.cbKomad_CheckedChanged);
            // 
            // cbKg
            // 
            this.cbKg.AutoSize = true;
            this.cbKg.Checked = true;
            this.cbKg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKg.Font = new System.Drawing.Font("Montserrat Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKg.Location = new System.Drawing.Point(387, 161);
            this.cbKg.Name = "cbKg";
            this.cbKg.Size = new System.Drawing.Size(46, 24);
            this.cbKg.TabIndex = 22;
            this.cbKg.Text = "kg";
            this.cbKg.UseVisualStyleBackColor = true;
            this.cbKg.CheckedChanged += new System.EventHandler(this.cbKg_CheckedChanged);
            // 
            // lblDodajSliku
            // 
            this.lblDodajSliku.AutoSize = true;
            this.lblDodajSliku.Font = new System.Drawing.Font("Montserrat Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodajSliku.ForeColor = System.Drawing.Color.Red;
            this.lblDodajSliku.Location = new System.Drawing.Point(59, 185);
            this.lblDodajSliku.Name = "lblDodajSliku";
            this.lblDodajSliku.Size = new System.Drawing.Size(66, 15);
            this.lblDodajSliku.TabIndex = 21;
            this.lblDodajSliku.Text = "Dodaj sliku";
            this.lblDodajSliku.Click += new System.EventHandler(this.lblDodajSliku_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlika.Location = new System.Drawing.Point(3, 19);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(170, 158);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSlika.TabIndex = 19;
            this.pbSlika.TabStop = false;
            // 
            // cbPodkategorija
            // 
            this.cbPodkategorija.Font = new System.Drawing.Font("Montserrat Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPodkategorija.FormattingEnabled = true;
            this.cbPodkategorija.Location = new System.Drawing.Point(387, 224);
            this.cbPodkategorija.Name = "cbPodkategorija";
            this.cbPodkategorija.Size = new System.Drawing.Size(163, 26);
            this.cbPodkategorija.TabIndex = 20;
            // 
            // txtCijena
            // 
            this.txtCijena.Font = new System.Drawing.Font("Montserrat Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCijena.Location = new System.Drawing.Point(387, 125);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(128, 24);
            this.txtCijena.TabIndex = 18;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Montserrat Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(387, 55);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(163, 24);
            this.txtNaziv.TabIndex = 17;
            // 
            // lblValidacija
            // 
            this.lblValidacija.AutoSize = true;
            this.lblValidacija.Font = new System.Drawing.Font("Montserrat Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidacija.ForeColor = System.Drawing.Color.Red;
            this.lblValidacija.Location = new System.Drawing.Point(279, 259);
            this.lblValidacija.Name = "lblValidacija";
            this.lblValidacija.Size = new System.Drawing.Size(180, 15);
            this.lblValidacija.TabIndex = 16;
            this.lblValidacija.Text = "Sva polja moraju biti popunjena.";
            this.lblValidacija.Visible = false;
            // 
            // lblCijenaPo
            // 
            this.lblCijenaPo.AutoSize = true;
            this.lblCijenaPo.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCijenaPo.Location = new System.Drawing.Point(233, 163);
            this.lblCijenaPo.Name = "lblCijenaPo";
            this.lblCijenaPo.Size = new System.Drawing.Size(71, 18);
            this.lblCijenaPo.TabIndex = 9;
            this.lblCijenaPo.Text = "Cijena po:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(429, 287);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(121, 29);
            this.btnSacuvaj.TabIndex = 15;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(233, 58);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(44, 18);
            this.lblNaziv.TabIndex = 3;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.Location = new System.Drawing.Point(233, 93);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(40, 18);
            this.lblOpis.TabIndex = 5;
            this.lblOpis.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Montserrat Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpis.Location = new System.Drawing.Point(387, 90);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(163, 24);
            this.txtOpis.TabIndex = 12;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCijena.Location = new System.Drawing.Point(233, 128);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(51, 18);
            this.lblCijena.TabIndex = 7;
            this.lblCijena.Text = "Cijena:";
            // 
            // lblPodkategorija
            // 
            this.lblPodkategorija.AutoSize = true;
            this.lblPodkategorija.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodkategorija.Location = new System.Drawing.Point(233, 227);
            this.lblPodkategorija.Name = "lblPodkategorija";
            this.lblPodkategorija.Size = new System.Drawing.Size(102, 18);
            this.lblPodkategorija.TabIndex = 11;
            this.lblPodkategorija.Text = "Podkategorija:";
            // 
            // lblUrediProizvod
            // 
            this.lblUrediProizvod.AutoSize = true;
            this.lblUrediProizvod.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrediProizvod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUrediProizvod.Location = new System.Drawing.Point(12, 21);
            this.lblUrediProizvod.Name = "lblUrediProizvod";
            this.lblUrediProizvod.Size = new System.Drawing.Size(124, 21);
            this.lblUrediProizvod.TabIndex = 20;
            this.lblUrediProizvod.Text = "Uredi proizvod";
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // frmUrediProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 411);
            this.Controls.Add(this.lblUrediProizvod);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(605, 450);
            this.MinimumSize = new System.Drawing.Size(605, 450);
            this.Name = "frmUrediProizvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUrediProizvod";
            this.Load += new System.EventHandler(this.frmUrediProizvod_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.CheckBox cbKomad;
        private System.Windows.Forms.CheckBox cbKg;
        private System.Windows.Forms.Label lblDodajSliku;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.ComboBox cbPodkategorija;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblCijenaPo;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label lblPodkategorija;
        private System.Windows.Forms.Label lblUrediProizvod;
        private System.Windows.Forms.Label lblValidacija;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}