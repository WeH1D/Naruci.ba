using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            cbPodkategorija.SelectedIndex = (int)_proizvod.PodkategorijaID;
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

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

        }
    }
}
