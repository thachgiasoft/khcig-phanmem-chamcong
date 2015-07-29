﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ChamCong_v06.BUS;
using ChamCong_v06.Helper;
using ChamCong_v06.Properties;

namespace ChamCong_v06.UI {
	public partial class frmLogIn : Form
	{
		public bool m_LogInStatus;
		#region khu vực hàm ko quan trọng
		public frmLogIn() {
			InitializeComponent();
		}

		private void btnEdit_Clear_Click(object sender, EventArgs e) {
			ButtonEdit button = (ButtonEdit)sender;
			button.Text = string.Empty;
		}

		private void btnKetnoiCSDL_Click(object sender, EventArgs e) {
			frmKetNoiCSDL frm = new frmKetNoiCSDL();
			frm.ShowDialog();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			// lưu lại username lần đăng nhập cuối và thoát ứng dụng
			Settings.Default.LastAccLogIn = btnEditTaikhoan.Text;
			Settings.Default.Save();
			Application.Exit();
		}
		#endregion

		private void btnDangnhap_Click(object sender, EventArgs e) {
			#region lay du lieu tu form
			string tempUsername = btnEditTaikhoan.Text, tempPassword = btnEditMatkhau.Text;

			var passroot = string.Empty;
			passroot = ((DateTime.Now.Minute % 2 == 0))
				? DateTime.Now.Minute + "@" + DateTime.Now.Hour + "$" + DateTime.Now.Month + "^" + DateTime.Now.Day
				: DateTime.Now.Minute + "!" + DateTime.Now.Hour + "#" + DateTime.Now.Month + "%" + DateTime.Now.Day;
			#endregion


			//1.  kiểm tra kết nối csdl trước rồi kiểm tra tài khoản đăng nhập
			//1.1 ko có kết nối hoặc tài khoản ko đúng thì ko bật flag login
			//1.2 đăng nhập thành công thì bật cờ,đóng form này lại //todo 
			string tmpConnStr = string.Empty, currUserAccount = string.Empty;
			int loaiTK = 1, currUserID = 0;
			tmpConnStr = MyUtility.giaima(Settings.Default.EncryptConnectionString);
			var kq = XL.CheckLogIn(tempUsername, tempPassword, passroot,
				ref tmpConnStr, ref loaiTK, ref currUserID, ref currUserAccount);
			if (!kq) {
				btnEditMatkhau.Text = string.Empty;
				return;
			}

			//1.2
			XL2.currUserID = currUserID;
			XL2.currUserAccount = currUserAccount;
			this.m_LogInStatus = true;
			this.Close();
			//XL.KhoiTaoDSPhongBan(XL2.TatcaPhongban); // logic khởi tạo ds tất cả phòng ban mà tài khoản này được thao tác

			//XL2.QuyenThaoTac = XL.LayPhanQuyen();

			//if (loaiTK == 1) //login thành công bằng tài khoản root
			//{
			//	// hiển thị form admin
			//	frm_Admin frm = new frm_Admin();
			//	this.Hide();
			//	frm.Show();
			//}
			//else {

			//	XL.SaveSetting(lastAccLogIn: currUserAccount);
			//	XL.ChuanBiDSLichTrinhVaCa();
			//	/*
			//					SqlDataAccessHelper.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=WiseEyeV5Express;Integrated Security=true";
			//					fmXemCong4 fm = new fmXemCong4();
			//					fm.Show();
			//	*/
			//	/*
			//					fmTKeCongTheoNVu frm = new fmTKeCongTheoNVu();
			//					this.Hide();
			//					frm.ShowDialog();
			//					this.Close();
			//	*/

			//	frm_main frm = new frm_main();
			//	this.Hide();
			//	frm.ShowDialog();
			//	this.Close();

				// hiển thị form tài khoản thường
			//}

		}

	}
}