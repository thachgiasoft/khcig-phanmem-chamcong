﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChamCong_v05.BUS;
using ChamCong_v05.Helper;
using ChamCong_v05.Properties;
using ChamCong_v05.DTO;

namespace ChamCong_v05.UI4._5 {
	public partial class fmXemCong4 : Form {
		public List<int> m_listCurrentIDPhg = new List<int>();

		public fmXemCong4() {
			InitializeComponent();
		}

		private void fmXemCong4_Load(object sender, EventArgs e) {
			#region kiểm tra kết nối csdl , nếu mất kết nối thì đóng
			if (SqlDataAccessHelper.TestConnection(SqlDataAccessHelper.ConnectionString) == false) {
				ACMessageBox.Show(Resources.Text_MatKetNoiCSDL, Resources.Caption_Loi, 4000);
				Close();
				return;
			}
			#endregion

			/* 1. load tree phòng ( datasource cho checkComboEdit chọn nv do hàm treeAfterselect tạo
			 * 2. 
			 * 3. set tháng khi load lần đầu
			 */
			XL.loadTreePhgBan(treePhongBan);
			treePhongBan.AfterSelect += treePhongBan_AfterSelect;

		}

		private void treePhongBan_AfterSelect(object sender, TreeViewEventArgs e) {
			#region mỗi lần chọn node thì lấy ID node hiện tại và tất cả node con

			m_listCurrentIDPhg.Clear();
			e.Node.Expand();
			TreeNode topnode = XL.TopNode(e.Node); //đưa về root để thực hiện từ trên xuống
			if (topnode != null) XL.GetIDNodeAndChildNode1(e.Node, ref m_listCurrentIDPhg); // chỉ lấy các phòng ban được phép, 
			else {
				var temp = ((DataRow)e.Node.Tag);
				if ((int)temp["IsYes"] == 1) m_listCurrentIDPhg.Add((int)temp["ID"]);
			}

			#endregion

			/* 1. clear select chọn nhân viên trước
			 * 2. load datasource cho check chọn nhân viên 
			 * 3. gán lại tên cho các column ngày
			 */
//			checkedComboBoxEdit1.Properties.Items.Clear();
			DataTable tableMaPhong = MyUtility.Array_To_DataTable("ArrUserIDD", m_listCurrentIDPhg);
			DataTable tableNhanVien = SqlDataAccessHelper.ExecSPQuery(SPName.UserInfo_DocDSNVThaoTac.ToString(), new SqlParameter("@ArrUserIDD", SqlDbType.Structured){Value = tableMaPhong});
			checkedDSNV.Properties.DataSource = tableNhanVien;
			checkedDSNV.Properties.DisplayMember = "DisplayItem";
			checkedDSNV.Properties.ValueMember = "UserEnrollNumber";

			for (int i = 3; i < 34; i++) // bắt đầu từ 3 vì 1 mã cc, 2 mã nv, 3 tên nv
			{
				dgrdTongHop.Columns[i].HeaderText = string.Empty;
			}
		}

		private void btnChamCong_Click(object sender, EventArgs e) {
			if (XL2.KiemtraKetnoiCSDL() == false) return;

			/* 1. lấy dsnv check, lấy tháng
			 * 
			 */
			string strChecked_ArrMaCC = checkedDSNV.EditValue.ToString();
			List<int> arrMaCC = new List<int>();
			strChecked_ArrMaCC.Split(new char[]{','}).ToList().ForEach(item=>arrMaCC.Add(int.Parse(item)));

			List<cUserInfo> listNhanVien = new List<cUserInfo>();
			DataTable tableDSNV = checkedDSNV.Properties.DataSource as DataTable;
			if (tableDSNV == null) return;
			foreach (int maCC in arrMaCC) {
				DataRow[] row = tableDSNV.Select("UserEnrollNumber=" + maCC);
				cUserInfo nhanvien = new cUserInfo{
					MaCC = (int)row[0]["UserEnrollNumber"],
					MaNV = row[0]["UserFullCode"].ToString(),
					TenNV = row[0]["UserFullName"].ToString(),
				};
				XL.GetLichTrinhNV(nhanvien, row[0]["SchID"] != DBNull.Value ? (int)row[0]["SchID"] : (int?)null);
				listNhanVien.Add(nhanvien);
			}
			DateTime ngaybd = MyUtility.FirstDayOfMonth(dateNavigator1.DateTime);
			DateTime ngaykt = MyUtility.LastDayOfMonth(ngaybd);

			XL.XemCongThoiGianChuaKetLuong(listNhanVien, ngaybd, ngaykt);
			DataTable table = tao();
			populatedata(listNhanVien, table);
			dataGridView1.DataSource = table;
		}

