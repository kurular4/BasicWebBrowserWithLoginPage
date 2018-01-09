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
using System.Net.Mail;
using System.Net;
using System.Diagnostics;

namespace metrostyle
{
    public partial class b : MetroFramework.Forms.MetroForm
    {
        public b()
        {
            InitializeComponent();
            this.Text = "Browser";
            webBrowser1.ScriptErrorsSuppressed = true;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(metroButton10, "Settings");
        }

        settings s;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(metroTextBox1.Text))
                webBrowser1.Navigate(metroTextBox1.Text);
            else
                MessageBox.Show("Please type a proper URL");
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
        public MetroFramework.Controls.MetroButton getMB3()
        {
            return metroButton3;
        }
        public MetroFramework.Controls.MetroButton getMB4()
        {
            return metroButton4;
        }
        public MetroFramework.Controls.MetroButton getMB5()
        {
            return metroButton5;
        }
        public MetroFramework.Controls.MetroButton getMB6()
        {
            return metroButton6;
        }
        public MetroFramework.Controls.MetroLabel getML()
        {
            return metroLabel1;
        }
        public MetroFramework.Controls.MetroButton getMB1()
        {
            return metroButton1;
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.facebook.com");
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.twitter.com");
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            s = new settings(this);
            s.Show();
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        public MetroFramework.Controls.MetroDateTime getDT()
        {
            return metroDateTime1;
        }
    }
}
