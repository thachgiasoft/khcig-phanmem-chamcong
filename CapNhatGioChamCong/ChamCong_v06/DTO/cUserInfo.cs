﻿using System;
using System.Collections.Generic;
using System.Data;
using ChamCong_v06.Helper;

namespace ChamCong_v06.DTO {
	public class cUserInfo
	{
		public string MaNV;
		public string TenNV;
		public int MaCC;
		public bool IsUserEnabled;
		public ID_Description ChucVu;
		public ID_Description LichTrinh;
		public ID_Description PhongBan_ID_Des;
		public cPhongBan PhongBan;


		public List<cNgayCong> DSNgayDaCC = new List<cNgayCong>();
		public cNhomCa NhomCa;
	}

/*
	public class cUserInfo {
		public string MaNV;
		public string TenNV;
		public int MaCC;
		public bool IsUserEnabled;
		public ID_Description ChucVu;
		//comment_ver5 public LoaiCongNhat LoaiCN;// mặc định là false, tức ko phải nv công nhật -->đó là nv chính thức
		//comment_ver5 //dưới csdl, nếu là nv chính thức thì check true => bool NVCongNhat = true nếu NVChinhThuc false, NVCongNhat = false nếu NVChinhThuc true
		//comment_ver5 public DateTime NgayBDCongnhat;
		//comment_ver5 public DateTime NgayKTCongnhat;
		public StartEnd NgayBD_KT_CongNhat;
		public cPhongBan PhongBan;

		public cShiftSchedule LichTrinhLV = new cShiftSchedule();
		public List<cCheck> DS_Check_A = new List<cCheck>();
		public List<cCheckInOut> DS_CIO_A = new List<cCheckInOut>();
		public List<cCheckInOut> DS_CIO_V = new List<cCheckInOut>();
		public List<cCheckInOut> DSVaoRa = new List<cCheckInOut>();
		public List<cLoaiVang> DSVang = new List<cLoaiVang>();
		public List<DataRow> DSXNPC5 = new List<DataRow>();

		#region v4

		public List<structPCTC> DSXNPhuCap50 = new List<structPCTC>();
		public List<structPCDB> DSXNPhuCapDB = new List<structPCDB>();

		#endregion

		public DateTime NgayCongBD_Bef2D;
		public DateTime NgayCongKT_Aft2D;
		//public TimeSpan StartNT;//ver 4.0.0.4
		//public TimeSpan EndddNT;//ver 4.0.0.4

		public HeSo HeSo;
		public ChiTietLuong chiTietLuong;
		public ThongKeCong_PC ThongKeThang;

		public override string ToString() {
			var temp = "MaNV:{0}; Ten:{1}; MaCC:{2}";
			return string.Format(temp, MaCC, TenNV, MaCC);
		}

		public cUserInfo() {
		}

	}

	public struct LCB {
		public double CongThucTe;
		public double CheDoNghi;
		public double CongCV;
		public double PhuCap; // tổng lương cơ bản theo phụ cấp

		// tổng lương theo công, chế độ,
		//private double CongCdNghi;
		// tổng lương theo công, chế độ, chờ việc
		//private double CongCdNghiCv;
		//tổng lương cơ bản theo công(bao gồm chế độ, chờ việc) và phụ cấp
		//private double TongCongCdCvPc;

		public double Cong_CDNghi {
			get { return CongThucTe + CheDoNghi; }
			//set { CongCdNghi = value; }
		}

		public double Cong_CDNghi_CV {
			get { return CongThucTe + CheDoNghi + CongCV; }
			//set { CongCdNghiCv = value; }
		}

		public double TongCong_CD_CV_PC {
			get { return CongThucTe + CheDoNghi + CongCV + PhuCap; }
			//set { TongCongCdCvPc = value; }
		}
	}
	public struct LSP {
		public double CongThucTe;
		public double CheDoNghi;
		public double PhuCap;

		//private double cong_CDNghi;//CongThucTe +CheDoNghi
		public double Cong_CDNghi {
			get { return CongThucTe + CheDoNghi; }
			//set { cong_CDNghi = value; }
		}


		//public double TongCong_CD_PC;// tổng lương sản phẩm theo công và phụ cấp (lương sản phẩm ko có chờ việc
		//private double tongCong_CD_PC;

		public double TongCong_CD_PC {
			get { return CongThucTe + CheDoNghi + PhuCap; }
			//set { tongCong_CD_PC = value; }
		}


	}

	public struct SPLamRa {
		public double CongThucTe;
		public double CheDoNghi;
		public double PhuCap;
		//private double CongCdNghi;

		public double Cong_CDNghi {
			get { return CongThucTe + CheDoNghi; }
			//set { CongCdNghi = value; }
		}
		//private double tongSPLamRa;

		public double TongSPLamRa {
			get { return CongThucTe + CheDoNghi + PhuCap; }
			//set { tongSPLamRa = value; }
		}

	}




	public struct ChiTietLuong {
		//-----lương cb, sp theo công, phụ cấp
		public LCB LCB_Theo;
		public LSP LSP_Theo;
		public SPLamRa SPLamRa_Theo;

		private double tongLuong_KoTinhCacLoaiPhuCap; //= LCB_Theo.Cong_CDNghi_CV + LSP_Theo.CongThucTe + LSP_Theo.CheDoNghi + LuongDieuChinh
		public double TongLuong_KoTinhCacLoaiPhuCap {
			get { return LCB_Theo.Cong_CDNghi_CV + LSP_Theo.CongThucTe + LSP_Theo.CheDoNghi + LuongDieuChinh; }
			set { tongLuong_KoTinhCacLoaiPhuCap = value; }
		}

		private double tongPhuCapLuong;//=LCB_Theo.PhuCap + LSP_Theo.PhuCap + BoiDuongQuaDem
		public double TongPhuCapLuong {
			get { return LCB_Theo.PhuCap + LSP_Theo.PhuCap + BoiDuongQuaDem; }
			set { tongPhuCapLuong = value; }
		}
		/*
				private double ;//
				public double 
				{
					get { return  ;}
					set {  = value;}
				}
		#1#
		private double tongLuong_NghiDinh205CP;//
		public double TongLuong_NghiDinh205CP {
			get { return LCB_Theo.Cong_CDNghi_CV + LCB_Theo.PhuCap; }
			set { tongLuong_NghiDinh205CP = value; }
		}

		//public double TongLuong_NghiDinh205CP;// = nv.chiTietLuong.LCB_Theo.Cong_CDNghi_CV + nv.chiTietLuong.LCB_Theo.PhuCap;

		public double LuongDieuChinh;
		public double BoiDuongQuaDem;
		public float MucDongBHXH;
		public KhauTru KhauTru;

		public double TienComTrua;
		public double TongLuong {
			get { return TongLuong_KoTinhCacLoaiPhuCap + TongPhuCapLuong; }//=nv.chiTietLuong.TongLuong_KoTinhCacLoaiPhuCap + nv.chiTietLuong.TongPhuCapLuong
			//set { tongLuong = value; }
		}
		//public double TongLuong;

		//public double ThucLanh;//= nv.chiTietLuong.TongLuong - nv.chiTietLuong.KhauTru.TongKhauTru;
		private double thucLanh;//
		public double ThucLanh {
			get { return TongLuong - KhauTru.TongKhauTru + TienComTrua; }//ver 4.0.0.4	thuc lanh = tong luong- tong khau tru + com trua
			set { thucLanh = value; }
		}

		//------lương công nhật
		public double CongNhat;


	}

	public struct ThongKeCong_PC {
		public float Cong_Congnhat;
		public float TongNgayLV;//ver4.0.0.1
		public float Cong;
		public int NgayQuaDem;
		public PhuCap PhuCaps;
		public float Le;
		public float Phep;
		public float CongCV; // công chờ việc bao gồm tự động tính và khai báo, trải qua 2 bước : +khai báo, sau đó tính tự động
		public float CongCV_KB;// công chờ việc được khai báo trước
		public float CongCV_Auto;// công chờ việc tự động tính theo công chuẩn
		public float CongCVTreSom;
		public float BHXH;
		public float H_CT_PT;
		public float PTDT;
		public float NghiRo;
	}



	public struct KhauTru {
		public double TamUng;
		public double BHXH;
		public double ThuChiKhac;
		public double TongKhauTru {
			get { return TamUng + BHXH + ThuChiKhac; }
		}
	}
*/
}
