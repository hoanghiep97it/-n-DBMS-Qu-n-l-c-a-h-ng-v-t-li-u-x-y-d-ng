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
        DataTable sanPham = null;
        public frmLapHoaDon()
        {
            InitializeComponent();
        }

        void LoadSP()
        {
            try
            {
                sanPham = new DataTable();
                sanPham.Clear();
                DataSet ds = s.LoadSanPham();
                sanPham = ds.Tables[0];
                dataSP.DataSource = sanPham;
                dataSP.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Loi !!! Khong load duoc du lieu san pham");
            }
        }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            LoadSP();
        }

        private void dataHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}