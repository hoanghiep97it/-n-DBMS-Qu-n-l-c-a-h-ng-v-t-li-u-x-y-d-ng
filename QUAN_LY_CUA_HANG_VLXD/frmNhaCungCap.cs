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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        BA_NhaCungCap ncc = new BA_NhaCungCap();
        DataSet ds;
        bool Them;
        bool Sua;
        string err;
        public frmNhaCungCap()
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
            txtMaNCC.ResetText();
            txtTenNCC.ResetText();
            txtDiaChi.ResetText();
            txtEmail.ResetText();
            txtPhone.ResetText();
            txtTinhTrang.ResetText();
        }
        private void Co()
        {
            Them = false;
            Sua = false;
        }
        private void chon()
        {
            txtMaNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtTinhTrang.DataBindings.Clear();

            txtMaNCC.DataBindings.Add("text", ds.Tables[0], "MaNCC");
            txtTenNCC.DataBindings.Add("text", ds.Tables[0], "TenNCC");
            txtDiaChi.DataBindings.Add("text", ds.Tables[0], "DiaChi");
            txtPhone.DataBindings.Add("text", ds.Tables[0], "Phone");
            txtEmail.DataBindings.Add("text", ds.Tables[0], "Email");
            txtTinhTrang.DataBindings.Add("text", ds.Tables[0], "TinhTrang");
        }
        void LoadNhaCungCap()
        {
            try
            {
                ds = ncc.LoadNhaCungCap();
                dataNhaCungCap.DataSource = ds.Tables[0];
                dataNhaCungCap.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Loi !!! Khong load duoc du lieu san pham");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            ds = ncc.LoadNhaCungCap_Ma(txtMaTK.Text);
            dataNhaCungCap.DataSource = ds.Tables[0];
            dataNhaCungCap.AutoResizeColumns();
            chon();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            MoKhoa();
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            dataNhaCungCap.Enabled = false;
            XoaText();
            Co();
            Them = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Co();
            try
            {
                ncc.DeleteNhaCungCap(txtMaNCC.Text, ref err);
                LoadNhaCungCap();
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
            dataNhaCungCap.Enabled = false;
            txtMaNCC.Enabled = false;
            Co();
            Sua = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                try
                {
                    ncc.ThemNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtPhone.Text, txtEmail.Text,txtTinhTrang.Text , ref err);
                    dataNhaCungCap.Enabled = true;
                    LoadNhaCungCap();
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
                        ncc.UpdateNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtPhone.Text, txtEmail.Text,txtTinhTrang.Text, ref err);
                        dataNhaCungCap.Enabled = true;
                        LoadNhaCungCap();
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
            dataNhaCungCap.Enabled = true;
            Co();
            chon();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaText();
            MoKhoa();
            Co();
            txtMaNCC.Enabled = true;
            dataNhaCungCap.Enabled = true;
            chon();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
            chon();
        }
    }
}