using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.DTO;
namespace QuanLyNhanVien.DAL
{
    class QUOCTICH_DAL
    {
        private static QUOCTICH_DAL instance;
        public static QUOCTICH_DAL Instance
        {
            get { if (instance == null) instance = new QUOCTICH_DAL(); return instance; }
            private set { instance = value; }
        }
        private QUOCTICH_DAL() { }
        public bool checkIsExist(string MaPB)
        {
            string query = "SELECT * FROM dbo.QUOCTICH WHERE MaQT = N'" + MaPB + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public List<QuocTich_DTO> LoadListQUOCTICH()
        {
            List<QuocTich_DTO> QuocTich = new List<QuocTich_DTO>();

            string query = "SELECT * FROM dbo.QUOCTICH ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                QuocTich_DTO quoctich = new QuocTich_DTO(item);
                QuocTich.Add(quoctich);
            }

            return QuocTich;
        }
        public bool InsertQUOCTICH(QuocTich_DTO quoctich)
        {
            string query = "INSERT INTO dbo.QUOCTICH(MaQT,TenQT,GhiChu) " +
                "VALUES(N'" + quoctich.MaQT + "',N'" + quoctich.TenQT + "',N'" + quoctich.GhiChu + "') ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public void UpdateQUOCTICH(string MaQT, string TenQT, string GhiChu)
        {
            string query = string.Format("UPDATE dbo.QUOCTICH SET TenQT = N'{0}', GhiChu = N'{1}' WHERE MaQT = N'{2}' ", TenQT, GhiChu, MaQT);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void DeleteQUOCTICH(string MaQT)
        {
            string query = string.Format("DELETE FROM dbo.QUOCTICH WHERE MaQT = N'{0}'", MaQT);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
