using QuanLyNhanVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DAL
{
    class TRINHDONGOAINGU_DAL
    {
        private static TRINHDONGOAINGU_DAL instance;

        public static TRINHDONGOAINGU_DAL Instance
        {
            get { if (instance == null) instance = new TRINHDONGOAINGU_DAL(); return instance; }
            private set { instance = value; }
        }
        private TRINHDONGOAINGU_DAL() { }

        public bool checkIsExist(string Ma)
        {
            string query = "SELECT * FROM dbo.TRINHDONGOAINGU WHERE MaTDNN = N'" + Ma + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public List<TRINHDONGOAINGU_DTO> LoadListTDNN()
        {
            List<TRINHDONGOAINGU_DTO> TDNN = new List<TRINHDONGOAINGU_DTO>();

            string query = "SELECT * FROM dbo.TRINHDONGOAINGU ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TRINHDONGOAINGU_DTO tdnn = new TRINHDONGOAINGU_DTO(item);
                TDNN.Add(tdnn);
            }

            return TDNN;
        }

        public void InsertTDNN(TRINHDONGOAINGU_DTO tdnn)
        {
            string query = "INSERT INTO dbo.TRINHDONGOAINGU(MaTDNN,TenTDNN) " +
                "VALUES(N'" + tdnn.MaTDNN + "',N'" + tdnn.TenTDNN + "') ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void DeleteTDNN(string Ma)
        {
            string query = string.Format("DELETE FROM dbo.TRINHDONGOAINGU WHERE MaTDNN = N'{0}'", Ma);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateTDNN(string maTDNN, string tenTDNN)
        {
            string query = string.Format("UPDATE dbo.TRINHDONGOAINGU SET TenTDNN = N'{0}' WHERE Matdnn = N'{1}' ", tenTDNN, maTDNN);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
