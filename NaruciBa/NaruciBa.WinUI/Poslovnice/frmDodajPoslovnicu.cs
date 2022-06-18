using Microsoft.AspNetCore.SignalR.Client;
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
    public partial class frmDodajPoslovnicu : Form
    {
        APIService _poslovniceService = new APIService("Poslovnica");
        APIService _lanacPOslovnicaService = new APIService("TrgovackiLanac");
        APIService _gradService = new APIService("Grad");

        public frmDodajPoslovnicu()
        {
            InitializeComponent();
        }

        private async void frmDodajPoslovnicu_Load(object sender, EventArgs e)
        {
            btnDodajPoslovnicu.BackColor = AppTheme.PrimaryColor;

            var lanciposlovnica = await _lanacPOslovnicaService.Get<List<Model.TrgovackiLanac>>();
            cbLanacPoslovnica.DataSource = lanciposlovnica;
            cbLanacPoslovnica.DisplayMember = "Naziv";
            cbLanacPoslovnica.ValueMember = "TrgovackiLanacId";

            var gradovi = await _gradService.Get<List<Model.Grad>>();
            cbGrad.DataSource = gradovi;
            cbGrad.DisplayMember = "Naziv";
            cbGrad.ValueMember = "GradID";

        }

        private async void btnDodajPoslovnicu_Click(object sender, EventArgs e)
        {
            if (txtAdresa.Text != "" && txtKontaktEmail.Text != "" && txtKontaktTelefon.Text != "")
            {
                Model.Requests.PoslovnicaInsertRequest request = new Model.Requests.PoslovnicaInsertRequest()
                {
                    Adresa = txtAdresa.Text,
                    GradID = int.Parse(cbGrad.SelectedValue.ToString()),
                    KontaktEmail = txtKontaktEmail.Text,
                    KontaktTel = txtKontaktTelefon.Text,
                    TrgovackiLanacID = int.Parse(cbLanacPoslovnica.SelectedValue.ToString()),
                    DatumKreiranja = DateTime.Now,
                    DatumIzmjene = DateTime.Now
                };
                await _poslovniceService.Insert<Model.Poslovnica>(request);

                this.Close();
            }
            else
                lblValidacija.Visible = true;
        }
    }
}
