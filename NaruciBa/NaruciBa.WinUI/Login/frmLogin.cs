using IdentityModel.Client;
using NaruciBa.WinUI.Services;
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
        private APIService _korisnikService = new APIService("Korisnik");

        public frmLogin()
        {
            InitializeComponent();
            pnlDecoration.BackColor = AppTheme.PrimaryColor;
            btnLogin.BackColor = AppTheme.PrimaryColor;
            lblSignup.ForeColor = AppTheme.PrimaryColor;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //if(!string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            //{
            //    this.Hide();
            //    frmHome frm = new frmHome();
            //    frm.ShowDialog();
            //}
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            TokenService service = new TokenService();
            try
            {
                Properties.Settings.Default.AccessToken = "";
                Properties.Settings.Default.RefreshToken = "";
                await service.setToken(txtEmail.Text, txtPassword.Text);

                this.Hide();
                frmHome frm = new frmHome();
                frm.ShowDialog();
            }
            catch(Exception)
            {
                txtValidation.Visible = true;
                txtEmail.Text = "";
                txtPassword.Text = "";
            }
        }
    }
}
