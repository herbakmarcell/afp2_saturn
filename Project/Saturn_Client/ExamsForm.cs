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
            hideUpdateExamFunctions();
        }
        private void hideExamFunctions()
        {
            backButton.Visible = false;
            myExamsButton.Visible = false;
            applyButton.Visible = false;
            addExamButton.Visible = false;
            deleteExamButton.Visible = false;
            updateExamButton.Visible = false;
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
                deleteExamButton.Visible = true;
                updateExamButton.Visible = true;
            }

        }
        private void hideUpdateExamFunctions()
        {
            subjectLabel.Visible = false;
            subjectTB.Visible = false;
            subjectcodeLabel.Visible = false;
            subjectcodeTB.Visible = false;
            courseLabel.Visible = false;
            courseTB.Visible = false;
            typeLabel.Visible = false;
            typeTB.Visible = false;
            startLabel.Visible = false;
            startTB.Visible = false;
            limitLabel.Visible = false;
            limitTB.Visible = false;
            classroomLabel.Visible = false;
            classroomTB.Visible = false;
            teacherLabel.Visible = false;
            teacherTB.Visible = false;
            addExamToDBButton.Visible = false;
            updateExamInDBButton.Visible = false;
        }
        private void showUpdateExamFunctions()
        {
            subjectLabel.Visible = true;
            subjectTB.Visible = true;
            subjectcodeLabel.Visible = true;
            subjectcodeTB.Visible = true;
            courseLabel.Visible = true;
            courseTB.Visible = true;
            typeLabel.Visible = true;
            typeTB.Visible = true;
            startLabel.Visible = true;
            startTB.Visible = true;
            limitLabel.Visible = true;
            limitTB.Visible = true;
            classroomLabel.Visible = true;
            classroomTB.Visible = true;
            teacherLabel.Visible = true;
            teacherTB.Visible = true;
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            if (TokenContainer.IsAdmin)
            {
                MessageBox.Show("Itt tudod kezelni a vizsgákat. Hozzáadni, módosítani, törölni tudsz vizsgákat.");
            }
            else
            {
                MessageBox.Show("Itt megtudhatsz mindent a közelgő vizsgáiddal kapcsolatban. A táblázatban kiválasztott vizsgáidatt, fel tudod venni. Megtekintheted a már felvett vizsgáidat.");
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

        private void backButton_Click(object sender, EventArgs e)
        {
            backButton.Visible = false;
            hideExamFunctions();
            showRoleFunctions();
            examsDataGridView.Visible = true;
            hideUpdateExamFunctions();
        }

        private void myExamsButton_Click(object sender, EventArgs e)
        {
            examsDataGridView.Visible = true;
            backButton.Visible = true;
            applyButton.Visible = false;
            hideUpdateExamFunctions();
        }

        private void addExamButton_Click(object sender, EventArgs e)
        {
            hideExamFunctions();
            backButton.Visible = true;
            examsDataGridView.Visible = false;
            showUpdateExamFunctions();
            addExamToDBButton.Visible = true;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            // add exam function backend
        }

        private void updateExamButton_Click(object sender, EventArgs e)
        {
            hideExamFunctions();
            backButton.Visible = true;
            examsDataGridView.Visible = false;
            showUpdateExamFunctions();
            updateExamInDBButton.Visible = true;
        }

        private void deleteExamButton_Click(object sender, EventArgs e)
        {
            // delete exam function backend
        }

        private void updateExamInDBButton_Click_1(object sender, EventArgs e)
        {
            backButton.Visible = false;
            hideExamFunctions();
            showRoleFunctions();
            examsDataGridView.Visible = true;
            hideUpdateExamFunctions();
        }

        private void addExamToDBButton_Click(object sender, EventArgs e)
        {
            backButton.Visible = false;
            hideExamFunctions();
            showRoleFunctions();
            examsDataGridView.Visible = true;
            hideUpdateExamFunctions();
        }
    }
}
