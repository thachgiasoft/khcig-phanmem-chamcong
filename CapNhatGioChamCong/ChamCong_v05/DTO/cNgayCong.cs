﻿using System;
using System.Collections.Generic;
using System.Linq;
using ChamCong_v05.Helper;
using ChamCong_v05.Properties;

namespace ChamCong_v05.DTO {
	public class cNgayCong {
		public DateTime Ngay;
		public List<cCheckInOut> DSVaoRa = new List<cCheckInOut>();
		public List<cLoaiVang> DSVang = new List<cLoaiVang>();
		public cNgayCong prev;
		public cNgayCong next;

		public structThoiGianTheoNgayCong TG5;
		public structCong Cong5;
		public PhuCap PhuCaps;
		public bool QuaDem;
		public TrangThaiDiemDanh TrangThaiDiemDanh;

		#region v4

		public ThoiGian TG = new ThoiGian();
		public float TongCong;
		public float TongNgayLV; //ver4.0.0.1
		public bool TinhPC50;
		public bool TinhPCDB;
		public int LoaiPCDB;

		#endregion


		public override string ToString() {
			var temp = Ngay.ToString("d/M") + "; " + "; " + "; TongLam: " + TG.GioLamViec5.TotalHours.ToString("##.##") + "; LamDem" +
				   TG.LamBanDem.TotalHours.ToString("#0.##") + "; Cong: " + TongCong.ToString("#0.##") + "; PC: " + PhuCaps._TongPC.ToString("#0.##") + "\n";
			if (DSVaoRa != null) {
				temp = DSVaoRa.Aggregate(temp, (current, @out) => current + "; I:" + ((@out.Vao != null) ? @out.Vao.Time.ToString("H:mm") : "----") + "; O:" + ((@out.Raa != null) ? @out.Raa.Time.ToString("H:mm") : "----") + "\n");
			}
			return temp;
		}


		public void XuatChuoiVang(ref string temp) {
			temp += DSVang.Aggregate(string.Empty, (current, loaiVang) => current + (loaiVang.LayKyHieu() + ";"));
		}
		public void XuatChuoiKyHieuChamCong(ref string temp) {
			temp = string.Empty;
			//xuất theo format <chuỗi ký hiệu ca> <chuỗi ký hiệu vắng> <chuỗi ký hiệu phụ cấp>
			foreach (var CIO in DSVaoRa) {
				if (CIO.HaveINOUT < 0) continue;
				temp += (temp == string.Empty) ? CIO.ThuocCa.KyHieuCC : ", " + CIO.ThuocCa.KyHieuCC;
			}
			foreach (cLoaiVang vang in DSVang)
				temp = temp + ((temp == string.Empty) ? vang.LayKyHieu() : ", " + vang.LayKyHieu());

			//có đi làm (tức có ký hiệu chấm công mới có phụ cấp nên luôn là dấu , trước
			if (PhuCaps._100_LVNN_Ngay > 0f) temp += ", (x2)";
			if (PhuCaps._150_LVNN_Dem > 0f) temp += ", (x2đ)";
			if (PhuCaps._200_LeTet_Ngay > 0f) temp += ", (x3)";
			if (PhuCaps._250_LeTet_Dem > 0f) temp += ", (x3đ)";
			if (PhuCaps._Cus > 0f) temp += ", (xYC)";
			if (PhuCaps._50_TC > 0f) temp += ", (TC)";
			if (PhuCaps._100_TCC3 > 0f) temp += ", (T3)";
		}
		public void XuatChuoiKyHieuPhuCap_Vang(ref string temp) {
			temp = string.Empty;
			if (DSVang != null && DSVang.Count == 0)
				foreach (cLoaiVang vang in DSVang)
					temp = temp + ((temp == string.Empty) ? vang.LayKyHieu() : ", " + vang.LayKyHieu());
			if (PhuCaps._30_dem > 0f) temp += "; (C3)";
			if (TinhPCDB) {
				if (PhuCaps._100_LVNN_Ngay > 0f) temp += "; (x2)";
				if (PhuCaps._150_LVNN_Dem > 0f) temp += "; (x2đ)";
				if (PhuCaps._200_LeTet_Ngay > 0f) temp += "; (x3)";
				if (PhuCaps._250_LeTet_Dem > 0f) temp += "; (x3đ)";
				if (PhuCaps._Cus > 0f) temp += "; (xYC)";
			}
			else if (TinhPC50) {
				if (PhuCaps._50_TC > 0f) temp += "; (TC)";
				if (PhuCaps._100_TCC3 > 0f) temp += "; (T3)";
			}
		}

