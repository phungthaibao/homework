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
            txtNumbers.Enabled = true;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
