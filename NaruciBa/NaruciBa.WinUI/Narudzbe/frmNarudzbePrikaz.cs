using Microsoft.AspNetCore.SignalR.Client;
using NaruciBa.WinUI.Dostavljac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaruciBa.WinUI.Narudzbe
{
    public partial class frmNarudzbePrikaz : Form
    {
        private APIService _narudzbeService = new APIService("Narudzba");
        private APIService _poslovnicaService = new APIService("Poslovnica");
        private APIService _trgovackiLanacService = new APIService("TrgovackiLanac");
        private APIService _narudzbaStatusService = new APIService("NarudzbaStatus");
        private APIService _dostavljacService = new APIService("Dostavljac");
        private APIService _korisnikService = new APIService("Korisnik");

        HubConnection connection;

        public frmNarudzbePrikaz()
        {
            InitializeComponent();
            connectToHubAsync();
        }

        async Task connectToHubAsync()
        {
            connection = new HubConnectionBuilder().WithUrl(Properties.Settings.Default.hub).WithAutomaticReconnect().Build();

            connection.On("NarudzbaUpdateovana", () => loadNarudzbeAsync());

            await connection.StartAsync();
        }

        private async void frmNarudzbePrikaz_LoadAsync(object sender, EventArgs e)
        {
            await loadNarudzbeAsync();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvNarudzbe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var dgv = (DataGridView)sender;
                var narudzbaId = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (dgv.Rows[e.RowIndex].Cells[4].Value.ToString() == "Dodaj")
                {
                    frmPrikazDostavljaca frm = new frmPrikazDostavljaca(narudzbaId);
                    frm.FormClosing += frmNarudzbePrikaz_LoadAsync;
                    frm.ShowDialog();
                }
               
            }
        }

       async Task loadNarudzbeAsync()
        {
            dgvNarudzbe.AutoGenerateColumns = false;
            List<Model.Narudzba> narudzbe = await _narudzbeService.Get<List<Model.Narudzba>>(new Model.SearchObjects.NarudzbaSearchObject()
            {
                excludeNarudzbaWithStatusId = 1
            });
            narudzbe = narudzbe.OrderBy(a => a.NarudzbaStatusID).ToList();
            List<DataGridNarudzbeRow> rows = new List<DataGridNarudzbeRow>();

            List<Model.Poslovnica> poslovnice = await _poslovnicaService.Get<List<Model.Poslovnica>>();
            List<Model.TrgovackiLanac> trgovackiLanaci = await _trgovackiLanacService.Get<List<Model.TrgovackiLanac>>();
            List<Model.NarudzbaStatus> statusi = await _narudzbaStatusService.Get<List<Model.NarudzbaStatus>>();

            foreach (var narudzba in narudzbe)
            {
                Model.Poslovnica poslovnica = poslovnice.Where(a => a.PoslovnicaID == narudzba.PoslovnicaID).FirstOrDefault();
                Model.TrgovackiLanac trgovackiLanac = trgovackiLanaci.Where(a => a.TrgovackiLanacID == poslovnica.TrgovackiLanacID).FirstOrDefault();
                Model.NarudzbaStatus status = statusi.Where(a => a.NarudzbaStatusID == narudzba.NarudzbaStatusID).FirstOrDefault();

                rows.Add(new DataGridNarudzbeRow()
                {
                    narudzbaId = narudzba.NarudzbaID,
                    adresa = poslovnica.Adresa,
                    poslovnica = trgovackiLanac.Naziv,
                    statusNarudzbe = status.Naziv,
                    dostavljac = narudzba.DostavljacID == null ? "Dodaj" : await getDostavljac(narudzba.DostavljacID)
                });
            }
            dgvNarudzbe.DataSource = rows;
            foreach(DataGridViewRow row in dgvNarudzbe.Rows)
            {
                if(row.Cells[3].Value.ToString() == "Aktivna")
                {
                    dgvNarudzbe.Rows[row.Index].DefaultCellStyle = new DataGridViewCellStyle() { 
                        BackColor = AppTheme.PrimaryColor,
                        ForeColor = Color.White
                    };
                }
            }
        }
        async Task<string> getDostavljac(int? dostavljacID)
        {
            Model.Dostavljac _dostvljac = await _dostavljacService.GetById<Model.Dostavljac>(dostavljacID);
            Model.Korisnik _dostavljacKorisnik = await _korisnikService.GetById<Model.Korisnik>(_dostvljac.KorisnikID);

            return _dostavljacKorisnik.Ime + " " + _dostavljacKorisnik.Prezime;
        }
    }

    class DataGridNarudzbeRow
    {
        public int narudzbaId { get; set; }
        public string poslovnica { get; set; }
        public string adresa { get; set; }
        public string statusNarudzbe { get; set; }
        public string dostavljac { get; set; }
    }
}
