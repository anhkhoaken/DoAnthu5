using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DAL
{
    public class TAIKHOAN_DAL
    {
        private static TAIKHOAN_DAL instance;

        public static TAIKHOAN_DAL Instance
        {
            get { if (instance == null) instance = new TAIKHOAN_DAL(); return instance; }
            private set { instance = value; }
        }

        private TAIKHOAN_DAL() { }
        public bool Login(string Taikhoan,string MatKhau)
        {
            string query = "SELECT * FROM dbo.TAIKHOAN WHERE TaiKhoan = N'" + Taikhoan + "' AND MatKhau = N'" + MatKhau + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
    }
}
