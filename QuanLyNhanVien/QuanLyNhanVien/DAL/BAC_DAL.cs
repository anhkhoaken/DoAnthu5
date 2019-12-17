using QuanLyNhanVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DAL
{
    public class BAC_DAL
    {
        private static BAC_DAL instance;

        public static BAC_DAL Instance
        {
            get { if (instance == null) instance = new BAC_DAL(); return instance; }
            private set { instance = value; }
        }
        private BAC_DAL() { }

        public bool checkIsExist(string MaBac)
        {
            string query = "SELECT * FROM dbo.BAC WHERE MaBac = N'" + MaBac + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public List<BAC_DTO> LoadListBAC()
        {
            List<BAC_DTO> Bac = new List<BAC_DTO>();

            string query = "SELECT * FROM dbo.BAC ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                BAC_DTO bac = new BAC_DTO(item);
                Bac.Add(bac);
            }

            return Bac;
        }

        public void addBAC(BAC_DTO bac)
        {
            string query = "INSERT INTO dbo.BAC(MaBac,TenBac) " +
                "VALUES(N'" + bac.MaBac + "',N'" + bac.TenBac + "') ";
             DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void DeleteBAC(string MaBac)
        {
            string query = string.Format("DELETE FROM dbo.BAC WHERE MaBac = N'{0}'", MaBac);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateBAC(string maBac, string tenBac)
        {
            string query = string.Format("UPDATE dbo.BAC SET TenBac = N'{0}' WHERE MaBac = N'{1}' ", tenBac, maBac);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

    }
}
