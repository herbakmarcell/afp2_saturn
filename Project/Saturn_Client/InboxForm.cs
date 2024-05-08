using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Saturn_Client
{
    public partial class InboxForm : Form
    {
        private RestClient client;

        public InboxForm()
        {
            InitializeComponent();
            InitializeMessageDataGridView();
            HideSend(false);
            client = new RestClient("https://localhost:7204/api/Message/");
            RefreshReceivedData();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Az Üzenetek oldalon, láthatod a beérkezett és elküldött üzeneteidet. Küldhetsz üzenetet másoknak és kezelheted a már meglévőket.");
        }

        private void HideSend(bool enabled)
        {
            label1.Visible = enabled;
            label2.Visible = enabled;
            label3.Visible = enabled;
            textBox1.Visible = enabled;
            textBox2.Visible = enabled;
            richTextBox1.Visible = enabled;
            button1.Visible = enabled;
        }

        private void InitializeMessageDataGridView()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("sender", "Feladó");
            dataGridView1.Columns.Add("subject", "Tárgy");
            dataGridView1.Columns.Add("content", "Üzenet");
            dataGridView1.Columns.Add("receivers", "Címzettek");
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].FillWeight = 1;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Művelet";
            buttonColumn.Name = "Törlés";
            buttonColumn.Text = "Törlés";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);
        }

        public void DeleteMessage(int messageId)
        {

            var request = new RestRequest("/delete", Method.Post);
            request.AddHeader("Authorization", $"Bearer {TokenContainer.Token}");

            try
            {
                request.AddBody(new
                {
                    SaturnCode = TokenContainer.GetSaturnCode,
                    MessageId = messageId
                });

                var response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Message deleted successfully.");
                    RefreshSentData();
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var temp = JsonSerializer.Deserialize<Response<string>>(response.Content);
                    MessageBox.Show("Error: " + temp.message);
                }
                else
                {
                    MessageBox.Show($"Unexpected response: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred!\nDetails: " + ex.Message);
            }
        }

        public void RefreshSentData()
        {
            var request = new RestRequest("/sent", Method.Get);

            try
            {
                request.AddHeader("Authorization", $"Bearer {TokenContainer.Token}");

                var response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseContent = response.Content;

                    var responseData = JsonSerializer.Deserialize<Response<List<SentMessageResponse>>>(responseContent);

                    if (responseData != null && responseData.resource != null)
                    {
                        dataGridView1.Rows.Clear();

                        foreach (var message in responseData.resource)
                        {
                            string receiversString = message.receivers != null ? string.Join(", ", message.receivers) : "";

                            dataGridView1.Rows.Add(message.id, message.sender, message.subject, message.content, receiversString);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No messages received.");
                    }
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var responseContent = response.Content;
                    var temp = JsonSerializer.Deserialize<Response<string>>(responseContent);
                    MessageBox.Show("Error: " + temp.message);
                }
                else
                {
                    MessageBox.Show($"Unexpected response: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred!\nDetails: " + ex.Message);
            }
        }

        public void RefreshReceivedData()
        {
            var request = new RestRequest("/received", Method.Get);

            try
            {
                request.AddHeader("Authorization", $"Bearer {TokenContainer.Token}");

                var response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseContent = response.Content;

                    var responseData = JsonSerializer.Deserialize<Response<List<ReceivedMessageResponse>>>(responseContent);

                    if (responseData != null && responseData.resource != null)
                    {
                        dataGridView1.Rows.Clear();

                        foreach (var message in responseData.resource)
                        {
                            dataGridView1.Rows.Add(message.id, message.sender, message.subject, message.content);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No messages received.");
                    }
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var responseContent = response.Content;
                    var temp = JsonSerializer.Deserialize<Response<string>>(responseContent);
                    MessageBox.Show("Error: " + temp.message);
                }
                else
                {
                    MessageBox.Show($"Unexpected response: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred!\nDetails: " + ex.Message);
            }
        }

        public void ResetText()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
        }
        public void SendMessage()
        {
            string pattern = "^[a-zA-Z0-9,]*$";
            var request = new RestRequest("/send", Method.Post);
            if (!Regex.IsMatch(textBox1.Text, pattern))
            {
                MessageBox.Show("Helytelen formátum");
                return;
            }
            string[] receivers = textBox1.Text.Split(',');

            try
            {
                request.AddHeader("Authorization", $"Bearer {TokenContainer.Token}");
                request.AddHeader("saturnCode", TokenContainer.GetSaturnCode);

                request.AddJsonBody(new
                {
                    Sender = TokenContainer.GetSaturnCode,
                    Subject = textBox2.Text,
                    Content = richTextBox1.Text,
                    Receivers = receivers.ToList(),
                });

                var response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseContent = response.Content;
                    Response<SendMessageResponse> responseData = JsonSerializer.Deserialize<Response<SendMessageResponse>>(responseContent);

                    textBox1.Text = string.Join(",", responseData.resource.receivers);
                    textBox2.Text = responseData.resource.subject;
                    richTextBox1.Text = responseData.resource.content;
                    ResetText();
                    MessageBox.Show("Üzenet sikeresen elküldve!");
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var responseContent = response.Content;
                    Response<string> temp = JsonSerializer.Deserialize<Response<string>>(responseContent);
                    MessageBox.Show("Baly: " + temp.message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Váratlan hiba! \nBővebben: " + ex.Message);
            }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label4.Visible = false;
            HideSend(true);
            linkLabel2.Visible = true;
            dataGridView1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Törlés"].Index && e.RowIndex >= 0)
            {
                int messageId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                DeleteMessage(messageId);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HideSend(false);
            RefreshReceivedData();
            dataGridView1.Show();
            dataGridView1.Columns[4].Visible = false;
            linkLabel2.Visible = false;
            label4.Visible = true;
            label4.Text = "Bejövő üzenetek";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshSentData();
            HideSend(false);
            dataGridView1.Show();
            dataGridView1.Columns[4].Visible = true;
            linkLabel2.Visible = true;
            label4.Visible = true;
            label4.Text = "Elküldött üzenetek";
        }
    }
}
