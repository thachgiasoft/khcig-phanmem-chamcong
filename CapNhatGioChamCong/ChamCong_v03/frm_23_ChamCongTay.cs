﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ChamCong_v03.BUS;
using ChamCong_v03.DAO;
using ChamCong_v03.DTO;
using ChamCong_v03.Properties;
using log4net;

namespace ChamCong_v03 {
	public partial class frm_23_ChamCongTay : Form {
		public readonly ILog lg = LogManager.GetLogger("frm_23_ChamCongTay");

		public List<int> m_listIDPhongBan { get; set; }
		public List<cCaAbs> m_DSCa;
		public List<cUserInfo> m_DSNV = new List<cUserInfo>();
		public DataTable m_Bang_DSNV;
		public DataTable TaoBang_DSNV() {
			var kq = XL.TaoCauTrucDataTable(
				new[] { "check", "cUserInfo", "UserEnrollNumber", "UserFullCode", "UserFullName", "SchID", "SchName", "TitleName", "IDD_1", "Description_1", "HeSoLuongCB", "HeSoLuongSP", "HSBHCongThem" },
				new[] { typeof(bool), typeof(cUserInfo), typeof(int), typeof(string), typeof(string), typeof(int), typeof(string), typeof(string), typeof(int), typeof(string), typeof(double), typeof(double), typeof(double) });
			return kq;
		}

		public frm_23_ChamCongTay() {
			InitializeComponent();

			m_listIDPhongBan = new List<int>();
			m_DSNV = new List<cUserInfo>();
			dgrdDSNVTrgPhg.AutoGenerateColumns = false;
			m_Bang_DSNV = TaoBang_DSNV();
			DataView dataView = new DataView(m_Bang_DSNV);
			dgrdDSNVTrgPhg.DataSource = dataView;

			DateTime today = DateTime.Today;
			dtpNgay.Value = new DateTime(today.Year, today.Month, today.Day);
			dtpBDLam.Value = new DateTime(today.Year, today.Month, today.Day);
			dtpKTLam.Value = new DateTime(today.Year, today.Month, today.Day);

			XL2.VeCheckBox_CheckAll(dgrdDSNVTrgPhg, checkAll_GridDSNV, checkAll_CheckedChanged, new Point(7, 3));
		}

		#region load treeview new
		public TreeView loadTreePhgBan(TreeView tvDSPhongBan, DataTable pDataTable) {
			if (pDataTable.Rows.Count > 0) {
				foreach (var dataRow in pDataTable.Select("RelationID = 0", "ViTri asc")) {
					var ParentNode = new TreeNode { Text = dataRow["Description"].ToString(), Tag = (int)dataRow["ID"] };
					tvDSPhongBan.Nodes.Add(ParentNode);
					loadTreeSubNode(ref ParentNode, (int)(dataRow["ID"]), pDataTable);
				}
			}
			return tvDSPhongBan;
		}

		private void loadTreeSubNode(ref TreeNode ParentNode, int ParentId, DataTable dtMenu) {
			var childs = dtMenu.Select("RelationID = " + ParentId, "ViTri asc");
			foreach (var dRow in childs) {
				var child = new TreeNode { Text = dRow["Description"].ToString(), Tag = (int)dRow["ID"], ToolTipText = dRow["Description"].ToString() };
				ParentNode.Nodes.Add(child);
				//Recursion Call
				loadTreeSubNode(ref child, (int)dRow["ID"], dtMenu);
			}
		}

		private void GetIDLeafNodeExceptParent(TreeNode root, List<int> listID) {
			if (root == null) return;

			listID.Add((int)root.Tag);

			if (root.Nodes.Count > 0) {
				foreach (TreeNode node in root.Nodes) {
					GetIDLeafNodeExceptParent(node, listID);
				}
			}
			// xuốn đến đây tương đương root.Nodes.Count== 0; return
		}

