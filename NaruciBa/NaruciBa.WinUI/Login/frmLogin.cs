﻿using IdentityModel.Client;
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
        private APIService _koordinatorService = new APIService("Koordinator");
        TokenService service = new TokenService();

        public frmLogin()
        {
            InitializeComponent();
            pnlDecoration.BackColor = AppTheme.PrimaryColor;
            btnLogin.BackColor = AppTheme.PrimaryColor;
            lblSignup.ForeColor = AppTheme.PrimaryColor;
        }

     // Open app --> if there is an access token set refresh token and log in automatically
     //          --> if refresh token cant be set reset all storred data of user
     // Login --> if access token is set succesfully store email and hashed password and let user through
     //       --> if token isnt set succesfully then reset text fields and let user tryy again

        private async void frmLogin_Load(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            //{
            //    try
            //    {
            //        await service.setRefreshToken();

            //        this.Hide();
            //        frmHome frm = new frmHome();
            //        frm.ShowDialog();
            //    }
            //    catch (Exception)
            //    {
            //        Properties.Settings.Default.AccessToken = "";
            //        Properties.Settings.Default.RefreshToken = "";
            //        Properties.Settings.Default.email = "";
            //        Properties.Settings.Default.passwordHash = "";
            //    }

            //}
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
           
            try
            {
                Properties.Settings.Default.AccessToken = "";
                Properties.Settings.Default.RefreshToken = "";
                Properties.Settings.Default.email = "";
                Properties.Settings.Default.passwordHash = "";

                await service.setToken(txtEmail.Text, txtPassword.Text);

                Properties.Settings.Default.email = txtEmail.Text;
                // TODO --> hashs the password
                Properties.Settings.Default.passwordHash = txtPassword.Text;
                Properties.Settings.Default.Save();

                Model.SearchObjects.KorisnikSearchObject korisnikSearch = new Model.SearchObjects.KorisnikSearchObject
                {
                    Email = txtEmail.Text
                };
                List<Model.Korisnik> korisnik = await _korisnikService.Get<List<Model.Korisnik>>(korisnikSearch);

                Model.SearchObjects.KoordinatorSearchObject koordinatorSearch = new Model.SearchObjects.KoordinatorSearchObject
                {
                    KorisnikID = korisnik.First().KorisnikID
                };
                List<Model.Koordinator> koordinator = await _koordinatorService.Get<List<Model.Koordinator>>(koordinatorSearch);

                if (koordinator.Any())
                {
                    this.Hide();
                    frmHome frm = new frmHome();
                    frm.ShowDialog();
                } else
                {
                    throw new Exception("Wrong email or password");
                }
            }
            catch (Exception err)
            {
                txtValidation.Visible = true;
                txtEmail.Text = "";
                txtPassword.Text = "";
            }
            
        }
    }
}
