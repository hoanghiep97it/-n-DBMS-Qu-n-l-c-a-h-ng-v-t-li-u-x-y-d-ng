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
    public class BA_TaiKhoan
    {
        //Tao bien ket noi
        DALayer db = null;
        //Khoi tao ket noi
        public BA_TaiKhoan()
        {
            db = new DALayer();
          
        }

        public DataSet ThemTaiKhoan(string MaNV, string Username, string MaPQ, string Pass, string Email)
        {
            return db.ExecuteQueryDataSet("Execute SP_TaiKhoan_insert '"+MaNV+"','"+Username+"','"+MaPQ+"','"+Pass+"','"+Email+"';", CommandType.Text);
        }

        public DataSet UpdateTaiKhoan(string MaNV, string Username, string MaPQ, string Pass, string Email)
        {
            return db.ExecuteQueryDataSet("Execute SP_TaiKhoan_update '"+MaNV+"','"+Username+"','"+MaPQ+"','"+Pass+"','"+Email+"';", CommandType.Text);
        }
        public DataSet DeleteTaiKhoan()
        {
            return db.ExecuteQueryDataSet("Execute SP_TaiKhoan_delete", CommandType.Text);
        }
        public DataSet LoadTaiKhoan()
        {
            return db.ExecuteQueryDataSet("Execute SP_TaiKhoan_selectall", CommandType.Text);
        }
        public DataSet LoadTaiKhoan_Ma(string MaNV)
        {
            return db.ExecuteQueryDataSet("Execute SP_TaiKhoan_select_byID '"+MaNV+"';", CommandType.Text);
        }
    }
}
