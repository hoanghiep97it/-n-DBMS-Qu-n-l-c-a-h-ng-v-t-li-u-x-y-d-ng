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
using System.Data.SqlClient;
using QUAN_LY_CUA_HANG_VLXD.BAL;

namespace QUAN_LY_CUA_HANG_VLXD
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        BA_KhachHang kh = new BA_KhachHang();
        DataSet ds;
        bool Them;
        bool Sua;
        string err;
        public frmKhachHang()
        {
            InitializeComponent();
            ds = new DataSet();
        }
        private void MoKhoa()
        {
            btnluu.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnHuy.Enabled = true;
        }
        private void XoaText()
        {
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            txtGioiTinh.ResetText();
            txtDiaChi.ResetText();
            txtEmail.ResetText();
            txtPhone.ResetText();
        }
        private void Co()
        {
            Them = false;
            Sua = false;
        }
        void LoadKhachHang()
        {
            try
            {
                ds = kh.LoadKhachHang();
                dataKhachHang.DataSource = ds.Tables[0];
                dataKhachHang.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Loi !!! Khong load duoc du lieu san pham");
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            MoKhoa();
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            dataKhachHang.Enabled = false;
            XoaText();
            Co();
            Them = true;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Co();
            try
            {
                kh.DeleteKhachHang(txtMaKH.Text, ref err);
                LoadKhachHang();
                MessageBox.Show("Đã xóa xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            MoKhoa();
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            dataKhachHang.Enabled = false;
            txtMaKH.Enabled = false;
            Co();
            Sua = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if(Them==true)
            {
                try
                {
                    kh.ThemKhachHang(txtMaKH.Text, txtTenKH.Text, txtGioiTinh.Text, txtDiaChi.Text, txtPhone.Text, txtEmail.Text, ref err);
                    dataKhachHang.Enabled = true;
                    LoadKhachHang();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                if (Sua == true)
                {
                    try
                    {
                        kh.UpdateKhachHang(txtMaKH.Text, txtTenKH.Text, txtGioiTinh.Text, txtDiaChi.Text, txtPhone.Text, txtEmail.Text, ref err);
                        dataKhachHang.Enabled = true;
                        LoadKhachHang();
                        MessageBox.Show("Đã cập nhập!");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không cập nhập được. Lỗi rồi!");
                    }
                }
            }
            MoKhoa();
            dataKhachHang.Enabled = true;
            Co();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            XoaText();
            txtMaKH.Text = "ffdfhfh";
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            txtMaKH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtGioiTinh.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtEmail.DataBindings.Clear();

            txtMaKH.DataBindings.Add("text",ds.Tables[0],"MaKH");
            txtTenKH.DataBindings.Add("text", ds.Tables[0], "TenKH");
            txtGioiTinh.DataBindings.Add("text", ds.Tables[0], "GioiTinh");
            txtDiaChi.DataBindings.Add("text", ds.Tables[0], "DiaChi");
            txtPhone.DataBindings.Add("text", ds.Tables[0], "Phone");
            txtEmail.DataBindings.Add("text", ds.Tables[0], "Email");

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaText();
            MoKhoa();
            Co();
        }
    }
}