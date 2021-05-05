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
using WindowsFormsApp1;


namespace WindowsFormsApp1
{
    public partial class frmStaff : Form
    {
        DataTable tblNV;
        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            txtIDStaff.Enabled = false;
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaNhanVien,TenNhanVien,GioiTinh,DiaChi,DienThoai,NgaySinh FROM tblNhanVien";
            tblNV = Functions.GetDataToTable(sql);
            dgvStaff.DataSource = tblNV;
            dgvStaff.Columns[0].HeaderText = "Mã nhân viên";
            dgvStaff.Columns[1].HeaderText = "Tên nhân viên";
            dgvStaff.Columns[2].HeaderText = "Giới tính";
            dgvStaff.Columns[3].HeaderText = "Địa chỉ";
            dgvStaff.Columns[4].HeaderText = "Điện thoại";
            dgvStaff.Columns[5].HeaderText = "Ngày sinh";
            dgvStaff.Columns[0].Width = 100;
            dgvStaff.Columns[1].Width = 150;
            dgvStaff.Columns[2].Width = 100;
            dgvStaff.Columns[3].Width = 150;
            dgvStaff.Columns[4].Width = 100;
            dgvStaff.Columns[5].Width = 100;
            dgvStaff.AllowUserToAddRows = false;
            dgvStaff.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvStaff_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDStaff.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtIDStaff.Text = dgvStaff.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txtNameStaff.Text = dgvStaff.CurrentRow.Cells["TenNhanVien"].Value.ToString();

            if (dgvStaff.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam") chkSex.Checked = true;
            else chkSex.Checked = false;

            txtAddressStaff.Text = dgvStaff.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtbPhoneStaff.Text = dgvStaff.CurrentRow.Cells["DienThoai"].Value.ToString();
            mskDateOfBirthStaff.Text = dgvStaff.CurrentRow.Cells["NgaySinh"].Value.ToString();
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
            btnSkip.Enabled = true;
            
            ResetValues();
            txtIDStaff.Enabled = true;
            txtIDStaff.Focus();
        }

        private void ResetValues()
        {
            txtIDStaff.Text = "";
            txtNameStaff.Text = "";
            chkSex.Checked = false;
            txtAddressStaff.Text = "";
            mskDateOfBirthStaff.Text = "";
            mtbPhoneStaff.Text = "";
        }
    }
}
