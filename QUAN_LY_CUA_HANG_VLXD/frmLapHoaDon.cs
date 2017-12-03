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
    public partial class frmLapHoaDon : DevExpress.XtraEditors.XtraForm
    {
        BA_SanPham s = new BA_SanPham();
        DataSet ds;
        int stt = 0;
        public frmLapHoaDon()
        {
            InitializeComponent();
            ds = new DataSet();
        }


        void LoadSP()
        {
            try
            {
        
                ds = s.LoadSanPham();
                dataSP.DataSource = ds.Tables[0];
            }
            catch (SqlException)
            {
                MessageBox.Show("Loi !!! Khong load duoc du lieu san pham");
            }
            dataSP_CellClick(null, null);
        }

        private void dataSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Thứ tự dòng hiện hành
            int r = dataSP.CurrentCell.RowIndex;
            // Chuyển thông tin lên Panel
            dataHoaDon.Rows[stt].Cells[0].Value = dataSP.Rows[r].Cells[0].Value.ToString();
            dataHoaDon.Rows[stt].Cells[1].Value = dataSP.Rows[r].Cells[0].Value.ToString();
            dataHoaDon.Rows[stt].Cells[2].Value = dataSP.Rows[r].Cells[0].Value.ToString();
            dataHoaDon.Rows[stt].Cells[3].Value = dataSP.Rows[r].Cells[0].Value.ToString();
            //this.dtpNgaySinh.Value = Convert.ToDateTime(dsNhanVienQL.Rows[r].Cells[3].Value.ToString());
        }
        //private void chon()
        //{
        //    txtMaNV.DataBindings.Clear();
        //    txtMa.DataBindings.Clear();
        //    dtpNgayTao.DataBindings.Clear();
        //    txtMaKH.DataBindings.Clear();
        //    txtTenKH.DataBindings.Clear();
        //    txtSDT.DataBindings.Clear();
        //    cbGioiTinh.DataBindings.Clear();
        //    txtDiachi.DataBindings.Clear();

        //    dtSP.DataBindings.Add("text", ds.Tables[0], "MaNV");
        //    txtMaPQ.DataBindings.Add("text", ds.Tables[0], "MaPQ");
        //    txtUsername.DataBindings.Add("text", ds.Tables[0], "Username");
        //    txtTenNV.DataBindings.Add("text", ds.Tables[0], "TenNV");
        //    cbGioiTinh.DataBindings.Add("text", ds.Tables[0], "GioiTinh");
        //    dtNgaySinh.DataBindings.Add("text", ds.Tables[0], "NgaySinh");
        //    txtDiaChi.DataBindings.Add("text", ds.Tables[0], "DiaChi");
        //    txtPhone.DataBindings.Add("text", ds.Tables[0], "Phone");
        //    txtEmail.DataBindings.Add("text", ds.Tables[0], "Email");
        //    cbTinhTrang.DataBindings.Add("text", ds.Tables[0], "TinhTrang");
        //}

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            LoadSP();
        }

        private void dataHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }

    }
}