		private void populatedata(List<cUserInfo> dsnv, DataTable table) {
			foreach (var nhanvien in dsnv) {
				foreach(cNgayCong ngayCong in nhanvien.DSNgayCong){
				DataRow row = table.NewRow();
				row["UserEnrollNumber"] = nhanvien.MaCC ;
				row["UserFullCode"] = nhanvien.MaNV ;
				row["UserLastName"] = nhanvien.TenNV ;
					row["Ngay"] = ngayCong.Ngay ;
					row["Thu"] = ngayCong.Ngay ;
					row["GioThucTe5"] = ngayCong.TG5.GioThucTe5 ;
					row["TongGioLamViec5"] = ngayCong.TG5.TongGioLamViec5 ;
					row["TongGioLamNgay"] = ngayCong.TG5.TongGioLamNgay ;
					row["TongGioLamDem"] = ngayCong.TG5.TongGioLamDem ;
					row["TongGioTangCuong"] = ngayCong.TG5.TongGioTangCuong ;
					row["GioLamNgay_KoTC"] = ngayCong.TG5.GioLamNgay_KoTC ;
					row["HuongPC_TangCuongNgay"] = ngayCong.TG5.HuongPC_TangCuongNgay ;
					row["HuongPC_Dem"] = ngayCong.TG5.HuongPC_Dem ;
					row["HuongPC_TangCuongDem"] = ngayCong.TG5.HuongPC_TangCuongDem ;
					row["PCNgay5"] = ngayCong.PhuCaps.PCNgay5 ;
					row["PCTangCuongNgay5"] = ngayCong.PhuCaps.PCTangCuongNgay5 ;
					row["PCDem5"] = ngayCong.PhuCaps.PCDem5 ;
					row["PCTangCuongDem5"] = ngayCong.PhuCaps.PCTangCuongDem5 ;
					row["_TongPC"] = ngayCong.PhuCaps._TongPC ;
					row["LoaiPhuCap"] = ngayCong.PhuCaps.LoaiPhuCap ;
					table.Rows.Add(row);

				}

			}
		}

		public DataTable tao() { 
			DataTable table = new DataTable();
			table.Columns.Add("UserEnrollNumber", typeof(int));
			table.Columns.Add("UserFullCode", typeof(string));
			table.Columns.Add("UserLastName", typeof(string));
			table.Columns.Add("Ngay", typeof(DateTime));
			table.Columns.Add("Thu", typeof(DateTime));
			table.Columns.Add("GioThucTe5", typeof(TimeSpan));
			table.Columns.Add("TongGioLamViec5", typeof(TimeSpan));
			table.Columns.Add("TongGioLamNgay", typeof(TimeSpan));
			table.Columns.Add("TongGioLamDem", typeof(TimeSpan));
			table.Columns.Add("TongGioTangCuong", typeof(TimeSpan));
			table.Columns.Add("GioLamNgay_KoTC", typeof(TimeSpan));
			table.Columns.Add("HuongPC_TangCuongNgay", typeof(TimeSpan));
			table.Columns.Add("HuongPC_Dem", typeof(TimeSpan));
			table.Columns.Add("HuongPC_TangCuongDem", typeof(TimeSpan));
			table.Columns.Add("PCNgay5", typeof(float));
			table.Columns.Add("PCTangCuongNgay5", typeof(float));
			table.Columns.Add("PCDem5", typeof(float));
			table.Columns.Add("PCTangCuongDem5", typeof(float));
			table.Columns.Add("_TongPC", typeof(float));
			table.Columns.Add("LoaiPhuCap", typeof(int));
			//table.Columns.Add("", typeof(float));
			//table.Columns.Add("", typeof(float));
			//table.Columns.Add("", typeof());

			return table;
		}
	}
}