		private void treePhongBan_AfterSelect(object sender, TreeViewEventArgs e) {

			m_listIDPhongBan.Clear();
			if (e.Node.FirstNode != null) GetIDLeafNodeExceptParent(e.Node, m_listIDPhongBan);
			else m_listIDPhongBan.Add((int)e.Node.Tag);
			e.Node.Expand();

			if (SqlDataAccessHelper.TestConnection(SqlDataAccessHelper.ConnectionString) == false) {
				AutoClosingMessageBox.Show("Mất kết nối với CSDL. Vui lòng thử lại sau.", "Lỗi", 4000);
				this.Close();
				return;
			}

			var table = DAL.LayDSNV(m_listIDPhongBan.ToArray());
			if (table.Rows.Count == 0) return;
			m_DSNV.Clear();
			XL.KhoiTaoDSNV(m_DSNV, table);
			m_Bang_DSNV.Rows.Clear();
			XL.TaoTableDSNV(m_DSNV, m_Bang_DSNV);
			var dataView = dgrdDSNVTrgPhg.DataSource as DataView;
			var Source = new AutoCompleteStringCollection();
			Source.AddRange((from nv in m_DSNV select nv.TenNV.ToUpperInvariant()).ToArray());
			tbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
			tbSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			tbSearch.AutoCompleteCustomSource = Source;
			dataView.RowFilter = string.Empty;

			checkAll_GridDSNV.Checked = false;
		}

		#endregion
		#region vẽ check box check all và xử lý sự kiện
		private readonly CheckBox checkAll_GridDSNV = new CheckBox();

		private void checkAll_CheckedChanged(object sender, EventArgs e) {
			//1. xác định datagrid nào đang check all
			DataGridView tempGrid = dgrdDSNVTrgPhg;

			// 2. kiểm tra nếu ko có dòng dữ liệu nào thì thoát
			if (tempGrid.Rows.Count == 0) return;

			//3. có dữ liệu, duyệt qua hết và gán giá trị check (or uncheck), sau đó endEDIT lại lưới để dòng đầu tiên có giá trị
			var tmpCheckAll = ((CheckBox)sender).Checked;

			tempGrid.BeginEdit(true);
			var dt = tempGrid.DataSource as DataView;

			if (dt != null && dt.Count != 0) {
				foreach (DataRowView row in dt) {
					row["check"] = tmpCheckAll;
				}
			}

			tempGrid.EndEdit();
			tempGrid.Update();
			tempGrid.RefreshEdit();
		}

		#endregion

