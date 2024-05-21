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
    public partial class SubjectsForm : Form
    {
        private RestClient client;
        public SubjectsForm()
        {
            InitializeComponent();
            client = new RestClient("https://localhost:7204/api/Auth");
            manageFuctions();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Itt megtekintheted a tárgyakat és azok adatait. Láthatod azt is, hogy az adott tárgyat már felvetted-e, vagy már teljesítetted.");
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
        private void manageFuctions()
        {
            backButton.Visible = false;
            if (!TokenContainer.IsAdmin)
            {
                updateSubjectButton.Visible = false;
                addSubjectButton.Visible = false;
                deleteSubjectButton.Visible = false;

            }

        }
        private void manageAdminFunctions()
        {
            subjectDataGridView.Visible = false;
        }

        private void updateSubjectButton_Click(object sender, EventArgs e)
        {
            manageAdminFunctions();
            backButton.Visible = true;
        }

        private void deleteSubjectButton_Click(object sender, EventArgs e)
        {
            backButton.Visible = true;
            manageAdminFunctions();
            //backendösszekötés
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            backButton.Visible = true;
            manageAdminFunctions();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            backButton.Visible = true;
            manageAdminFunctions();
            //backendösszekötés
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            subjectDataGridView.Visible = true;
        }
    }
}