		public string CIOs_CodeComp(string chuoiTruoc = null) {
			var kq = DSVaoRa.Aggregate(string.Empty, (current, CIO) => current + ((current == string.Empty) ? CIO.CIOCodeComp() : "; " + CIO.CIOCodeComp()));
			kq = (chuoiTruoc == null) ? kq : chuoiTruoc + "; " + kq;
			return kq;
		}
		public string CIOs_CodeFull(string chuoiTruoc = null) {
			var kq = DSVaoRa.Aggregate(string.Empty, (current, CIO) => current + ((current == string.Empty) ? CIO.CIOCodeFull() : "; " + CIO.CIOCodeFull()));
			kq = (chuoiTruoc == null) ? kq : chuoiTruoc + "; " + kq;
			return kq;
		}

		public string Absents_Code(string chuoiTruoc = null) {
			// xuất chuỗi ký hiệu vắng
			var kq = DSVang.Aggregate(string.Empty, (current, loaiVang) => current + ((current == string.Empty) ? loaiVang.LayKyHieu() : "; " + loaiVang.LayKyHieu()));
			kq = (chuoiTruoc == null) ? kq : chuoiTruoc + "; " + kq;
			return kq;
		}

		public string CIOs_Absents_Code_Comp(string chuoiTruoc = null) {
			// lấy chuỗi CIO Code và absent code
			var CIOs_Code = string.Empty;
			CIOs_Code += CIOs_CodeComp();
			var AbsentsCode = string.Empty;
			AbsentsCode += Absents_Code();
			var kq = string.Empty;

			// kết hợp theo format <cio code> <absentcode> <phu cap 50, 100>
			if (string.IsNullOrEmpty(CIOs_Code)) kq += AbsentsCode;
			else if (string.IsNullOrEmpty(AbsentsCode)) kq += CIOs_Code;
			else kq = (CIOs_Code + ";" + AbsentsCode);
			kq = (chuoiTruoc == null) ? kq : chuoiTruoc + ";" + kq;

			if (TinhPCDB) {
				if (PhuCaps._100_LVNN_Ngay > 0f) kq += ";(x2)";
				if (PhuCaps._150_LVNN_Dem > 0f) kq += ";(x2đ)";
				if (PhuCaps._200_LeTet_Ngay > 0f) kq += ";(x3)";
				if (PhuCaps._250_LeTet_Dem > 0f) kq += ";(x3đ)";
				if (PhuCaps._Cus > 0f) kq += ";(xYC)";
			}
			else if (TinhPC50) {
				if (PhuCaps._50_TC > 0f) kq += ";(TC)";
				if (PhuCaps._100_TCC3 > 0f) kq += ";(T3)";
			}
			return kq;
		}
		public string CIOs_Absents_Code_Full(string chuoiTruoc = null) {
			// lấy chuỗi CIO Code và absent code
			var CIOs_Code = string.Empty;
			CIOs_Code += CIOs_CodeFull();
			var AbsentsCode = string.Empty;
			AbsentsCode += Absents_Code();
			var kq = string.Empty;
			// kết hợp theo format <cio code> <absentcode> <phu cap 50, 100>
			if (string.IsNullOrEmpty(CIOs_Code)) kq += AbsentsCode;
			else if (string.IsNullOrEmpty(AbsentsCode)) kq += CIOs_Code;
			else kq = (CIOs_Code + ";" + AbsentsCode);
			kq = (chuoiTruoc == null) ? kq : chuoiTruoc + ";" + kq;
			if (TinhPC50 && PhuCaps._50_TC > 0f) kq += ";(TC)";
			if (TinhPCDB) {
				if (PhuCaps._100_LVNN_Ngay > 0f) kq += ";(x2)";
				if (PhuCaps._150_LVNN_Dem > 0f) kq += ";(x2đ)";
				if (PhuCaps._200_LeTet_Ngay > 0f) kq += ";(x3)";
				if (PhuCaps._250_LeTet_Dem > 0f) kq += ";(x3đ)";
				if (PhuCaps._Cus > 0f) kq += ";(xYC)";
			}
			else if (TinhPC50) {
				if (PhuCaps._50_TC > 0f) kq += ";(TC)";
				if (PhuCaps._100_TCC3 > 0f) kq += ";(T3)";
			}
			return kq;
		}


