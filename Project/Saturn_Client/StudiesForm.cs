using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saturn_Client
{
    public partial class StudiesForm : Form
    {
        public StudiesForm()
        {
            InitializeComponent();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Itt láthatod a tanulmányaidra vonatkozó adatokat, a Jogviszonyoddal és az aktuális félévvel kapcsolatban.");
        }
    }
}
