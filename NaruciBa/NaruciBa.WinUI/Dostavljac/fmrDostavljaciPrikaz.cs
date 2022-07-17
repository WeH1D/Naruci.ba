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
    public partial class fmrDostavljaciPrikaz : Form
    {
        private APIService _dostavljacService = new APIService("Dostavljac");
        private APIService _korisnikService = new APIService("Korisnik");
        private APIService _gradService = new APIService("Grad");
        public fmrDostavljaciPrikaz()
        {
            InitializeComponent();
        }

        private async void fmrDostavljaciPrikaz_LoadAsync(object sender, EventArgs e)
        {
            dgvPoslovnice.AutoGenerateColumns = false;
            List<Model.Dostavljac> dostavljaci = await _dostavljacService.Get<List<Model.Dostavljac>>();
            List<Model.Grad> gradovi = await _gradService.Get<List<Model.Grad>>();
            List<dataGridDostavljacRow> dostavljaciKorisnici = new List<dataGridDostavljacRow>();
            foreach (Model.Dostavljac dostavljac in dostavljaci)
            {
                Model.Korisnik dos = await _korisnikService.GetById<Model.Korisnik>(dostavljac.KorisnikID);
                dostavljaciKorisnici.Add(new dataGridDostavljacRow()
                {
                    korisnikID = dos.KorisnikID,
                    Ime = dos.Ime,
                    Prezime = dos.Prezime,
                    Email = dos.Email,
                    Adresa = dos.Adresa,
                    Telefon = dos.Telefon,
                    Grad = gradovi.Where(a => a.GradID == dos.GradID).FirstOrDefault().Naziv
                });
            }
            dgvPoslovnice.DataSource = dostavljaciKorisnici;

            btnDodajDostavljaca.BackColor = AppTheme.PrimaryColor;
        }

        private void btnDodajDostavljaca_Click(object sender, EventArgs e)
        {
            frmDodajDostavljaca frm = new frmDodajDostavljaca();
            frm.FormClosing += fmrDostavljaciPrikaz_LoadAsync;
            frm.ShowDialog();
        }
    }
    class dataGridDostavljacRow
    {
        public int korisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
    }
}
