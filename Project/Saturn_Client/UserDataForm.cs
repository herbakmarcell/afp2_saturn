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
            passwordLabel.Visible = false;
            passwordTB.Visible = false;
            rolesAdminCB.Visible = false;
            rolesTeacherCB.Visible = false;
            rolesStudentCB.Visible = false;
            rolesLabel.Visible = false;

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
                    this.saturnCodeLabel.Text += TokenContainer.GetSaturnCode;
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

            firstnameTB.Visible = true;
            lastnameTB.Visible = true;
            emailTB.Visible = true;
            phonenumberTB.Visible = true;
            passwordLabel.Visible = true;
            passwordTB.Visible = true;
            saveChangesButton.Visible = true;

            if (TokenContainer.IsAdmin)
            {
                saturncodeTB.Visible = true;
                rolesAdminCB.Visible = true;
                rolesTeacherCB.Visible = true;
                rolesStudentCB.Visible = true;
                rolesLabel.Visible = true;
                this.saturnCodeLabel.Text = "Saturn Kód:";
                rolesAdminCB.Checked = true;
            }


            this.familyNameLabel.Text = "Vezetéknév:";
            this.givenNameLabel.Text = "Utónév:";
            this.emailLabel.Text = "E-mail:";
            this.phoneLabel.Text = "Telefonszám:";

            saturncodeTB.Text = "";
            firstnameTB.Text = "";
            lastnameTB.Text = "";
            passwordTB.Text = "";
            emailTB.Text = "";
            phonenumberTB.Text = "";
        }
        private async void UpdateAsync()
        {
            string saturncode = saturncodeTB.Text;
            string firstname = firstnameTB.Text;
            string lastname = lastnameTB.Text;
            string email = emailTB.Text;
            string phonenumber = phonenumberTB.Text;
            string password = passwordTB.Text;
            List<string> roles = new List<string>();
            if (rolesAdminCB.Checked)
            {
                roles.Add("Admin");
            }
            if (rolesTeacherCB.Checked)
            {
                roles.Add("Teacher");
            }
            if (rolesStudentCB.Checked)
            {
                roles.Add("Student");
            }

            var request = new RestRequest("/change", Method.Post);
            request.AddHeader("Authorization", $"Bearer {TokenContainer.Token}");

            request.AddBody(new
            {
                SaturnCode = (saturncode == "" ? null : saturncode),
                NewPassword = (password == "" ? null : password),
                NewLastName = (lastname == "" ? null : lastname),
                NewFirstName = (firstname == "" ? null : firstname),
                NemEmail = (email == "" ? null : email),
                NewPhoneNumber = (phonenumber == "" ? null : phonenumber),
                NewRoles = roles
            }); ;
            try
            {
                var response = await client.ExecuteAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string s = "";

                    var responseContent = response.Content;
                    Response<ChangeResponse> temp = JsonSerializer.Deserialize<Response<ChangeResponse>>(responseContent);
                    if (temp.resource.saturnCode != null)
                    {
                        s += "\n A módosított felhasználó változtatott adatai:" + temp.resource.saturnCode;
                    }
                    if (temp.resource.newPassword != null)
                    {
                        s += "\n A módosított felhasználó új jelszava:" + temp.resource.newPassword;
                    }
                    if (temp.resource.newLastName != null)
                    {
                        s += "\n A módosított felhasználó új vezetékneve:" + temp.resource.newLastName;
                    }
                    if (temp.resource.newFirstName != null)
                    {
                        s += "\n A módosított felhasználó új utóneve:" + temp.resource.newFirstName;
                    }
                    if (temp.resource.newEmail != null)
                    {
                        s += "\n A módosított felhasználó új e-mail címe:" + temp.resource.newEmail;
                    }
                    if (temp.resource.newPhone != null)
                    {
                        s += "\n A módosított felhasználó új telefonszáma:" + temp.resource.newPhone;
                    }
                    if (temp.resource.newRoles != null)
                    {
                        s += "\n A módosított felhasználó új jogköre(i):";
                        foreach (var role in temp.resource.newRoles)
                        {
                            s += role;
                        }
                    }
                    MessageBox.Show(s);
                    loadUserData();
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var responseContent = response.Content;
                    ErrorResponse errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent);
                    MessageBox.Show("B Hibás adatbevitel! \nHibaüzenet: " + errorResponse.errors[0]);
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    var responseContent = response.Content;
                    var errorResponse = JsonSerializer.Deserialize<Response<string>>(responseContent);
                    MessageBox.Show("Hibás adatbevitel! \nHibaüzenet: " + errorResponse.message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Váratlan hiba! \nBővebben: " + ex.Message);
            }


        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            UpdateAsync();
            hideUpdateFunctions();
        }

        private void rolesAdminCB_CheckedChanged(object sender, EventArgs e)
        {
            if (rolesAdminCB.Checked)
            {
                rolesStudentCB.Checked = false;
                rolesTeacherCB.Checked = false;
            }
        }

        private void rolesTeacherCB_CheckedChanged(object sender, EventArgs e)
        {
            if (rolesTeacherCB.Checked)
            {
                rolesAdminCB.Checked = false;
            }
        }

        private void rolesStudentCB_CheckedChanged(object sender, EventArgs e)
        {
            if (rolesStudentCB.Checked)
            {
                rolesAdminCB.Checked = false;
            }
        }
    }
}
