using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.DTO;

namespace QuanLyNhanVien.DAL
{
    class TRINHDOHOCVAN_DAL
    {
        private static TRINHDOHOCVAN_DAL instance;
        public static TRINHDOHOCVAN_DAL Instance
        {
            get { if (instance == null) instance = new TRINHDOHOCVAN_DAL(); return instance; }
            private set { instance = value; }
        }
        private TRINHDOHOCVAN_DAL() { }
        public bool checkIsExist(string Ma)
        {
            string query = "SELECT * FROM dbo.TRINHDOHOCVAN WHERE MaTDHV = N'" + Ma + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public List<TRINHDOHOCVAN_DTO> LoadListTDHV()
        {
            List<TRINHDOHOCVAN_DTO> TDHV = new List<TRINHDOHOCVAN_DTO>();

            string query = "SELECT * FROM dbo.TRINHDOHOCVAN ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TRINHDOHOCVAN_DTO tdhv = new TRINHDOHOCVAN_DTO(item);
                TDHV.Add(tdhv);
            }

            return TDHV;
        }
        public bool InsertTDHV(TRINHDOHOCVAN_DTO tdhv)
        {
            string query = "INSERT INTO dbo.TRINHDOHOCVAN(MaTDHV,TenTDHV,GhiChu) " +
                "VALUES(N'" + tdhv.MaTDHV + "',N'" + tdhv.TenTDHV + "',N'" + tdhv.GhiChu + "') ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
       
    }
}
