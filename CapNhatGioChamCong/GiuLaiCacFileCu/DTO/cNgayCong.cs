﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuLaiCacFileCu.DTO {
    public class cNgayCong {
        public DateTime NgayCong { get; set; }
        public List<cChk> DSCheck { get; set; }
        public List<cChkInOut> DSVaoRa { get; set; }
        public List<cLoaiVang> DSVang { get; set; }

        /// <summary>
        /// false nếu vắng mặt, true nếu có mặt, chỉ cần có check xem như có mặt
        /// </summary>
        public bool HasCheck { get; set; }
		public bool QuaDem { get; set; }

        public TimeSpan TongGioLam { get; set; }
        public TimeSpan TongGioThuc { get; set; }
        public TimeSpan TongGioLamDem { get; set; }
        public float	TongCong { get; set; } // tổng công = tổng công làm + tổng công khai báo
		//public float	TongCongLam { get; set; }
        public TimeSpan TongTre { get; set; }
        public TimeSpan TongSom { get; set; }
        public float TongPhuCap { get; set; }
        public float PhuCapDem { get; set; }
        public float PhuCapThem { get; set; }
		public bool TinhPC200 { get; set; }
		public bool TinhPC150 { get; set; }
        public override string ToString() {
            string temp = NgayCong.ToString("d/M") + "; " + ((HasCheck) ? "HasCheck" : "--") + "; " + "; TongLam: " + TongGioLam.TotalHours.ToString("##.##") + "; Thuc: " + TongGioThuc.TotalHours.ToString("##.##") + "; LamDem" +
                   TongGioLamDem.TotalHours.ToString("#0.##") + "; Cong: " + TongCong.ToString("#0.##") + "; PC: " + TongPhuCap.ToString("#0.##") + "; Tre: " + TongTre.TotalMinutes.ToString("####") + "; Som: " + TongSom.TotalMinutes.ToString("####") +
                   "\n";
            if (DSVaoRa != null) {
	            foreach (cChkInOut @out in DSVaoRa) 
					temp = temp + "; I:" + ((@out.Vao != null) ? @out.Vao.TimeStr.ToString("H:mm") : "----" )
						+ "; O:" + ((@out.Raa != null) ? @out.Raa.TimeStr.ToString("H:mm") : "----" ) + "\n";
            }
            return temp;
        }

        internal void them(cChkInOut tmpVaoRa1) {
            if (DSVaoRa == null) DSVaoRa = new List<cChkInOut>();
            DSVaoRa.Add(tmpVaoRa1);
            if (DSCheck == null) DSCheck = new List<cChk>();
            if (tmpVaoRa1.Vao != null) DSCheck.Add(tmpVaoRa1.Vao);
            if (tmpVaoRa1.Raa != null) DSCheck.Add(tmpVaoRa1.Raa);

        }
        public cNgayCong(){}
    }


    public class cLoaiVang {
        public string MaLV { get; set; }
        public float Cong { get; set; }
        public string MoTa { get; set; }
        public string KyHieu { get; set; }
        public DateTime Ngay { get; set; }
    }
}
