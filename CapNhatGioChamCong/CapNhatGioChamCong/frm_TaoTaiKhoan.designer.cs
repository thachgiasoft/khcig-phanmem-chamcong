﻿namespace CapNhatGioChamCong
{
    partial class frmTaoTaiKhoan
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
			this.cbTaikhoanWE = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbPass1 = new System.Windows.Forms.TextBox();
			this.btnTaoTK = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.dataGridTK = new System.Windows.Forms.DataGridView();
			this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colUserAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbPass2 = new System.Windows.Forms.TextBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.tbTenTaiKhoan = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnXoaTK = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTK)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(78, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên tài khoản:";
			// 
			// cbTaikhoanWE
			// 
			this.cbTaikhoanWE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTaikhoanWE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cbTaikhoanWE.ForeColor = System.Drawing.Color.Blue;
			this.cbTaikhoanWE.Location = new System.Drawing.Point(174, 13);
			this.cbTaikhoanWE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cbTaikhoanWE.Name = "cbTaikhoanWE";
			this.cbTaikhoanWE.Size = new System.Drawing.Size(226, 24);
			this.cbTaikhoanWE.TabIndex = 0;
			this.cbTaikhoanWE.SelectedIndexChanged += new System.EventHandler(this.cbTaikhoanWE_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(102, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mật khẩu:";
			// 
			// tbPass1
			// 
			this.tbPass1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.tbPass1.ForeColor = System.Drawing.Color.Blue;
			this.tbPass1.Location = new System.Drawing.Point(174, 75);
			this.tbPass1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbPass1.Name = "tbPass1";
			this.tbPass1.Size = new System.Drawing.Size(226, 22);
			this.tbPass1.TabIndex = 2;
			this.tbPass1.UseSystemPasswordChar = true;
			// 
			// btnTaoTK
			// 
			this.btnTaoTK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnTaoTK.ForeColor = System.Drawing.Color.Blue;
			this.btnTaoTK.Location = new System.Drawing.Point(174, 135);
			this.btnTaoTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnTaoTK.Name = "btnTaoTK";
			this.btnTaoTK.Size = new System.Drawing.Size(110, 28);
			this.btnTaoTK.TabIndex = 4;
			this.btnTaoTK.Text = "Tạo tài khoản";
			this.btnTaoTK.UseVisualStyleBackColor = true;
			this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThoat.ForeColor = System.Drawing.Color.Blue;
			this.btnThoat.Location = new System.Drawing.Point(290, 554);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(110, 28);
			this.btnThoat.TabIndex = 7;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// dataGridTK
			// 
			this.dataGridTK.AllowUserToAddRows = false;
			this.dataGridTK.AllowUserToDeleteRows = false;
			this.dataGridTK.AllowUserToOrderColumns = true;
			this.dataGridTK.AllowUserToResizeRows = false;
			this.dataGridTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserID,
            this.colUserAccount});
			this.dataGridTK.Location = new System.Drawing.Point(6, 23);
			this.dataGridTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridTK.MultiSelect = false;
			this.dataGridTK.Name = "dataGridTK";
			this.dataGridTK.ReadOnly = true;
			this.dataGridTK.RowHeadersVisible = false;
			this.dataGridTK.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridTK.Size = new System.Drawing.Size(373, 344);
			this.dataGridTK.TabIndex = 6;
			this.dataGridTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTK_CellClick);
			// 
			// colUserID
			// 
			this.colUserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.colUserID.DataPropertyName = "UserID";
			this.colUserID.HeaderText = "ID";
			this.colUserID.Name = "colUserID";
			this.colUserID.ReadOnly = true;
			this.colUserID.Width = 45;
			// 
			// colUserAccount
			// 
			this.colUserAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colUserAccount.DataPropertyName = "UserAccount";
			this.colUserAccount.HeaderText = "Tài khoản";
			this.colUserAccount.Name = "colUserAccount";
			this.colUserAccount.ReadOnly = true;
			this.colUserAccount.Width = 89;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridTK);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(12, 171);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new System.Drawing.Size(387, 375);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách tài khoản ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(51, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "Nhập lại mật khẩu:";
			// 
			// tbPass2
			// 
			this.tbPass2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.tbPass2.ForeColor = System.Drawing.Color.Blue;
			this.tbPass2.Location = new System.Drawing.Point(174, 105);
			this.tbPass2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbPass2.Name = "tbPass2";
			this.tbPass2.Size = new System.Drawing.Size(225, 22);
			this.tbPass2.TabIndex = 3;
			this.tbPass2.UseSystemPasswordChar = true;
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnReset.ForeColor = System.Drawing.Color.Blue;
			this.btnReset.Location = new System.Drawing.Point(290, 135);
			this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(110, 28);
			this.btnReset.TabIndex = 5;
			this.btnReset.Text = "Reset mật khẩu";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// tbTenTaiKhoan
			// 
			this.tbTenTaiKhoan.Enabled = false;
			this.tbTenTaiKhoan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.tbTenTaiKhoan.ForeColor = System.Drawing.Color.Blue;
			this.tbTenTaiKhoan.Location = new System.Drawing.Point(174, 45);
			this.tbTenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbTenTaiKhoan.Name = "tbTenTaiKhoan";
			this.tbTenTaiKhoan.Size = new System.Drawing.Size(226, 22);
			this.tbTenTaiKhoan.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(12, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(156, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Chọn tài khoản WiseEye:";
			// 
			// btnXoaTK
			// 
			this.btnXoaTK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXoaTK.ForeColor = System.Drawing.Color.Blue;
			this.btnXoaTK.Location = new System.Drawing.Point(58, 135);
			this.btnXoaTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnXoaTK.Name = "btnXoaTK";
			this.btnXoaTK.Size = new System.Drawing.Size(110, 28);
			this.btnXoaTK.TabIndex = 6;
			this.btnXoaTK.Text = "Xóa tài khoản";
			this.btnXoaTK.UseVisualStyleBackColor = true;
			this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
			// 
			// frmTaoTaiKhoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 595);
			this.Controls.Add(this.cbTaikhoanWE);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXoaTK);
			this.Controls.Add(this.btnTaoTK);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.tbPass2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbTenTaiKhoan);
			this.Controls.Add(this.tbPass1);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frmTaoTaiKhoan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tạo tài khoản";
			this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridTK)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTaikhoanWE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPass1;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridTK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPass2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbTenTaiKhoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserAccount;
    }
}