		private void btnThoat_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnThucHien_Click(object sender, EventArgs e) {
			if (SqlDataAccessHelper.TestConnection(SqlDataAccessHelper.ConnectionString) == false) {
				AutoClosingMessageBox.Show("Mất kết nối với CSDL. Vui lòng thử lại sau.", "Lỗi", 2000);
				return;
			}

			// kiểm tra chọn ca làm việc chưa? chưa thì báo
			cCaAbs ca = cbCa.SelectedItem as cCaAbs;
			if (ca == null || cbCa.SelectedIndex == 0) {
				AutoClosingMessageBox.Show("Bạn chưa chọn ca làm việc.", "Thông báo", 1500);
				return;
			}

			//đã chọn ca làm việc
			var ngay = dtpNgay.Value.Date;
			TimeSpan timespanBD = dtpBDLam.Value.TimeOfDay;
			TimeSpan timeSpanKT = dtpKTLam.Value.TimeOfDay;
			var timeBD = ngay.Add(timespanBD);
			var timeKT = ngay.Add(timeSpanKT);
			if (timespanBD > timeSpanKT) timeKT = timeKT.AddDays(1d);

			var sophutOT = (checkXNLamThem.Checked && numSoPhutOT.Value > 0) ? (int)numSoPhutOT.Value : 0;
			var TinhPCTC = (checkTinhPC150.Checked);
			var TreSomTinhCV = checkTreSomTinhCV.Checked;
			var giolam = TimeSpan.Zero;
			var Cong = 0d;
			var PhuCap = 0d;

			if (ca.QuaDem && timespanBD < timeSpanKT && timespanBD < XL2._04h30) {
				timeBD = timeBD.AddDays(1d);
				timeKT = timeKT.AddDays(1d);
			}
			if (TinhToan(ngay, ca.ID, ca.WorkingTimeTS, ca.Workingday, ca.LunchMin, ngay.Add(ca.OnnTS), ngay.Add(ca.OffTS), ngay.Add(ca.chophepTreTS), ngay.Add(ca.chophepSomTS), 
				timeBD, timeKT, sophutOT, TinhPCTC, out giolam, out Cong, out PhuCap) == false)
			{
				tbGioLam.Text = giolam.TotalHours.ToString("#0.##");
				tbCong.Text = Cong.ToString("0.0#");
				tbPC.Text = PhuCap.ToString("0.0#");
				return;
			}

			#region hỏi lại trước khi thực hiện

			if (
				MessageBox.Show(
					"Bạn muốn thêm các giờ chấm công tay cho các nhân viên?\nVui lòng kiểm tra kỹ thời gian nhập để không làm sai lệch công của nhân viên.",
					Resources.capXacNhan, MessageBoxButtons.YesNo) == DialogResult.No) {
				return;
			}

			#endregion


			// kiểm tra chọn NV chưa, chưa thì báo
			DataView tableCheckNV = dgrdDSNVTrgPhg.DataSource as DataView;
			if (tableCheckNV == null) return;
			DataRow[] arrRows = tableCheckNV.Table.Select("check = true", "UserEnrollNumber asc");
			if (arrRows.Length == 0) {
				AutoClosingMessageBox.Show("Bạn chưa chọn nhân viên.", "Thông báo", 1500);
				return;
			}

			// đã chọn NV, lấy ds mã CC đã chọn
			string lydo = (cbLyDo.SelectedItem != null) ? cbLyDo.SelectedItem.ToString() : cbLyDo.SelectedText;
			string ghichu = tbGhiChu.Text;

			bool flag = true;

			try {
				foreach (DataRow row in arrRows) {
					//dsNVcheck.Add((int)row["UserEnrollNumber"]);
					int iUserEnrollNumber = (int)row["UserEnrollNumber"];
					if (ca.ID == int.MinValue)
						XL.TaoCaTuDo((cCaTuDo)ca, timeBD, XL2._08gio, XL2.ChoPhepTre, XL2.ChoPhepSom, XL2.LamThemAfterOT, 1f, "8");
					else if (ca.ID == int.MinValue + 1)
						XL.TaoCaTuDo((cCaTuDo)ca, timeBD, XL2._12gio, XL2.ChoPhepTre, XL2.ChoPhepSom, XL2.LamThemAfterOT, 1.5f, "D");

					if (checkXNLamThem.Checked || TinhPCTC || TreSomTinhCV) //1.có XN làm thêm --> thêm giờ XN,  2.không xác nhận làm thêm thì thêm giờ A
                    {
						var nv = new cUserInfo { MaCC = iUserEnrollNumber, NgayCongBD_Bef2D = ngay.Date.AddDays(-2d), NgayCongKT_Aft2D = ngay.Date.AddDays(2d) };
						var chkinn = new cChkInn_A { Time = timeBD, Type = "I", MachineNo = 21, Source = "PC", PhucHoi = new cPhucHoi { Them = true, IDGioGoc = -1, Xoaa = false } };

						var chkout = new cChkOut_A { Time = timeKT, Type = "O", MachineNo = 22, Source = "PC", PhucHoi = new cPhucHoi { Them = true, IDGioGoc = -1, Xoaa = false } };
						var cio_a = new cChkInOut_A {
							Vao = chkinn,
							Raa = chkout, 
							HaveINOUT = 1,
							ThuocCa = ca,
							TimeDaiDien = chkinn.Time,
							ThuocNgayCong = XL.ThuocNgayCong(chkinn.Time),
							TD = new ThoiDiem()
						};
						if (cio_a.ThuocNgayCong <= XL2.ThangKetCong && XL2.ThangKetCong != DateTime.MinValue) continue; //tbd temp patch

						nv.DS_CIO_A.Add(cio_a);
						XL.ThemGioChoNV(chkinn, nv, XL2.currUserID, lydo, ghichu);
						XL.ThemGioChoNV(chkout, nv, XL2.currUserID, lydo, ghichu);
						if (ca.TachCa)
							XL.XacNhanCoTachCa(nv, cio_a, ca, sophutOT, TinhPCTC, TreSomTinhCV);
						else
							XL.XacNhanKoTachCa(nv, cio_a, ca, sophutOT, TinhPCTC, TreSomTinhCV);
					}
					else {//2.không xác nhận làm thêm thì thêm giờ A
						if (timeBD.Date <= XL2.ThangKetCong && XL2.ThangKetCong != DateTime.MinValue) continue; //tbd temp patch

						var nv = new cUserInfo { MaCC = iUserEnrollNumber, NgayCongBD_Bef2D = ngay.Date.AddDays(-2d), NgayCongKT_Aft2D = ngay.Date.AddDays(2d) };
						XL.ThemGioChoNV(new cChkInn_A { Time = timeBD, Type = "I", MachineNo = 21, Source = "PC", PhucHoi = new cPhucHoi { Them = true, IDGioGoc = -1, Xoaa = false } }, new cUserInfo { MaCC = iUserEnrollNumber }, XL2.currUserID, lydo, ghichu);
						XL.ThemGioChoNV(new cChkOut_A { Time = timeKT, Type = "O", MachineNo = 22, Source = "PC", PhucHoi = new cPhucHoi { Them = true, IDGioGoc = -1, Xoaa = false } }, new cUserInfo { MaCC = iUserEnrollNumber }, XL2.currUserID, lydo, ghichu);
						XL.CheckTinhPC50(nv, (timeBD.TimeOfDay < XL2._04h30 ? timeBD.Date.AddDays(-1) : timeBD.Date), TinhPCTC);
					}

				}
			} catch (Exception exception) {
				lg.Error("", exception);

			}
			if (flag) {
				AutoClosingMessageBox.Show("Thêm giờ chấm công tay cho các nhân viên thành công.", "Thông báo", 2000);
			}
		}

