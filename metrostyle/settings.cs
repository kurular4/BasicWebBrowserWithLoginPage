using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace metrostyle
{
    public partial class settings : MetroFramework.Forms.MetroForm
    {
        b nb;
        public settings(b b)
        {
            InitializeComponent();
            this.Text = "Settings";
            nb = b;
            metroCheckBox1.Checked = true;
        }

        private void settings_Load(object sender, EventArgs e)
        {
            metroTrackBar1.Maximum = 100;
            metroTrackBar1.Minimum = 20;
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            nb.Opacity = (double)metroTrackBar1.Value / 100;
            
        }

        public MetroFramework.Controls.MetroLabel getML()
        {
            return metroLabel1;
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked == true)
                nb.getDT().Show();
            else
                nb.getDT().Hide();
        }
    }
}
