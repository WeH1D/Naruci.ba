using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaruciBa.WinUI.utils
{
    class PrimaryColorBackgroundRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
            Color c = e.Item.Selected ? AppTheme.PrimaryColor : Color.Transparent;
            using (SolidBrush brush = new SolidBrush(c))
            {
                e.Graphics.FillRectangle(brush, rc);
                e.Item.ForeColor = e.Item.Selected ? Color.White : Color.FromArgb(64, 64, 64);
            }
            
        }
    }
}
