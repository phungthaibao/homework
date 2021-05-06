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
using System.Data;
using WindowsFormsApp1.Class; // class Functions.cs


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
            LoadDataGirdView();
        }

        private void LoadDataGirdView()
        {
            string sql;
            sql = "select * MaChatLieu, TenChatLieu from tblChatLieu";
            tblCL = Class.Functions.GetDataToTable(sql);
            dgvMaterial.DataSource = tblCL;
            dgvMaterial.Columns[0].HeaderText = "Mã chất liệu";
            dgvMaterial.Columns[1].HeaderText = "Tên chất liệu";
            dgvMaterial.Columns[0].Width = 100;
            dgvMaterial.Columns[1].Width = 300;
            dgvMaterial.AllowUserToAddRows = false;
            dgvMaterial.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvChatLieu_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDMaterial.Focus();
                return;
            }
            if (tblCL.Rows.Count == 0)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtIDMaterial.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDMaterial.Focus();
                return;
            }
            if (txtNameMaterial.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNameMaterial.Focus();
                return;
            }
            sql = "Select MaChatLieu From tblChatLieu where MaChatLieu=N'" + txtIDMaterial.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDMaterial.Focus();
                return;
            }

            sql = "INSERT INTO tblChatLieu VALUES(N'" +
                txtIDMaterial.Text + "',N'" + txtNameMaterial.Text + "')";
            Functions.RunSQL(sql);
            LoadDataGirdView();
            ResetValue();
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            btnModify.Enabled = true;
            btnSkip.Enabled = false;
            btnSave.Enabled = false;
            txtIDMaterial.Enabled = false;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtIDMaterial.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtNameMaterial.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblChatLieu SET TenChatLieu=N'" +
                txtNameMaterial.Text.ToString() +
                "' WHERE MaChatLieu=N'" + txtIDMaterial.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGirdView();
            ResetValue();

            btnSkip.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtIDMaterial.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblChatLieu WHERE MaChatLieu=N'" + txtIDMaterial.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGirdView();
                ResetValue();
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnSkip.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnModify.Enabled = true;
            btnSave.Enabled = false;
            txtIDMaterial.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}