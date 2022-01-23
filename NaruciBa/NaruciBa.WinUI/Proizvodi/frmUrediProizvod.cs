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
    public partial class frmUrediProizvod : Form
    {
        APIService _podkategorijaService = new APIService("Podkategorija");
        APIService _proizvodService = new APIService("Proizvod");
        private int _proizvodId;
        string dodanaSlikaPutanja = "";
        byte[] dodanaSlika;
        bool _slikaUpdated = false;

        public frmUrediProizvod(int proizvodId)
        {
            InitializeComponent();
            _proizvodId = proizvodId;
        }

        private async void frmUrediProizvod_Load(object sender, EventArgs e)
        {
            btnSacuvaj.BackColor = AppTheme.PrimaryColor;

            cbPodkategorija.DataSource = await _podkategorijaService.Get<List<Model.Podkategorija>>();
            cbPodkategorija.DisplayMember = "Naziv";
            cbPodkategorija.ValueMember = "PodkategorijaId";


            var _proizvod = await _proizvodService.GetById<Model.Proizvod>(_proizvodId);
            txtSifra.Text = _proizvod.Sifra;
            txtSifra.ReadOnly = true;
            txtNaziv.Text = _proizvod.Naziv;
            txtOpis.Text = _proizvod.Opis;
            txtCijena.Text = _proizvod.Cijena.ToString();
            cbPodkategorija.SelectedValue = _proizvod.PodkategorijaID;
            dodanaSlikaPutanja = _proizvod.SlikaPutanja;
            dodanaSlika = _proizvod.Slika;
            if ((bool)_proizvod.Kg)
            {
                cbKg.Checked = true;
                cbKomad.Checked = false;
            }
            else
            {
                cbKg.Checked = false;
                cbKomad.Checked = true;
            }

            if (_proizvod.Slika != null && _proizvod.Slika.Length > 0)
            {
                Image x = (Bitmap)((new ImageConverter()).ConvertFrom(_proizvod.Slika));
                pbSlika.Image = x;
            }

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
                _slikaUpdated = true;
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (txtSifra.Text != "" && txtNaziv.Text != "" && txtOpis.Text != "" && txtCijena.Text != "")
            {
                Model.Requests.ProizvodUpdateRequest request = new Model.Requests.ProizvodUpdateRequest()
                {
                    Naziv = txtNaziv.Text,
                    Cijena = decimal.Parse(txtCijena.Text),
                    DatumIzmjene = DateTime.Now,
                    Opis = txtOpis.Text,
                    PodkategorijaID = int.Parse(cbPodkategorija.SelectedValue.ToString()),
                    Kg = cbKg.Checked,
                    SlikaPutanja = dodanaSlikaPutanja,
                    Slika = dodanaSlika
                };
                await _proizvodService.Update<Model.Proizvod>(_proizvodId, request);
                this.Close();
            }
            else
                lblValidacija.Visible = true;
        }
    }
}
