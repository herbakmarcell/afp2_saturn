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
            if (!TokenContainer.IsAdmin)
            {
                regButton.Visible = false;
                regButton.Enabled = false;
            }
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
            this.visibleDataPanel.Controls.Add(childForm);
            this.visibleDataPanel.Tag = childForm;
            this.visibleDataPanel.BackColor = Color.Transparent;
            childForm.BringToFront();
            childForm.Show();

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


        private void userDataButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserDataForm(), sender);
            userDataButton.BackgroundImage = Properties.Resources.clickuser;
            inboxButton.BackgroundImage = Properties.Resources.inboxButton;
            financesButton.BackgroundImage = Properties.Resources.financesButton;
            subjectsButton.BackgroundImage= Properties.Resources.subjectsButton;
            studiesButton.BackgroundImage=Properties.Resources.studiesButton;
            examsButton.BackgroundImage = Properties.Resources.examsButton;
            visibleDataPanel.Visible = true;
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

        private void inboxButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InboxForm(), sender);
            inboxButton.BackgroundImage = Properties.Resources.clickinbox;
            userDataButton.BackgroundImage = Properties.Resources.userDataButton;
            financesButton.BackgroundImage = Properties.Resources.financesButton;
            subjectsButton.BackgroundImage = Properties.Resources.subjectsButton;
            studiesButton.BackgroundImage = Properties.Resources.studiesButton;
            examsButton.BackgroundImage = Properties.Resources.examsButton;
            visibleDataPanel.Visible = true;
        }

        private void studiesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudiesForm(), sender);
            studiesButton.BackgroundImage = Properties.Resources.clickstudies;
            userDataButton.BackgroundImage = Properties.Resources.userDataButton;
            inboxButton.BackgroundImage = Properties.Resources.inboxButton;
            financesButton.BackgroundImage = Properties.Resources.financesButton;
            subjectsButton.BackgroundImage = Properties.Resources.subjectsButton;
            examsButton.BackgroundImage = Properties.Resources.examsButton;
            visibleDataPanel.Visible = true;
        }

        private void subjectsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubjectsForm(), sender);
            subjectsButton.BackgroundImage = Properties.Resources.clicksubjects;
            userDataButton.BackgroundImage = Properties.Resources.userDataButton;
            inboxButton.BackgroundImage = Properties.Resources.inboxButton;
            financesButton.BackgroundImage = Properties.Resources.financesButton;
            studiesButton.BackgroundImage = Properties.Resources.studiesButton;
            examsButton.BackgroundImage = Properties.Resources.examsButton;
            visibleDataPanel.Visible = true;
        }

        private void examsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ExamsForm(), sender);
            examsButton.BackgroundImage = Properties.Resources.clickexams;
            userDataButton.BackgroundImage = Properties.Resources.userDataButton;
            inboxButton.BackgroundImage = Properties.Resources.inboxButton;
            financesButton.BackgroundImage = Properties.Resources.financesButton;
            subjectsButton.BackgroundImage = Properties.Resources.subjectsButton;
            studiesButton.BackgroundImage = Properties.Resources.studiesButton;
            visibleDataPanel.Visible = true;
        }

        private void financesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FinancesForm(), sender);
            financesButton.BackgroundImage = Properties.Resources.clickfinances;
            userDataButton.BackgroundImage = Properties.Resources.userDataButton;
            inboxButton.BackgroundImage = Properties.Resources.inboxButton;
            subjectsButton.BackgroundImage = Properties.Resources.subjectsButton;
            studiesButton.BackgroundImage = Properties.Resources.studiesButton;
            examsButton.BackgroundImage = Properties.Resources.examsButton;
            visibleDataPanel.Visible = true;
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A fõoldalon menüpontok között tudsz navigálni. Lásd: Saját, Tanulmányok, Tárgyak, Vizsgázás, Pénzügyek, Postaláda");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity = 1.00;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegFrom(), sender);
            visibleDataPanel.Visible = true;

        }
    }
}
