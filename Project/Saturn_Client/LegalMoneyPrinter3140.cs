using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saturn_Client
{
    public partial class LegalMoneyPrinter3140 : Form
    {
        public LegalMoneyPrinter3140()
        {
            InitializeComponent();
        }


        public int Radius { get; set; } = 30;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, Radius * 2, Radius * 2, 180, 90);
            path.AddArc(Width - Radius * 2, 0, Radius * 2, Radius * 2, 270, 90);
            path.AddArc(Width - Radius * 2, Height - Radius * 2, Radius * 2, Radius * 2, 0, 90);
            path.AddArc(0, Height - Radius * 2, Radius * 2, Radius * 2, 90, 90);
            path.CloseAllFigures();

            Region = new Region(path);

            using (Pen pen = new Pen(Color.Black, 3))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

    }
}
