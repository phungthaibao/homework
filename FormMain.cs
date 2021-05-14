using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }
        

        private void mnuExit_Click(object sender, EventArgs e)
        {
            //Đóng kết nối database
            Class.Functions.Disconnect();
            Application.Exit();
        }

        private void mnuMaterial_Click(object sender, EventArgs e)
        {
            frmMaterial frmM = new frmMaterial();
            frmM.ShowDialog();  // .Show(); dang thong thuong
        }

        private void mnuStaff_Click(object sender, EventArgs e)
        {
            frmStaff frmS = new frmStaff();
            frmS.ShowDialog(); // .Show(); dang thong thuong
        }

        private void mnuCustommer_Click(object sender, EventArgs e)
        {
            frmCustomer frmC = new frmCustomer();
            frmC.ShowDialog(); // .Show(); dang thong thuong
        }

        private void mnuGoods_Click(object sender, EventArgs e)
        {
            frmGoods frmG = new frmGoods();
            frmG.MdiParent = this;
            frmG.Show(); // .Show(); dang thong thuong
        }


    }
}
