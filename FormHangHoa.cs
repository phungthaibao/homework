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
using System.Data.SqlClient;
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class frmGoods : Form
    {
        DataTable tblHH; // table Hàng Hóa

        public frmGoods()
        {
            InitializeComponent();
        }
        private void ResetValues()
        {
            txtIDGoods.Text = "";
            txtNameGoods.Text = "";
            cboIDMaterial.Text = "";
            txtAmount.Text = "0";
            txtUnitPriceEnter.Text = "0";
            txtUntiSellingPrice.Text = "0";
            txtAmount.Enabled = true;
            txtUnitPriceEnter.Enabled = false;
            txtUntiSellingPrice.Enabled = false;
            txtPic.Text = "";
            picA.Image = null;
            txtNote.Text = "";
        }

        private void frmGoods_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * FROM tblChatLieu";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
            btnSkip.Enabled = true;
            ResetValues();
            txtIDGoods.Enabled = true;
            txtIDGoods.Focus();
            txtAmount.Enabled = true;
            txtUnitPriceEnter.Enabled = true;
            txtUntiSellingPrice.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtIDGoods.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblHang WHERE MaHang=N'" + txtIDGoods.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();

            }
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from tblHang";
            tblHH = Functions.GetDataToTable(sql);
            dgvGoods.DataSource = tblHH;
            dgvGoods.Columns[0].HeaderText = "Mã hàng";
            dgvGoods.Columns[1].HeaderText = "Tên hàng";
            dgvGoods.Columns[2].HeaderText = "Chất liệu";
            dgvGoods.Columns[3].HeaderText = "Số lượng";
            dgvGoods.Columns[4].HeaderText = "Đơn giá nhập";
            dgvGoods.Columns[5].HeaderText = "Đơn giá bán";
            dgvGoods.Columns[6].HeaderText = "Ảnh";
            dgvGoods.Columns[7].HeaderText = "Ghi chú";
            dgvGoods.Columns[0].Width = 80;
            dgvGoods.Columns[1].Width = 140;
            dgvGoods.Columns[2].Width = 80;
            dgvGoods.Columns[3].Width = 80;
            dgvGoods.Columns[4].Width = 100;
            dgvGoods.Columns[5].Width = 100;
            dgvGoods.Columns[6].Width = 200;
            dgvGoods.Columns[7].Width = 300;
            dgvGoods.AllowUserToAddRows = false;
            dgvGoods.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvGoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaChatLieu;
            string sql;
            if (btnAdd.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDGoods.Focus();
                return;
            }
            if (tblHH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtIDGoods.Text = dgvGoods.CurrentRow.Cells["MaHang"].Value.ToString();
            txtNameGoods.Text = dgvGoods.CurrentRow.Cells["TenHang"].Value.ToString();
            MaChatLieu = dgvGoods.CurrentRow.Cells["MaChatLieu"].Value.ToString();
            sql = "SELECT TenChatLieu FROM tblChatLieu WHERE MaChatLieu=N'" + MaChatLieu + "'";
            cboIDMaterial.Text = Functions.GetFieldValues(sql);
            txtAmount.Text = dgvGoods.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtUnitPriceEnter.Text = dgvGoods.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtUntiSellingPrice.Text = dgvGoods.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            sql = "SELECT Anh FROM tblHang WHERE MaHang=N'" + txtIDGoods.Text + "'";
            txtPic.Text = Functions.GetFieldValues(sql);
            picA.Image = Image.FromFile(txtPic.Text);
            sql = "SELECT Ghichu FROM tblHang WHERE MaHang = N'" + txtIDGoods.Text + "'";
            txtNote.Text = Functions.GetFieldValues(sql);
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
            btnSkip.Enabled = true;
        }



    }
}
