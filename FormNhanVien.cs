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
using WindowsFormsApp1.Class;


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
            tblNV = Class.Functions.GetDataToTable(sql);
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
            dtpDateOfBirthStaff.Text = dgvStaff.CurrentRow.Cells["NgaySinh"].Value.ToString();
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
        }

        

        private void ResetValues()
        {
            txtIDStaff.Text = "";
            txtNameStaff.Text = "";
            chkSex.Checked = false;
            txtAddressStaff.Text = "";
            dtpDateOfBirthStaff.Text = "";
            mtbPhoneStaff.Text = "";
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtIDStaff.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDStaff.Focus();
                return;
            }
            if (txtNameStaff.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameStaff.Focus();
                return;
            }
            if (txtAddressStaff.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddressStaff.Focus();
                return;
            }
            if (mtbPhoneStaff.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbPhoneStaff.Focus();
                return;
            }
            if (dtpDateOfBirthStaff.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDateOfBirthStaff.Focus();
                return;
            }
            if (!Functions.IsDate(dtpDateOfBirthStaff.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                dtpDateOfBirthStaff.Focus();
                return;
            }
            if (chkSex.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT MaNhanVien FROM tblNhanVien WHERE MaNhanVien=N'" + txtIDStaff.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDStaff.Focus();
                txtIDStaff.Text = "";
                return;
            }
            sql = "INSERT INTO tblNhanVien(MaNhanVien,TenNhanVien,GioiTinh, DiaChi,DienThoai, NgaySinh) VALUES (N'" + txtIDStaff.Text.Trim() + "',N'" + txtNameStaff.Text.Trim() + "',N'" + gt + "',N'" + txtAddressStaff.Text.Trim() + "','" + mtbPhoneStaff.Text + "','" + Functions.ConvertDateTime(dtpDateOfBirthStaff.Text) + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();

            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnModify.Enabled = true;
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
            txtIDStaff.Enabled = false;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtIDStaff.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtNameStaff.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameStaff.Focus();
                return;
            }
            if (txtAddressStaff.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddressStaff.Focus();
                return;
            }
            if (mtbPhoneStaff.Text == "    -   -   ")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbPhoneStaff.Focus();
                return;
            }
            if (dtpDateOfBirthStaff.Text == "  /  / ")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDateOfBirthStaff.Focus();
                return;
            }
            if (!Functions.IsDate(dtpDateOfBirthStaff.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDateOfBirthStaff.Text = "";
                dtpDateOfBirthStaff.Focus();
                return;
            }
            if (chkSex.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE tblNhanVien SET  TenNhanVien=N'" + txtNameStaff.Text.Trim().ToString() +
                    "',DiaChi=N'" + txtAddressStaff.Text.Trim().ToString() +
                    "',DienThoai='" + mtbPhoneStaff.Text.ToString() + "',GioiTinh=N'" + gt +
                    "',NgaySinh='" + Functions.ConvertDateTime(dtpDateOfBirthStaff.Text) +
                    "' WHERE MaNhanVien=N'" + txtIDStaff.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnSkip.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtIDStaff.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhanVien WHERE MaNhanVien=N'" + txtIDStaff.Text + "'";
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
            txtIDStaff.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}