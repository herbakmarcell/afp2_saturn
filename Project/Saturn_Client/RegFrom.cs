using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saturn_Client
{
    public partial class RegFrom : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public RegFrom()
        {
            InitializeComponent();
            InitFormStyle();
        }
        private void InitFormStyle()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            this.Hide();


        }

        private void RegFrom_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void RegFrom_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void RegFrom_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
