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
    public class BA_NhaCungCap
    {
        //Tao bien ket noi
        DALayer db = null;
        //Khoi tao ket noi
        public BA_NhaCungCap()
        {
            db = new DALayer();
          
        }

        public bool ThemNhaCungCap(string MaNCC, string TenNCC, string DiaChi, string Phone, string Email, string TinhTrang, ref string err)
        {
            return db.MyExecuteNonQuery("Execute SP_NhaCungCap_insert '" + MaNCC + "','" + TenNCC + "','" + DiaChi + "','" + Phone + "','" + Email + "','" + TinhTrang + "';", CommandType.Text, ref err);
        }

        public bool UpdateNhaCungCap(string MaNCC, string TenNCC, string DiaChi, string Phone, string Email, string TinhTrang, ref string err)
        {
            return db.MyExecuteNonQuery("Execute SP_NhaCungCap_update '" + MaNCC + "','" + TenNCC + "','" + DiaChi + "','" + Phone + "','" + Email + "','" + TinhTrang + "';", CommandType.Text, ref err);
        }
        public bool DeleteNhaCungCap(string MaNCC, ref string err)
        {
            return db.MyExecuteNonQuery("Execute SP_NhaCungCap_delete '"+MaNCC+"';", CommandType.Text, ref err);
        }
        public DataSet LoadNhaCungCap()
        {
            return db.ExecuteQueryDataSet("Execute SP_NhaCungCap_selectall", CommandType.Text, null);
        }
        public DataSet LoadNhaCungCap_Ma(string MaNCC)
        {
            return db.ExecuteQueryDataSet("Execute SP_NhaCungCap_select_byID '" + MaNCC + "';", CommandType.Text, null);
        }
        public int TongNhaCungCap(ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_DemSLNhaCungCap() from TB_NhaCungCap", CommandType.Text,ref err, null);
        }
    }
}