		private void frm_ChamCongTay_Load(object sender, EventArgs e) {
			if (SqlDataAccessHelper.TestConnection(SqlDataAccessHelper.ConnectionString) == false) {
				AutoClosingMessageBox.Show("Mất kết nối với CSDL. Vui lòng thử lại sau.", "Lỗi", 2000);
				this.Close();
				return;
			}

			dtpBDLam.ValueChanged += dtp_ValueChanged;
			dtpKTLam.ValueChanged += dtp_ValueChanged;
			dtpNgay.ValueChanged += dtpNgay_ValueChanged;
			m_DSCa = new List<cCaAbs>(XL.DSCa);
			cCaTuDo tmp = new cCaTuDo { ID = 0, Code = "--" };
			cCaTuDo ca8tieng = new cCaTuDo { ID = int.MinValue, Code = "Ca8h", LunchMin = TimeSpan.Zero, WorkingTimeTS = XL2._08gio, Workingday = 1f,
				AfterOTMin = XL2.LamThemAfterOT};
			cCaTuDo cadai = new cCaTuDo { ID = int.MinValue + 1, Code = "CaDài 12h", LunchMin = TimeSpan.Zero, WorkingTimeTS = XL2._12gio, Workingday = 1.5f,
				AfterOTMin = XL2.LamThemAfterOT};
			m_DSCa.Insert(0, cadai);
			m_DSCa.Insert(0, ca8tieng);
			m_DSCa.Insert(0, tmp);

			cbCa.ValueMember = "ID";
			cbCa.DisplayMember = "Code";
			cbCa.DataSource = m_DSCa;
			cbCa.SelectionChangeCommitted += cbCa_SelectionChangeCommitted;
			tbGioLam.TextChanged += tbGioLam_TextChanged;


			DataTable tablePhong = DAL.LayDSPhong(XL2.currUserID);
			if (tablePhong.Rows.Count == 0) {
				AutoClosingMessageBox.Show("Bạn chưa được phân quyền thao tác.", "Thông báo", 2000);
				return;
			}
			//2. lấy dữ liệu phòng ban được phép thao tác  và load treePhongBan : xoá dữ liệu trước và load
			treePhongBan.Nodes.Clear();
			loadTreePhgBan(treePhongBan, tablePhong);

			// đăng ký sự kiện cho tree và chọn topNode
			treePhongBan.AfterSelect += treePhongBan_AfterSelect;
			treePhongBan.SelectedNode = treePhongBan.TopNode;

		}

		void tbGioLam_TextChanged(object sender, EventArgs e) {
/*			if (string.IsNullOrEmpty(tbGioLam.Text) || tbGioLam.Text == "0") {
				tbCong.Text = "0";
				return;
			}
			//int cong = int.Parse(tbGioLam.Text);
			cCaAbs ca = cbCa.SelectedItem as cCaAbs;
			if (ca == null) {
				AutoClosingMessageBox.Show("ca null", "", 1000);
				return;
			}
			TimeSpan sophutlamthem = new TimeSpan(0, (int)numSoPhutOT.Value, 0);
			Double giolam = (string.IsNullOrEmpty(tbGioLam.Text)) ? 0d : Double.Parse(tbGioLam.Text);
			giolam = giolam + sophutlamthem.TotalHours;
			Double cong = 0d;

			if (ca.ID == 0 || ca.ID == int.MinValue || ca.ID == int.MinValue + 1) cong = giolam / 8d;
			else {
				cong = ((giolam) / ca.WorkingTimeTS.TotalHours) * ca.Workingday;
			}
			cong = Math.Round(cong, 2);
			tbCong.Text = cong.ToString("#0.0#");// */
		}

