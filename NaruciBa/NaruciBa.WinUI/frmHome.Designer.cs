
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
            this.poslovniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlLogoContainer = new System.Windows.Forms.Panel();
            this.txtLogo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlLogoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poslovniceToolStripMenuItem,
            this.kategorijeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 59);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip.Size = new System.Drawing.Size(200, 602);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // poslovniceToolStripMenuItem
            // 
            this.poslovniceToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poslovniceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.poslovniceToolStripMenuItem.Name = "poslovniceToolStripMenuItem";
            this.poslovniceToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15);
            this.poslovniceToolStripMenuItem.Size = new System.Drawing.Size(199, 50);
            this.poslovniceToolStripMenuItem.Text = "Poslovnice";
            this.poslovniceToolStripMenuItem.Click += new System.EventHandler(this.poslovniceToolStripMenuItem_Click);
            // 
            // kategorijeToolStripMenuItem
            // 
            this.kategorijeToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategorijeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kategorijeToolStripMenuItem.Name = "kategorijeToolStripMenuItem";
            this.kategorijeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15);
            this.kategorijeToolStripMenuItem.Size = new System.Drawing.Size(199, 50);
            this.kategorijeToolStripMenuItem.Text = "Kategorije";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlLogo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1284, 59);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.White;
            this.pnlLogo.Controls.Add(this.pnlLogoContainer);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 59);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlLogoContainer
            // 
            this.pnlLogoContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogoContainer.Controls.Add(this.txtLogo);
            this.pnlLogoContainer.Controls.Add(this.pictureBox1);
            this.pnlLogoContainer.Location = new System.Drawing.Point(12, 12);
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
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pnlMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.SizeChanged += new System.EventHandler(this.frmHome_SizeChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlMain.ResumeLayout(false);
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
    }
}



