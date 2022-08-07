using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaruciBa.WinUI.Proizvodi
{
    public partial class frmDodajNoviProizvod : Form
    {
        APIService _podkategorijaService = new APIService("Podkategorija");
        APIService _kategorijaService = new APIService("Kategorija");
        APIService _proizvodService = new APIService("Proizvod");
        string dodanaSlikaPutanja = "";
        byte[] dodanaSlika;
        int _poslovnicaId;

        public frmDodajNoviProizvod(int poslovnicaId)
        {
            InitializeComponent();
            _poslovnicaId = poslovnicaId;
        }

        private async void frmDodajNoviProizvod_Load(object sender, EventArgs e)
        {
            btnDodajPrpozvod.BackColor = AppTheme.PrimaryColor;
            cbKategorija.DataSource = await _kategorijaService.Get<List<Model.Kategorija>>();
            cbKategorija.DisplayMember = "Naziv";
            cbKategorija.ValueMember = "KategorijaID";

            fillPodkategorije(int.Parse(cbKategorija.SelectedValue.ToString()));
        }

        private async void fillPodkategorije(int kategorijaId)
        {
            Model.SearchObjects.PodkategorijaSearchObject search = new Model.SearchObjects.PodkategorijaSearchObject { KategorijaID = kategorijaId };
            cbPodkategorija.DataSource = await _podkategorijaService.Get<List<Model.Podkategorija>>(search);
            cbPodkategorija.DisplayMember = "Naziv";
            cbPodkategorija.ValueMember = "PodkategorijaId";
        }

        private void lblDodajSliku_Click(object sender, EventArgs e)
        {
            var result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                var filename = ofd.FileName;
                dodanaSlikaPutanja = filename;
                var file = File.ReadAllBytes(filename);
                dodanaSlika = file;
                Image img = Image.FromFile(filename);
                pbSlika.Image = img;
            }
        }

        private async void btnDodajPrpozvod_Click(object sender, EventArgs e)
        {
            if (txtSifra.Text != "" && txtNaziv.Text != "" && txtOpis.Text != "" && txtCijena.Text != "")
            {
                Model.Requests.ProizvodInsertRequest proizvod = new Model.Requests.ProizvodInsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    Opis = txtOpis.Text,
                    Cijena = decimal.Parse(txtCijena.Text),
                    Kg = cbKg.Checked,
                    PoslovnicaID = _poslovnicaId,
                    PodkategorijaID = int.Parse(cbPodkategorija.SelectedValue.ToString()),
                    Sifra = txtSifra.Text,
                    DatumKreiranja = DateTime.Now,
                    DatumIzmjene = DateTime.Now,
                    SlikaPutanja = dodanaSlikaPutanja,
                    Slika = dodanaSlika
                };

                await _proizvodService.Insert<Model.Proizvod>(proizvod);
                this.Close();
            }
            else
                lblValidacija.Visible = true;
        }

        private void txtCijena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cbKg_CheckedChanged(object sender, EventArgs e)
        {
            cbKomad.Checked = false;
        }

        private void cbKomad_CheckedChanged(object sender, EventArgs e)
        {
            cbKg.Checked = false;
        }

        private void cbKategorija_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillPodkategorije(int.Parse(cbKategorija.SelectedValue.ToString()));
        }
    }
}
