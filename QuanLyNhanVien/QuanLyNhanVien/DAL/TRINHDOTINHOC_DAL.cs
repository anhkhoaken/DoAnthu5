using QuanLyNhanVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyNhanVien.DAL
{
    class TRINHDOTINHOC_DAL
    {
        private static TRINHDOTINHOC_DAL instance;
        public static TRINHDOTINHOC_DAL Instance
        {
            get { if (instance == null) instance = new TRINHDOTINHOC_DAL(); return instance; }
            private set { instance = value; }
        }
        private TRINHDOTINHOC_DAL() { }
        public bool checkIsExist(string Ma)
        {
            string query = "SELECT * FROM dbo.TRINHDOTINHOC WHERE MaTDTH = N'" + Ma + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public List<TRINHDOTINHOC_DTO> LoadListTDTH()
        {
            List<TRINHDOTINHOC_DTO> TDTH = new List<TRINHDOTINHOC_DTO>();

            string query = "SELECT * FROM dbo.TRINHDOTINHOC ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TRINHDOTINHOC_DTO tdtt = new TRINHDOTINHOC_DTO(item);
                TDTH.Add(tdtt);
            }

            return TDTH;
        }
        public bool InsertTDTH(TRINHDOTINHOC_DTO tdth)
        {
            string query = "INSERT INTO dbo.TRINHDOTINHOC(MaTDTH,TenTDTH) " +
                "VALUES(N'" + tdth.MaTDTH + "',N'" + tdth.TenTDTH + "') ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public void UpdateTDTH(string MaTDTH, string TenTDTH)
        {
            string query = string.Format("UPDATE dbo.TRINHDOTINHOC SET TenTDTH = N'{0}' WHERE MaTDTH = N'{1}' ", TenTDTH, MaTDTH);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void DeleteTDTH(string Ma)
        {
            string query = string.Format("DELETE FROM dbo.TRINHDOTINHOC WHERE MaTDTH = N'{0}'", Ma);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
