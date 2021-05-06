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
    }
}
