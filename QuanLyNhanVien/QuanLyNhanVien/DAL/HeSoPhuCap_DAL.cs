using QuanLyNhanVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DAL
{
    class HeSoPhuCap_DAL
    {
        private static HeSoPhuCap_DAL instance;

        public static HeSoPhuCap_DAL Instance
        {
            get { if (instance == null) instance = new HeSoPhuCap_DAL(); return instance; }
            private set { instance = value; }
        }
        private HeSoPhuCap_DAL() { }

        public bool checkIsExist(string MaBac)
        {
            string query = "SELECT * FROM dbo.HESOPHUCAP WHERE MaHSPC = N'" + MaBac + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public List<HeSoPhuCap_DTO> LoadList()
        {
            List<HeSoPhuCap_DTO> HSPC = new List<HeSoPhuCap_DTO>();

            string query = "SELECT * FROM dbo.HESOPHUCAP ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HeSoPhuCap_DTO hspc = new HeSoPhuCap_DTO(item);
                HSPC.Add(hspc);
            }

            return HSPC;
        }
        public HeSoPhuCap_DTO Load(string ma)
        {
            HeSoPhuCap_DTO HSPC = new HeSoPhuCap_DTO();

            string query = "SELECT * FROM dbo.HESOPHUCAP WHERE MaHSPC = N'" + ma + "' " ;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            HeSoPhuCap_DTO hspc = new HeSoPhuCap_DTO(data.Rows[0]);
            return hspc;
        }


        public void add(HeSoPhuCap_DTO hspc)
        {
            string query = "INSERT INTO dbo.HESOPHUCAP(MaHSPC,TenHSPC) " +
                "VALUES(N'" + hspc.MaHSPC + "',N'" + hspc.TenHSPC + "') ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void Delete(string Ma)
        {
            string query = string.Format("DELETE FROM dbo.HESOPHUCAP WHERE MaHSPC = N'{0}'", Ma);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void Update(string ma, string ten)
        {
            string query = string.Format("UPDATE dbo.HESOPHUCAP SET TenHSPC = N'{0}' WHERE MaHSPC = N'{1}' ", ten, ma);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
