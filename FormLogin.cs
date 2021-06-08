using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=quanlybanhang;Integrated Security=True");
            string sqlSelect = "select * from tblLogin where username=" + "'" + txtUserName.Text + "'" + " and pass= " + "'" + txtPassword.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
               
                frmMain main = new frmMain();
                this.Hide();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Something wrong");
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtUserName.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
