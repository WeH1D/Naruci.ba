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
        APIService _proizvodService = new APIService("Proizvod");
        APIService _gradService = new APIService("Grad");
        APIService _proizvodiService = new APIService("Proizvod");
        APIService _kategorijaService = new APIService("Kategorija");
        APIService _kategorijrFromProizvodiService = new APIService("Kategorija/getKategorijeFromProizvodiList");

        public class ProizvodForView
        {
            public int ProizvodID { get; set; }
            public int KategorijaID { get; set; }
            public string Naziv { get; set; }
            public string Opis { get; set; }
            public string Cijena { get; set; }
            public string Kg { get; set; }
            public string Izbrisi { get; set; }
            public string Uredi { get; set; }

        }

        public frmPoslovnicaDetalji(string polsovnicaID)
        {
            InitializeComponent();
            poslovnicaId = polsovnicaID;
        }

        private async void frmPoslovnicaDetalji_Load(object sender, EventArgs e)
        {
            btnSacuvaj.BackColor = AppTheme.PrimaryColor;
            btnDodajNoviProizvod.BackColor = AppTheme.PrimaryColor;

            await setPoslovnicaInfo();

            await setProizvodiInfo();
        }

        private async Task setProizvodiInfo()
        {
            List<Model.Proizvod> proizvodi = await _proizvodiService.Get<List<Model.Proizvod>>(new Model.SearchObjects.ProizvodSearchObject()
            {
                PoslovnicaID = int.Parse(poslovnicaId),
                IncludeList = new List<string>() { "Podkategorija" }
            });

            ///////////////////////// Get all availbale kategorije from list of products ///////////////////////

            List<int> kategorijeIDs = new List<int>();

            foreach (var proizvod in proizvodi)
            {
                kategorijeIDs.Add((int)proizvod.Podkategorija.KategorijaID);
            }

            kategorijeIDs = kategorijeIDs.Distinct().ToList();

            List<Model.Kategorija> kategorije = await _kategorijrFromProizvodiService.Get<List<Model.Kategorija>>(new Model.SearchObjects.KategorijaSearchObject()
            {
                proizvodiID = kategorijeIDs
            });

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            generateProductList(kategorije, proizvodi);
        }

        private void generateProductList(List<Model.Kategorija> kategorije, List<Model.Proizvod> proizvodi)
        {

            pnlPorizvodiBack.Controls.Clear();

            foreach (Model.Kategorija kategorija in kategorije)
            {
                DataGridView dgv = new DataGridView();
                dgv.Dock = DockStyle.Top;
                dgv.ColumnHeadersVisible = false;
                dgv.Name = $"dgv{kategorija.Naziv}";
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dgv.AutoSize = true;
                dgv.BackgroundColor = Color.White;
                dgv.BorderStyle = BorderStyle.None;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

                DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
                columnId.Visible = false;
                columnId.DataPropertyName = "ProizvodID";
                dgv.Columns.Add(columnId);

                DataGridViewTextBoxColumn columnNaziv = new DataGridViewTextBoxColumn();
                columnNaziv.HeaderText = "Naziv";
                columnNaziv.DataPropertyName = "Naziv";
                columnNaziv.FillWeight = 2;
                DataGridViewCellStyle nazivStyle = new DataGridViewCellStyle();
                nazivStyle.BackColor = Color.White;
                nazivStyle.ForeColor = Color.FromArgb(64, 64, 64);
                nazivStyle.SelectionBackColor = Color.White;
                nazivStyle.SelectionForeColor = Color.FromArgb(64, 64, 64);
                columnNaziv.DefaultCellStyle = nazivStyle;
                dgv.Columns.Add(columnNaziv);

                DataGridViewTextBoxColumn columnOpis = new DataGridViewTextBoxColumn();
                columnOpis.HeaderText = "Opis";
                columnOpis.DataPropertyName = "Opis";
                columnOpis.FillWeight = 2;
                DataGridViewCellStyle opisStyle = new DataGridViewCellStyle();
                opisStyle.BackColor = Color.White;
                opisStyle.ForeColor = Color.FromArgb(64, 64, 64);
                opisStyle.SelectionBackColor = Color.White;
                opisStyle.SelectionForeColor = Color.FromArgb(64, 64, 64);
                columnOpis.DefaultCellStyle = opisStyle;
                dgv.Columns.Add(columnOpis);

                DataGridViewTextBoxColumn columnCijena = new DataGridViewTextBoxColumn();
                columnCijena.HeaderText = "Cijena";
                columnCijena.DataPropertyName = "Cijena";
                columnCijena.FillWeight = 1;
                DataGridViewCellStyle cijenaStyle = new DataGridViewCellStyle();
                cijenaStyle.BackColor = Color.White;
                cijenaStyle.ForeColor = Color.FromArgb(64, 64, 64);
                cijenaStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                cijenaStyle.SelectionBackColor = Color.White;
                cijenaStyle.SelectionForeColor = Color.FromArgb(64, 64, 64);
                columnCijena.DefaultCellStyle = cijenaStyle;
                dgv.Columns.Add(columnCijena);

                DataGridViewTextBoxColumn columnKolicina = new DataGridViewTextBoxColumn();
                columnKolicina.HeaderText = "Kg";
                columnKolicina.DataPropertyName = "Kg";
                columnKolicina.FillWeight = 1;
                DataGridViewCellStyle kgStyle = new DataGridViewCellStyle();
                kgStyle.BackColor = Color.White;
                kgStyle.ForeColor = Color.FromArgb(64, 64, 64);
                kgStyle.SelectionBackColor = Color.White;
                kgStyle.SelectionForeColor = Color.FromArgb(64, 64, 64);
                columnKolicina.DefaultCellStyle = kgStyle;
                dgv.Columns.Add(columnKolicina);

                DataGridViewTextBoxColumn columnUredi = new DataGridViewTextBoxColumn();
                columnUredi.DataPropertyName = "Uredi";
                columnUredi.FillWeight = 1;
                DataGridViewCellStyle urediStyle = new DataGridViewCellStyle();
                urediStyle.ForeColor = Color.HotPink;
                urediStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                urediStyle.SelectionBackColor = Color.White;
                urediStyle.SelectionForeColor = Color.HotPink;
                columnUredi.DefaultCellStyle = urediStyle;
                dgv.Columns.Add(columnUredi);

                DataGridViewTextBoxColumn columnIzbrisi = new DataGridViewTextBoxColumn();
                columnIzbrisi.DataPropertyName = "Izbrisi";
                columnIzbrisi.FillWeight = 1;
                DataGridViewCellStyle izbrisiStyle = new DataGridViewCellStyle();
                izbrisiStyle.ForeColor = Color.HotPink;
                izbrisiStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                izbrisiStyle.SelectionBackColor = Color.White;
                izbrisiStyle.SelectionForeColor = Color.HotPink;
                columnIzbrisi.DefaultCellStyle = izbrisiStyle;
                dgv.Columns.Add(columnIzbrisi);

                var odgovarajuciProizvodi = proizvodi.Where(a => a.Podkategorija.KategorijaID == kategorija.KategorijaID).ToList();
                List<ProizvodForView> proizvodiUKategoriji = new List<ProizvodForView>();
                foreach (var proizvod in odgovarajuciProizvodi)
                {
                    proizvodiUKategoriji.Add(new ProizvodForView
                    {
                        ProizvodID = proizvod.ProizvodID,
                        KategorijaID = (int)proizvod.Podkategorija.KategorijaID,
                        Cijena = $"{proizvod.Cijena} KM",
                        Kg = (bool)proizvod.Kg ? "po Kg" : "po komadu",
                        Naziv = proizvod.Naziv,
                        Opis = proizvod.Opis,
                        Uredi = "Uredi",
                        Izbrisi = "Izbrisi"
                    });
                }

                dgv.AutoGenerateColumns = false;
                dgv.DataSource = proizvodiUKategoriji;
                dgv.Visible = false;
                dgv.Height = proizvodiUKategoriji.Count * 22 + 10;

                dgv.CellClick += onCellClick;

                pnlPorizvodiBack.Controls.Add(dgv);

                Button btn = new Button();
                btn.Text = kategorija.Naziv;
                btn.Height = 40;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = AppTheme.PrimaryColor;
                btn.ForeColor = Color.White;
                btn.Font = new Font("monteserat", 12, FontStyle.Bold);
                btn.Dock = DockStyle.Top;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Padding = new Padding(10, 0, 0, 0);
                btn.Click += new EventHandler(expandKategorija);
                pnlPorizvodiBack.Controls.Add(btn);
            }
        }

        private async void onCellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            var proizvodID = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (e.ColumnIndex == 5)
            {
                frmUrediProizvod form = new frmUrediProizvod(int.Parse(proizvodID));
                form.FormClosing += updateProducts;
                form.ShowDialog();
            }
            if (e.ColumnIndex == 6)
            {
                var confirmResult = MessageBox.Show("Jeste li sigurni da zelite izbrisati odabrani proizvod?", "", MessageBoxButtons.YesNo);
                if(confirmResult == DialogResult.Yes)
                {
                    Model.Requests.ProizvodUpdateRequest request = new Model.Requests.ProizvodUpdateRequest()
                    {
                        DatumIzmjene = DateTime.Now,
                        Status = false
                    };
                    await _proizvodService.Update<Model.Proizvod>(proizvodID, request);
                    await setProizvodiInfo();
                }
            }
        }

        private async void updateProducts(object sender, EventArgs e)
        {
            await setProizvodiInfo();
        }

        private void expandKategorija(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var control = pnlPorizvodiBack.Controls.Find($"dgv{btn.Text}", true).First();
            control.Visible = !control.Visible;
        }

        private void btnDodajNoviProizvod_Click(object sender, EventArgs e)
        {
            frmDodajNoviProizvod frm = new frmDodajNoviProizvod(int.Parse(poslovnicaId));
            frm.FormClosing += updateProducts;
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
    }
}
