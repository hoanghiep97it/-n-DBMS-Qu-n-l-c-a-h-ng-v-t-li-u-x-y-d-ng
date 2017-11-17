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
    public class BA_KhachHang
    {
        //Tao bien ket noi
        DALayer db = null;
        //Khoi tao ket noi
        public BA_KhachHang()
        {
            db = new DALayer();
          
        }
        
        public DataSet ThemKhachHang(string MaKH, string TenKH, string GioiTinh, string DiaChi, string Phone, string Email)
        {
            return db.ExecuteQueryDataSet("Execute SP_KhachHang_insert '" + MaKH + "','" + TenKH + "','" + GioiTinh + "','" + DiaChi + "','" + Phone + "','" + Email + "';", CommandType.Text);
        }

        public DataSet UpdateKhachHang(string MaKH, string TenKH, string GioiTinh, string DiaChi, string Phone, string Email)
        {
            return db.ExecuteQueryDataSet("Execute SP_KhachHang_update '" + MaKH + "','" + TenKH + "','" + GioiTinh + "','" + DiaChi + "','" + Phone + "','" + Email + "';", CommandType.Text);
        }
        public DataSet DeleteKhachHang()
        {
            return db.ExecuteQueryDataSet("Execute SP_KhachHang_delete", CommandType.Text);
        }
        public DataSet LoadKhachHang()
        {
            return db.ExecuteQueryDataSet("Execute SP_KhachHang_selectall", CommandType.Text);
        }
        public DataSet LoadKhachHang_Ma(string MaKH)
        {
            return db.ExecuteQueryDataSet("Execute SP_KhachHang_select_byID '"+MaKH+"';", CommandType.Text);
        }
        public DataSet LoadKhachHang_Phone(string Phone)
        {
            return db.ExecuteQueryDataSet("Execute SP_KhachHang_select_bySDT '"+Phone+"';", CommandType.Text);
        }
    }
}
