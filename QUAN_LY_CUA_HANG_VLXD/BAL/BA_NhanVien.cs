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
    public class BA_NhanVien
    {
        //Tao bien ket noi
        DALayer db = null;
        //Khoi tao ket noi
        public BA_NhanVien()
        {
            db = new DALayer();
          
        }

        public bool ThemNhanVien(string MaNV, string Username, string MaPQ, string TenNV, string GioiTinh, string NgaySinh, string DiaChi, string Phone, string Email, string TinhTrang, ref string err)
        {
            return db.MyExecuteNonQuery("Execute SP_NhanVien_insert '" + MaNV + "','" + Username + "','" + MaPQ + "','" + TenNV + "','" + GioiTinh + "','" + NgaySinh + "','" + DiaChi + "','" + Phone + "','" + Email + "','" + TinhTrang + "';", CommandType.Text, ref err);
        }

        public bool UpdateNhanVien(string MaNV, string Username, string MaPQ, string TenNV, string GioiTinh, string NgaySinh, string DiaChi, string Phone, string Email, string TinhTrang, ref string err)
        {
            return db.MyExecuteNonQuery("Execute SP_NhanVien_update '" + MaNV + "','" + Username + "','" + MaPQ + "','" + TenNV + "','" + GioiTinh + "','" + NgaySinh + "','" + DiaChi + "','" + Phone + "','" + Email + "','" + TinhTrang + "';", CommandType.Text, ref err);
        }
        public bool DeleteNhanVien(string MaNV, ref string err)
        {
            return db.MyExecuteNonQuery("Execute SP_NhanVien_delete '" + MaNV + "';", CommandType.Text, ref err);
        }
        public DataSet LoadNhanVien()
        {
            return db.ExecuteQueryDataSet("Execute SP_NhanVien_selectall", CommandType.Text, null);
        }
        public DataSet LoadNhanVien_Ma(string MaNV)
        {
            return db.ExecuteQueryDataSet("Execute SP_NhanVien_select_byID '" + MaNV + "';", CommandType.Text, null);
        }
        public int TongNhanVien(ref string err)
        {
            return db.MyExecuteScalar("select distinct dbo.FT_DemSLNhanVien() from TB_NhanVien", CommandType.Text,ref err, null);
        }
    }
}
