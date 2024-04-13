using System.Drawing.Drawing2D;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestSharp;


namespace Saturn_Client
{
    public partial class LoginForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private RestClient client;


        public LoginForm()
        {
            InitializeComponent();
            InitFormStyle();
            ButtonStyle();
            passwordField.PasswordChar = '*';
            client = new RestClient("https://localhost:7204/api/Auth");

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

        private async void LoginAsync()
        {
            string loginSaturnCode = usernameField.Text;
            string loginPassword = passwordField.Text;

            var request = new RestRequest("/login", Method.Post);

            request.AddBody(new
            {
                saturnCode = loginSaturnCode,
                password = loginPassword
            });

            try
            {
                var response = await client.ExecuteAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm(this);
                    mainForm.Show();
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var responseContent = response.Content;
                    Response<string> temp = JsonSerializer.Deserialize<Response<string>>(responseContent);
                    MessageBox.Show("Hibás felhasználónév vagy jelszó! \nHibaüzenet: " + temp.message);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Váratlan hiba! \nBõvebben: " + ex.Message);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginAsync();

        }

        private void regformButton_Click(object sender, EventArgs e)
        {
            RegFrom regFrom = new RegFrom();
            regFrom.Show();
            regformButton.Enabled = false;
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A SaturnKódod és Jelszavad megadása után, a Bejelentkezés gombra kattintva tudsz belépni az alkalmazásba.");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            regformButton.Visible = false;
            regformButton.Enabled = false;
        }
    }
}
