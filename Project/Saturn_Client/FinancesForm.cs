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
    public partial class FinancesForm : Form
    {
        public FinancesForm()
        {
            InitializeComponent();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ezen az oldalon, megtalálod az információkat az egyetemi pénzügyeiddel kapcsolatban. A fontos befizetések összegét és határidejét mindig tartsd figyelemmel");
        }
    }
}
