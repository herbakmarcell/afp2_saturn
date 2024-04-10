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
    public partial class SubjectsForm : Form
    {
        public SubjectsForm()
        {
            InitializeComponent();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Itt megtekintheted a tárgyakat és azok adatait. Láthatod azt is, hogy az adott tárgyat már felvetted-e, vagy már teljesítetted.");
        }
    }
}
