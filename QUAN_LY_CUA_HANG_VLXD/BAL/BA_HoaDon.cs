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
    class BA_HoaDon
    {
        //Tao bien ket noi
        DALayer db = null;
        //Khoi tao ket noi
        public BA_HoaDon()
        {
            db = new DALayer();
          
        }
        //Lay thong tin nhan vien thong qua store LoadNhanVien ,tra ve 1 dataset
        public DataSet LoadHoaDon(string MaHD)
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_selectall", CommandType.Text);
        }
        //Lay thong tin nhan vien thong qua store LoadNhanVien ,tra ve 1 dataset
        public DataSet ThemHoaDon(string MaHD, string MaKH, string MaNV , string Ngay, float ThanhTien)
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_insert", CommandType.Text);
        }
        //Lay thong tin nhan vien thong qua store LoadNhanVien ,tra ve 1 dataset
        public DataSet UpdateHoaDon(string MaHD, string MaKH, string MaNV, string Ngay, float ThanhTien)
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_update", CommandType.Text);
        }
        public DataSet DeleteHoaDon()
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_delete", CommandType.Text);
        }
        public DataSet LoadHoaDon_Ngay(string Ngay)
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_select_byDay", CommandType.Text);
        }
        public DataSet LoadHoaDon_Thang(string Thang)
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_select_byThang", CommandType.Text);
        }
        public DataSet LoadHoaDon_Nam(string Nam)
        {
            return db.ExecuteQueryDataSet("Execute SP_HoaDon_select_byNam", CommandType.Text);
        }
    }
}
