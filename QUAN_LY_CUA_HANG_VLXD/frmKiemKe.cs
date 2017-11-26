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
    public partial class frmKiemKe : DevExpress.XtraEditors.XtraForm
    {
        BA_KiemKe KK = new BA_KiemKe();
        DataSet ds;
        DataSet CTHD;
        public frmKiemKe()
        {
            InitializeComponent();
            ds = new DataSet();
            CTHD = new DataSet();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (Ngay.Checked == true)
            {
                ds = KK.LoadKiemKe_Ngay(dtNgayTao.Value.ToString("MM/dd/yyyy"));
                dataKiemKe.DataSource = ds.Tables[0];
                dataKiemKe.AutoResizeColumns();
            }
            else
            {
                if (Thang.Checked == true)
                {
                    ds = KK.LoadKiemKe_Thang(dtNgayTao.Value.Month.ToString());
                    dataKiemKe.DataSource = ds.Tables[0];
                    dataKiemKe.AutoResizeColumns();
                }
                else
                {
                    if (Nam.Checked == true)
                    {
                        ds = KK.LoadKiemKe_Nam(dtNgayTao.Value.Year.ToString());
                        dataKiemKe.DataSource = ds.Tables[0];
                        dataKiemKe.AutoResizeColumns();
                    }
                }
            }
            chon();
        }

        private void chon()
        {
            txtMaKK.DataBindings.Clear();
            txtNhanVien.DataBindings.Clear();
            txtNgayTao.DataBindings.Clear();
            txtSanPham.DataBindings.Clear();
            txtSL.DataBindings.Clear();

            txtMaKK.DataBindings.Add("text", ds.Tables[0], "MaKK");
            txtNhanVien.DataBindings.Add("text", ds.Tables[0], "MaNV");
            txtSanPham.DataBindings.Add("text", ds.Tables[0], "MaSP");
            txtNgayTao.DataBindings.Add("text", ds.Tables[0], "NgayTao");
            txtSL.DataBindings.Add("text", ds.Tables[0], "SoLuong");
        }
        private void dataThongKe_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            chon();
            DateTime NgayTao = Convert.ToDateTime(dataKiemKe.CurrentRow.Cells[3].Value.ToString());
            CTHD = KK.LoadKiemKe_Ngay_SP(NgayTao.ToString(), dataKiemKe.CurrentRow.Cells[2].Value.ToString());
                dataBan.DataSource = CTHD.Tables[0];
                dataBan.AutoResizeColumns();

        }


    }
}