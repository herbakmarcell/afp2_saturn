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
    public partial class FinancesForm : Form
    {
        public FinancesForm()
        {
            InitializeComponent();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ezen az oldalon, megtalálod az információkat az egyetemi pénzügyeiddel kapcsolatban. A fontos befizetések összegét és határidejét mindig tartsd figyelemmel");
        }




        private void InitializeMessageDataGridView()
        {
            
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
