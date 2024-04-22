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
        }


        private async void loadUserData()
        {
            var request = new RestRequest("/user", Method.Get);
            try
            {
                request.AddHeader("saturnCode", TokenContainer.GetSaturnCode);
                var response = await client.ExecuteAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseContent = response.Content;
                    var responseData = JsonSerializer.Deserialize<Response<UserDataResponse>>(response.Content);
                    saturnCodeLabel.Text = responseData.resource.saturnCode;
                    familyNameLabel.Text = responseData.resource.lastName;
                    givenNameLabel.Text = responseData.resource.firstName;
                    emailLabel.Text = responseData.resource.email;
                    phoneLabel.Text = responseData.resource.phoneNumber;
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
            loadUserData();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Itt megtekintheted a felhasználói fiókod adatait. A SaturnKódodat és a nevedet.");
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
