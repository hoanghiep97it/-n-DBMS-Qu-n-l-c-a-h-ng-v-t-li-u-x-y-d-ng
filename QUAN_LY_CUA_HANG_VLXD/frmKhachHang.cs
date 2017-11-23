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
        bool ThemSP;
        bool Sua;
        bool Xoa;
        string err;
        public frmKhachHang()
        {
            InitializeComponent();
            ds = new DataSet();
        }
        private void Khao()
        {
            btnluu.Enabled = false;
            btnsua.Enabled = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnHuy.Enabled = false;
        }
        private void Xoa()
        {

        }
        void LoadKhachHang()
        {
            try
            {
                ds = kh.LoadKhachHang();
                dataKhachHang.DataSource = ds.Tables[0];
                dataKhachHang.AutoResizeColumns();
                //dataKhachHang_CellClick(null, null);


            }
            catch (SqlException)
            {
                MessageBox.Show("Loi !!! Khong load duoc du lieu san pham");
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            Them = true;

            kh.ThemKhachHang(txtMaKH.Text, txtTenKH.Text, txtGioiTinh.Text, txtDiaChi.Text, txtPhone.Text, txtEmail.Text, ref err);
            LoadKhachHang();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

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

        }
    }
}