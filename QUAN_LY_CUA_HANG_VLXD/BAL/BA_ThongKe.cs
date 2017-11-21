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
    public class BA_ThongKe
    {
        //Tao bien ket noi;
        DALayer db = null;
        //Khoi tao ket noi
        public BA_ThongKe()
        {
            db = new DALayer();
          
        }

        public bool ThemThongKe(string MaTK, string MaNV, string NgayTao, float DoanhThu, ref string err)
        {
            string sql="Execute SP_ThongKe_insert '" + MaTK + "','" + MaNV + "','" + NgayTao + "'," + DoanhThu + ";";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        public bool UpdateThongKe(string MaTK, string MaNV, string NgayTao, string DoanhThu, ref string err)
        {
            string sql="Execute SP_ThongKe_update '" + MaTK + "','" + MaNV + "','" + NgayTao + "'," + DoanhThu + ";";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool DeleteThongKe(string MaTK, ref string err)
        {
            string sql= "Execute SP_ThongKe_delete '"+MaTK+"';";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public DataSet LoadThongKe()
        {
            return db.ExecuteQueryDataSet("Execute SP_ThongKe_selectall", CommandType.Text, null);
        }
        public DataSet LoadThongKe_Ma(string MaTK)
        {
            return db.ExecuteQueryDataSet("Execute SP_ThongKe_select_byID '" + MaTK + "';", CommandType.Text, null);
        }
        public DataSet LoadThongKe_Ngay(string Ngay)
        {
            return db.ExecuteQueryDataSet("Execute SP_ThongKe_select_byDay '" + Ngay + "';", CommandType.Text, null);
        }
        public DataSet LoadThongKe_Thang(string Thang)
        {
            return db.ExecuteQueryDataSet("Execute SP_ThongKe_select_byThang '" + Thang + "';", CommandType.Text, null);
        }
        public DataSet LoadThongKe_Nam(string Nam)
        {
            return db.ExecuteQueryDataSet("Execute SP_ThongKe_select_byNam '" + Nam + "';", CommandType.Text, null);
        }
        public float TongThuNhap(ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_TongThuNhap() from TB_HoaDon", CommandType.Text,ref err, null);
        }
        public float ThuNhap_Ngay(string ngay, ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_TongThuNhap_Ngay('" + ngay + "') from TB_HoaDon", CommandType.Text, ref err, null);
        }
        public float ThuNhap_Thang(string Thang, ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_TongThuNhap_Thang('" + Thang + "') from TB_HoaDon", CommandType.Text, ref err, null);
        }
        public float ThuNhap_Nam(string Nam, ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_TongThuNhap_Nam('" + Nam + "') from TB_HoaDon", CommandType.Text, ref err, null);
        }
    }
}
