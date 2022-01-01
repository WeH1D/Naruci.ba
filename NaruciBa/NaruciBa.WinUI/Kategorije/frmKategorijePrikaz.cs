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
        public frmKategorijePrikaz()
        {
            InitializeComponent();
        }

        private async void frmKategorijePrikaz_Load(object sender, EventArgs e)
        {
            List<Model.Podkategorija> podkategorije = await _podkategorijeService.Get<List<Model.Podkategorija>>();
            List<Model.Kategorija> kategorije = await _kategorijaService.Get<List<Model.Kategorija>>();

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
                dgv.Name = $"{kategorija}";
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

                dgv.Height = 50;

                dgv.ColumnHeaderMouseClick += handleHeaderClick;

                flpKategorije.Controls.Add(dgv);
            }
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

        private void flpKategorije_Layout(object sender, LayoutEventArgs e)
        {
            flpKategorije.SuspendLayout();
            dgvIdk.Width = pnlFlow.Width - 50;
            flpKategorije.ResumeLayout();

        }
    }
}
