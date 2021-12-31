
namespace NaruciBa.WinUI
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.narudzbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poslovniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kuponiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dostavljaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlLogoContainer = new System.Windows.Forms.Panel();
            this.txtLogo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlLogoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.narudzbeToolStripMenuItem,
            this.poslovniceToolStripMenuItem,
            this.kuponiToolStripMenuItem,
            this.dostavljaciToolStripMenuItem,
            this.kategorijeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 107);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip.Size = new System.Drawing.Size(200, 554);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // narudzbeToolStripMenuItem
            // 
            this.narudzbeToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.narudzbeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.narudzbeToolStripMenuItem.Name = "narudzbeToolStripMenuItem";
            this.narudzbeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15);
            this.narudzbeToolStripMenuItem.Size = new System.Drawing.Size(199, 50);
            this.narudzbeToolStripMenuItem.Text = "Narudzbe";
            this.narudzbeToolStripMenuItem.Click += new System.EventHandler(this.narudzbeToolStripMenuItem_Click);
            // 
            // poslovniceToolStripMenuItem
            // 
            this.poslovniceToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.poslovniceToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poslovniceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.poslovniceToolStripMenuItem.Name = "poslovniceToolStripMenuItem";
            this.poslovniceToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15);
            this.poslovniceToolStripMenuItem.Size = new System.Drawing.Size(199, 50);
            this.poslovniceToolStripMenuItem.Text = "Poslovnice";
            this.poslovniceToolStripMenuItem.Click += new System.EventHandler(this.poslovniceToolStripMenuItem_Click);
            // 
            // kuponiToolStripMenuItem
            // 
            this.kuponiToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuponiToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kuponiToolStripMenuItem.Name = "kuponiToolStripMenuItem";
            this.kuponiToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15);
            this.kuponiToolStripMenuItem.Size = new System.Drawing.Size(199, 50);
            this.kuponiToolStripMenuItem.Text = "Kuponi";
            this.kuponiToolStripMenuItem.Click += new System.EventHandler(this.kuponiToolStripMenuItem_Click);
            // 
            // dostavljaciToolStripMenuItem
            // 
            this.dostavljaciToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dostavljaciToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dostavljaciToolStripMenuItem.Name = "dostavljaciToolStripMenuItem";
            this.dostavljaciToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15);
            this.dostavljaciToolStripMenuItem.Size = new System.Drawing.Size(199, 50);
            this.dostavljaciToolStripMenuItem.Text = "Dostavljaci";
            this.dostavljaciToolStripMenuItem.Click += new System.EventHandler(this.dostavljaciToolStripMenuItem_Click);
            // 
            // kategorijeToolStripMenuItem
            // 
            this.kategorijeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.kategorijeToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategorijeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kategorijeToolStripMenuItem.Name = "kategorijeToolStripMenuItem";
            this.kategorijeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15);
            this.kategorijeToolStripMenuItem.Size = new System.Drawing.Size(199, 50);
            this.kategorijeToolStripMenuItem.Text = "Kategorije";
            this.kategorijeToolStripMenuItem.Click += new System.EventHandler(this.kategorijeToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Controls.Add(this.pnlLogo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1284, 107);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlRight.Controls.Add(this.pnlTopBar);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(200, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(20);
            this.pnlRight.Size = new System.Drawing.Size(1084, 107);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.lblNaslov);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopBar.Location = new System.Drawing.Point(20, 20);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1044, 67);
            this.pnlTopBar.TabIndex = 0;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNaslov.Location = new System.Drawing.Point(38, 21);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(119, 26);
            this.lblNaslov.TabIndex = 1;
            this.lblNaslov.Text = "Poslovnice";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.White;
            this.pnlLogo.Controls.Add(this.pnlLogoContainer);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 107);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlLogoContainer
            // 
            this.pnlLogoContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogoContainer.Controls.Add(this.txtLogo);
            this.pnlLogoContainer.Controls.Add(this.pictureBox1);
            this.pnlLogoContainer.Location = new System.Drawing.Point(12, 36);
            this.pnlLogoContainer.Name = "pnlLogoContainer";
            this.pnlLogoContainer.Size = new System.Drawing.Size(167, 32);
            this.pnlLogoContainer.TabIndex = 0;
            // 
            // txtLogo
            // 
            this.txtLogo.BackColor = System.Drawing.Color.Transparent;
            this.txtLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtLogo.Font = new System.Drawing.Font("Montserrat", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLogo.Location = new System.Drawing.Point(35, 0);
            this.txtLogo.Margin = new System.Windows.Forms.Padding(0);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(132, 32);
            this.txtLogo.TabIndex = 0;
            this.txtLogo.Text = "Naruci.ba";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pnlMain);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naruci.ba";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.SizeChanged += new System.EventHandler(this.frmHome_SizeChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem poslovniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorijeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label txtLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLogoContainer;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.ToolStripMenuItem narudzbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kuponiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dostavljaciToolStripMenuItem;
        private System.Windows.Forms.Label lblNaslov;
    }
}



