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

namespace NaruciBa.WinUI.Poslovnice
{
    public partial class fmrDodajLanacPoslovnica : Form
    {
        APIService _LanacPoslovnicaService = new APIService("TrgovackiLanac");
        Model.Requests.TrgovackiLanacUpsertRequest request = new Model.Requests.TrgovackiLanacUpsertRequest();

        public fmrDodajLanacPoslovnica()
        {
            InitializeComponent();
        }

        private void fmrDodajLanacPoslovnica_Load(object sender, EventArgs e)
        {
            btnDodaj.BackColor = AppTheme.PrimaryColor;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if(txtNaziv.Text != "")
            {
                request.Naziv = txtNaziv.Text;
                await _LanacPoslovnicaService.Insert<Model.TrgovackiLanac>(request);

                this.Close();
            }
        }

        private void lblDodajSliku_Click(object sender, EventArgs e)
        {
            var result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                var filename = ofd.FileName;
                request.SlikaPutanja = filename;
                var file = File.ReadAllBytes(filename);
                request.Slika = file;
                Image img = Image.FromFile(filename);
                pbTrgovackiLanac.Image = img;
            }
        }
    }
}
