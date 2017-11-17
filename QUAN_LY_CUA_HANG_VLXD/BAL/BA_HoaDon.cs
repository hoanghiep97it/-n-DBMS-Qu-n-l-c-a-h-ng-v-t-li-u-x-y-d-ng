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
      
        public DataSet ThemHoaDon(string MaHD, string MaKH, string MaNV , string Ngay, float ThanhTien)
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_insert '"+MaHD+"','"+MaKH+"','"+MaNV+"','"+Ngay+"',"+ThanhTien+";", CommandType.Text);
        }
        
        public DataSet UpdateHoaDon(string MaHD, string MaKH, string MaNV, string Ngay, float ThanhTien)
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_update '" + MaHD + "','" + MaKH + "','" + MaNV + "','" + Ngay + "'," + ThanhTien + ";", CommandType.Text);
        }
        public DataSet DeleteHoaDon()
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_delete", CommandType.Text);
        }
        public DataSet LoadHoaDon()
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_selectall", CommandType.Text);
        }
        public DataSet LoadHoaDon_Ma(string MaHD)
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_select_byID '" + MaHD + "';", CommandType.Text);
        }
        public DataSet LoadHoaDon_Ngay(string Ngay)
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_select_byDay '" + Ngay + "';", CommandType.Text);
        }
        public DataSet LoadHoaDon_Thang(string Thang)
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_select_byThang '" + Thang + "';", CommandType.Text);
        }
        public DataSet LoadHoaDon_Nam(string Nam)
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_select_byNam '" + Nam + "';", CommandType.Text);
        }
    }
}
