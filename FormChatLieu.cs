using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient; // SQL server
using WindowsFormsApp1; // class Functions.cs


namespace WindowsFormsApp1
{
    public partial class frmMaterial : Form
    {
        DataTable tblCL; 
        public frmMaterial()
        {
            InitializeComponent();
        }

        private void frmMaterial_Load(object sender, EventArgs e)
        {
            txtIDMaterial.Enabled = false;
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
            LoadDataGirdView();//Hiển thị bảng tblChatLieu
        }

        private void LoadDataGirdView()
        {
            string sql;
            sql = "select * MaChatLieu, TenChatLieu from tblChatLieu";
            tblCL = Functions.GetDataToTable(sql);
            dgvMaterial.DataSource = tblCL;
            dgvMaterial.Columns[0].HeaderText = "Mã chất liệu";
            dgvMaterial.Columns[1].HeaderText = "Mã chất liệu";
            dgvMaterial.Columns[0].Width = 100;
            dgvMaterial.Columns[1].Width = 300;
            dgvMaterial.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvMaterial.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvChatLieu_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDMaterial.Focus();
                return;
            }
            if (tblCL.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtIDMaterial.Text = dgvMaterial.CurrentRow.Cells["MaChatLieu"].Value.ToString();
            txtNameMaterial.Text = dgvMaterial.CurrentRow.Cells["TenChatLieu"].Value.ToString();
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
            btnSkip.Enabled = true;
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnSkip.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtIDMaterial.Enabled = true; //cho phép nhập mới
            txtIDMaterial.Focus();
        }
        private void ResetValue()
        {
            txtIDMaterial.Text = "";
            txtNameMaterial.Text = "";
        }
    }
}
