using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaruciBa.WinUI.Poslovnice
{
    public partial class frmPoslovnicePrikaz : Form
    {
        private APIService _poslovnicaService = new APIService("Poslovnica");
        private APIService _gradService = new APIService("Grad");
        private APIService _trgovackiLanacService = new APIService("TrgovackiLanac");
        public frmPoslovnicePrikaz()
        {
            InitializeComponent();
            pnlDgv.Height = this.ClientRectangle.Height - pnlActions.ClientRectangle.Height;
            pnlDgv.Width = this.ClientRectangle.Width;
            btnDodajPoslovnicu.BackColor = AppTheme.PrimaryColor;
            btnDodajLanacPoslovnica.BackColor = AppTheme.PrimaryColor;
        }

        private async void frmPoslovnicePrikaz_Load(object sender, EventArgs e)
        {
            List<Model.Grad> gradovi = await _gradService.Get<List<Model.Grad>>();
            List<Model.TrgovackiLanac> trgovackiLanci = await _trgovackiLanacService.Get<List<Model.TrgovackiLanac>>();

            dgvPoslovnice.AutoGenerateColumns = false;
            List<Model.Poslovnica> poslovnice = await _poslovnicaService.Get<List<Model.Poslovnica>>();
            List<poslovniceForPrikaz> poslovniceForPrikaz = new List<poslovniceForPrikaz>();
            foreach (var poslovnica in poslovnice)
            {
                poslovniceForPrikaz.Add(new poslovniceForPrikaz()
                {
                    PoslovnicaID = poslovnica.PoslovnicaID,
                    Adresa = poslovnica.Adresa,
                    KontaktEmail = poslovnica.KontaktEmail,
                    KontaktTel = poslovnica.KontaktTel,
                    TrgovackiLanac = trgovackiLanci.First(a => a.TrgovackiLanacID == poslovnica.TrgovackiLanacID).Naziv,
                    Grad = gradovi.First(a => a.GradID == poslovnica.GradID).Naziv,
                });
            }

            dgvPoslovnice.DataSource = poslovniceForPrikaz;

            foreach (DataGridViewRow Row in dgvPoslovnice.Rows)
            {
                Row.Cells[6].Value = "Detalji";
            }

            btnDodajPoslovnicu.BackColor = AppTheme.PrimaryColor;
            btnDodajLanacPoslovnica.BackColor = AppTheme.PrimaryColor;
        }

        private void frmPoslovnicePrikaz_SizeChanged(object sender, EventArgs e)
        {
            pnlDgv.Height = this.ClientRectangle.Height - pnlActions.ClientRectangle.Height;
            pnlDgv.Width = this.ClientRectangle.Width;
        }

        private void btnDodajPoslovnicu_Click(object sender, EventArgs e)
        {
            frmDodajPoslovnicu frm = new frmDodajPoslovnicu();
            frm.ShowDialog();
        }

        private void btnDodajLanacPoslovnica_Click(object sender, EventArgs e)
        {
            fmrDodajLanacPoslovnica frm = new fmrDodajLanacPoslovnica();
            frm.ShowDialog();
        }

        private void dgvPoslovnice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                frmPoslovnicaDetalji frm = new frmPoslovnicaDetalji(dgvPoslovnice.Rows[e.RowIndex].Cells[0].Value.ToString());
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }
    }
    public class poslovniceForPrikaz
    {
        public int PoslovnicaID { get; set; }
        public string Adresa { get; set; }
        public string KontaktTel { get; set; }
        public string KontaktEmail { get; set; }
        public string TrgovackiLanac { get; set; }
        public string Grad { get; set; }

    }
}
