using Microsoft.VisualBasic.ApplicationServices;
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
using System.Net;
using System.Text.Json;

namespace Saturn_Client
{
    public partial class RegFrom : Form
    {
        private bool mouseDown;
        private RestClient client;
        private Point lastLocation;

        public RegFrom()
        {
            InitializeComponent();
            InitFormStyle();
            
            client = new RestClient("https://localhost:7204/api/Auth");
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
            RegAsync();
            

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
        public async void RegAsync()
        {
            await Console.Out.WriteLineAsync("meghivva fazis");
            string firstname = FirstName_tbox.Text;
            string lastname = LastName_tbox.Text;
            string email = Email_tbox.Text;
            string phonenumber = PhoneNumber_tbox.Text;
            string password = Password_tbox.Text;

            var request = new RestRequest("/register", Method.Post);

            request.AddBody(new
            {
                Firstname = firstname,
                LastName = lastname,
                Email = email,
                Password = password,
                PhoneNumber = phonenumber
            }); 

            try
            {
                await Console.Out.WriteLineAsync("try fazis");
                var response = await client.ExecuteAsync(request);
                LoginForm lf = new LoginForm();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseContent = response.Content;
                    Response<string> temp = JsonSerializer.Deserialize<Response<string>>(responseContent);
                    MessageBox.Show(temp.message);
                    this.Hide();
                    lf.Show();
                    await Console.Out.WriteLineAsync("siker fazis");



                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var responseContent = response.Content;
                    Response<string> temp = JsonSerializer.Deserialize<Response<string>>(responseContent);
                    MessageBox.Show("Hibás adatbevitel! \nHibaüzenet: " + temp.message);
                    FirstName_tbox.Text = "";
                    LastName_tbox.Text = "";
                    Email_tbox.Text = "";
                    PhoneNumber_tbox.Text = "";
                    Password_tbox.Text = "";
                    await Console.Out.WriteLineAsync("szar fazis");
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Váratlan hiba! \nBővebben: " + ex.Message);
            }
        }

        private void FirstName_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNumber_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_tbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
