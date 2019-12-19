using QuanLyNhanVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DAL
{
    public class DANTOC_DAL
    {
        private static DANTOC_DAL instance;

        public static DANTOC_DAL Instance
        {
            get { if (instance == null) instance = new DANTOC_DAL(); return instance; }
            private set { instance = value; }
        }
        private DANTOC_DAL() { }

        public bool checkIsExist(string MaDT)
        {
            string query = "SELECT * FROM dbo.DANTOC WHERE MaDT = N'" + MaDT + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public List<DANTOC_DTO> LoadListDanToc()
        {
            List<DANTOC_DTO> Dantoc = new List<DANTOC_DTO>();

            string query = "SELECT * FROM dbo.DANTOC ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DANTOC_DTO dantoc = new DANTOC_DTO(item);
                Dantoc.Add(dantoc);
            }

            return Dantoc;
        }

        public void addDanToc(DANTOC_DTO dantoc)
        {
            string query = string.Format("INSERT INTO dbo.DANTOC (MaDT,TenDT,GhiChu) VALUES (N'{0}',N'{1}',N'{2}' )", dantoc.MaDT,dantoc.TenDT,dantoc.GhiChu);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void DeleteDantoc(string MaDT)
        {
            string query = string.Format("DELETE FROM dbo.DANTOC WHERE MaDT = N'{0}'", MaDT);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateDanToc(DANTOC_DTO dantoc)
        {
            string query = string.Format("UPDATE dbo.DANTOC SET TenDT = N'{0}', GhiChu = N'{1}' WHERE MaDT = N'{2}' ",dantoc.TenDT,dantoc.GhiChu,dantoc.MaDT);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
