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
    public partial class frmThongKe : DevExpress.XtraEditors.XtraForm
    {
        BA_ThongKe TK = new BA_ThongKe();
        DataSet ds;
        DataSet HD;
        public frmThongKe()
        {
            InitializeComponent();
            ds = new DataSet();
            HD = new DataSet();
        }

        void LoadThongKe()
        {
            try
            {
                ds = TK.LoadThongKe();
                dsThongKe.DataSource = ds.Tables[0];
                dsThongKe.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Loi !!! Khong load duoc du lieu nhan vien");
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            if (CheckNgay.Checked == true)
            {
                string ngay =dtNgayTaoTK.Value.ToString("MM/dd/yyyy");
                float doanhthu=TK.ThuNhap_Ngay(ngay);
                txtDoanhThu.Text = doanhthu.ToString();
            }
            else
            {
                if (CheckThang.Checked == true)
                {
                    string thang = dtNgayTaoTK.Value.Month.ToString("MM/dd/yyyy");
                    string nam = dtNgayTaoTK.Value.Year.ToString("MM/dd/yyyy");
                    float doanhthu = TK.ThuNhap_Thang(thang,nam);
                    txtDoanhThu.Text = doanhthu.ToString();
                }
                else
                {
                    if (CheckNam.Checked == true)
                    {
                        string nam = dtNgayTaoTK.Value.Year.ToString("MM/dd/yyyy");
                        float doanhthu = TK.ThuNhap_Nam(nam);
                        txtDoanhThu.Text = doanhthu.ToString();
                    }
                }
            }
        }

        private void btnTínhLai_Click(object sender, EventArgs e)
        {

        }

        private void chon()
        {
            txtMaTK.DataBindings.Clear();
            txtMaNV.DataBindings.Clear();
            dtNgayTaoTK.DataBindings.Clear();
            txtDoanhThu.DataBindings.Clear();

            txtMaTK.DataBindings.Add("text", ds.Tables[0], "MaTK");
            txtMaNV.DataBindings.Add("text", ds.Tables[0], "MaNV");
            dtNgayTaoTK.DataBindings.Add("text", ds.Tables[0], "NgayTao");
            txtDoanhThu.DataBindings.Add("text", ds.Tables[0], "DoanhThu");


        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (CheckNgay.Checked == true)
            {
                ds = TK.LoadThongKe_Ngay(dtNgayTaoTK.Value.ToString("MM/dd/yyyy"));
                dsThongKe.DataSource = ds.Tables[0];
                dsThongKe.AutoResizeColumns();
            }
            else
            {
                if (CheckThang.Checked == true)
                {
                    ds = TK.LoadThongKe_Thang(dtNgayTaoTK.Value.Month.ToString(),dtNgayTaoTK.Value.Year.ToString());
                    dsThongKe.DataSource = ds.Tables[0];
                    dsThongKe.AutoResizeColumns();
                }
                else
                {
                    if (CheckNam.Checked == true)
                    {
                        ds = TK.LoadThongKe_Nam(dtNgayTaoTK.Value.Year.ToString());
                        dsThongKe.DataSource = ds.Tables[0];
                        dsThongKe.AutoResizeColumns();
                    }
                }
            }
            chon();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadThongKe();
            chon();
        }

        private void dsThongKe_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            chon();
            BA_HoaDon hd = new BA_HoaDon();
            HD = hd.LoadHoaDon_Ngay( dtNgayTaoTK.Value.ToString("MM/dd/yyyy"));
            dsHoaDon.DataSource = HD.Tables[0];
            dsHoaDon.AutoResizeColumns();
        }
    }
}