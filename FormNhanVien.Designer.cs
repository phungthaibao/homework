
namespace WindowsFormsApp1
{
    partial class frmStaff
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDStaff = new System.Windows.Forms.TextBox();
            this.txtNameStaff = new System.Windows.Forms.TextBox();
            this.txtAddressStaff = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbPhoneStaff = new System.Windows.Forms.MaskedTextBox();
            this.mtbDateOfBirthStaff = new System.Windows.Forms.MaskedTextBox();
            this.chkSex = new System.Windows.Forms.CheckBox();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "PhoneNumber";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date Of Birth";
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Location = new System.Drawing.Point(108, 78);
            this.txtIDStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.Size = new System.Drawing.Size(278, 26);
            this.txtIDStaff.TabIndex = 6;
            // 
            // txtNameStaff
            // 
            this.txtNameStaff.Location = new System.Drawing.Point(108, 154);
            this.txtNameStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameStaff.Name = "txtNameStaff";
            this.txtNameStaff.Size = new System.Drawing.Size(278, 26);
            this.txtNameStaff.TabIndex = 7;
            // 
            // txtAddressStaff
            // 
            this.txtAddressStaff.Location = new System.Drawing.Point(628, 78);
            this.txtAddressStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddressStaff.Name = "txtAddressStaff";
            this.txtAddressStaff.Size = new System.Drawing.Size(346, 26);
            this.txtAddressStaff.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(352, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 55);
            this.label7.TabIndex = 9;
            this.label7.Text = "LIST STAFF";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mtbPhoneStaff
            // 
            this.mtbPhoneStaff.Location = new System.Drawing.Point(628, 154);
            this.mtbPhoneStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbPhoneStaff.Name = "mtbPhoneStaff";
            this.mtbPhoneStaff.Size = new System.Drawing.Size(346, 26);
            this.mtbPhoneStaff.TabIndex = 10;
            // 
            // mtbDateOfBirthStaff
            // 
            this.mtbDateOfBirthStaff.Location = new System.Drawing.Point(628, 232);
            this.mtbDateOfBirthStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbDateOfBirthStaff.Name = "mtbDateOfBirthStaff";
            this.mtbDateOfBirthStaff.Size = new System.Drawing.Size(346, 26);
            this.mtbDateOfBirthStaff.TabIndex = 11;
            // 
            // chkSex
            // 
            this.chkSex.AutoSize = true;
            this.chkSex.Location = new System.Drawing.Point(111, 235);
            this.chkSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSex.Name = "chkSex";
            this.chkSex.Size = new System.Drawing.Size(69, 24);
            this.chkSex.TabIndex = 12;
            this.chkSex.Text = "Male";
            this.chkSex.UseVisualStyleBackColor = true;
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(17, 294);
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.Size = new System.Drawing.Size(957, 175);
            this.dgvStaff.TabIndex = 13;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(17, 496);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 56);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(194, 496);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 56);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(372, 496);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(96, 56);
            this.buttonModify.TabIndex = 16;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(543, 496);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 56);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonSkip
            // 
            this.buttonSkip.Location = new System.Drawing.Point(718, 496);
            this.buttonSkip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(96, 56);
            this.buttonSkip.TabIndex = 18;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(879, 496);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(96, 56);
            this.buttonClose.TabIndex = 19;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 594);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.chkSex);
            this.Controls.Add(this.mtbDateOfBirthStaff);
            this.Controls.Add(this.mtbPhoneStaff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddressStaff);
            this.Controls.Add(this.txtNameStaff);
            this.Controls.Add(this.txtIDStaff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStaff";
            this.Text = "List Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDStaff;
        private System.Windows.Forms.TextBox txtNameStaff;
        private System.Windows.Forms.TextBox txtAddressStaff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbPhoneStaff;
        private System.Windows.Forms.MaskedTextBox mtbDateOfBirthStaff;
        private System.Windows.Forms.CheckBox chkSex;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.Button buttonClose;
    }
}