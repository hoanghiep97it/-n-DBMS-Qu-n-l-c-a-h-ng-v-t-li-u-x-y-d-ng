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
    class BA_SanPham
    {
        //Tao bien ket noi
        DALayer db = null;
        //Khoi tao ket noi
        public BA_SanPham()
        {
            db = new DALayer();
          
        }
        //Lay thong tin nhan vien thong qua store LoadNhanVien ,tra ve 1 dataset
        public DataSet LoadSanPham()
        {
            return db.ExecuteQueryDataSet("Execute SP_SanPham_selectall", CommandType.Text);
        }

    }

}
