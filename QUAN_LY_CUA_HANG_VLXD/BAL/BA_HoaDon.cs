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
    public class BA_HoaDon
    {
        //Tao bien ket noi
        DALayer db = null;
        //Khoi tao ket noi
        public BA_HoaDon()
        {
            db = new DALayer();
          
        }

        public bool ThemHoaDon(string MaHD, string MaKH, string MaNV, string Ngay, float ThanhTien, ref string err)
        {
            return db.MyExecuteNonQuery("Execute SP_HoaDon_insert '" + MaHD + "','" + MaKH + "','" + MaNV + "','" + Ngay + "'," + ThanhTien + ";", CommandType.Text, ref err);
        }

        public bool UpdateHoaDon(string MaHD, string MaKH, string MaNV, string Ngay, float ThanhTien, ref string err)
        {
            return db.MyExecuteNonQuery("Execute SP_HoaDon_update '" + MaHD + "','" + MaKH + "','" + MaNV + "','" + Ngay + "'," + ThanhTien + ";", CommandType.Text, ref err);
        }
        public bool DeleteHoaDon(string MaHD, ref string err)
        {
            return db.MyExecuteNonQuery("Execute SP_HoaDon_delete '"+MaHD+"';", CommandType.Text, ref err);
        }
        public DataSet LoadHoaDon()
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_selectall", CommandType.Text, null);
        }
        public DataSet LoadHoaDon_Ma(string MaHD)
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_select_byID '" + MaHD + "';", CommandType.Text, null);
        }
        public DataSet LoadHoaDon_Ngay(string Ngay)
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_select_byDay '" + Ngay + "';", CommandType.Text, null);
        }
        public DataSet LoadHoaDon_Thang(string Thang)
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_select_byThang '" + Thang + "';", CommandType.Text, null);
        }
        public DataSet LoadHoaDon_Nam(string Nam)
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_select_byNam '" + Nam + "';", CommandType.Text, null);
        }
        public int DemSoHD( ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_DemSLHoaDon() from TB_HoaDon", CommandType.Text,ref err, null);
        }
        public int DemSoHD_Ngay(string ngay, ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_DemSLHoaDon_Ngay('"+ngay+"') from TB_HoaDon", CommandType.Text,ref err, null);
        }
        public int DemSoHD_Thang(string thang, ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_DemSLHoaDon_Thang('"+thang+"') from TB_HoaDon", CommandType.Text,ref err, null);
        }
        public int DemSoHD_Nam(string nam, ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_DemSLHoaDon_Nam('"+nam+"') from TB_HoaDon", CommandType.Text,ref err, null);
        }
    }
}
