using System.Drawing.Drawing2D;

namespace Saturn_Client
{
    public partial class LoginForm : Form
    {

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
            logoBox.Image = Properties.Resources.saturnbeta;
            exitButton.Image = Properties.Resources.exiticon;
            userPic.Image= Properties.Resources.user;
            passPic.Image= Properties.Resources.padlock;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
