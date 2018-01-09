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
using System.Data.SqlClient;
using MetroFramework;


namespace metrostyle
{
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(metroTextBox1.Text) || String.IsNullOrWhiteSpace(metroTextBox2.Text))
                MessageBox.Show("You cannot leave boxes empty");
            else
            {
                SqlConnection sqlConn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\bimstajyer1\Documents\loginapp.mdf; Integrated Security = True; Connect Timeout = 30");
                bool exists = false;
                using (SqlCommand cmd = new SqlCommand("select count(*) from loginapptable where Username = @UserName", sqlConn))
                {
                    cmd.Parameters.AddWithValue("Username", metroTextBox1.Text);
                    sqlConn.Open();
                    exists = (int)cmd.ExecuteScalar() > 0;
                }
                if (exists)
                    MetroMessageBox.Show(this,"This user name is already in use");
                else
                {
                    SqlCommand sqlComm = new SqlCommand();
                    sqlComm = sqlConn.CreateCommand();
                    sqlComm.CommandText = @"INSERT into loginapptable (Username, Password) VALUES (@Username, @Password)";
                    sqlComm.Parameters.Add("@Username", SqlDbType.NVarChar);
                    sqlComm.Parameters["@Username"].Value = metroTextBox1.Text;
                    sqlComm.Parameters.Add("@Password", SqlDbType.NVarChar);
                    sqlComm.Parameters["@Password"].Value = metroTextBox2.Text;
                    sqlComm.Parameters.Add("@Email", SqlDbType.NVarChar);
                    sqlComm.Parameters["@Email"].Value = metroTextBox3.Text;
                    sqlComm.ExecuteNonQuery();
                    sqlConn.Close();
                    MetroMessageBox.Show(this,"You have successfuly signed in the system.");
                    this.Hide();
                }
            }
        }

        public MetroFramework.Controls.MetroButton getMB1()
        {
            return metroButton1;
        }

        public MetroFramework.Controls.MetroLabel getML3()
        {
            return metroLabel3;
        }
        public MetroFramework.Controls.MetroLabel getML1()
        {
            return metroLabel1;
        }
        public MetroFramework.Controls.MetroLabel getML2()
        {
            return metroLabel2;
        }
        public MetroFramework.Controls.MetroLabel getML4()
        {
            return metroLabel4;
        }
    }
}
