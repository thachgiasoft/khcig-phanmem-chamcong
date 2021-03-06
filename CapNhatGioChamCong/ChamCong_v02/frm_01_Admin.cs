﻿ using System;
using System.Data;
using System.Windows.Forms;
using ChamCong_v02.BUS;
using ChamCong_v02.DAO;

namespace ChamCong_v02 {
    public partial class frm_01_Admin : Form {
        //1. mỗi lần thêm 1 chức năng gì phải update lại bên menuid mặc định của tài khoản
        public frm_01_Admin() {
            InitializeComponent();
        }

        private void btnChonCSDL_Click(object sender, EventArgs e) {
            frmKetNoiCSDL frm = new frmKetNoiCSDL();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e) {
            Application.Exit();
        }


        private void frmTaoTaiKhoan_Load(object sender, EventArgs e) {
            try {
                Load_dataGridNewUserAccount();
                Load_cbTaikhoanWE();

            } catch (Exception) {
                MessageBox.Show("Mất kết nối đến máy chủ. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK);
            }
        }


        private void Load_cbTaikhoanWE() {
            try {
                DataTable dataTable = SqlDataAccessHelper.ExecuteQueryString(
                        @"  select UserID, UserAccount from UserAccount 
						where UserAccount not in (select NewUserAccount.UserAccount from NewUserAccount)", null, null);
                cbTaikhoanWE.DisplayMember = "UserAccount";
                cbTaikhoanWE.ValueMember = "UserID";
                cbTaikhoanWE.DataSource = dataTable;
                tbPass1.Text = tbPass2.Text = string.Empty;
                if (dataTable == null || dataTable.Rows.Count == 0) btnTaoTK.Enabled = false;
            } catch (Exception exception) {
                throw exception;
            }
        }

        private void Load_dataGridNewUserAccount() {
            try {
                DataTable dataTable = SqlDataAccessHelper.ExecuteQueryString("Select UserID, UserAccount from NewUserAccount", null, null);
                dataGridTK.DataSource = dataTable;
            } catch (Exception exception) {
                throw exception;
            }

        }

        private void btnTaoTK_Click(object sender, EventArgs e) {
            if (tbPass1.Text != tbPass2.Text) {
                MessageBox.Show("Mật khẩu không khớp.");
                return;
            }
            if (tbPass1.Text == string.Empty || tbPass2.Text == string.Empty) {
                MessageBox.Show("Mật khẩu không được để trống.");
                return;
            }

	        string insertString = " insert into NewUserAccount(UserID, UserAccount, Password) values (@UserID, @UserAccount, @password) " +
	                              " insert into MenuPrivilege (UserID, MenuID, IsYes) values (@UserID, 10001, 0) " +
	                              " insert into MenuPrivilege (UserID, MenuID, IsYes) values (@UserID, 10002, 0) " +
	                              " insert into MenuPrivilege (UserID, MenuID, IsYes) values (@UserID, 20001, 0) " +
	                              " insert into MenuPrivilege (UserID, MenuID, IsYes) values (@UserID, 20002, 0) " +
	                              " insert into MenuPrivilege (UserID, MenuID, IsYes) values (@UserID, 20003, 0) " +
	                              " insert into MenuPrivilege (UserID, MenuID, IsYes) values (@UserID, 30001, 0) " +
	                              " insert into MenuPrivilege (UserID, MenuID, IsYes) values (@UserID, 30002, 0) " +
	                              " insert into MenuPrivilege (UserID, MenuID, IsYes) values (@UserID, 40001, 0) " +
	                              " insert into MenuPrivilege (UserID, MenuID, IsYes) values (@UserID, 40002, 0) " +
	                              " insert into MenuPrivilege (UserID, MenuID, IsYes) values (@UserID, 40003, 0) " +
	                              " insert into MenuPrivilege (UserID, MenuID, IsYes) values (@UserID, 60001, 0) ";

            int tempUserID = (int)cbTaikhoanWE.SelectedValue;

            string tempUserAccount = cbTaikhoanWE.SelectedItem.ToString();
            string tempPass = tbPass1.Text;
            string tempPassEncrypt = MyUtility.Mahoa(tempPass);
            try {
                int kq = SqlDataAccessHelper.ExecNoneQueryString(insertString
                                                                , new[] { "@UserID", "@UserAccount", "@password" }
                                                                , new object[] { tempUserID, tempUserAccount, tempPassEncrypt });
                if (kq != 0) AutoClosingMessageBox.Show("Thêm tài khoản thành công.", "Thông báo", 2000);
                else MessageBox.Show("Không thêm được tài khoản.", "Lỗi", MessageBoxButtons.OK);
                Load_dataGridNewUserAccount();
                Load_cbTaikhoanWE();

            } catch (Exception) {
                MessageBox.Show("Mất kết nối đến máy chủ. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK);
            }
        }



        private void btnReset_Click(object sender, EventArgs e) {
            if (tbPass1.Text != tbPass2.Text) {
                MessageBox.Show("Mật khẩu không khớp.");
                return;
            }
            if (tbPass1.Text == string.Empty || tbPass2.Text == string.Empty) {
                MessageBox.Show("Mật khẩu không được để trống.");
                return;
            }

            string tempTenTK = tbTenTaiKhoan.Text;
            string tempPass = tbPass1.Text;
            string tempPassEncrypt = MyUtility.Mahoa(tempPass);
            string updateString = @" update NewUserAccount set Password=@Password where UserAccount = @UserAccount ";
            int kq = SqlDataAccessHelper.ExecNoneQueryString(updateString, new[] { "@UserAccount", "@Password" }
                                                            , new object[] { tempTenTK, tempPassEncrypt });
            if (kq != 0) AutoClosingMessageBox.Show("Reset mật khẩu tài khoản thành công.", "Thông báo", 2000);
            else AutoClosingMessageBox.Show("Không Reset mật khẩu tài khoản được.", "Lỗi", 2000);
            tbPass1.Text = tbPass2.Text = string.Empty;
        }

        private void cbTaikhoanWE_SelectedIndexChanged(object sender, EventArgs e) {
            string tempTenTK = cbTaikhoanWE.Text;
            tbTenTaiKhoan.Text = tempTenTK;
            tbPass1.Text = tbPass2.Text = string.Empty;
            btnTaoTK.Enabled = true;
            btnXoaTK.Enabled = btnReset.Enabled = false;

        }

        private void btnXoaTK_Click(object sender, EventArgs e) {
            string tempTenTK = tbTenTaiKhoan.Text;
            string deleteString = @" delete NewUserAccount where UserAccount = @UserAccount ";
            try {
                int kq = SqlDataAccessHelper.ExecNoneQueryString(deleteString, new[] { "@UserAccount" }, new object[] { tempTenTK });
                if (kq != 0) MessageBox.Show("Xóa tài khoản thành công.", "Thông báo", MessageBoxButtons.OK);
                Load_cbTaikhoanWE();
                Load_dataGridNewUserAccount();
            } catch (Exception ex) {
                MessageBox.Show("Không xóa tài khoản được.\nLỗi:" + ex.ToString(), "Lỗi", MessageBoxButtons.OK);
            }
        }


        private void dataGridTK_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) return;
            btnTaoTK.Enabled = false;
            btnXoaTK.Enabled = btnReset.Enabled = true;

            string tempTenTK = dataGridTK.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbTenTaiKhoan.Text = tempTenTK;
            int tempUserID = (int)dataGridTK.Rows[e.RowIndex].Cells[0].Value;
            tbPass1.Text = tbPass2.Text = string.Empty;
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e) {
            frm_52_PhanQuyen frm52 = new frm_52_PhanQuyen();
	        frm52.ShowDialog();
        }

    }
}
