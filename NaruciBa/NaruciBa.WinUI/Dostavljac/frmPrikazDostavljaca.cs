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

namespace NaruciBa.WinUI.Dostavljac
{
    public partial class frmPrikazDostavljaca : Form
    {
        private APIService _dostavljacService = new APIService("Dostavljac");
        private APIService _narudzbaService = new APIService("Narudzba");
        private APIService _korisnikService = new APIService("Korisnik");
        private APIService _dostavljacStatusService = new APIService("DostavljacStatus");

        List<Dostavljac> _dostavljaci = new List<Dostavljac>();

        int _narudzbaId;

        HubConnection connection;

        public frmPrikazDostavljaca(string narudzbaId)
        {
            InitializeComponent();
            btnDodijeli.BackColor = AppTheme.PrimaryColor;
            _narudzbaId = int.Parse(narudzbaId);
            loadDostavljaciAsync();
            connectToHubAsync();
        }

        async Task connectToHubAsync()
        {
            connection = new HubConnectionBuilder().WithUrl("http://localhost:5000/NaruciBaHub").WithAutomaticReconnect().Build();

            await connection.StartAsync();
        }

        async Task loadDostavljaciAsync()
        {
            List<Model.Dostavljac> dostavljaci = await _dostavljacService.Get<List<Model.Dostavljac>>(new Model.SearchObjects.DostavljacSearchObject(){ 
                dostavljacStatusId = 1
            });
            List<Model.DostavljacStatus> statusi = await _dostavljacStatusService.Get<List<Model.DostavljacStatus>>();

            foreach (Model.Dostavljac dostavljac in dostavljaci)
            {
                Model.Korisnik korisnik = await _korisnikService.GetById<Model.Korisnik>(dostavljac.KorisnikID);
                _dostavljaci.Add(new Dostavljac
                {
                    DostavljacId = dostavljac.DostavljacID,
                    Ime = korisnik.Ime + " " + korisnik.Prezime,
                    status = statusi.Where(a => a.DostavljacStatusID == dostavljac.DostavljacStatus).First().Naziv,
                    statusId = dostavljac.DostavljacStatus,
                });
            }

            cbDostavljaci.DataSource = _dostavljaci;
            cbDostavljaci.DisplayMember = "Ime";
            cbDostavljaci.ValueMember = "DostavljacId";

            lblIme.Text = _dostavljaci.First().Ime;
            lblStatus.Text = _dostavljaci.First().status;
        }

        private async void btnDodaj_ClickAsync(object sender, EventArgs e)
        {
            int dostavljacID = int.Parse(cbDostavljaci.SelectedValue.ToString());
            Model.Requests.NarudzbaUpsertRequest request = new Model.Requests.NarudzbaUpsertRequest
            {
                DostavljacID = dostavljacID,
                NarudzbaStatusID = 3
            };
            await _narudzbaService.Update<Model.Narudzba>(_narudzbaId, request);

            Model.Requests.DostavljacUpsertRequest dostavljacRequest = new Model.Requests.DostavljacUpsertRequest
            {
                DostavljacStatus = 2
            };

            await _dostavljacService.Update<Model.Dostavljac>(dostavljacID, dostavljacRequest);

            try
            {
                await connection.InvokeAsync("NarudzbaUpdateovana");
            }
            catch (Exception ex)
            {
                var E = ex;
            }

            await connection.StopAsync();

            this.Close();
        }

        private void cbDostavljaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dostavljac = _dostavljaci.Where(a => a.DostavljacId.ToString() == cbDostavljaci.SelectedValue.ToString());
            if (dostavljac != null && dostavljac.Any())
            {
                lblIme.Text = dostavljac.First().Ime;
                lblStatus.Text = dostavljac.First().status;
                btnDodijeli.Enabled = dostavljac.First().statusId == 1;
            }
        }


        private class Dostavljac
        {
            public int DostavljacId { get; set; }
            public String Ime { get; set; }
            public String status { get; set; }
            public int? statusId { get; set; }
        }

        private void frmPrikazDostavljaca_Load(object sender, EventArgs e)
        {

        }
    }
}
