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
using System.Data;
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class frmCustomer : Form
    {
        DataTable tblKH;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            txtIDCustomer.Enabled = false;
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from tblKhachHang";
            tblKH = Class.Functions.GetDataToTable(sql); //Lấy dữ liệu từ bảng
            dgvCustomer.DataSource = tblKH; //Hiển thị vào dataGridView
            dgvCustomer.Columns[0].HeaderText = "Mã khách";
            dgvCustomer.Columns[1].HeaderText = "Tên khách";
            dgvCustomer.Columns[2].HeaderText = "Địa chỉ";
            dgvCustomer.Columns[3].HeaderText = "Điện thoại";
            dgvCustomer.Columns[0].Width = 100;
            dgvCustomer.Columns[1].Width = 150;
            dgvCustomer.Columns[2].Width = 150;
            dgvCustomer.Columns[3].Width = 150;
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvCustomer_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDCustomer.Focus();
                return;
            }
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtIDCustomer.Text = dgvCustomer.CurrentRow.Cells["MaKhach"].Value.ToString();
            txtNameCustomer.Text = dgvCustomer.CurrentRow.Cells["TenKhach"].Value.ToString();
            txtAddressCustomer.Text = dgvCustomer.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtbPhoneCustomer.Text = dgvCustomer.CurrentRow.Cells["DienThoai"].Value.ToString();
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
            btnSkip.Enabled = true;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            btnSkip.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            ResetValues();
            txtIDCustomer.Enabled = true;
            txtIDCustomer.Focus();
        }
        private void ResetValues()
        {
            txtIDCustomer.Text = "";
            txtNameCustomer.Text = "";
            txtAddressCustomer.Text = "";
            mtbPhoneCustomer.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtIDCustomer.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDCustomer.Focus();
                return;
            }
            if (txtNameCustomer.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNameCustomer.Focus();
                return;
            }
            if (txtAddressCustomer.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddressCustomer.Focus();
                return;
            }
            if (mtbPhoneCustomer.Text == "    -   -   ")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbPhoneCustomer.Focus();
                return;
            }
            //Kiểm tra đã tồn tại mã khách chưa
            sql = "SELECT MaKhach FROM tblKhachHang WHERE MaKhach=N'" + txtIDCustomer.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDCustomer.Focus();
                return;
            }
            //Chèn thêm
            sql = "INSERT INTO tblKhach VALUES (N'" + txtIDCustomer.Text.Trim() +
                "',N'" + txtNameCustomer.Text.Trim() + "',N'" + txtAddressCustomer.Text.Trim() + "','" + mtbPhoneCustomer.Text + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();

            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            btnModify.Enabled = true;
            btnSkip.Enabled = false;
            btnSave.Enabled = false;
            txtIDCustomer.Enabled = false;
        }
        


        
        private void btnModify_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtIDCustomer.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtNameCustomer.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNameCustomer.Focus();
                return;
            }
            if (txtAddressCustomer.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddressCustomer.Focus();
                return;
            }
            if (mtbPhoneCustomer.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbPhoneCustomer.Focus();
                return;
            }
            sql = "UPDATE tblKhachHang SET TenKhach=N'" + txtNameCustomer.Text.Trim().ToString() + "',DiaChi=N'" +
                txtAddressCustomer.Text.Trim().ToString() + "',DienThoai='" + mtbPhoneCustomer.Text.ToString() +
                "' WHERE MaKhach=N'" + txtIDCustomer.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnSkip.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtIDCustomer.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblKhach WHERE MaKhach=N'" + txtIDCustomer.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnSkip.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnModify.Enabled = true;
            btnSave.Enabled = false;
            txtIDCustomer.Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
    }
}
