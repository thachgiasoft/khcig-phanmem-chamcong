﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ChamCong_v06.Helper;
using ChamCong_v06.Properties;

namespace ChamCong_v06.BUS {

	public class XL2 {
		public static List<int> QuyenThaoTac;

		public class cChucNang {
			public int ID { get; set; }
			public string MoTa { get; set; }
			public bool IsYes { get; set; }
			public override string ToString() {
				return "ID= " + ID + " IsYes= " + IsYes + "\t" + MoTa;
			}
		}




		public static void TachThang(DateTime ngayBd, DateTime ngayKt, out List<DateTime> arrNgayBd, out List<DateTime> arrNgayKt) {
			arrNgayBd = new List<DateTime>();
			arrNgayKt = new List<DateTime>();
			var indexNgay = ngayBd;
			var indexThang = new DateTime(indexNgay.Year, indexNgay.Month, 1);
			var ThangKT = new DateTime(ngayKt.Year, ngayKt.Month, 1);
			while (indexThang < ThangKT) {
				var ngayktthang = new DateTime(indexNgay.Year, indexNgay.Month, DateTime.DaysInMonth(indexNgay.Year, indexNgay.Month));
				arrNgayBd.Add(indexNgay);
				arrNgayKt.Add(ngayktthang);
				indexNgay = new DateTime(indexNgay.Year, indexNgay.Month, 1); // trả về ngày đầu tháng
				indexNgay = indexNgay.AddMonths(1);// index ngày giữ ngày đầu tiên của tháng (trừ lần đầu tiên giữ ngày bd)
				indexThang = indexThang.AddMonths(1); // thực tế là tăng tháng
			}
			//tháng của index = tháng của ngày kết thúc
			arrNgayBd.Add(indexNgay);
			arrNgayKt.Add(ngayKt);
		}

		public static bool KiemtraKetnoiCSDL() {
			if (SqlDataAccessHelper.TestConnection(SqlDataAccessHelper.ConnectionString) == false) {
				ACMessageBox.Show(Resources.Text_MatKetNoiCSDL, Resources.Caption_Loi, 3000);
				return false;
			}
			return true;
		}

		public static Point GetCenterLocation(int MdiParentWidth, int MdiParentHeight, int formWidth, int formHeight) {
			return new Point((int)((MdiParentWidth - formWidth) / 2f), (int)((MdiParentHeight - formHeight) / 2f));
		}

		internal static List<XL2.cChucNang> TaoChucNang() {
			List<cChucNang> lstChucNang = new List<cChucNang>();
			//lstChucNang.Add(new cChucNang() { ID = 10000, MoTa = "Kết nối CSDL" });
			lstChucNang.Add(new cChucNang() { ID = 10011, MoTa = "Xem Công" });
			lstChucNang.Add(new cChucNang() { ID = 10012, MoTa = "Thêm xoá sửa giờ chấm công" });
			lstChucNang.Add(new cChucNang() { ID = 10033, MoTa = "Xác nhận ca và làm thêm" });
			lstChucNang.Add(new cChucNang() { ID = 10014, MoTa = "Xác nhận phụ cấp tăng cường" });
			lstChucNang.Add(new cChucNang() { ID = 10015, MoTa = "Xác nhận phụ cấp làm việc ngày nghỉ, trực lễ, tết" });
			lstChucNang.Add(new cChucNang() { ID = 10016, MoTa = "Kết công tháng" });
			lstChucNang.Add(new cChucNang() { ID = 10021, MoTa = "Điểm danh Nhân viên" });
			lstChucNang.Add(new cChucNang() { ID = 10031, MoTa = "Chấm công tay cho Quản lý" });

			lstChucNang.Add(new cChucNang() { ID = 20011, MoTa = "Khai báo vắng cho Nhân viên" });

			lstChucNang.Add(new cChucNang() { ID = 30011, MoTa = "Sửa giờ hàng loạt" });
			lstChucNang.Add(new cChucNang() { ID = 30012, MoTa = "Xem lịch sử thao tác" });
			lstChucNang.Add(new cChucNang() { ID = 30013, MoTa = "Quản lý nhiệm vụ của nhân viên" });
			lstChucNang.Add(new cChucNang() { ID = 30014, MoTa = "Xem thống kê công, PC, phép theo nhiệm vụ" });
			lstChucNang.Add(new cChucNang() { ID = 30015, MoTa = "Xem danh sách nhiệm vụ" });

			lstChucNang.Add(new cChucNang() { ID = 40011, MoTa = "Quản lý Nhân viên" });

			lstChucNang.Add(new cChucNang() { ID = 50011, MoTa = "Kết lương và huỷ kết lương tháng" });

			//lstChucNang.Add(new cChucNang() { ID = 60011, MoTa = "Đổi mật khẩu tài khoản" });// xem [2703_1]
			lstChucNang.Add(new cChucNang() { ID = 70011, MoTa = "Phân quyền" });
			lstChucNang.Add(new cChucNang() { ID = 70012, MoTa = "Cài đặt thông số" });
			lstChucNang.Add(new cChucNang() { ID = 70013, MoTa = "Tạo tài khoản đăng nhập" });

			return lstChucNang;


		}
	}
}