		void cbCa_SelectionChangeCommitted(object sender, EventArgs e) {
			cCaAbs ca = (cbCa.SelectedItem) as cCaAbs;
			if (ca == null) {
				AutoClosingMessageBox.Show("ca null", "", 1000);
				return;
			}
			DateTime ngay = dtpNgay.Value.Date;
			if (ca.ID == 0 || ca.ID == int.MinValue || ca.ID == int.MinValue + 1) {
				dtpBDLam.Value = new DateTime(ngay.Year, ngay.Month, ngay.Day, 0, 0, 0);
				dtpKTLam.Value = new DateTime(ngay.Year, ngay.Month, ngay.Day, 0, 0, 0);
				dtpBDLam.Update();
				dtpKTLam.Update();
				return;
			}

			// chọn ca 1, 2 ,....
			DateTime timeBD = ngay.Add(ca.OnnTS);
			DateTime timeKT = ngay.Add(ca.OffTS);
			dtpBDLam.Value = timeBD;
			dtpKTLam.Value = timeKT;

		}

		void dtpNgay_ValueChanged(object sender, EventArgs e) {
			DateTime ngay = dtpNgay.Value;
			dtpBDLam.Value = new DateTime(ngay.Year, ngay.Month, ngay.Day, 0, 0, 0);
			dtpKTLam.Value = new DateTime(ngay.Year, ngay.Month, ngay.Day, 0, 0, 0);
			dtpBDLam.Update();
			dtpKTLam.Update();
		}

		void dtp_ValueChanged(object sender, EventArgs e)
		{
			var ngay = dtpNgay.Value;
			TimeSpan timespanBD = dtpBDLam.Value.TimeOfDay;
			TimeSpan timeSpanKT = dtpKTLam.Value.TimeOfDay;
			var timeBD = ngay.Add(timespanBD);
			var timeKT = ngay.Add(timeSpanKT);
			if (timespanBD > timeSpanKT) timeKT = timeKT.AddDays(1d);

//			DateTime timeBD = dtpBDLam.Value;
//			DateTime timeKT = dtpKTLam.Value;
			TimeSpan tongGioThuc = timeKT - timeBD;
			if (tongGioThuc < XL2._30phut || tongGioThuc > XL2._24h00) {
				tongGioThuc = TimeSpan.Zero;
			}
			tbTongGio.Text = tongGioThuc.TotalHours.ToString("#0.##");
		}

