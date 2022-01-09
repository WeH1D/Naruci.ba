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
    public partial class fmrDodajLanacPoslovnica : Form
    {
        APIService _LanacPoslovnicaService = new APIService("TrgovackiLanac");
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
                await _LanacPoslovnicaService.Insert<Model.TrgovackiLanac>(new Model.Requests.TrgovackiLanacUpsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    Slika = null
                });
            }
        }
    }
}
