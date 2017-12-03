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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        BA_NhanVien nv = new BA_NhanVien();
        DataSet ds ;
        bool Them;
        bool Sua;
        string err;
        public frmNhanVien()
        {
            InitializeComponent();
            ds = new DataSet();
        }
        void LoadNV()
        {
            try
            {
                ds = nv.LoadNhanVien();
                dataNhanVien.DataSource = ds.Tables[0];
                dataNhanVien.AutoResizeColumns();
                int sl = nv.TongNhanVien(ref err);
                txtSL_NV.Text = sl.ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("Loi !!! Khong load duoc du lieu nhan vien");
            }
        }

        private void MoKhoa()
        {
            btnLuu.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }
        private void XoaText()
        {
            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtUsername.ResetText();
            cbGioiTinh.ResetText();
            txtMaPQ.ResetText();
            txtMaTK.ResetText();
            txtDiaChi.ResetText();
            txtEmail.ResetText();
            txtPhone.ResetText();
        }

        private void chon()
        {
            txtMaNV.DataBindings.Clear();
            txtMaPQ.DataBindings.Clear();
            txtUsername.DataBindings.Clear();
            txtTenNV.DataBindings.Clear();
            dtNgaySinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            cbTinhTrang.DataBindings.Clear();

            txtMaNV.DataBindings.Add("text", ds.Tables[0], "MaNV");
            txtMaPQ.DataBindings.Add("text", ds.Tables[0], "MaPQ");
            txtUsername.DataBindings.Add("text", ds.Tables[0], "Username");
            txtTenNV.DataBindings.Add("text", ds.Tables[0], "TenNV");
            cbGioiTinh.DataBindings.Add("text", ds.Tables[0], "GioiTinh");
            dtNgaySinh.DataBindings.Add("text", ds.Tables[0], "NgaySinh");
            txtDiaChi.DataBindings.Add("text", ds.Tables[0], "DiaChi");
            txtPhone.DataBindings.Add("text", ds.Tables[0], "Phone");
            txtEmail.DataBindings.Add("text", ds.Tables[0], "Email");
            cbTinhTrang.DataBindings.Add("text", ds.Tables[0], "TinhTrang");
        }
        
        private void Co()
        {
            Them = false;
            Sua = false;
        }

        
       
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            MoKhoa();
            btnthem.Enabled = false;
            btnXoa.Enabled = false;
            btnsua.Enabled = false;
            dataNhanVien.Enabled = false;
            XoaText();
            Co();
            Them = true;
        }

        

        private void btnsua_Click(object sender, EventArgs e)
        {
            MoKhoa();
            btnthem.Enabled = false;
            btnXoa.Enabled = false;
            btnsua.Enabled = false;
            dataNhanVien.Enabled = false;
            txtMaNV.Enabled = false;
            Co();
            Sua = true;
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            LoadNV();
            MoKhoa();
            txtMaNV.Enabled = true;
            dataNhanVien.Enabled = true;
            Co();
            chon();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (Them == true)
            {
                try
                {
                    nv.ThemNhanVien(txtMaNV.Text, txtUsername.Text, txtMaPQ.Text, txtTenNV.Text, cbGioiTinh.SelectedItem.ToString(), dtNgaySinh.Value.ToString("MM/dd/yyyy"), txtDiaChi.Text, txtPhone.Text, txtEmail.Text, cbTinhTrang.SelectedItem.ToString(), ref err);
                    dataNhanVien.Enabled = true;
                    LoadNV();
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
                        nv.UpdateNhanVien(txtMaNV.Text, txtUsername.Text, txtMaPQ.Text, txtTenNV.Text, cbGioiTinh.SelectedItem.ToString(), dtNgaySinh.Value.ToString("MM/dd/yyyy"), txtDiaChi.Text, txtPhone.Text, txtEmail.Text, cbTinhTrang.SelectedItem.ToString(), ref err);
                        dataNhanVien.Enabled = true;
                        LoadNV();
                        MessageBox.Show("Đã cập nhập!");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không cập nhập được. Lỗi rồi!");
                    }
                }
            }
            MoKhoa();
            dataNhanVien.Enabled = true;
            txtMaNV.Enabled = true;
            Co();
            chon();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            
        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            Co();
            try
            {
                nv.DeleteNhanVien(txtMaNV.Text, ref err);
                LoadNV();
                MessageBox.Show("Đã xóa xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadNV();
            dataNhanVien.Enabled = true;
            txtMaNV.Enabled = true;
            MoKhoa();
            Co();
            chon();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUAN_LY_CUA_HANG_VAT_LIEU_XAY_DUNGDataSet.TB_NhanVien' table. You can move, or remove it, as needed.
            LoadNV();
            chon();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            ds = nv.LoadNhanVien_Ma(txtMaTK.Text);
            dataNhanVien.DataSource = ds.Tables[0];
            dataNhanVien.AutoResizeColumns();
            chon();
            txtSL_NV.ResetText();
        }
        
        

    }
}