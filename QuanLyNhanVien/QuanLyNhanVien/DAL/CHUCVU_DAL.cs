using QuanLyNhanVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DAL
{
    public class CHUCVU_DAL
    {
        private static CHUCVU_DAL instance;

        public static CHUCVU_DAL Instance
        {
            get { if (instance == null) instance = new CHUCVU_DAL(); return instance; }
            private set { instance = value; }
        }
        private CHUCVU_DAL() { }

        public bool checkIsExist(string MaCV)
        {
            string query = "SELECT * FROM dbo.CHUCVU WHERE MaCV = N'" + MaCV + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public List<CHUCVU_DTO> LoadListChucVu()
        {
            List<CHUCVU_DTO> Chucvu = new List<CHUCVU_DTO>();

            string query = "SELECT * FROM dbo.CHUCVU ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CHUCVU_DTO chucvu = new CHUCVU_DTO(item);
                Chucvu.Add(chucvu);
            }

            return Chucvu;
        }

        public void addChucVu(CHUCVU_DTO chucvu)
        {
            string query = string.Format("INSERT INTO dbo.CHUCVU (MaCV,TenCV,HeSoCV,GhiChu) VALUES (N'{0}',N'{1}',{2},N'{3}')", chucvu.MaCV,chucvu.TenCV,chucvu.HeSoCV,chucvu.GhiChu);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void DeleteChucVu(string MaCV)
        {
            string query = string.Format("DELETE FROM dbo.CHUCVU WHERE MaCV = N'{0}'", MaCV);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateChucVu(CHUCVU_DTO chucvu)
        {
            string query = string.Format("UPDATE dbo.CHUCVU SET TenCV = N'{0}', HeSoCV = N'{1}', GhiChu = N'{2}' WHERE MaCV = N'{3}' ", chucvu.TenCV,chucvu.HeSoCV,chucvu.GhiChu,chucvu.MaCV);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
