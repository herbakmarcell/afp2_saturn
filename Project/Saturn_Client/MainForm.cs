using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace Saturn_Client
{

    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private Form activeForm;
        private Form loginForm;

        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            InitFormStyle();

        }

        private void InitFormStyle()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            this.userDataPanel.Controls.Add(childForm);
            this.userDataPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void userDataButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserDataForm(), sender);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
        }

        private void exitButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }
    }
}
