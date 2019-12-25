using QuanLyNhanVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyNhanVien.DAL
{
    class Cong_DAL
    {
        private static Cong_DAL instance;

        public static Cong_DAL Instance
        {
            get { if (instance == null) instance = new Cong_DAL(); return instance; }
            private set { instance = value; }
        }
        private Cong_DAL() { }

        public bool checkIsExist(string Ma)
        {
            string query = "SELECT * FROM dbo.Cong WHERE MaNhanVien = N'" + Ma + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public bool check(int thang,int nam,string ma)
        {
            string query = "SELECT * FROM dbo.Cong WHERE THANG = N'" + thang + "' AND NAM = N'" + nam + "' AND MaNhanVien = N'" + ma + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public List<Cong_DTO> Load(int thang,int nam)
        {
            List<Cong_DTO> Cong = new List<Cong_DTO>();

            string query = "SELECT * FROM dbo.Cong WHERE THANG = N'" + thang + "' AND NAM = N'" + nam + "' ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Cong_DTO cong = new Cong_DTO(item);
                Cong.Add(cong);
            }

            return Cong;
        }
        public List<Cong_DTO> Load(string ma,int thang, int nam)
        {
            List<Cong_DTO> Cong = new List<Cong_DTO>();

            string query = "SELECT * FROM dbo.Cong WHERE MaNhanVien = N'" + ma + "' AND THANG = N'" + thang + "' AND NAM = N'" + nam + "' ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Cong_DTO cong = new Cong_DTO(item);
                Cong.Add(cong);
            }

            return Cong;
        }
        public List<Cong_DTO> LoadId(string ma)
        {
            List<Cong_DTO> Cong = new List<Cong_DTO>();

            string query = "SELECT * FROM dbo.Cong WHERE MaNhanVien = N'" + ma + "' ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Cong_DTO cong = new Cong_DTO(item);
                Cong.Add(cong);
            }

            return Cong;
        }
        public List<Cong_DTO> LoadList()
        {
            List<Cong_DTO> Cong = new List<Cong_DTO>();

            string query = "SELECT * FROM dbo.Cong ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Cong_DTO cong = new Cong_DTO(item);
                Cong.Add(cong);
            }

            return Cong;
        }

        public void add(Cong_DTO cong)
        {
            string query = string.Format("INSERT INTO dbo.Cong (MaNhanVien,TenNhanVien,NgayCong,MaHSPC,Thang,Nam) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')", cong.MaNhanVien, cong.TenNhanVien, cong.NgayCong, cong.MaHSPC,cong.Thang,cong.Nam);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void Delete(string Ma)
        {
            string query = string.Format("DELETE FROM dbo.Cong WHERE MaNhanVien = N'{0}'", Ma);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void Update(Cong_DTO cong)
        {
            string query = string.Format("UPDATE dbo.Cong SET TenNhanVien = N'{0}' , NgayCong = N'{1}' , MaHSPC = N'{2}', Thang = N'{3}', Nam = N'{4}' WHERE MaNhanVien = N'{5}' ", cong.TenNhanVien, cong.NgayCong, cong.MaHSPC, cong.Thang, cong.Nam, cong.MaNhanVien);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
