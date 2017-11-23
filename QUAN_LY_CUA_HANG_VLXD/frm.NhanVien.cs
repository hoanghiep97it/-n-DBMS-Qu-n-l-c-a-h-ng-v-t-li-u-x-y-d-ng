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
        public frmNhanVien()
        {
            InitializeComponent();
            ds = new DataSet();
        }
        void LoadSP()
        {
            try
            {
                ds = nv.LoadNhanVien();
                dataNhanVien.DataSource = ds.Tables[0];
            }
            catch (SqlException)
            {
                MessageBox.Show("Loi !!! Khong load duoc du lieu san pham");
            }
        }

        private void khoa()
        {
            btnHuy.Enabled = false;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUAN_LY_CUA_HANG_VAT_LIEU_XAY_DUNGDataSet.TB_NhanVien' table. You can move, or remove it, as needed.

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {

        }

        private void btnsua_Click(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}