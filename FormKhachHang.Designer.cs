﻿
namespace WindowsFormsApp1
{
    partial class frmCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDCustomer = new System.Windows.Forms.TextBox();
            this.txtAddressCustomer = new System.Windows.Forms.TextBox();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbPhoneCustomer = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dgvListCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Customers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDCustomer
            // 
            this.txtIDCustomer.Location = new System.Drawing.Point(85, 76);
            this.txtIDCustomer.Name = "txtIDCustomer";
            this.txtIDCustomer.Size = new System.Drawing.Size(163, 26);
            this.txtIDCustomer.TabIndex = 1;
            // 
            // txtAddressCustomer
            // 
            this.txtAddressCustomer.Location = new System.Drawing.Point(518, 76);
            this.txtAddressCustomer.Name = "txtAddressCustomer";
            this.txtAddressCustomer.Size = new System.Drawing.Size(270, 26);
            this.txtAddressCustomer.TabIndex = 2;
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(85, 142);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(163, 26);
            this.txtNameCustomer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID:";
            // 
            // mtbPhoneCustomer
            // 
            this.mtbPhoneCustomer.Location = new System.Drawing.Point(518, 142);
            this.mtbPhoneCustomer.Name = "mtbPhoneCustomer";
            this.mtbPhoneCustomer.Size = new System.Drawing.Size(270, 26);
            this.mtbPhoneCustomer.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 56);
            this.button2.TabIndex = 10;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 56);
            this.button3.TabIndex = 11;
            this.button3.Text = "Modify";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(438, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 56);
            this.button4.TabIndex = 12;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(567, 396);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 56);
            this.button5.TabIndex = 13;
            this.button5.Text = "Skip";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(692, 396);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 56);
            this.button6.TabIndex = 14;
            this.button6.Text = "Close";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dgvListCustomer
            // 
            this.dgvListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCustomer.Location = new System.Drawing.Point(18, 191);
            this.dgvListCustomer.Name = "dgvListCustomer";
            this.dgvListCustomer.RowHeadersWidth = 62;
            this.dgvListCustomer.RowTemplate.Height = 28;
            this.dgvListCustomer.Size = new System.Drawing.Size(770, 186);
            this.dgvListCustomer.TabIndex = 15;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.dgvListCustomer);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtbPhoneCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameCustomer);
            this.Controls.Add(this.txtAddressCustomer);
            this.Controls.Add(this.txtIDCustomer);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomer";
            this.Text = "Danh mục khách hàng";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDCustomer;
        private System.Windows.Forms.TextBox txtAddressCustomer;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbPhoneCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dgvListCustomer;
    }
}