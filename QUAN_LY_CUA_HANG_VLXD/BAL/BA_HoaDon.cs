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
        public DataSet LoadHoaDon()
        {
            return db.ExecuteQueryDataSet("Execute SP_SanPham_selectall", CommandType.Text);
        }
        //Lay thong tin nhan vien thong qua store LoadNhanVien ,tra ve 1 dataset
        public DataSet ThemHoaDon()
        {
            return db.ExecuteQueryDataSet("Execute SP_SanPham_selectall", CommandType.Text);
        }
        //Lay thong tin nhan vien thong qua store LoadNhanVien ,tra ve 1 dataset
        public DataSet UpdateHoaDon()
        {
            return db.ExecuteQueryDataSet("Execute SP_SanPham_selectall", CommandType.Text);
        }
        public DataSet DeleteHoaDon()
        {
            return db.ExecuteQueryDataSet("Execute SP_SanPham_selectall", CommandType.Text);
        }
    }
}
