using System.Drawing.Drawing2D;

namespace Saturn_Client
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
            logoBox.Image = Properties.Resources.saturnbeta;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.Image = Properties.Resources.exit;
        }
    }
}
