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
    public partial class ExamsForm : Form
    {
        private RestClient client;
        public ExamsForm()
        {
            InitializeComponent();
            client = new RestClient("https://localhost:7204/api/Auth");
            hideExamFunctions();
            showRoleFunctions();
        }
        private void hideExamFunctions()
        {
            backButton.Visible = false;
            myExamsButton.Visible = false;
            applyButton.Visible = false;
            addExamButton.Visible = false;
        }
        private void showRoleFunctions()
        {
            myExamsButton.Visible = true;
            applyButton.Visible = true;
            if (TokenContainer.IsAdmin)
            {
                myExamsButton.Visible = false;
                applyButton.Visible = false;
                addExamButton.Visible = true;
            }           
           
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Itt megtudhatsz mindent a közelgő vizsgáiddal kapcsolatban. A vizsgák összes fontossabb adatát megtalálod.");
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

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void myExamsButton_Click(object sender, EventArgs e)
        {

        }

        private void addExamButton_Click(object sender, EventArgs e)
        {

        }

        private void applyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
