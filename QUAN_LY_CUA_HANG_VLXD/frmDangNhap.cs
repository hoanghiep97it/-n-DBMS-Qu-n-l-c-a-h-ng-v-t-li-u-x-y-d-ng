using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QUAN_LY_CUA_HANG_VLXD.BAL;
using System.Threading;

namespace QUAN_LY_CUA_HANG_VLXD
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        BA_DangNhap DN = new BA_DangNhap();
        Bien b = new Bien();
        frmMain giaodien = new frmMain();
        string err ;
        public frmDangNhap()
        {
            InitializeComponent();
            DN = new BA_DangNhap();
            b = new Bien();
        }
        private void btnDN_Click(object sender, EventArgs e)
        {
            b.Server = cbServer.SelectedItem.ToString();
            b.DB = cbData.SelectedItem.ToString();
            b.PassHT = txtPassHT.Text;
            b.User = txtUser.Text;
            b.Pass = txtMK.Text;
            if (checkQL.Checked == true)
            {
                if (!DN.DBAccess(cbServer.SelectedItem.ToString(), cbData.SelectedItem.ToString(), "quanly", txtPassHT.Text))
                {
                    MessageBox.Show("Đăng nhập hệ thống thất bại");
                }
                else
                {
                    try
                    {
                        DN.DangNhap(txtUser.Text, txtMK.Text, "Q01", ref err);
                        int check = DN.KTDangNhap(txtUser.Text, txtMK.Text);
                        if (check == 1)
                        {
                            frmDangNhap Fdn = new frmDangNhap();
                            Fdn.Close();
                            giaodien.Show();
                            MessageBox.Show("Đăng nhập thành công");
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thất bại , sai tên đăng nhập hoặc mật khẩu");
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Lỗi đăng nhập /n ", "System ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (checkNV.Checked == true)
                {
                    if (!DN.DBAccess(cbServer.SelectedItem.ToString(), cbData.SelectedItem.ToString(), "nhanvien", txtPassHT.Text))
                    {
                        MessageBox.Show("Đăng nhập hệ thống thất bại");
                    }
                    else
                    {
                        try
                        {
                            DN.DangNhap(txtUser.Text, txtMK.Text, "Q02", ref err);
                            int check = DN.KTDangNhap(txtUser.Text, txtMK.Text);
                            if (check == 1)
                            {
                                frmDangNhap Fdn = new frmDangNhap();
                                Fdn.Close();
                                giaodien.Show();
                                MessageBox.Show("Đăng nhập thành công");
                            }
                            else
                            {
                                MessageBox.Show("Đăng nhập thất bại , sai tên đăng nhập hoặc mật khẩu");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Lỗi nhận xe /n " + err + "", "System ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }
    }
}