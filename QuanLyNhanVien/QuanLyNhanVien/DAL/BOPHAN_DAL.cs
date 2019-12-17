using QuanLyNhanVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DAL
{
    public class BOPHAN_DAL
    {
        private static BOPHAN_DAL instance;

        public static BOPHAN_DAL Instance
        {
            get { if (instance == null) instance = new BOPHAN_DAL(); return instance; }
            private set { instance = value; }
        }
        private BOPHAN_DAL() { }

        public bool checkIsExist(string MaBoPhan)
        {
            string query = "SELECT * FROM dbo.BOPHAN WHERE MaBoPhan = N'" + MaBoPhan + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public List<BOPHAN_DTO> LoadListBoPhan()
        {
            List<BOPHAN_DTO> Bophan = new List<BOPHAN_DTO>();

            string query = "SELECT * FROM dbo.BOPHAN ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BOPHAN_DTO bophan = new BOPHAN_DTO(item);
                Bophan.Add(bophan);
            }

            return Bophan;
        }

        public void addBophan(BOPHAN_DTO bophan)
        {
            string query = string.Format("INSERT INTO dbo.BOPHAN (MaBoPhan,TenBoPhan,PhongBan,GhiChu) VALUES (N'{0}',N'{1}',N'{2}',N'{3}')", bophan.MaBoPhan, bophan.TenBoPhan, bophan.PhongBan, bophan.GhiChu);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void DeleteBOPHAN(string MaBoPhan)
        {
            string query = string.Format("DELETE FROM dbo.BOPHAN WHERE MaBoPhan = N'{0}'", MaBoPhan);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateBOPHAN(BOPHAN_DTO bophan)
        {
            string query = string.Format("UPDATE dbo.BOPHAN SET TenBoPhan = N'{0}', PhongBan = N'{1}', GhiChu = N'{2}' WHERE MaBoPhan = N'{3}' ", bophan.TenBoPhan, bophan.PhongBan,bophan.GhiChu,bophan.MaBoPhan);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
