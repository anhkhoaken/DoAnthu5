using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.DTO;

namespace QuanLyNhanVien.DAL
{
    class TONGIAO_DAL
    {
        private static TONGIAO_DAL instance;
        public static TONGIAO_DAL Instance
        {
            get { if (instance == null) instance = new TONGIAO_DAL(); return instance; }
            private set { instance = value; }
        }
        private TONGIAO_DAL() { }
        public bool checkIsExist(string MaTG)
        {
            string query = "SELECT * FROM dbo.TONGIAO WHERE MaTG = N'" + MaTG + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public List<TONGIAO_DTO> LoadListTONGIAO()
        {
            List<TONGIAO_DTO> TonGiao = new List<TONGIAO_DTO>();

            string query = "SELECT * FROM dbo.TONGIAO ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TONGIAO_DTO tongiao = new TONGIAO_DTO(item);
                TonGiao.Add(tongiao);
            }

            return TonGiao;
        }
        public bool InsertTONGIAO(TONGIAO_DTO tongiao)
        {
            string query = "INSERT INTO dbo.TONGIAO(MaTG,TenTG,GhiChu) " +
                "VALUES(N'" + tongiao.MaTG + "',N'" + tongiao.TenTG + "',N'" + tongiao.GhiChu + "') ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public void UpdateTONGIAO(string MaTG, string TenTG, string GhiChu)
        {
            string query = string.Format("UPDATE dbo.TONGIAO SET TenTG = N'{0}', GhiChu = N'{1}' WHERE MaTG = N'{2}' ", TenTG, GhiChu, MaTG);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void DeleteTONGIAO(string MaTG)
        {
            string query = string.Format("DELETE FROM dbo.TONGIAO WHERE MaTG = N'{0}'", MaTG);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
