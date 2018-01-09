using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;

namespace metrostyle
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        
        public Form1()
        {
            InitializeComponent();
            metroComboBox1.Text = "Language";
            metroComboBox1.Items.Add("Turkish");
            metroComboBox1.Items.Add("English");
            metroComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        b f2 = new b();
        Register r = new Register();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bimstajyer1\Documents\loginapp.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from loginapptable where Username = '" + metroTextBox1.Text + "' and Password = '" + metroTextBox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {
                this.Hide();
                f2.Show();
            }
            else
                MetroMessageBox.Show(this,"Wrong username or password");
            
                
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            r.Show();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.Text.Equals("Turkish"))
            {
                metroButton1.Text = "Giris";
                metroButton2.Text = "Kayit";
                metroLabel1.Text = "Kullanici adi";
                metroLabel2.Text = "Sifre";
                r.getMB1().Text = "Kayit ol";
                r.getML1().Text = "Kullanici adi";
                r.getML2().Text = "Sifre";
                r.getML3().Text = "Kullanici adi ve sifrenizi seciniz";
                r.getML4().Text = "E-mail";
                f2.getMB3().Text = "Ana sayfa";
                f2.getMB4().Text = "Yenile";
                f2.getMB6().Text = "Durdur";
                f2.getML().Text = "Giris yaptiniz";
                f2.getMB5().Text = "Git";
            }
            if (metroComboBox1.Text.Equals("English"))
            {
                metroButton1.Text = "Log in";
                metroButton2.Text = "Sign in";
                metroLabel1.Text = "Username";
                metroLabel2.Text = "Password";
                r.getMB1().Text = "Sign in";
                r.getML1().Text = "Username";
                r.getML2().Text = "Sifre";
                r.getML3().Text = "Choose your username and password";
                r.getML4().Text = "E-mail";
                f2.getMB3().Text = "Home";
                f2.getMB4().Text = "Refresh";
                f2.getMB6().Text = "Stop";
                f2.getML().Text = "You logged in";
                f2.getMB5().Text = "Go";
            }
        }

        private void metroProgressSpinner1_Click(object sender, EventArgs e)
        {

        }
    }
}
