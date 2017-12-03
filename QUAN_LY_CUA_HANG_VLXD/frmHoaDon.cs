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
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        BA_HoaDon HD = new BA_HoaDon();
        DataSet ds;
        DataSet kh;
        DataSet CTHD;
        string err;
        public frmHoaDon()
        {
            InitializeComponent();
            ds= new DataSet();
            kh = new DataSet();
            CTHD = new DataSet();
        }

       void LoadHD()
        {
            try
            {
                ds = HD.LoadHoaDon();
                dataHoaDon.DataSource = ds.Tables[0];
                dataHoaDon.AutoResizeColumns();
                int sl = HD.DemSoHD();
                txtSoHD.Text = sl.ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("Loi !!! Khong load duoc du lieu nhan vien");
            }

        }

       
       private void btnTK_Click(object sender, EventArgs e)
       {
           if (Ngay.Checked==true)
           {
               ds = HD.LoadHoaDon_Ngay(dtpNgayTao.Value.ToString("MM/dd/yyyy"));
               dataHoaDon.DataSource = ds.Tables[0];
               dataHoaDon.AutoResizeColumns();
               int sl = HD.DemSoHD_Ngay(dtpNgayTao.Value.ToString("MM/dd/yyyy"));
               txtSoHD.Text = sl.ToString();
           }
           else
           {
               if (thang.Checked == true)
               {
                   ds = HD.LoadHoaDon_Thang(dtpNgayTao.Value.Month.ToString(), dtpNgayTao.Value.Year.ToString());
                   dataHoaDon.DataSource = ds.Tables[0];
                   dataHoaDon.AutoResizeColumns();
                   int sl = HD.DemSoHD_Thang(dtpNgayTao.Value.Month.ToString(), dtpNgayTao.Value.Year.ToString());
                   txtSoHD.Text = sl.ToString();
               }
               else
               {
                   if (Nam.Checked == true)
                   {
                       ds=HD.LoadHoaDon_Nam(dtpNgayTao.Value.Year.ToString());
                       dataHoaDon.DataSource = ds.Tables[0];
                       dataHoaDon.AutoResizeColumns();
                       int sl = HD.DemSoHD_Nam(dtpNgayTao.Value.Year.ToString());
                       txtSoHD.Text = sl.ToString();
                   }
               }
           }
           chon();
       }

        private void chon()
       {
           txtMaNV.DataBindings.Clear();
           txtMaHD.DataBindings.Clear();
           txtNgayTao.DataBindings.Clear();
           txtTien.DataBindings.Clear();

           txtMaHD.DataBindings.Add("text", ds.Tables[0], "MaHD");
           txtMaNV.DataBindings.Add("text", ds.Tables[0], "MaNV");          
           txtNgayTao.DataBindings.Add("text", ds.Tables[0], "NgayTao");
           txtTien.DataBindings.Add("text", ds.Tables[0], "ThanhTien");

           
       }
       private void radioButton3_CheckedChanged(object sender, EventArgs e)
       {

       }

       private void frmHoaDon_Load(object sender, EventArgs e)
       {
           LoadHD();
       }

       private void dataHoaDon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
       {
           chon();
           txtMaKH.Text = dataHoaDon.CurrentRow.Cells[1].Value.ToString();
           BA_KhachHang KH = new BA_KhachHang();
           kh = KH.LoadKhachHang_Ma(txtMaKH.Text);

           txtMaKH.DataBindings.Clear();
           txtSDT.DataBindings.Clear();
           cbxGioiTinh.DataBindings.Clear();
           txtDiaChi.DataBindings.Clear();
           txtTenKH.DataBindings.Clear();
           txtSDT.DataBindings.Clear();

           txtMaKH.DataBindings.Add("text", kh.Tables[0], "MaKH");
           txtTenKH.DataBindings.Add("text", kh.Tables[0], "TenKH");
           cbxGioiTinh.DataBindings.Add("text", kh.Tables[0], "GioiTinh");
           txtDiaChi.DataBindings.Add("text", kh.Tables[0], "DiaChi");
           txtSDT.DataBindings.Add("text", kh.Tables[0], "Phone");

           //string MaHD = dataHoaDon.CurrentRow.Cells[0].Value.ToString();
           BA_ChiTietHoaDon CT = new BA_ChiTietHoaDon();
           CTHD = CT.LoadChiTietHD_Ma(txtMaHD.Text);
           dataChiTietHoaDon.DataSource = CTHD.Tables[0];


       }

    }
}