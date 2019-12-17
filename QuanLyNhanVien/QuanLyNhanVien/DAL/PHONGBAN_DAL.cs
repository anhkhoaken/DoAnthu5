using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.DTO;

namespace QuanLyNhanVien.DAL
{
    class PHONGBAN_DAL
    {
        private static PHONGBAN_DAL instance;
        public static PHONGBAN_DAL Instance
        {
            get { if (instance == null) instance = new PHONGBAN_DAL(); return instance; }
            private set { instance = value; }
        }
        private PHONGBAN_DAL() { }
        public bool checkIsExist(string MaPB)
        {
            string query = "SELECT * FROM dbo.PHONGBAN WHERE MaPB = N'" + MaPB + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public List<PHONGBAN_DTO> LoadListPHONGBAN()
        {
            List<PHONGBAN_DTO> PhongBan = new List<PHONGBAN_DTO>();

            string query = "SELECT * FROM dbo.PHONGBAN ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PHONGBAN_DTO phongban = new PHONGBAN_DTO(item);
                PhongBan.Add(phongban);
            }

            return PhongBan;
        }
        public bool InsertPHONGBAN(PHONGBAN_DTO phongban)
        {
            string query = "INSERT INTO dbo.PHONGBAN(MaPB,TenPB,SoLuongNhanVien,GhiChu) " +
                "VALUES(N'" + phongban.MaPB + "',N'" + phongban.TenPB + "',N'" + phongban.SoLuongNhanVien + "',N'" + phongban.GhiChu + "') ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdatePHONGBAN(string MaPB, string TenPB, int SoLuongNhanVien, string GhiChu)
        {
            string query = string.Format("UPDATE dbo.PHONGBAN SET TenPB = N'{0}', SoLuongNhanVien = {1}, GhiChu = {2} WHERE MaPB = {3}", TenPB, SoLuongNhanVien, GhiChu, MaPB);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeletePHONGBAN(int MaPB)
        {
            string query = string.Format("Delete PHONGBAN where id = {0}", MaPB);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
