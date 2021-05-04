
namespace WindowsFormsApp1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustommer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBills = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaleInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindBills = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNotify = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuCategory,
            this.mnuBills,
            this.mnuFind,
            this.mnuNotify,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(968, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(54, 29);
            this.mnuFile.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(141, 34);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuCategory
            // 
            this.mnuCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMaterial,
            this.mnuStaff,
            this.mnuCustommer,
            this.mnuGoods});
            this.mnuCategory.Name = "mnuCategory";
            this.mnuCategory.Size = new System.Drawing.Size(100, 29);
            this.mnuCategory.Text = "Category";
            // 
            // mnuMaterial
            // 
            this.mnuMaterial.Name = "mnuMaterial";
            this.mnuMaterial.Size = new System.Drawing.Size(270, 34);
            this.mnuMaterial.Text = "Material";
            this.mnuMaterial.Click += new System.EventHandler(this.mnuMaterial_Click);
            // 
            // mnuStaff
            // 
            this.mnuStaff.Name = "mnuStaff";
            this.mnuStaff.Size = new System.Drawing.Size(270, 34);
            this.mnuStaff.Text = "Staff";
            this.mnuStaff.Click += new System.EventHandler(this.mnuStaff_Click);
            // 
            // mnuCustommer
            // 
            this.mnuCustommer.Name = "mnuCustommer";
            this.mnuCustommer.Size = new System.Drawing.Size(270, 34);
            this.mnuCustommer.Text = "Customer";
            this.mnuCustommer.Click += new System.EventHandler(this.mnuCustommer_Click);
            // 
            // mnuGoods
            // 
            this.mnuGoods.Name = "mnuGoods";
            this.mnuGoods.Size = new System.Drawing.Size(270, 34);
            this.mnuGoods.Text = "Goods";
            this.mnuGoods.Click += new System.EventHandler(this.mnuGoods_Click);
            // 
            // mnuBills
            // 
            this.mnuBills.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSaleInvoice});
            this.mnuBills.Name = "mnuBills";
            this.mnuBills.Size = new System.Drawing.Size(58, 29);
            this.mnuBills.Text = "Bills";
            // 
            // mnuSaleInvoice
            // 
            this.mnuSaleInvoice.Name = "mnuSaleInvoice";
            this.mnuSaleInvoice.Size = new System.Drawing.Size(206, 34);
            this.mnuSaleInvoice.Text = "Sale invoice";
            // 
            // mnuFind
            // 
            this.mnuFind.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFindBills,
            this.mnuFindGoods,
            this.mnuFindCustomers});
            this.mnuFind.Name = "mnuFind";
            this.mnuFind.Size = new System.Drawing.Size(62, 29);
            this.mnuFind.Text = "Find";
            // 
            // mnuFindBills
            // 
            this.mnuFindBills.Name = "mnuFindBills";
            this.mnuFindBills.Size = new System.Drawing.Size(199, 34);
            this.mnuFindBills.Text = "Bills";
            // 
            // mnuFindGoods
            // 
            this.mnuFindGoods.Name = "mnuFindGoods";
            this.mnuFindGoods.Size = new System.Drawing.Size(199, 34);
            this.mnuFindGoods.Text = "Goods";
            // 
            // mnuFindCustomers
            // 
            this.mnuFindCustomers.Name = "mnuFindCustomers";
            this.mnuFindCustomers.Size = new System.Drawing.Size(199, 34);
            this.mnuFindCustomers.Text = "Customers";
            // 
            // mnuNotify
            // 
            this.mnuNotify.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInventory,
            this.mnuRevenue});
            this.mnuNotify.Name = "mnuNotify";
            this.mnuNotify.Size = new System.Drawing.Size(77, 29);
            this.mnuNotify.Text = "Notify";
            // 
            // mnuInventory
            // 
            this.mnuInventory.Name = "mnuInventory";
            this.mnuInventory.Size = new System.Drawing.Size(189, 34);
            this.mnuInventory.Text = "Inventory";
            // 
            // mnuRevenue
            // 
            this.mnuRevenue.Name = "mnuRevenue";
            this.mnuRevenue.Size = new System.Drawing.Size(189, 34);
            this.mnuRevenue.Text = "Revenue";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(65, 29);
            this.mnuHelp.Text = "Help";
            // 
            // Help
            // 
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(151, 34);
            this.Help.Text = "Help";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 661);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Chương trình quản lý bán hàng";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCategory;
        private System.Windows.Forms.ToolStripMenuItem mnuStaff;
        private System.Windows.Forms.ToolStripMenuItem mnuMaterial;
        private System.Windows.Forms.ToolStripMenuItem mnuCustommer;
        private System.Windows.Forms.ToolStripMenuItem mnuGoods;
        private System.Windows.Forms.ToolStripMenuItem mnuBills;
        private System.Windows.Forms.ToolStripMenuItem mnuSaleInvoice;
        private System.Windows.Forms.ToolStripMenuItem mnuFind;
        private System.Windows.Forms.ToolStripMenuItem mnuFindBills;
        private System.Windows.Forms.ToolStripMenuItem mnuFindGoods;
        private System.Windows.Forms.ToolStripMenuItem mnuFindCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuNotify;
        private System.Windows.Forms.ToolStripMenuItem mnuInventory;
        private System.Windows.Forms.ToolStripMenuItem mnuRevenue;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem Help;
    }
}