		public bool TinhToan(DateTime ngay, int ShiftID, TimeSpan ShiftWorkingTime, double ShiftWorkingDay, TimeSpan LunchMin,
			DateTime ThoiDiem_onnDuty, DateTime ThoiDiem_offDuty, DateTime ThoiDiem_ChoPhepTre, DateTime ThoiDiem_ChoPhepSom,
			DateTime timeBD, DateTime timeKT, int sophutOT, bool tinhPCTC,
			out TimeSpan tongGioLam, out double cong, out double phucap) {
			var tongGioThuc = TimeSpan.Zero;
			tongGioLam = TimeSpan.Zero;
			cong = 0f;
			phucap = 0f;

			tongGioThuc = timeKT - timeBD;
			if (tongGioThuc < XL2._30phut || tongGioThuc > XL2._24h00) {
				MessageBox.Show("Thời gian vào ra chưa hợp lệ. Vui lòng kiểm tra lại.");
				return false;
			}
			sophutOT = (checkXNLamThem.Checked && numSoPhutOT.Value > 0) ? (int)numSoPhutOT.Value : 0;
			if (ShiftID == int.MinValue) {
				ThoiDiem_onnDuty = timeBD;
				ThoiDiem_offDuty = timeBD.Add(XL2._08gio);
				ThoiDiem_ChoPhepTre = ThoiDiem_onnDuty.Add(XL2.ChoPhepTre);
				ThoiDiem_ChoPhepSom = ThoiDiem_offDuty.Subtract(XL2.ChoPhepSom);
			}
			if (ShiftID == int.MinValue + 1) {
				ThoiDiem_onnDuty = timeBD;
				ThoiDiem_offDuty = timeBD.Add(XL2._12gio);
				ThoiDiem_ChoPhepTre = ThoiDiem_onnDuty.Add(XL2.ChoPhepTre);
				ThoiDiem_ChoPhepSom = ThoiDiem_offDuty.Subtract(XL2.ChoPhepSom);
			}
			if (ThoiDiem_offDuty < timeBD || timeKT < ThoiDiem_onnDuty) {
				MessageBox.Show("Thời gian vào ra chưa hợp lệ. Vui lòng kiểm tra lại.");
				return false;
			}
			var ra_coOT = ThoiDiem_offDuty.Add(new TimeSpan(0, sophutOT, 0));
			if (timeKT < ra_coOT && sophutOT > 0) {
				MessageBox.Show("Giờ ra chưa được cộng thêm giờ làm thêm. Vui lòng kiểm tra lại.");
				return false;
			}

			var vaolam = DateTime.MinValue;
			var raalam = DateTime.MinValue;
			var raalam_CoOT = DateTime.MinValue;
			var vaotre = TimeSpan.Zero;
			var raasom = TimeSpan.Zero;
			XL.Vao(timeBD, ThoiDiem_onnDuty, ThoiDiem_ChoPhepTre, out vaolam, out vaotre);
			XL.Raa(timeKT, ThoiDiem_offDuty, ThoiDiem_ChoPhepSom, out raalam, out raasom);
			XL.LamThem(raalam, new TimeSpan(0, sophutOT, 0), out raalam_CoOT);
			tongGioLam = raalam_CoOT - vaolam - LunchMin;
			cong = (tongGioLam.TotalHours / ShiftWorkingTime.TotalHours) * ShiftWorkingDay;
			phucap = (tinhPCTC) ? ((tongGioLam > XL2._08gio) ? ((tongGioLam - XL2._08gio).TotalHours / 8d) * (XL2.PC50 / 100d) : 0d)
								: 0f;

			return true;
			}

		private void btnTim_Click(object sender, EventArgs e) {
			if (dgrdDSNVTrgPhg.DataSource == null) return;

			var searchStr1 = tbSearch.Text;
			var searchStr = string.Format("UserFullName like '%{0}%' or UserFullCode like '%{0}%'", searchStr1);
			var dataView = dgrdDSNVTrgPhg.DataSource as DataView;
			dataView.RowFilter = searchStr;


		}

		private void linkHienThiTatCaNV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			var dataView = dgrdDSNVTrgPhg.DataSource as DataView;
			dataView.RowFilter = string.Empty;

		}

		private void linkTinhLaiCong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			var ngay = dtpNgay.Value;
			TimeSpan timespanBD = dtpBDLam.Value.TimeOfDay;
			TimeSpan timeSpanKT = dtpKTLam.Value.TimeOfDay;
			var timeBD = ngay.Add(timespanBD);
			var timeKT = ngay.Add(timeSpanKT);
			if (timespanBD > timeSpanKT) timeKT = timeKT.AddDays(1d);

			cCaAbs ca = cbCa.SelectedItem as cCaAbs;
			if (ca == null) {
				AutoClosingMessageBox.Show("ca null", "", 1000);
				return;
			}

			var sophutOT = (checkXNLamThem.Checked && numSoPhutOT.Value > 0) ? (int)numSoPhutOT.Value : 0;
			var tinhPCTC = (checkTinhPC150.Checked);
			var tongGioLam = TimeSpan.Zero;
			var Cong = 0d;
			var Phucap = 0d;
			if (ca.QuaDem && timespanBD < timeSpanKT && timespanBD < XL2._04h30)
			{
				timeBD = timeBD.AddDays(1d);
				timeKT = timeKT.AddDays(1d);
			}
			TinhToan(ngay, ca.ID, ca.WorkingTimeTS, ca.Workingday, ca.LunchMin,
				ngay.Add(ca.OnnTS), ngay.Add(ca.OffTS), ngay.Add(ca.chophepTreTS), ngay.Add(ca.chophepSomTS),
				timeBD, timeKT, sophutOT, tinhPCTC, out tongGioLam, out Cong, out Phucap);
			tbGioLam.Text = tongGioLam.TotalHours.ToString("#0.##");
			tbCong.Text = Cong.ToString("0.0#");
			tbPC.Text = Phucap.ToString("0.0#");

		}

		private void toolTip1_Draw(object sender, DrawToolTipEventArgs e) {

		}

		private void toolTip1_Popup(object sender, PopupEventArgs e) {

		}
	}
}
