﻿namespace ChamCong_v04.UI.TinhLuong {
	partial class frmDocTuFileExcel {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.dgrdDThuchiExcel = new System.Windows.Forms.DataGridView();
			this.cChkDSNV2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.cUserFullCodeDSNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cUserFullNameDSNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.g1c10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.g1c9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.g1c11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.g1c21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cUserEnrollNumberDSNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cChucVuDSNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cSchIDDSNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cUserIDDDSNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cSchNameDSNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dialogOpenExcel = new System.Windows.Forms.OpenFileDialog();
			this.btnCapNhatVaoCSDL = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.lbTongThuchikhac = new System.Windows.Forms.Label();
			this.lbTongLuongdieuchinh = new System.Windows.Forms.Label();
			this.lbTongTamung = new System.Windows.Forms.Label();
			this.lbTongMucDongBHXH = new System.Windows.Forms.Label();
			this.lbTongNV = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgrdDThuchiExcel)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBrowse
			// 
			this.btnBrowse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.btnBrowse.ForeColor = System.Drawing.Color.Blue;
			this.btnBrowse.Location = new System.Drawing.Point(12, 11);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(129, 25);
			this.btnBrowse.TabIndex = 0;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// dgrdDThuchiExcel
			// 
			this.dgrdDThuchiExcel.AllowUserToAddRows = false;
			this.dgrdDThuchiExcel.AllowUserToDeleteRows = false;
			this.dgrdDThuchiExcel.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgrdDThuchiExcel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgrdDThuchiExcel.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgrdDThuchiExcel.ColumnHeadersHeight = 25;
			this.dgrdDThuchiExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgrdDThuchiExcel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cChkDSNV2,
            this.cUserFullCodeDSNV2,
            this.cUserFullNameDSNV2,
            this.g1c10,
            this.g1c9,
            this.g1c11,
            this.g1c21,
            this.cUserEnrollNumberDSNV2,
            this.cChucVuDSNV2,
            this.cSchIDDSNV2,
            this.cUserIDDDSNV2,
            this.cSchNameDSNV2});
			this.dgrdDThuchiExcel.Location = new System.Drawing.Point(12, 86);
			this.dgrdDThuchiExcel.Name = "dgrdDThuchiExcel";
			this.dgrdDThuchiExcel.ReadOnly = true;
			this.dgrdDThuchiExcel.RowHeadersVisible = false;
			this.dgrdDThuchiExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgrdDThuchiExcel.Size = new System.Drawing.Size(708, 214);
			this.dgrdDThuchiExcel.TabIndex = 2;
			// 
			// cChkDSNV2
			// 
			this.cChkDSNV2.DataPropertyName = "check";
			this.cChkDSNV2.FalseValue = "false";
			this.cChkDSNV2.Frozen = true;
			this.cChkDSNV2.HeaderText = "";
			this.cChkDSNV2.Name = "cChkDSNV2";
			this.cChkDSNV2.ReadOnly = true;
			this.cChkDSNV2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.cChkDSNV2.TrueValue = "true";
			this.cChkDSNV2.Visible = false;
			this.cChkDSNV2.Width = 22;
			// 
			// cUserFullCodeDSNV2
			// 
			this.cUserFullCodeDSNV2.DataPropertyName = "UserFullCode";
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.cUserFullCodeDSNV2.DefaultCellStyle = dataGridViewCellStyle2;
			this.cUserFullCodeDSNV2.HeaderText = "Mã NV";
			this.cUserFullCodeDSNV2.Name = "cUserFullCodeDSNV2";
			this.cUserFullCodeDSNV2.ReadOnly = true;
			this.cUserFullCodeDSNV2.ToolTipText = "Mã Nhân viên";
			this.cUserFullCodeDSNV2.Width = 55;
			// 
			// cUserFullNameDSNV2
			// 
			this.cUserFullNameDSNV2.DataPropertyName = "UserFullName";
			this.cUserFullNameDSNV2.HeaderText = "Tên NV";
			this.cUserFullNameDSNV2.Name = "cUserFullNameDSNV2";
			this.cUserFullNameDSNV2.ReadOnly = true;
			this.cUserFullNameDSNV2.ToolTipText = "Tên Nhân viên";
			this.cUserFullNameDSNV2.Width = 150;
			// 
			// g1c10
			// 
			this.g1c10.DataPropertyName = "TamUng";
			dataGridViewCellStyle3.Format = "###,###,###,##0";
			this.g1c10.DefaultCellStyle = dataGridViewCellStyle3;
			this.g1c10.HeaderText = "Tạm ứng tháng";
			this.g1c10.Name = "g1c10";
			this.g1c10.ReadOnly = true;
			this.g1c10.Width = 120;
			// 
			// g1c9
			// 
			this.g1c9.DataPropertyName = "LuongDieuChinh";
			dataGridViewCellStyle4.Format = "###,###,###,##0";
			this.g1c9.DefaultCellStyle = dataGridViewCellStyle4;
			this.g1c9.HeaderText = "Lương điều chỉnh";
			this.g1c9.Name = "g1c9";
			this.g1c9.ReadOnly = true;
			this.g1c9.Width = 120;
			// 
			// g1c11
			// 
			this.g1c11.DataPropertyName = "ThuChiKhac";
			dataGridViewCellStyle5.Format = "###,###,###,##0";
			this.g1c11.DefaultCellStyle = dataGridViewCellStyle5;
			this.g1c11.HeaderText = "Thu chi khác";
			this.g1c11.Name = "g1c11";
			this.g1c11.ReadOnly = true;
			this.g1c11.Width = 120;
			// 
			// g1c21
			// 
			this.g1c21.DataPropertyName = "MucDongBHXH";
			this.g1c21.HeaderText = "Mức đóng BHXH";
			this.g1c21.Name = "g1c21";
			this.g1c21.ReadOnly = true;
			this.g1c21.Width = 120;
			// 
			// cUserEnrollNumberDSNV2
			// 
			this.cUserEnrollNumberDSNV2.DataPropertyName = "UserEnrollNumber";
			dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.cUserEnrollNumberDSNV2.DefaultCellStyle = dataGridViewCellStyle6;
			this.cUserEnrollNumberDSNV2.HeaderText = "Mã CC_hide";
			this.cUserEnrollNumberDSNV2.Name = "cUserEnrollNumberDSNV2";
			this.cUserEnrollNumberDSNV2.ReadOnly = true;
			this.cUserEnrollNumberDSNV2.ToolTipText = "Mã Chấm công";
			this.cUserEnrollNumberDSNV2.Visible = false;
			this.cUserEnrollNumberDSNV2.Width = 55;
			// 
			// cChucVuDSNV2
			// 
			this.cChucVuDSNV2.DataPropertyName = "ChucVu";
			this.cChucVuDSNV2.HeaderText = "Chức vụ_hide";
			this.cChucVuDSNV2.Name = "cChucVuDSNV2";
			this.cChucVuDSNV2.ReadOnly = true;
			this.cChucVuDSNV2.ToolTipText = "Chức vụ";
			this.cChucVuDSNV2.Visible = false;
			this.cChucVuDSNV2.Width = 200;
			// 
			// cSchIDDSNV2
			// 
			this.cSchIDDSNV2.DataPropertyName = "SchID";
			this.cSchIDDSNV2.HeaderText = "Mã lịch trình_hide";
			this.cSchIDDSNV2.Name = "cSchIDDSNV2";
			this.cSchIDDSNV2.ReadOnly = true;
			this.cSchIDDSNV2.ToolTipText = "Mã lịch trình";
			this.cSchIDDSNV2.Visible = false;
			// 
			// cUserIDDDSNV2
			// 
			this.cUserIDDDSNV2.DataPropertyName = "MaPhong";
			this.cUserIDDDSNV2.HeaderText = "Mã Phòng ban_hide";
			this.cUserIDDDSNV2.Name = "cUserIDDDSNV2";
			this.cUserIDDDSNV2.ReadOnly = true;
			this.cUserIDDDSNV2.Visible = false;
			// 
			// cSchNameDSNV2
			// 
			this.cSchNameDSNV2.DataPropertyName = "SchName";
			this.cSchNameDSNV2.HeaderText = "Lịch trình_hide";
			this.cSchNameDSNV2.Name = "cSchNameDSNV2";
			this.cSchNameDSNV2.ReadOnly = true;
			this.cSchNameDSNV2.ToolTipText = "Lịch trình";
			this.cSchNameDSNV2.Visible = false;
			this.cSchNameDSNV2.Width = 95;
			// 
			// dialogOpenExcel
			// 
			this.dialogOpenExcel.FileName = "openFileDialog1";
			// 
			// btnCapNhatVaoCSDL
			// 
			this.btnCapNhatVaoCSDL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.btnCapNhatVaoCSDL.ForeColor = System.Drawing.Color.Blue;
			this.btnCapNhatVaoCSDL.Location = new System.Drawing.Point(12, 55);
			this.btnCapNhatVaoCSDL.Name = "btnCapNhatVaoCSDL";
			this.btnCapNhatVaoCSDL.Size = new System.Drawing.Size(129, 25);
			this.btnCapNhatVaoCSDL.TabIndex = 1;
			this.btnCapNhatVaoCSDL.Text = "Cập nhật vào CSDL";
			this.btnCapNhatVaoCSDL.UseVisualStyleBackColor = true;
			this.btnCapNhatVaoCSDL.Click += new System.EventHandler(this.btnCapNhatVaoCSDL_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.button3.ForeColor = System.Drawing.Color.Blue;
			this.button3.Location = new System.Drawing.Point(642, 306);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(78, 25);
			this.button3.TabIndex = 3;
			this.button3.Text = "Thoát";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// lbTongThuchikhac
			// 
			this.lbTongThuchikhac.AutoSize = true;
			this.lbTongThuchikhac.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.lbTongThuchikhac.Location = new System.Drawing.Point(156, 59);
			this.lbTongThuchikhac.Margin = new System.Windows.Forms.Padding(3);
			this.lbTongThuchikhac.Name = "lbTongThuchikhac";
			this.lbTongThuchikhac.Size = new System.Drawing.Size(158, 16);
			this.lbTongThuchikhac.TabIndex = 16;
			this.lbTongThuchikhac.Text = "Tổng thu chi khác: {0}";
			// 
			// lbTongLuongdieuchinh
			// 
			this.lbTongLuongdieuchinh.AutoSize = true;
			this.lbTongLuongdieuchinh.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.lbTongLuongdieuchinh.Location = new System.Drawing.Point(485, 15);
			this.lbTongLuongdieuchinh.Name = "lbTongLuongdieuchinh";
			this.lbTongLuongdieuchinh.Size = new System.Drawing.Size(193, 16);
			this.lbTongLuongdieuchinh.TabIndex = 17;
			this.lbTongLuongdieuchinh.Text = "Tổng lương điều chỉnh: {0}";
			// 
			// lbTongTamung
			// 
			this.lbTongTamung.AutoSize = true;
			this.lbTongTamung.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.lbTongTamung.Location = new System.Drawing.Point(156, 37);
			this.lbTongTamung.Margin = new System.Windows.Forms.Padding(3);
			this.lbTongTamung.Name = "lbTongTamung";
			this.lbTongTamung.Size = new System.Drawing.Size(130, 16);
			this.lbTongTamung.TabIndex = 18;
			this.lbTongTamung.Text = "Tổng tạm ứng: {0}";
			// 
			// lbTongMucDongBHXH
			// 
			this.lbTongMucDongBHXH.AutoSize = true;
			this.lbTongMucDongBHXH.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.lbTongMucDongBHXH.Location = new System.Drawing.Point(485, 37);
			this.lbTongMucDongBHXH.Name = "lbTongMucDongBHXH";
			this.lbTongMucDongBHXH.Size = new System.Drawing.Size(177, 16);
			this.lbTongMucDongBHXH.TabIndex = 19;
			this.lbTongMucDongBHXH.Text = "Các mức đóng BHXH: {0}";
			// 
			// lbTongNV
			// 
			this.lbTongNV.AutoSize = true;
			this.lbTongNV.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.lbTongNV.Location = new System.Drawing.Point(156, 15);
			this.lbTongNV.Margin = new System.Windows.Forms.Padding(3);
			this.lbTongNV.Name = "lbTongNV";
			this.lbTongNV.Size = new System.Drawing.Size(112, 16);
			this.lbTongNV.TabIndex = 20;
			this.lbTongNV.Text = "Tổng số NV: {0}";
			// 
			// frmDocTuFileExcel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(732, 338);
			this.ControlBox = false;
			this.Controls.Add(this.lbTongThuchikhac);
			this.Controls.Add(this.lbTongLuongdieuchinh);
			this.Controls.Add(this.lbTongTamung);
			this.Controls.Add(this.lbTongMucDongBHXH);
			this.Controls.Add(this.lbTongNV);
			this.Controls.Add(this.btnCapNhatVaoCSDL);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.dgrdDThuchiExcel);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frmDocTuFileExcel";
			this.Text = "Đọc từ file excel cập nhật vào CSDL";
			this.Load += new System.EventHandler(this.frmDocTuFileExcel_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgrdDThuchiExcel)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.DataGridView dgrdDThuchiExcel;
		private System.Windows.Forms.OpenFileDialog dialogOpenExcel;
		private System.Windows.Forms.Button btnCapNhatVaoCSDL;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label lbTongThuchikhac;
		private System.Windows.Forms.Label lbTongLuongdieuchinh;
		private System.Windows.Forms.Label lbTongTamung;
		private System.Windows.Forms.Label lbTongMucDongBHXH;
		private System.Windows.Forms.Label lbTongNV;
		private System.Windows.Forms.DataGridViewCheckBoxColumn cChkDSNV2;
		private System.Windows.Forms.DataGridViewTextBoxColumn cUserFullCodeDSNV2;
		private System.Windows.Forms.DataGridViewTextBoxColumn cUserFullNameDSNV2;
		private System.Windows.Forms.DataGridViewTextBoxColumn g1c10;
		private System.Windows.Forms.DataGridViewTextBoxColumn g1c9;
		private System.Windows.Forms.DataGridViewTextBoxColumn g1c11;
		private System.Windows.Forms.DataGridViewTextBoxColumn g1c21;
		private System.Windows.Forms.DataGridViewTextBoxColumn cUserEnrollNumberDSNV2;
		private System.Windows.Forms.DataGridViewTextBoxColumn cChucVuDSNV2;
		private System.Windows.Forms.DataGridViewTextBoxColumn cSchIDDSNV2;
		private System.Windows.Forms.DataGridViewTextBoxColumn cUserIDDDSNV2;
		private System.Windows.Forms.DataGridViewTextBoxColumn cSchNameDSNV2;
	}
}