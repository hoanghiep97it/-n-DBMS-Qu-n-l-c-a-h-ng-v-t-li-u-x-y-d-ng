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
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        BA_SanPham sp = new BA_SanPham();
        DataSet ds;
        bool Them;
        bool Sua;
        string err;
        public frmSanPham()
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
            txtMaSP.ResetText();
            txtTenSP.ResetText();
            txtMaNCC.ResetText();
            txtSoLuong.ResetText();
            txtGiaBan.ResetText();
            txtSanPhamTK.ResetText();
        }
        private void Co()
        {
            Them = false;
            Sua = false;
        }
        private void chon()
        {
            txtMaNCC.DataBindings.Clear();
            txtTenSP.DataBindings.Clear();
            txtMaSP.DataBindings.Clear();
            txtGiaBan.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();
            dtNgaySX.DataBindings.Clear();

            txtMaSP.DataBindings.Add("text", ds.Tables[0], "MaSP");
            txtTenSP.DataBindings.Add("text", ds.Tables[0], "TenSP");
            txtMaNCC.DataBindings.Add("text", ds.Tables[0], "MaNCC");
            txtSoLuong.DataBindings.Add("text", ds.Tables[0], "SoLuong");
            txtGiaBan.DataBindings.Add("text", ds.Tables[0], "GiaBan");
            dtNgaySX.DataBindings.Add("text", ds.Tables[0], "NgaySX");
        }

        void LoadSanPham()
        {
            try
            {
                ds = sp.LoadSanPham();
                dtSanPham.DataSource = ds.Tables[0];
                dtSanPham.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Loi !!! Khong load duoc du lieu san pham");
            }
        }

        

        private void btnTK_Click(object sender, EventArgs e)
        {
            ds = sp.LoadSanPham_Ma(txtSanPhamTK.Text);
            dtSanPham.DataSource = ds.Tables[0];
            dtSanPham.AutoResizeColumns();
            chon();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            MoKhoa();
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            dtSanPham.Enabled = false;
            XoaText();
            Co();
            Them = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Co();
            try
            {
                sp.DeleteSanPham(txtMaSP.Text, ref err);
                LoadSanPham();
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
            dtSanPham.Enabled = false;
            txtMaSP.Enabled = false;
            Co();
            Sua = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                try
                {
                    sp.ThemSanPham(txtMaSP.Text, txtMaNCC.Text, txtTenSP.Text, Int32.Parse(txtSoLuong.Text), dtNgaySX.Value.ToString("MM/dd/yyyy"), float.Parse(txtGiaBan.Text), ref err);
                    dtSanPham.Enabled = true;
                    LoadSanPham();
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
                        sp.UpdateSanPham(txtMaSP.Text, txtMaNCC.Text, txtTenSP.Text, Int32.Parse(txtSoLuong.Text), dtNgaySX.Value.ToString("MM/dd/yyyy"), float.Parse(txtGiaBan.Text), ref err);
                        dtSanPham.Enabled = true;
                        LoadSanPham();
                        MessageBox.Show("Đã cập nhập!");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không cập nhập được. Lỗi rồi!");
                    }
                }
            }
            MoKhoa();
            txtMaNCC.Enabled = true;
            dtSanPham.Enabled = true;
            Co();
            chon();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaText();
            MoKhoa();
            Co();
            txtMaSP.Enabled = true;
            dtSanPham.Enabled = true;
            LoadSanPham();
            chon();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            chon();
        }
    }
}