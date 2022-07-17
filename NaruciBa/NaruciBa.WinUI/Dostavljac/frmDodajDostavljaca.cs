using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaruciBa.WinUI.Dostavljac
{
    public partial class frmDodajDostavljaca : Form
    {
        private APIService _gradService = new APIService("Grad");
        private APIService _korisnikService = new APIService("Korisnik");

        public frmDodajDostavljaca()
        {
            InitializeComponent();
        }


        private async void frmDodajDostavljaca_LoadAsync(object sender, EventArgs e)
        {
            List<Model.Grad> gradovi = await _gradService.Get<List<Model.Grad>>();
            cbGrad.DataSource = gradovi;
            cbGrad.DisplayMember = "Naziv";
            cbGrad.ValueMember = "GradId";

            lblIncorrectPass.Visible = false;
            lblError.Visible = false;

            btnDodaj.BackColor = AppTheme.PrimaryColor;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnDodaj_ClickAsync(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPotvrdiPassword.Text)
            {
                int gradId = int.Parse(cbGrad.SelectedValue.ToString());
                Model.Requests.KorisnikInsertRequest request = new Model.Requests.KorisnikInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Adresa = txtAdresa.Text,
                    Email = txtEmail.Text,
                    Telefon = txtTelefon.Text,
                    Password = txtPassword.Text,
                    GradID = gradId,
                    DatumKreiranja = DateTime.Now,
                    DatumIzmjene = DateTime.Now,
                    DatumRodenja = dtDatumRodenja.Value,
                    dostavljacInsert = new Model.Requests.DostavljacUpsertRequest()
                    {
                        DatumZaposlenja = DateTime.Now,
                        DostavljacStatus = 1
                    }
                };

                try
                {
                    await _korisnikService.Insert<Model.Korisnik>(request);
                }
                catch (Exception ex)
                {
                    lblError.Visible = true;
                    lblError.Text = ex.Message;
                }
               
            } else
            {
                lblIncorrectPass.Visible = true;
            }
        }

        private void frmDodajDostavljaca_Load_1(object sender, EventArgs e)
        {

        }
    }
}
