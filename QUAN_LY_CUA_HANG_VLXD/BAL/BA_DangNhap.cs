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
    public class BA_DangNhap
    {
        DALayer db = null;
        //Khoi tao ket noi
        public BA_DangNhap()
        {
            db = new DALayer();
          
        }
        public bool DBAccess(string ip, string bd, string quyen, string passht)
        {
            return db.accesssDB(ip, bd, quyen, passht);
        }

        public bool DangNhap(string quyen, string User, string Pass, ref string err)
        {
            return db.MyExecuteNonQuery("Execute SP_DangNhap '" + User + "','" + Pass + "','" + quyen + "';", CommandType.Text, ref err);
        }
        public int KTDangNhap(string User, string Pass)
        {
            int dn = db.MyExecuteScalar("select distinct dbo.FT_DangNhap('" + User + "','" + Pass + "') from TB_TaiKhoan", CommandType.Text);
            return dn;
        }
    }
}
