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
    public partial class InboxForm : Form
    {
        public InboxForm()
        {
            InitializeComponent();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Az Üzenetek oldalon, láthatod a beérkezett és elküldött üzeneteidet. Küldhetsz üzenetet másoknak és kezelheted a már meglévőket.");
        }
    }
}
