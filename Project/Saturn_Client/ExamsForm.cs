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
    public partial class ExamsForm : Form
    {
        public ExamsForm()
        {
            InitializeComponent();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Itt megtudhatsz mindent a közelgő vizsgáiddal kapcsolatban. A vizsgák összes fontossabb adatát megtalálod.");
        }
    }
}
