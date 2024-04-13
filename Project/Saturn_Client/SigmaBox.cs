using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturn_Client
{
    public class SigmaBox : TextBox
    {
        public SigmaBox()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var brush = new SolidBrush(Color.FromArgb(128, this.BackColor)))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }
    }
}
