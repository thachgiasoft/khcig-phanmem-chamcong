﻿namespace CapNhatGioChamCong {
    partial class frm_KhaiBaoVang {
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("px thành phẩm");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("bảo vệ");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("văn phòng", new System.Windows.Forms.TreeNode[] {
            treeNode2});
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nhà máy thuốc lá khánh hội", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3});
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.splitPhong_DSNV = new System.Windows.Forms.SplitContainer();
			this.gpChonPhongBan = new System.Windows.Forms.GroupBox();
			this.treePhongBan = new System.Windows.Forms.TreeView();
			this.gp1 = new System.Windows.Forms.GroupBox();
			this.dgrdDSNVTrgPhg = new System.Windows.Forms.DataGridView();
			this.cChkDSNV2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.cUserEnrollNumberDSNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cUserFullNameDSNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cUserFullCodeDSNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cSchNameDSNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cTitleNameDSNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cDescriptionDSNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cSchIDDSNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cUserIDDDSNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpThang = new System.Windows.Forms.DateTimePicker();
			this.checklistNgay = new System.Windows.Forms.CheckedListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbLoaiVang = new System.Windows.Forms.ComboBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnLietKe = new System.Windows.Forms.Button();
			this.dgrdNgayVang = new System.Windows.Forms.DataGridView();
			this.g1check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.g2macc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.g1tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.g1ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.g1th = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.g1mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.g1cong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.g1userfullcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.g1ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.g1absentcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.splitPhong_DSNV)).BeginInit();
			this.splitPhong_DSNV.Panel1.SuspendLayout();
			this.splitPhong_DSNV.Panel2.SuspendLayout();
			this.splitPhong_DSNV.SuspendLayout();
			this.gpChonPhongBan.SuspendLayout();
			this.gp1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgrdDSNVTrgPhg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgrdNgayVang)).BeginInit();
			this.SuspendLayout();
			// 
			// splitPhong_DSNV
			// 
			this.splitPhong_DSNV.Dock = System.Windows.Forms.DockStyle.Left;
			this.splitPhong_DSNV.Location = new System.Drawing.Point(0, 0);
			this.splitPhong_DSNV.Name = "splitPhong_DSNV";
			this.splitPhong_DSNV.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitPhong_DSNV.Panel1
			// 
			this.splitPhong_DSNV.Panel1.Controls.Add(this.gpChonPhongBan);
			// 
			// splitPhong_DSNV.Panel2
			// 
			this.splitPhong_DSNV.Panel2.Controls.Add(this.gp1);
			this.splitPhong_DSNV.Size = new System.Drawing.Size(255, 600);
			this.splitPhong_DSNV.SplitterDistance = 203;
			this.splitPhong_DSNV.SplitterWidth = 2;
			this.splitPhong_DSNV.TabIndex = 0;
			// 
			// gpChonPhongBan
			// 
			this.gpChonPhongBan.Controls.Add(this.treePhongBan);
			this.gpChonPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gpChonPhongBan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.gpChonPhongBan.Location = new System.Drawing.Point(0, 0);
			this.gpChonPhongBan.Name = "gpChonPhongBan";
			this.gpChonPhongBan.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
			this.gpChonPhongBan.Size = new System.Drawing.Size(255, 203);
			this.gpChonPhongBan.TabIndex = 1;
			this.gpChonPhongBan.TabStop = false;
			this.gpChonPhongBan.Text = "Chọn phòng ban";
			// 
			// treePhongBan
			// 
			this.treePhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treePhongBan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.treePhongBan.Indent = 18;
			this.treePhongBan.ItemHeight = 20;
			this.treePhongBan.Location = new System.Drawing.Point(3, 21);
			this.treePhongBan.Name = "treePhongBan";
			treeNode1.Name = "Node2";
			treeNode1.Text = "px thành phẩm";
			treeNode2.Name = "Node5";
			treeNode2.Text = "bảo vệ";
			treeNode3.Name = "Node4";
			treeNode3.Text = "văn phòng";
			treeNode4.Name = "Node0";
			treeNode4.Text = "Nhà máy thuốc lá khánh hội";
			this.treePhongBan.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
			this.treePhongBan.ShowNodeToolTips = true;
			this.treePhongBan.Size = new System.Drawing.Size(249, 179);
			this.treePhongBan.TabIndex = 0;
			// 
			// gp1
			// 
			this.gp1.Controls.Add(this.dgrdDSNVTrgPhg);
			this.gp1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gp1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.gp1.Location = new System.Drawing.Point(0, 0);
			this.gp1.Name = "gp1";
			this.gp1.Size = new System.Drawing.Size(255, 395);
			this.gp1.TabIndex = 0;
			this.gp1.TabStop = false;
			this.gp1.Text = "Danh sách Nhân viên";
			// 
			// dgrdDSNVTrgPhg
			// 
			this.dgrdDSNVTrgPhg.AllowUserToAddRows = false;
			this.dgrdDSNVTrgPhg.AllowUserToDeleteRows = false;
			this.dgrdDSNVTrgPhg.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgrdDSNVTrgPhg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgrdDSNVTrgPhg.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgrdDSNVTrgPhg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cChkDSNV2,
            this.cUserEnrollNumberDSNV2,
            this.cUserFullNameDSNV2,
            this.cUserFullCodeDSNV2,
            this.cSchNameDSNV2,
            this.cTitleNameDSNV2,
            this.cDescriptionDSNV2,
            this.cSchIDDSNV2,
            this.cUserIDDDSNV2});
			this.dgrdDSNVTrgPhg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgrdDSNVTrgPhg.GridColor = System.Drawing.Color.Red;
			this.dgrdDSNVTrgPhg.Location = new System.Drawing.Point(3, 18);
			this.dgrdDSNVTrgPhg.Name = "dgrdDSNVTrgPhg";
			this.dgrdDSNVTrgPhg.RowHeadersVisible = false;
			this.dgrdDSNVTrgPhg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgrdDSNVTrgPhg.Size = new System.Drawing.Size(249, 374);
			this.dgrdDSNVTrgPhg.TabIndex = 2;
			// 
			// cChkDSNV2
			// 
			this.cChkDSNV2.DataPropertyName = "check";
			this.cChkDSNV2.FalseValue = "false";
			this.cChkDSNV2.Frozen = true;
			this.cChkDSNV2.HeaderText = "";
			this.cChkDSNV2.Name = "cChkDSNV2";
			this.cChkDSNV2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.cChkDSNV2.TrueValue = "true";
			this.cChkDSNV2.Width = 22;
			// 
			// cUserEnrollNumberDSNV2
			// 
			this.cUserEnrollNumberDSNV2.DataPropertyName = "UserEnrollNumber";
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.cUserEnrollNumberDSNV2.DefaultCellStyle = dataGridViewCellStyle2;
			this.cUserEnrollNumberDSNV2.HeaderText = "Mã CC";
			this.cUserEnrollNumberDSNV2.Name = "cUserEnrollNumberDSNV2";
			this.cUserEnrollNumberDSNV2.ReadOnly = true;
			this.cUserEnrollNumberDSNV2.ToolTipText = "Mã Chấm công";
			this.cUserEnrollNumberDSNV2.Width = 55;
			// 
			// cUserFullNameDSNV2
			// 
			this.cUserFullNameDSNV2.DataPropertyName = "UserFullName";
			this.cUserFullNameDSNV2.HeaderText = "Tên NV";
			this.cUserFullNameDSNV2.Name = "cUserFullNameDSNV2";
			this.cUserFullNameDSNV2.ReadOnly = true;
			this.cUserFullNameDSNV2.ToolTipText = "Tên Nhân viên";
			this.cUserFullNameDSNV2.Width = 165;
			// 
			// cUserFullCodeDSNV2
			// 
			this.cUserFullCodeDSNV2.DataPropertyName = "UserFullCode";
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.cUserFullCodeDSNV2.DefaultCellStyle = dataGridViewCellStyle3;
			this.cUserFullCodeDSNV2.HeaderText = "Mã NV";
			this.cUserFullCodeDSNV2.Name = "cUserFullCodeDSNV2";
			this.cUserFullCodeDSNV2.ReadOnly = true;
			this.cUserFullCodeDSNV2.ToolTipText = "Mã Nhân viên";
			this.cUserFullCodeDSNV2.Visible = false;
			this.cUserFullCodeDSNV2.Width = 55;
			// 
			// cSchNameDSNV2
			// 
			this.cSchNameDSNV2.DataPropertyName = "SchName";
			this.cSchNameDSNV2.HeaderText = "Lịch trình";
			this.cSchNameDSNV2.Name = "cSchNameDSNV2";
			this.cSchNameDSNV2.ReadOnly = true;
			this.cSchNameDSNV2.ToolTipText = "Lịch trình";
			this.cSchNameDSNV2.Width = 95;
			// 
			// cTitleNameDSNV2
			// 
			this.cTitleNameDSNV2.DataPropertyName = "TitleName";
			this.cTitleNameDSNV2.HeaderText = "Chức vụ";
			this.cTitleNameDSNV2.Name = "cTitleNameDSNV2";
			this.cTitleNameDSNV2.ReadOnly = true;
			this.cTitleNameDSNV2.ToolTipText = "Chức vụ";
			this.cTitleNameDSNV2.Width = 200;
			// 
			// cDescriptionDSNV2
			// 
			this.cDescriptionDSNV2.DataPropertyName = "Description";
			this.cDescriptionDSNV2.HeaderText = "Phòng ban";
			this.cDescriptionDSNV2.Name = "cDescriptionDSNV2";
			this.cDescriptionDSNV2.ReadOnly = true;
			this.cDescriptionDSNV2.ToolTipText = "Phòng ban";
			this.cDescriptionDSNV2.Width = 105;
			// 
			// cSchIDDSNV2
			// 
			this.cSchIDDSNV2.DataPropertyName = "SchID";
			this.cSchIDDSNV2.HeaderText = "Mã lịch trình";
			this.cSchIDDSNV2.Name = "cSchIDDSNV2";
			this.cSchIDDSNV2.ReadOnly = true;
			this.cSchIDDSNV2.ToolTipText = "Mã lịch trình";
			this.cSchIDDSNV2.Visible = false;
			// 
			// cUserIDDDSNV2
			// 
			this.cUserIDDDSNV2.DataPropertyName = "UserIDD";
			this.cUserIDDDSNV2.HeaderText = "Mã Phòng ban";
			this.cUserIDDDSNV2.Name = "cUserIDDDSNV2";
			this.cUserIDDDSNV2.ReadOnly = true;
			this.cUserIDDDSNV2.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(266, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Chọn tháng";
			// 
			// dtpThang
			// 
			this.dtpThang.CustomFormat = "  M / yyyy";
			this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpThang.Location = new System.Drawing.Point(365, 21);
			this.dtpThang.Name = "dtpThang";
			this.dtpThang.ShowUpDown = true;
			this.dtpThang.Size = new System.Drawing.Size(98, 22);
			this.dtpThang.TabIndex = 0;
			this.dtpThang.Value = new System.DateTime(2014, 2, 1, 19, 11, 0, 0);
			this.dtpThang.ValueChanged += new System.EventHandler(this.dtpThang_ValueChanged);
			// 
			// checklistNgay
			// 
			this.checklistNgay.CheckOnClick = true;
			this.checklistNgay.ColumnWidth = 95;
			this.checklistNgay.FormatString = "d - ddd";
			this.checklistNgay.FormattingEnabled = true;
			this.checklistNgay.Items.AddRange(new object[] {
            "1 - Hai",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "11",
            "12",
            "13",
            "14",
            "15",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
			this.checklistNgay.Location = new System.Drawing.Point(269, 77);
			this.checklistNgay.MultiColumn = true;
			this.checklistNgay.Name = "checklistNgay";
			this.checklistNgay.Size = new System.Drawing.Size(496, 123);
			this.checklistNgay.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(266, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Chọn ngày";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(266, 212);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "Loại vắng";
			// 
			// cbLoaiVang
			// 
			this.cbLoaiVang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLoaiVang.FormattingEnabled = true;
			this.cbLoaiVang.Location = new System.Drawing.Point(365, 209);
			this.cbLoaiVang.Name = "cbLoaiVang";
			this.cbLoaiVang.Size = new System.Drawing.Size(168, 24);
			this.cbLoaiVang.TabIndex = 2;
			// 
			// btnThem
			// 
			this.btnThem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.Blue;
			this.btnThem.Image = global::CapNhatGioChamCong.Properties.Resources.icon_add;
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThem.Location = new System.Drawing.Point(365, 239);
			this.btnThem.Name = "btnThem";
			this.btnThem.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.btnThem.Size = new System.Drawing.Size(70, 27);
			this.btnThem.TabIndex = 3;
			this.btnThem.Text = "Thêm";
			this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.Blue;
			this.btnXoa.Image = global::CapNhatGioChamCong.Properties.Resources.icon_del;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoa.Location = new System.Drawing.Point(463, 239);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.btnXoa.Size = new System.Drawing.Size(70, 27);
			this.btnXoa.TabIndex = 4;
			this.btnXoa.Text = "Xóa ";
			this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnLietKe
			// 
			this.btnLietKe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLietKe.ForeColor = System.Drawing.Color.Blue;
			this.btnLietKe.Image = global::CapNhatGioChamCong.Properties.Resources.icon_xemChitiet;
			this.btnLietKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLietKe.Location = new System.Drawing.Point(471, 17);
			this.btnLietKe.Name = "btnLietKe";
			this.btnLietKe.Size = new System.Drawing.Size(147, 32);
			this.btnLietKe.TabIndex = 1;
			this.btnLietKe.Text = "Liệt kê báo vắng";
			this.btnLietKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLietKe.UseVisualStyleBackColor = true;
			this.btnLietKe.Click += new System.EventHandler(this.btnLietKe_Click);
			// 
			// dgrdNgayVang
			// 
			this.dgrdNgayVang.AllowUserToAddRows = false;
			this.dgrdNgayVang.AllowUserToDeleteRows = false;
			this.dgrdNgayVang.ColumnHeadersHeight = 27;
			this.dgrdNgayVang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgrdNgayVang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.g1check,
            this.g2macc,
            this.g1tennv,
            this.g1ngay,
            this.g1th,
            this.g1mota,
            this.g1cong,
            this.g1userfullcode,
            this.g1ID,
            this.g1absentcode});
			this.dgrdNgayVang.Location = new System.Drawing.Point(269, 272);
			this.dgrdNgayVang.Name = "dgrdNgayVang";
			this.dgrdNgayVang.RowHeadersVisible = false;
			this.dgrdNgayVang.Size = new System.Drawing.Size(496, 325);
			this.dgrdNgayVang.TabIndex = 8;
			// 
			// g1check
			// 
			this.g1check.DataPropertyName = "check";
			this.g1check.FalseValue = "false";
			this.g1check.HeaderText = "";
			this.g1check.Name = "g1check";
			this.g1check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.g1check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.g1check.TrueValue = "true";
			this.g1check.Width = 24;
			// 
			// g2macc
			// 
			this.g2macc.DataPropertyName = "UserEnrollNumber";
			this.g2macc.HeaderText = "Mã CC";
			this.g2macc.Name = "g2macc";
			this.g2macc.ReadOnly = true;
			this.g2macc.Width = 55;
			// 
			// g1tennv
			// 
			this.g1tennv.DataPropertyName = "UserFullName";
			this.g1tennv.HeaderText = "Tên NV";
			this.g1tennv.Name = "g1tennv";
			this.g1tennv.ReadOnly = true;
			this.g1tennv.Width = 150;
			// 
			// g1ngay
			// 
			this.g1ngay.DataPropertyName = "TimeDate";
			dataGridViewCellStyle4.Format = "d/M";
			this.g1ngay.DefaultCellStyle = dataGridViewCellStyle4;
			this.g1ngay.HeaderText = "Ngày";
			this.g1ngay.Name = "g1ngay";
			this.g1ngay.ReadOnly = true;
			this.g1ngay.Width = 45;
			// 
			// g1th
			// 
			this.g1th.DataPropertyName = "TimeDate";
			dataGridViewCellStyle5.Format = "ddd";
			this.g1th.DefaultCellStyle = dataGridViewCellStyle5;
			this.g1th.HeaderText = "Thứ";
			this.g1th.Name = "g1th";
			this.g1th.ReadOnly = true;
			this.g1th.Width = 45;
			// 
			// g1mota
			// 
			this.g1mota.DataPropertyName = "AbsentDescription";
			this.g1mota.HeaderText = "Mô tả";
			this.g1mota.Name = "g1mota";
			this.g1mota.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.g1mota.Width = 170;
			// 
			// g1cong
			// 
			this.g1cong.DataPropertyName = "Workingday";
			dataGridViewCellStyle6.Format = "#0.##";
			this.g1cong.DefaultCellStyle = dataGridViewCellStyle6;
			this.g1cong.HeaderText = "Công_hide";
			this.g1cong.Name = "g1cong";
			this.g1cong.ReadOnly = true;
			this.g1cong.Visible = false;
			this.g1cong.Width = 45;
			// 
			// g1userfullcode
			// 
			this.g1userfullcode.DataPropertyName = "UserFullCode";
			this.g1userfullcode.HeaderText = "UserFullCode_hide";
			this.g1userfullcode.Name = "g1userfullcode";
			this.g1userfullcode.ReadOnly = true;
			this.g1userfullcode.Visible = false;
			// 
			// g1ID
			// 
			this.g1ID.DataPropertyName = "ID";
			this.g1ID.HeaderText = "ID_hide";
			this.g1ID.Name = "g1ID";
			this.g1ID.ReadOnly = true;
			this.g1ID.Visible = false;
			// 
			// g1absentcode
			// 
			this.g1absentcode.DataPropertyName = "AbsentCode";
			this.g1absentcode.HeaderText = "AbsentCodeHide";
			this.g1absentcode.Name = "g1absentcode";
			this.g1absentcode.Visible = false;
			// 
			// frm_KhaiBaoVang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(777, 600);
			this.Controls.Add(this.dgrdNgayVang);
			this.Controls.Add(this.btnLietKe);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.cbLoaiVang);
			this.Controls.Add(this.dtpThang);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.checklistNgay);
			this.Controls.Add(this.splitPhong_DSNV);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frm_KhaiBaoVang";
			this.Text = "Khai báo vắng cho Nhân viên";
			this.Load += new System.EventHandler(this.frm_KhaiBaoVang_Load);
			this.splitPhong_DSNV.Panel1.ResumeLayout(false);
			this.splitPhong_DSNV.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitPhong_DSNV)).EndInit();
			this.splitPhong_DSNV.ResumeLayout(false);
			this.gpChonPhongBan.ResumeLayout(false);
			this.gp1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgrdDSNVTrgPhg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgrdNgayVang)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitPhong_DSNV;
        private System.Windows.Forms.GroupBox gpChonPhongBan;
        private System.Windows.Forms.TreeView treePhongBan;
        private System.Windows.Forms.GroupBox gp1;
        private System.Windows.Forms.DataGridView dgrdDSNVTrgPhg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.CheckedListBox checklistNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbLoaiVang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLietKe;
        private System.Windows.Forms.DataGridView dgrdNgayVang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cChkDSNV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserEnrollNumberDSNV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserFullNameDSNV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserFullCodeDSNV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSchNameDSNV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTitleNameDSNV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescriptionDSNV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSchIDDSNV2;
		private System.Windows.Forms.DataGridViewTextBoxColumn cUserIDDDSNV2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn g1check;
		private System.Windows.Forms.DataGridViewTextBoxColumn g2macc;
		private System.Windows.Forms.DataGridViewTextBoxColumn g1tennv;
		private System.Windows.Forms.DataGridViewTextBoxColumn g1ngay;
		private System.Windows.Forms.DataGridViewTextBoxColumn g1th;
		private System.Windows.Forms.DataGridViewTextBoxColumn g1mota;
		private System.Windows.Forms.DataGridViewTextBoxColumn g1cong;
		private System.Windows.Forms.DataGridViewTextBoxColumn g1userfullcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn g1ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn g1absentcode;


    }
}