﻿namespace ChamCong_v03 {
    partial class frm_main {
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.MenuChamCong = new System.Windows.Forms.ToolStripMenuItem();
			this.SubMenu_XemCongNV = new System.Windows.Forms.ToolStripMenuItem();
			this.SubMenu_DiemDanh = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuKhaiBao = new System.Windows.Forms.ToolStripMenuItem();
			this.SubMenu_KhaibaoVang = new System.Windows.Forms.ToolStripMenuItem();
			this.SubMenu_ChamcongTay = new System.Windows.Forms.ToolStripMenuItem();
			this.SubMenu_ChamcongTayQL = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuHoatDong = new System.Windows.Forms.ToolStripMenuItem();
			this.SubMenu_SuaGioHangLoat = new System.Windows.Forms.ToolStripMenuItem();
			this.SubMenu_XemHistory = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuTinhLuong = new System.Windows.Forms.ToolStripMenuItem();
			this.SubMenu_TinhLuong = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
			this.SubMenu_DoiMK = new System.Windows.Forms.ToolStripMenuItem();
			this.SubMenu_PhanQuyen = new System.Windows.Forms.ToolStripMenuItem();
			this.SubMenu_TaoTK = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuThoat = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuChamCong,
            this.MenuKhaiBao,
            this.MenuHoatDong,
            this.MenuTinhLuong,
            this.MenuTaiKhoan,
            this.MenuThoat});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// MenuChamCong
			// 
			this.MenuChamCong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenu_XemCongNV,
            this.SubMenu_DiemDanh});
			this.MenuChamCong.Enabled = false;
			this.MenuChamCong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.MenuChamCong.ForeColor = System.Drawing.Color.Black;
			this.MenuChamCong.Name = "MenuChamCong";
			this.MenuChamCong.Size = new System.Drawing.Size(83, 20);
			this.MenuChamCong.Text = "Chấm công";
			// 
			// SubMenu_XemCongNV
			// 
			this.SubMenu_XemCongNV.Enabled = false;
			this.SubMenu_XemCongNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.SubMenu_XemCongNV.Name = "SubMenu_XemCongNV";
			this.SubMenu_XemCongNV.Size = new System.Drawing.Size(257, 22);
			this.SubMenu_XemCongNV.Text = "Xem công";
			this.SubMenu_XemCongNV.Click += new System.EventHandler(this.SubMenu_XemCongNV_Click);
			// 
			// SubMenu_DiemDanh
			// 
			this.SubMenu_DiemDanh.Enabled = false;
			this.SubMenu_DiemDanh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.SubMenu_DiemDanh.Name = "SubMenu_DiemDanh";
			this.SubMenu_DiemDanh.Size = new System.Drawing.Size(257, 22);
			this.SubMenu_DiemDanh.Text = "Điểm danh Nhân viên chấm công";
			this.SubMenu_DiemDanh.Click += new System.EventHandler(this.SubMenu_DiemDanh_Click);
			// 
			// MenuKhaiBao
			// 
			this.MenuKhaiBao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenu_KhaibaoVang,
            this.SubMenu_ChamcongTay,
            this.SubMenu_ChamcongTayQL});
			this.MenuKhaiBao.Enabled = false;
			this.MenuKhaiBao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.MenuKhaiBao.Name = "MenuKhaiBao";
			this.MenuKhaiBao.Size = new System.Drawing.Size(68, 20);
			this.MenuKhaiBao.Text = "Khai báo";
			// 
			// SubMenu_KhaibaoVang
			// 
			this.SubMenu_KhaibaoVang.Enabled = false;
			this.SubMenu_KhaibaoVang.Name = "SubMenu_KhaibaoVang";
			this.SubMenu_KhaibaoVang.Size = new System.Drawing.Size(223, 22);
			this.SubMenu_KhaibaoVang.Text = "Khai báo vắng";
			this.SubMenu_KhaibaoVang.Click += new System.EventHandler(this.SubMenu_KhaiBaoVang_Click);
			// 
			// SubMenu_ChamcongTay
			// 
			this.SubMenu_ChamcongTay.Enabled = false;
			this.SubMenu_ChamcongTay.Name = "SubMenu_ChamcongTay";
			this.SubMenu_ChamcongTay.Size = new System.Drawing.Size(223, 22);
			this.SubMenu_ChamcongTay.Text = "Chấm công tay";
			this.SubMenu_ChamcongTay.Click += new System.EventHandler(this.SubMenu_ChamCongTay_Click);
			// 
			// SubMenu_ChamcongTayQL
			// 
			this.SubMenu_ChamcongTayQL.Enabled = false;
			this.SubMenu_ChamcongTayQL.Name = "SubMenu_ChamcongTayQL";
			this.SubMenu_ChamcongTayQL.Size = new System.Drawing.Size(223, 22);
			this.SubMenu_ChamcongTayQL.Text = "Chấm công tay cho Quản lý";
			this.SubMenu_ChamcongTayQL.Click += new System.EventHandler(this.SubMenu_ChamcongTayQL_Click);
			// 
			// MenuHoatDong
			// 
			this.MenuHoatDong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenu_SuaGioHangLoat,
            this.SubMenu_XemHistory});
			this.MenuHoatDong.Enabled = false;
			this.MenuHoatDong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.MenuHoatDong.ForeColor = System.Drawing.Color.Black;
			this.MenuHoatDong.Name = "MenuHoatDong";
			this.MenuHoatDong.Size = new System.Drawing.Size(105, 20);
			this.MenuHoatDong.Text = "Hoạt động khác";
			// 
			// SubMenu_SuaGioHangLoat
			// 
			this.SubMenu_SuaGioHangLoat.Enabled = false;
			this.SubMenu_SuaGioHangLoat.Name = "SubMenu_SuaGioHangLoat";
			this.SubMenu_SuaGioHangLoat.Size = new System.Drawing.Size(249, 22);
			this.SubMenu_SuaGioHangLoat.Text = "Sửa giờ hàng loạt";
			this.SubMenu_SuaGioHangLoat.Click += new System.EventHandler(this.SubMenu_SuaGioHangLoat_Click);
			// 
			// SubMenu_XemHistory
			// 
			this.SubMenu_XemHistory.Enabled = false;
			this.SubMenu_XemHistory.Name = "SubMenu_XemHistory";
			this.SubMenu_XemHistory.Size = new System.Drawing.Size(249, 22);
			this.SubMenu_XemHistory.Text = "Xem lịch sử sửa giờ chấm công";
			this.SubMenu_XemHistory.Click += new System.EventHandler(this.SubMenu_xemHistory_Click);
			// 
			// MenuTinhLuong
			// 
			this.MenuTinhLuong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenu_TinhLuong});
			this.MenuTinhLuong.Enabled = false;
			this.MenuTinhLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.MenuTinhLuong.Name = "MenuTinhLuong";
			this.MenuTinhLuong.Size = new System.Drawing.Size(79, 20);
			this.MenuTinhLuong.Text = "Tính lương";
			// 
			// SubMenu_TinhLuong
			// 
			this.SubMenu_TinhLuong.Enabled = false;
			this.SubMenu_TinhLuong.Name = "SubMenu_TinhLuong";
			this.SubMenu_TinhLuong.Size = new System.Drawing.Size(259, 22);
			this.SubMenu_TinhLuong.Text = "Tính lương cho toàn bộ Nhân viên";
			this.SubMenu_TinhLuong.Click += new System.EventHandler(this.SubMenu_TinhLuong_Click);
			// 
			// MenuTaiKhoan
			// 
			this.MenuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenu_DoiMK,
            this.SubMenu_PhanQuyen,
            this.SubMenu_TaoTK});
			this.MenuTaiKhoan.Enabled = false;
			this.MenuTaiKhoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.MenuTaiKhoan.Name = "MenuTaiKhoan";
			this.MenuTaiKhoan.Size = new System.Drawing.Size(73, 20);
			this.MenuTaiKhoan.Text = "Tài khoản";
			// 
			// SubMenu_DoiMK
			// 
			this.SubMenu_DoiMK.Enabled = false;
			this.SubMenu_DoiMK.Name = "SubMenu_DoiMK";
			this.SubMenu_DoiMK.Size = new System.Drawing.Size(210, 22);
			this.SubMenu_DoiMK.Text = "Đổi mật khẩu đăng nhập";
			this.SubMenu_DoiMK.Click += new System.EventHandler(this.SubMenu_DoiMK_Click);
			// 
			// SubMenu_PhanQuyen
			// 
			this.SubMenu_PhanQuyen.Enabled = false;
			this.SubMenu_PhanQuyen.Name = "SubMenu_PhanQuyen";
			this.SubMenu_PhanQuyen.Size = new System.Drawing.Size(210, 22);
			this.SubMenu_PhanQuyen.Text = "Phân Quyền";
			this.SubMenu_PhanQuyen.Click += new System.EventHandler(this.SubMenu_PhanQuyen_Click);
			// 
			// SubMenu_TaoTK
			// 
			this.SubMenu_TaoTK.Enabled = false;
			this.SubMenu_TaoTK.Name = "SubMenu_TaoTK";
			this.SubMenu_TaoTK.Size = new System.Drawing.Size(210, 22);
			this.SubMenu_TaoTK.Text = "Tạo tài khoản đăng nhập";
			this.SubMenu_TaoTK.Click += new System.EventHandler(this.SubMenu_TaoTK_Click);
			// 
			// MenuThoat
			// 
			this.MenuThoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.MenuThoat.ForeColor = System.Drawing.Color.Black;
			this.MenuThoat.Name = "MenuThoat";
			this.MenuThoat.Size = new System.Drawing.Size(50, 20);
			this.MenuThoat.Text = "Thoát";
			this.MenuThoat.Click += new System.EventHandler(this.MenuThoat_Click);
			// 
			// frm_main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1144, 670);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần mềm ứng dụng chấm công vân tay";
			this.Load += new System.EventHandler(this.frm_main_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuChamCong;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_XemCongNV;
		private System.Windows.Forms.ToolStripMenuItem SubMenu_DiemDanh;
        private System.Windows.Forms.ToolStripMenuItem MenuHoatDong;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_SuaGioHangLoat;
		private System.Windows.Forms.ToolStripMenuItem SubMenu_XemHistory;
        private System.Windows.Forms.ToolStripMenuItem MenuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_DoiMK;
        private System.Windows.Forms.ToolStripMenuItem MenuThoat;
		private System.Windows.Forms.ToolStripMenuItem MenuKhaiBao;
		private System.Windows.Forms.ToolStripMenuItem SubMenu_KhaibaoVang;
		private System.Windows.Forms.ToolStripMenuItem SubMenu_ChamcongTay;
		private System.Windows.Forms.ToolStripMenuItem MenuTinhLuong;
		private System.Windows.Forms.ToolStripMenuItem SubMenu_TinhLuong;
		private System.Windows.Forms.ToolStripMenuItem SubMenu_PhanQuyen;
		private System.Windows.Forms.ToolStripMenuItem SubMenu_TaoTK;
		private System.Windows.Forms.ToolStripMenuItem SubMenu_ChamcongTayQL;

    }
}