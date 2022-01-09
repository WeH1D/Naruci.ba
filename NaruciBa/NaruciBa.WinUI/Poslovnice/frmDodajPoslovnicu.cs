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
        public frmDodajPoslovnicu()
        {
            InitializeComponent();
        }

        private void frmDodajPoslovnicu_Load(object sender, EventArgs e)
        {
            btnDodajPoslovnicu.BackColor = AppTheme.PrimaryColor;
        }

        private void btnDodajPoslovnicu_Click(object sender, EventArgs e)
        {

        }
    }
}
