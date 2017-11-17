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

        public DataSet ThemNhanVien(string MaNV, string Username, string MaPQ, string TenNV, string GioiTinh, string NgaySinh, string DiaChi, string Phone, string Email, string TinhTrang)
        {
            return db.ExecuteQueryDataSet("Execute SP_NhanVien_insert '"+MaNV+"','"+Username+"','"+MaPQ+"','"+TenNV+"','"+GioiTinh+"','"+NgaySinh+"','"+DiaChi+"','"+Phone+"','"+Email+"','"+TinhTrang+"';", CommandType.Text);
        }

        public DataSet UpdateNhanVien(string MaNV, string Username, string MaPQ, string TenNV, string GioiTinh, string NgaySinh, string DiaChi, string Phone, string Email, string TinhTrang)
        {
            return db.ExecuteQueryDataSet("Execute SP_NhanVien_update '" + MaNV + "','" + Username + "','" + MaPQ + "','" + TenNV + "','" + GioiTinh + "','" + NgaySinh + "','" + DiaChi + "','" + Phone + "','" + Email + "','" + TinhTrang + "';", CommandType.Text);
        }
        public DataSet DeleteNhanVien()
        {
            return db.ExecuteQueryDataSet("Execute SP_NhanVien_delete", CommandType.Text);
        }
        public DataSet LoadNhanVien()
        {
            return db.ExecuteQueryDataSet("Execute SP_NhanVien_selectall", CommandType.Text);
        }
        public DataSet LoadNhanVien_Ma(string MaNV)
        {
            return db.ExecuteQueryDataSet("Execute SP_NhanVien_select_byID '"+MaNV+"';", CommandType.Text);
        }
    }
}
