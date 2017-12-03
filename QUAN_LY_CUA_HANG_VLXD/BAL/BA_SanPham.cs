using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QUAN_LY_CUA_HANG_VLXD.DAL;

namespace QUAN_LY_CUA_HANG_VLXD.BAL
{
    class BA_SanPham
    {
        //Tao bien ket noi
        DALayer db = null;
        //Khoi tao ket noi
        public BA_SanPham()
        {
            db = new DALayer();
          
        }

        public bool ThemSanPham(string MaSP, string MaNCC, string TenSP, int SoLuong, string NgaySX, float GiaBan, ref string err)
        {
            return db.MyExecuteNonQuery("Execute SP_SanPham_insert '" + MaSP + "','" + MaNCC + "',N'" + TenSP + "'," + SoLuong + ",'NULL','" + NgaySX + "'," + GiaBan + ";", CommandType.Text, ref err);
        }

        public bool UpdateSanPham(string MaSP, string MaNCC, string TenSP, int SoLuong, string NgaySX, float GiaBan, ref string err)
        {
            return db.MyExecuteNonQuery("Execute SP_SanPham_update '" + MaSP + "','" + MaNCC + "',N'" + TenSP + "'," + SoLuong + ",'NULL','" + NgaySX + "'," + GiaBan + ";", CommandType.Text, ref err);
        }
        public bool DeleteSanPham(string MaSP, ref string err)
        {
            return db.MyExecuteNonQuery("Execute SP_SanPham_delete '"+MaSP+"';", CommandType.Text, ref err);
        }
        public DataSet LoadSanPham()
        {
            return db.ExecuteQueryDataSet("Execute SP_SanPham_selectall", CommandType.Text, null);
        }
        public DataSet LoadSanPham_Ma(string MaSP)
        {
            return db.ExecuteQueryDataSet("Execute SP_SanPham_select_byID '" + MaSP + "';", CommandType.Text, null);
        }
        public int TongSanPham()
        {
            return db.MyExecuteScalar("select distinct dbo.FT_DemSLSanPham() from TB_SanPham", CommandType.Text);
        }
    }

}
