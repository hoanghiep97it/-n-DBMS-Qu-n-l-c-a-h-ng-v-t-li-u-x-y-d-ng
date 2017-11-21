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
        public bool ThemKiemKe(string MaKK, string MaNV, string MaSP , string NgayTao, int SoLuong, ref string err)
        {
            return db.MyExecuteNonQuery("Execute SP_KiemKe_insert '" + MaKK + "','" + MaNV + "','" + MaSP + "','" + NgayTao + "'," + SoLuong + ";", CommandType.Text, ref err);
        }
        
        public bool UpdateKiemKe(string MaKK, string MaNV, string MaSP, string NgayTao, int SoLuong, ref string err)
        {
            return db.MyExecuteNonQuery("Execute SP_KiemKe_update '" + MaKK + "','" + MaNV + "','" + MaSP + "','" + NgayTao + "'," + SoLuong + ";", CommandType.Text, ref err);
        }
        public bool DeleteKiemKe(string MaKK, ref string err)
        {
            return db.MyExecuteNonQuery("Execute SP_KiemKe_delete '"+MaKK+"';", CommandType.Text, ref err);
        }
        public DataSet LoadKiemKe()
        {
            return db.ExecuteQueryDataSet("Execute SP_KiemKe_selectall", CommandType.Text);
        }
        public DataSet LoadKiemKe_Ma(string MaKK)
        {
            return db.ExecuteQueryDataSet("Execute SP_KiemKe_select_byID '" + MaKK + "';", CommandType.Text, null);
        }
        public DataSet LoadKiemKe_Ngay(string Ngay)
        {
            return db.ExecuteQueryDataSet("Execute SP_KiemKe_select_byDay '" + Ngay + "';", CommandType.Text, null);
        }
        public DataSet LoadKiemKe_Thang(string Thang)
        {
            return db.ExecuteQueryDataSet("Execute SP_KiemKe_select_byThang '" + Thang + "';", CommandType.Text, null);
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
        public int TongSPBanRa(ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_TongSanPhamBan() from TB_ChiTietHD", CommandType.Text,ref err, null);
        }
        public int TongSPBanRa_Ngay(string ngay, ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_TongSanPhamBan_Ngay('" + ngay + "') from TB_ChiTietHD", CommandType.Text, ref err, null);
        }
        public int TongSPBanRa_Thang(string Thang, ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_TongSanPhamBan_Thang('" + Thang + "') from TB_ChiTietHD", CommandType.Text, ref err, null);
        }
        public int TongSPBanRa_Nam(string Nam, ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_TongSanPhamBan_Nam('" + Nam + "') from TB_ChiTietHD", CommandType.Text, ref err, null);
        }
        public int TongSPBanRa_Ngay_SP(string ngay,string ma, ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_TongSanPhamBan_Ngay_SP('" + ngay + "','" + ma + "') from TB_ChiTietHD", CommandType.Text, ref err, null);
        }
        public int TongSPBanRa_Thang_SP(string Thang, string ma, ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_TongSanPhamBan_Thang_SP('" + Thang + "' ,'"+ma+"') from TB_ChiTietHD", CommandType.Text, ref err, null);
        }
        public int TongSPBanRa_Nam_SP(string Nam, string ma, ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_TongSanPhamBan_Nam_SP('" + Nam + "','" + ma + "') from TB_ChiTietHD", CommandType.Text, ref err, null);
        }
    }
}
