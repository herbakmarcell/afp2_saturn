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
    public partial class MainForm : Form
    {
        private Form activeForm;
        private Form loginForm;

        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
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
    }
}
