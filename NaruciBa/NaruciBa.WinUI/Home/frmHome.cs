using NaruciBa.WinUI.Kategorije;
using NaruciBa.WinUI.Login;
using NaruciBa.WinUI.Poslovnice;
using NaruciBa.WinUI.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaruciBa.WinUI
{
    public partial class frmHome : Form
    {
        private int childFormNumber = 0;

        public frmHome()
        {
            InitializeComponent();
            SetActiveMenuItem(poslovniceToolStripMenuItem);
            lblNaslov.Text = poslovniceToolStripMenuItem.Text;
            menuStrip.Renderer = new MyRenderer(AppTheme.PrimaryColor, Color.White);
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        private void frmHome_Load(object sender, EventArgs e)
        {
            this.SetBevel(false);

            btnLogout.BackColor = AppTheme.PrimaryColor;
            menuStrip.Width = this.Width / 6;
            pnlLogo.Width = this.Width / 6;

            lblUserName.Text = Properties.Settings.Default.email;

            frmPoslovnicePrikaz frm = new frmPoslovnicePrikaz();
            frm.MdiParent = this;
            frm.Show();

        }
        private void poslovniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPoslovnicePrikaz frm = new frmPoslovnicePrikaz();
            frm.MdiParent = this;
            frm.Show();
            SetActiveMenuItem(poslovniceToolStripMenuItem);
            lblNaslov.Text = poslovniceToolStripMenuItem.Text;


        }

        private void frmHome_SizeChanged(object sender, EventArgs e)
        {
            menuStrip.Width = this.Width / 6;
            pnlLogo.Width = this.Width / 6;
        }

        private void kategorijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategorijePrikaz frm = new frmKategorijePrikaz();
            frm.MdiParent = this;
            frm.Show();
            SetActiveMenuItem(kategorijeToolStripMenuItem);
            lblNaslov.Text = kategorijeToolStripMenuItem.Text;
        }

        private void narudzbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPoslovnicePrikaz frm = new frmPoslovnicePrikaz();
            //frm.MdiParent = this;
            //frm.Show();
            SetActiveMenuItem(narudzbeToolStripMenuItem);
            lblNaslov.Text = narudzbeToolStripMenuItem.Text;

        }

        private void kuponiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPoslovnicePrikaz frm = new frmPoslovnicePrikaz();
            //frm.MdiParent = this;
            //frm.Show();
            SetActiveMenuItem(kuponiToolStripMenuItem);
            lblNaslov.Text = kuponiToolStripMenuItem.Text;

        }

        private void dostavljaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPoslovnicePrikaz frm = new frmPoslovnicePrikaz();
            //frm.MdiParent = this;
            //frm.Show();
            SetActiveMenuItem(dostavljaciToolStripMenuItem);
            lblNaslov.Text = dostavljaciToolStripMenuItem.Text;

        }

        private void SetActiveMenuItem(ToolStripMenuItem activeItem)
        {
            foreach (ToolStripMenuItem item in menuStrip.Items)
            {
                if (item == activeItem)
                    item.BackColor = AppTheme.PrimaryColor;
                else
                    item.BackColor = Color.White;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AccessToken = "";
            Properties.Settings.Default.RefreshToken = "";
            Properties.Settings.Default.email = "";
            Properties.Settings.Default.passwordHash = "";

            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
            this.Close();

        }

    }
}
