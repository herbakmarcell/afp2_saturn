using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saturn_Client
{
    public partial class FinancesForm : Form
    {
        public FinancesForm()
        {
            InitializeComponent();
            InitFinancesGridView();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ezen az oldalon, megtalálod az információkat az egyetemi pénzügyeiddel kapcsolatban. A fontos befizetések összegét és határidejét mindig tartsd figyelemmel");
        }

        private void InitFinancesGridView()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("name", "Név");
            dataGridView1.Columns.Add("amount", "Összeg");
            dataGridView1.Columns.Add("type", "Típus");
            dataGridView1.Columns.Add("status", "Státusz");
            dataGridView1.Columns.Add("deadline", "Határidő");
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].FillWeight = 1;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Művelet";
            buttonColumn.Name = "Befizetés";
            buttonColumn.Text = "Befizetés";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);
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
