using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saturn_Client
{
    public partial class UserDataForm : Form
    {
        private RestClient client;

        public UserDataForm()
        {
            InitializeComponent();
            client = new RestClient("https://localhost:7204/api/Auth");
            loadUserData();
            hideUpdateFunctions();
        }
        private void hideUpdateFunctions()
        {
            saturncodeTB.Visible = false;
            firstnameTB.Visible = false;
            lastnameTB.Visible = false;
            emailTB.Visible = false;
            phonenumberTB.Visible = false;
            saveChangesButton.Visible = false;
        }


        private async void loadUserData()
        {
            var request = new RestRequest("/user", Method.Get);
            try
            {
                request.AddHeader("Authorization", $"Bearer {TokenContainer.Token}");
                request.AddHeader("saturnCode", TokenContainer.GetSaturnCode);
                var response = await client.ExecuteAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseContent = response.Content;
                    Response<UserDataResponse> responseData = JsonSerializer.Deserialize<Response<UserDataResponse>>(response.Content);
                    this.saturnCodeLabel.Text += responseData.resource.saturnCode;
                    this.familyNameLabel.Text += responseData.resource.lastName;
                    this.givenNameLabel.Text += responseData.resource.firstName;
                    this.emailLabel.Text += responseData.resource.email;
                    this.phoneLabel.Text += responseData.resource.phoneNumber;
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var responseContent = response.Content;
                    Response<string> temp = JsonSerializer.Deserialize<Response<string>>(responseContent);
                    MessageBox.Show("Hibás felhasználónév vagy jelszó! \nHibaüzenet: " + temp.message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Váratlan hiba! \nBővebben: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Itt megtekintheted a felhasználói fiókod adatait, a SaturnKódodat és a nevedet. A Módosítás gommbal pedig megváltoztathatod a személyes adataidat.");
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

        private void updateUserDataButton_Click(object sender, EventArgs e)
        {
            saturncodeTB.Visible = true;
            firstnameTB.Visible = true;
            lastnameTB.Visible = true;
            emailTB.Visible = true;
            phonenumberTB.Visible = true;
            saveChangesButton.Visible = true;

            this.saturnCodeLabel.Text = "Saturn Kód:";
            this.familyNameLabel.Text = "Vezetéknév:";
            this.givenNameLabel.Text = "Utónév:";
            this.emailLabel.Text = "E-mail:";
            this.phoneLabel.Text = "Telefonszám:";
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            //backend
        }
    }
}
