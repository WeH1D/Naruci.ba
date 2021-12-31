using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaruciBa.WinUI.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            pnlDecoration.BackColor = AppTheme.PrimaryColor;
            btnLogin.BackColor = AppTheme.PrimaryColor;
            lblSignup.ForeColor = AppTheme.PrimaryColor;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome frm = new frmHome();
            frm.ShowDialog();
        }
    }
}