		public string ExportKyHieuPhuCap5() {
			if (this.TG5.TongGioLamViec == TimeSpan.Zero) return string.Empty;
			string kq = string.Empty;
			if (this.LoaiPCDB == (int)LoaiPhuCap.NgayThuong) {//chỉ có c3, tc, t3
				if (TG5.HuongPC_Dem > TimeSpan.Zero) kq += ";" + Resources.SymPhuCapDem;
				if (TG5.HuongPC_TangCuongNgay > TimeSpan.Zero) kq += ";" + Resources.SymPhuCapTangCuong;
				if (TG5.HuongPC_TangCuongDem > TimeSpan.Zero) kq += ";" + Resources.SymPhuCapTangCuongDem;
			}
			else if (this.LoaiPCDB == (int)LoaiPhuCap.NgayNghi) {// x2
				kq += ";" + Resources.SymPhuCapNgayNghi;
			}
			else if (this.LoaiPCDB == (int)LoaiPhuCap.NgayLe) {//x3
				kq += ";" + Resources.SymPhuCapNgayLe;
			}
			else if (this.LoaiPCDB == (int)LoaiPhuCap.TuyChinhNgayDem) kq += ";" + Resources.SymPhuCapTuyChinhNgayDem;
			else if (this.LoaiPCDB == (int)LoaiPhuCap.TuyChinhTatCa) kq += ";" + Resources.SymPhuCapTuyChinhTatCa;
			kq = kq.XoaKyTuPhanCachDauTien();
			return kq;
		}

		public string ExportKyHieuThuocCa5(bool ShowDSCa_KV_KR = false) {
			if (this.DSVaoRa == null || this.DSVaoRa.Count == 0) return string.Empty;

			string kq = string.Empty;
			kq = this.DSVaoRa.Aggregate(kq, (current, @out) => current + @out.ExportKyHieu5_1(ShowDSCa_KV_KR)); // out empty | ;ca1[-T]
			kq = kq.XoaKyTuPhanCachDauTien();
			return kq;
		}

		public string ExportKyHieuVang()
		{
			if (this.DSVang == null || this.DSVang.Count == 0) return string.Empty;

			string kq = string.Empty;
			kq = DSVang.Aggregate(string.Empty, (current, loaiVang) => current + ";" + loaiVang.LayKyHieu());
			kq = kq.XoaKyTuPhanCachDauTien();
			return kq;
		}

		public cNgayCong() { }

		/// <summary>
		/// Thứ Hai 03/04:\n vào 13:50:00 -> 16:00:00 ra
		/// </summary>
		/// <returns></returns>
		public string ExportString5()
		{
			string kq = Ngay.ToString("dddd dd/MM:");
			if (DSVaoRa == null) return kq;
			kq += DSVaoRa.Aggregate(string.Empty, (current, @out) => current + "\n" + @out.ExportKyHieu5_2());
			return kq;
		}
	}


	public class cLoaiVang {
		public string MaLV_Code;
		public float WorkingDay;
		public string MoTa;
		public DateTime Ngay;
		public string LayKyHieu() {
			var kq = string.Empty;
			if (Math.Abs(WorkingDay - 0f) < 0.01f) kq += string.Empty;
			else if (Math.Abs(WorkingDay - 0.5f) < 0.01f) kq += "N" + MaLV_Code;
			else if (Math.Abs(WorkingDay - 1f) < 0.01f) kq += MaLV_Code;
			return kq;
		}

		public cLoaiVang() {

		}
	}

	#region v4

	public struct structPCDB {
		public DateTime Ngay;
		public int LoaiPC;
		public bool Duyet;
		public int PCNgay;
		public int PCDem;

		public override string ToString() {
			return LoaiPC + "; " + PCNgay.ToString("##0.0#") + "; " + Ngay.ToString("d/M") + Duyet;
		}
	}

	public struct structPCTC {
		public DateTime Ngay;
		public bool TinhPC50;

		public override string ToString() {
			return TinhPC50 + "; " + Ngay.ToString("d/M");
		}

	}

	#endregion
}
