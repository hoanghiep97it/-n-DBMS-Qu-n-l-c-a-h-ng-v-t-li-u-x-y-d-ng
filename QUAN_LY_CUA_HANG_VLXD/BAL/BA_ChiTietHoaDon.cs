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
    public class BA_ChiTietHoaDon
    {
        //Tao bien ket noi
        DALayer db = null;
        //Khoi tao ket noi
        public BA_ChiTietHoaDon()
        {
            db = new DALayer();
          
        }

        public DataSet ThemChiTietHD(string MaHD,string MaSP,string TenNCC,int SoLuong,float GiaBan,string NgayTao)
        {
            return db.ExecuteQueryDataSet("Execute SP_ChiTietHD_insert '" + MaHD + "','" + MaSP + "','" + TenNCC + "'," + SoLuong + "," + GiaBan + ",'" + NgayTao + "';", CommandType.Text);
        }

        public DataSet UpdateChiTietHD(string MaHD, string MaSP, string TenNCC, int SoLuong, float GiaBan, string NgayTao)
        {
            return db.ExecuteQueryDataSet("Execute SP_ChiTietHD_update '" + MaHD + "','" + MaSP + "','" + TenNCC + "'," + SoLuong + "," + GiaBan + ",'" + NgayTao + "';", CommandType.Text);
        }
        public DataSet DeleteChiTietHD()
        {
            return db.ExecuteQueryDataSet("Execute SP_ChiTietHD_delete", CommandType.Text);
        }
        public DataSet LoadChiTietHD()
        {
            return db.ExecuteQueryDataSet("Execute SP_ChiTietHD_selectall", CommandType.Text);
        }
        public DataSet LoadChiTietHD_Ma(string MaHD)
        {
            return db.ExecuteQueryDataSet("Execute SP_ChiTietHD_select_byID '"+MaHD+"';", CommandType.Text);
        }
        public DataSet LoadChiTietHD_Ngay(string Ngay)
        {
            return db.ExecuteQueryDataSet("Execute SP_ChiTietHD_select_byDay '"+Ngay+"';", CommandType.Text);
        }
        public DataSet LoadChiTietHD_Thang(string Thang)
        {
            return db.ExecuteQueryDataSet("Execute SP_ChiTietHD_select_byThang '"+Thang+"';", CommandType.Text);
        }
        public DataSet LoadChiTietHD_Nam(string Nam)
        {
            return db.ExecuteQueryDataSet("Execute SP_ChiTietHD_select_byNam '"+Nam+"';", CommandType.Text);
        }
    }
}
