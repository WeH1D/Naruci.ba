using NaruciBa.WinUI.Proizvodi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaruciBa.WinUI.Poslovnice
{
    public partial class frmPoslovnicaDetalji : Form
    {
        string poslovnicaId;
        APIService _poslovnciaApiService = new APIService("Poslovnica");
        APIService _trgovackiLanciService = new APIService("TrgovackiLanac");
        APIService _gradService = new APIService("Grad");
        APIService _proizvodiService = new APIService("Proizvod");
        APIService _kategorijaService = new APIService("Kategorija");
        public frmPoslovnicaDetalji(string polsovnicaID)
        {
            InitializeComponent();
            poslovnicaId = polsovnicaID;
        }

        private async void frmPoslovnicaDetalji_Load(object sender, EventArgs e)
        {

            await setPoslovnicaInfo();

            List<Model.Proizvod> proizvodi = await _proizvodiService.Get<List<Model.Proizvod>>(new Model.SearchObjects.ProizvodSearchObject()
            {
                PoslovnicaID = int.Parse(poslovnicaId),
                IncludeList = new List<string>() { "Podkategorija" }
            });

            List<Model.Kategorija> kategorije = await getKategorijeFromProizvodi(proizvodi);

            foreach (Model.Kategorija kategorija in kategorije)
            {
                DataGridView dgv = new DataGridView();
                dgv.Dock = DockStyle.Top;
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.BackColor = Color.White;
                style.ForeColor = Color.FromArgb(64, 64, 64);
                dgv.DefaultCellStyle = style;
                dgv.ColumnHeadersDefaultCellStyle = style;
                
                DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
                columnId.Visible = false;
                columnId.DataPropertyName = "KategorijaId";
                dgv.Columns.Add(columnId);

                DataGridViewTextBoxColumn columnNaziv = new DataGridViewTextBoxColumn();
                columnNaziv.HeaderText = "Naziv";
                columnNaziv.DataPropertyName = "Naziv";
                dgv.Columns.Add(columnNaziv);

                DataGridViewTextBoxColumn columnOpis = new DataGridViewTextBoxColumn();
                columnOpis.HeaderText = "Opis";
                columnOpis.DataPropertyName = "Opis";
                dgv.Columns.Add(columnOpis);

                DataGridViewTextBoxColumn columnCijena = new DataGridViewTextBoxColumn();
                columnCijena.HeaderText = "Cijena";
                columnCijena.DataPropertyName = "Cijena";
                dgv.Columns.Add(columnCijena);

                //foreach (var proizvod in proizvodi)
                //{
                //    if(proizvod.Podkategorija.KategorijaID == kategorija.KategorijaID)
                //    {
                //        dgv.Rows.Add(proizvod);
                //    }
                //}

                dgv.AutoGenerateColumns = false;
                dgv.DataSource = proizvodi;

                pnlPorizvodiBack.Controls.Add(dgv);

                Button btn = new Button();
                btn.Text = kategorija.Naziv;
                btn.Dock = DockStyle.Top;
                pnlPorizvodiBack.Controls.Add(btn);
            }

        }

        private void btnDodajNoviProizvod_Click(object sender, EventArgs e)
        {
            frmDodajNoviProizvod frm = new frmDodajNoviProizvod(int.Parse(poslovnicaId));
            frm.ShowDialog();
        }


        public async Task setPoslovnicaInfo()
        {
            var poslovnica = await _poslovnciaApiService.GetById<Model.Poslovnica>(poslovnicaId);

            txtAdresa.Text = poslovnica.Adresa;
            txtKontaktEmail.Text = poslovnica.KontaktEmail;
            txtKontaktTelefon.Text = poslovnica.KontaktTel;

            cbGrad.DataSource = await _gradService.Get<List<Model.Grad>>();
            cbGrad.DisplayMember = "Naziv";
            cbGrad.ValueMember = "GradId";
            cbGrad.SelectedValue = poslovnica.GradID;

            var trgovackiLanac = await _trgovackiLanciService.GetById<Model.TrgovackiLanac>(poslovnica.TrgovackiLanacID);
            cbLanacPoslovnica.DataSource = await _trgovackiLanciService.Get<List<Model.TrgovackiLanac>>();
            cbLanacPoslovnica.DisplayMember = "Naziv";
            cbLanacPoslovnica.ValueMember = "trgovackiLanacId";
            cbLanacPoslovnica.SelectedValue = poslovnica.TrgovackiLanacID;

            if (trgovackiLanac.Slika != null && trgovackiLanac.Slika.Length > 0)
            {
                Image x = (Bitmap)((new ImageConverter()).ConvertFrom(trgovackiLanac.Slika));
                pbSlika.Image = x;
            }
        }

        public async Task<List<Model.Kategorija>> getKategorijeFromProizvodi(List<Model.Proizvod> proizvodi)
        {

            List<string> kategorijeIDs = new List<string>();

            foreach (var proizvod in proizvodi)
            {
                kategorijeIDs.Add(proizvod.Podkategorija.KategorijaID.ToString());
            }

            kategorijeIDs = kategorijeIDs.Distinct().ToList();

            List<Model.Kategorija> kategorije = new List<Model.Kategorija>();

            foreach (var id in kategorijeIDs)
            {
                kategorije.Add(await _kategorijaService.GetById<Model.Kategorija>(id));
            }

            return kategorije;
        }
    }
}
