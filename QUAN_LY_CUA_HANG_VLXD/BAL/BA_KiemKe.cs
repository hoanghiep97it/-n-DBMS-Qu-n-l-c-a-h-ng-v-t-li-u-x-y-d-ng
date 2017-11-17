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
    public class BA_KiemKe
    {
        //Tao bien ket noi
        DALayer db = null;
        //Khoi tao ket noi
        public BA_KiemKe()
        {
            db = new DALayer();
          
        }
        public DataSet ThemKiemKe(string MaKK, string MaNV, string MaSP , string NgayTao, int SoLuong)
        {
            return db.ExecuteQueryDataSet("Execute SP_KiemKe_insert '" + MaKK + "','" + MaNV + "','" + MaSP + "','" + NgayTao + "'," + SoLuong + ";", CommandType.Text);
        }
        
        public DataSet UpdateKiemKe(string MaKK, string MaNV, string MaSP, string NgayTao, int SoLuong)
        {
            return db.ExecuteQueryDataSet("Execute SP_KiemKe_update '" + MaKK + "','" + MaNV + "','" + MaSP + "','" + NgayTao + "'," + SoLuong + ";", CommandType.Text);
        }
        public DataSet DeleteKiemKe()
        {
            return db.ExecuteQueryDataSet("Execute SP_KiemKe_delete", CommandType.Text);
        }
        public DataSet LoadKiemKe()
        {
            return db.ExecuteQueryDataSet("Execute SP_KiemKe_selectall", CommandType.Text);
        }
        public DataSet LoadKiemKe_Ma(string MaKK)
        {
            return db.ExecuteQueryDataSet("Execute SP_KiemKe_select_byID '" + MaKK + "';", CommandType.Text);
        }
        public DataSet LoadKiemKe_Ngay(string Ngay)
        {
            return db.ExecuteQueryDataSet("Execute SP_KiemKe_select_byDay '" +Ngay+ "';", CommandType.Text);
        }
        public DataSet LoadKiemKe_Thang(string Thang)
        {
            return db.ExecuteQueryDataSet("Execute SP_KiemKe_select_byThang '" +Thang+ "';", CommandType.Text);
        }
        public DataSet LoadKiemKe_Nam(string Nam)
        {
            return db.ExecuteQueryDataSet("Execute SP_KiemKe_select_byNam '" +Nam+ "';", CommandType.Text);
        }
        public DataSet LoadKiemKe_Ngay_SP(string Ngay, string MaSP)
        {
            return db.ExecuteQueryDataSet("Execute SP_KiemKe_select_byDay_SP '" + Ngay + "','" + MaSP + "';", CommandType.Text);
        }
        public DataSet LoadKiemKe_Thang_SP(string Thang, string MaSP)
        {
            return db.ExecuteQueryDataSet("Execute SP_KiemKe_select_byThang_SP '" + Thang + "','" + MaSP + "';", CommandType.Text);
        }
        public DataSet LoadKiemKe_Nam_SP(string Nam, string MaSP)
        {
            return db.ExecuteQueryDataSet("Execute SP_KiemKe_select_byNam_SP '" + Nam + "','" + MaSP + "';", CommandType.Text);
        }
    }
}
