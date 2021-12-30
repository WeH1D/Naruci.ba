using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaruciBa.WinUI.utils
{
    class MyRenderer : ToolStripProfessionalRenderer
    {
        private Color _selectedColor;
        private Color _selectedTextColor;
        public MyRenderer(Color selectedColor, Color selectedTextColor)
        {
            _selectedColor = selectedColor;
            _selectedTextColor = selectedTextColor;
        }
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.BackColor == Color.White)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                Color c = e.Item.Selected ? _selectedColor : Color.Transparent;

                e.Item.ForeColor = e.Item.Selected ? _selectedTextColor : Color.FromArgb(64, 64, 64);

                using (SolidBrush brush = new SolidBrush(c))
                {
                    e.Graphics.FillRectangle(brush, rc);
                }
            }
            else
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                Color c = _selectedColor;

                e.Item.ForeColor = _selectedTextColor;

                using (SolidBrush brush = new SolidBrush(c))
                {
                    e.Graphics.FillRectangle(brush, rc);
                }
            }
        }
    }
}
