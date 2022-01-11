using NaruciBa.WinUI.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaruciBa.WinUI.Kategorije
{
    public partial class frmKategorijePrikaz : Form
    {

        private APIService _podkategorijeService = new APIService("Podkategorija");
        private APIService _kategorijaService = new APIService("Kategorija");

        List<Model.Podkategorija> podkategorije;
        List<Model.Kategorija> kategorije;

        public frmKategorijePrikaz()
        {
            InitializeComponent();
        }

        private async void frmKategorijePrikaz_Load(object sender, EventArgs e)
        {
            pnlAddKategorija.Height = this.ClientRectangle.Height / 2 - 30;
            pnlEditKategorija.Height = this.ClientRectangle.Height / 2 - 30;
            pnlFlow.Width = this.ClientRectangle.Width / 3 * 2 - 30;
            pnlLeft.Height = this.ClientRectangle.Height - 40;
            pnlLeft.Width = this.ClientRectangle.Width / 3 - 30;

            btnDodajKategoriju.BackColor = AppTheme.PrimaryColor;
            btnDodajPodkateogrija.BackColor = AppTheme.PrimaryColor;
            btnIzbrisiKategoriju.BackColor = AppTheme.PrimaryColor;
            btnIzbrisiPodkategoriju.BackColor = AppTheme.PrimaryColor;

            podkategorije = await _podkategorijeService.Get<List<Model.Podkategorija>>();
            kategorije = await _kategorijaService.Get<List<Model.Kategorija>>();

            cbKategorija.DataSource = kategorije;
            cbKategorija.DisplayMember = "Naziv";
            cbKategorija.ValueMember = "KategorijaId";

            loadKategorije();
        }

        private void handleHeaderClick(object sender, EventArgs e)
        {
            var dgv = (DataGridView)sender;
            if (dgv.Height != 50)
                dgv.Height = 50;
            else
            {
                var height = dgv.Rows.GetRowsHeight(DataGridViewElementStates.None);
                dgv.ClientSize = new Size(dgv.ClientSize.Width, height + 30);
            }

        }

        private void handleCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var dgv = (DataGridView)sender;

            txtOdabranaKategorija.Text = dgv.Columns[e.ColumnIndex].HeaderText;
            txtOdabranaPodkategorija.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void flpKategorije_Layout(object sender, LayoutEventArgs e)
        {
            flpKategorije.SuspendLayout();
            dgvIdk.Width = pnlFlow.Width - 50;
            flpKategorije.ResumeLayout();

        }

        private void frmKategorijePrikaz_SizeChanged(object sender, EventArgs e)
        {
            pnlAddKategorija.Height = this.ClientRectangle.Height / 2 - 30;
            pnlEditKategorija.Height = this.ClientRectangle.Height / 2 - 30;
            pnlFlow.Width = this.ClientRectangle.Width / 3 * 2 - 30;
            pnlLeft.Height = this.ClientRectangle.Height - 40;
            pnlLeft.Width = this.ClientRectangle.Width / 3 - 30;
        }

        private async void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            if (txtDodajKategoriju.Text != "")
            {
                await _kategorijaService.Insert<Model.Kategorija>(new Model.Requests.KategorijaUpsertRequest()
                {
                    Naziv = txtDodajKategoriju.Text
                });

                kategorije = await _kategorijaService.Get<List<Model.Kategorija>>();
                txtDodajKategoriju.Text = "";

                cbKategorija.DataSource = null;
                cbKategorija.DataSource = kategorije;
                cbKategorija.DisplayMember = "Naziv";
                cbKategorija.ValueMember = "KategorijaId";

                clearKategorije();
                loadKategorije();
            }
        }

        private async void btnDodajPodkateogrija_Click(object sender, EventArgs e)
        {
            if (txtPodkategorijaNaziv.Text != "")
            {
                await _podkategorijeService.Insert<Model.Podkategorija>(new Model.Requests.PodkategorijaUpsertRequest()
                {
                    Naziv = txtPodkategorijaNaziv.Text,
                    KategorijaID = int.Parse(cbKategorija.SelectedValue.ToString())
                });

                podkategorije = await _podkategorijeService.Get<List<Model.Podkategorija>>();
                txtPodkategorijaNaziv.Text = "";

                clearKategorije();
                loadKategorije();
            }
        }

        void loadKategorije()
        {
            foreach (var kategorija in kategorije)
            {
                DataGridView dgv = new DataGridView();

                dgv.Columns.Add("kategorija", kategorija.Naziv);
                List<Model.Podkategorija> listaPodkategorija = podkategorije.Where(a => a.KategorijaID == kategorija.KategorijaID).ToList();

                foreach (var podkategorija in listaPodkategorija)
                {
                    dgv.Rows.Add(podkategorija.Naziv);
                }

                dgv.Dock = DockStyle.Top;
                dgv.Name = $"{kategorija.Naziv}";
                dgv.BorderStyle = BorderStyle.None;
                dgv.BackgroundColor = Color.White;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv.RowHeadersVisible = false;
                dgv.ColumnHeadersHeight = 50;
                dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgv.ScrollBars = ScrollBars.None;

                dgv.AllowUserToResizeRows = false;
                dgv.AllowUserToResizeColumns = false;

                dgv.RowTemplate.Height = 40;
                dgv.RowTemplate.MinimumHeight = 40;
                dgv.RowTemplate.Resizable = DataGridViewTriState.False;

                dgv.EnableHeadersVisualStyles = false;
                DataGridViewCellStyle headerCellStyle = new DataGridViewCellStyle();
                headerCellStyle.Font = new Font("Monteserrat", (float)9.7, FontStyle.Bold);
                headerCellStyle.ForeColor = Color.White;
                headerCellStyle.BackColor = AppTheme.PrimaryColor;
                headerCellStyle.Padding = new Padding(10, 0, 0, 0);
                dgv.ColumnHeadersDefaultCellStyle = headerCellStyle;

                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                cellStyle.Font = new Font("Monteserrat", (float)9.7, FontStyle.Regular);
                cellStyle.ForeColor = Color.FromArgb(64, 64, 64);
                cellStyle.Padding = new Padding(20, 0, 0, 0);
                cellStyle.BackColor = Color.White;
                cellStyle.SelectionBackColor = cellStyle.BackColor;
                cellStyle.SelectionForeColor = cellStyle.ForeColor;
                dgv.DefaultCellStyle = cellStyle;

                var height = dgv.Rows.GetRowsHeight(DataGridViewElementStates.None);
                dgv.ClientSize = new Size(dgv.ClientSize.Width, height + 30);

                dgv.ColumnHeaderMouseClick += handleHeaderClick;
                dgv.CellClick += handleCellClick;

                flpKategorije.Controls.Add(dgv);
            }
        }

        void clearKategorije()
        {
            List<Control> controlsToRemove = new List<Control>();

            foreach (Control control in flpKategorije.Controls)
            {
                if (control.Name != "dgvIdk")
                    controlsToRemove.Add(control);
            }

            foreach(Control control in controlsToRemove)
            {
                flpKategorije.Controls.Remove(control);
            }

        }
    }
}
