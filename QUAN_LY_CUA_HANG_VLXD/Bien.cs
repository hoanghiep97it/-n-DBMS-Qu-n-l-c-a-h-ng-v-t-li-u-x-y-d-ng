using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_CUA_HANG_VLXD
{
    public class Bien
    {
        public static int ngay;
        public static int thang;
        public static int nam;
        public static string tenNV, chiNhanh;
        public static string cuaHang;
        public static string kho;
        public static int quyen;
        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }

        }
        public string ChiNhanh
        {
            get { return chiNhanh; }
            set { chiNhanh = value; }

        }
        public int Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }
        public int Thang
        {
            get { return thang; }
            set { thang = value; }
        }
        public int Nam
        {
            get { return nam; }
            set { nam = value; }
        }
        public string CuaHang
        {
            get { return cuaHang; }
            set { cuaHang = value; }

        }
        public string Kho
        {
            get { return kho; }
            set { kho = value; }

        }
        public int Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }
    }
}
