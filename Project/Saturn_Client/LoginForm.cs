using System.Drawing.Drawing2D;

namespace Saturn_Client
{
    public partial class LoginForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public LoginForm()
        {
            InitializeComponent();
            InitFormStyle();
            ButtonStyle();
            ImageStyle();
        }

        private void InitFormStyle()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ButtonStyle()
        {
            exitButton.FlatAppearance.BorderSize = 0;
        }

        private void ImageStyle()
        {
            this.BackgroundImage = Properties.Resources.space;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(this);
            mainForm.Show();
        }

        private void regformButton_Click(object sender, EventArgs e)
        {
            RegFrom regFrom = new RegFrom();
            regFrom.Show();
        }
    }
}
