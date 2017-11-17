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

        public DataSet ThemThongKe(string MaTK, string MaNV, string NgayTao, float DoanhThu)
        {
            return db.ExecuteQueryDataSet("Execute SP_ThongKe_insert '"+MaTK+"','"+MaNV+"','"+NgayTao+"',"+DoanhThu+";", CommandType.Text);
        }

        public DataSet UpdateThongKe(string MaTK, string MaNV, string NgayTao, string DoanhThu)
        {
            return db.ExecuteQueryDataSet("Execute SP_ThongKe_update '"+MaTK+"','"+MaNV+"','"+NgayTao+"',"+DoanhThu+";", CommandType.Text);
        }
        public DataSet DeleteThongKe()
        {
            return db.ExecuteQueryDataSet("Execute SP_ThongKe_delete", CommandType.Text);
        }
        public DataSet LoadThongKe()
        {
            return db.ExecuteQueryDataSet("Execute SP_ThongKe_selectall", CommandType.Text);
        }
        public DataSet LoadThongKe_Ma(string MaTK)
        {
            return db.ExecuteQueryDataSet("Execute SP_ThongKe_select_byID '"+MaTK+"';", CommandType.Text);
        }
        public DataSet LoadThongKe_Ngay(string Ngay)
        {
            return db.ExecuteQueryDataSet("Execute SP_ThongKe_select_byDay '"+Ngay+"';", CommandType.Text);
        }
        public DataSet LoadThongKe_Thang(string Thang)
        {
            return db.ExecuteQueryDataSet("Execute SP_ThongKe_select_byThang '"+Thang+"';", CommandType.Text);
        }
        public DataSet LoadThongKe_Nam(string Nam)
        {
            return db.ExecuteQueryDataSet("Execute SP_ThongKe_select_byNam '"+Nam+"';", CommandType.Text);
        }
    }
}
