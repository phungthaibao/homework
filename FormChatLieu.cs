using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // SQL server
using WindowsFormsApp1; // class Functions.cs


namespace WindowsFormsApp1
{
    public partial class frmMaterial : Form
    {
        DataTable ; // name table Chat lieu can add them 
        public frmMaterial()
        {
            InitializeComponent();
        }

        private void frmMaterial_Load(object sender, EventArgs e)
        {
            txtIDMaterial.Enabled = false;
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng tblChatLieu
        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        
        private void labelName_Click(object sender, EventArgs e)
        {

        }
   
        private void button4_Click(object sender, EventArgs e)
        {

        }

       
    }
}
