using QuanLyNhanVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DAL
{
    public class Ngach_DAL
    {
        private static Ngach_DAL instance;

        public static Ngach_DAL Instance
        {
            get { if (instance == null) instance = new Ngach_DAL(); return instance; }
            private set { instance = value; }
        }
        private Ngach_DAL() { }

        public bool checkIsExist(string maNgach)
        {
            string query = "SELECT * FROM dbo.NGACH WHERE Magach = N'" + maNgach + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public List<NGACH_DTO> LoadListBoPhan()
        {
            List<NGACH_DTO> Ngach = new List<NGACH_DTO>();

            string query = "SELECT * FROM dbo.NGACH ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NGACH_DTO ngach = new NGACH_DTO(item);
                Ngach.Add(ngach);
            }

            return Ngach;
        }

        public void addNgach(NGACH_DTO ngach)
        {
            string query = string.Format("INSERT INTO dbo.NGACH (MaNgach,TenNgach) VALUES (N'{0}',N'{1}')", ngach.MaNgach, ngach.TenNgach);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void DeleteNgach(string maNgach)
        {
            string query = string.Format("DELETE FROM dbo.NGACH WHERE MaNgach = N'{0}'", maNgach);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateNGACH(NGACH_DTO ngach)
        {
            string query = string.Format("UPDATE dbo.NGACH SET TenNgach = N'{0}' WHERE MaNgach = N'{1}'", ngach.TenNgach, ngach.MaNgach);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
