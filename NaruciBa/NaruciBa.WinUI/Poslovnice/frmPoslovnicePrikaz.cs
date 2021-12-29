using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NaruciBa.Model.SearchObjects;

namespace NaruciBa.WinUI.Poslovnica
{
    public partial class FrmPoslovnicePrikaz : Form
    {
        APIService _poslovnicaService = new APIService("Poslovnica");
        public FrmPoslovnicePrikaz()
        {
            InitializeComponent();
        }

        private async void FrmPoslovnicePrikaz_Load(object sender, EventArgs e)
        {
            dgvPoslovnice.DataSource = await _poslovnicaService.Get<List<Model.Poslovnica>>();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
           
        }
    }
}
