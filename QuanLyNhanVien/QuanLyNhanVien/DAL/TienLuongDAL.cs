using QuanLyNhanVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DAL
{
    class TienLuongDAL
    {
        private static TienLuongDAL instance;

        public static TienLuongDAL Instance
        {
            get { if (instance == null) instance = new TienLuongDAL(); return instance; }
            private set { instance = value; }
        }
        private TienLuongDAL() { }

        public bool checkIsExist(string Ma, int thang, int nam)
        {
            string query = "SELECT * FROM dbo.TienLuong WHERE MaNhanVien = N'" + Ma + "' AND THANG = N'" + thang + "' AND NAM = N'" + nam + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public List<TienLuongDTO> LoadList()
        {
            List<TienLuongDTO> TienLuong = new List<TienLuongDTO>();

            string query = "SELECT * FROM dbo.TienLuong  ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TienLuongDTO tienluong = new TienLuongDTO(item);
                TienLuong.Add(tienluong);
            }

            return TienLuong;
        }
        public List<TienLuongDTO> Load(string Ma)
        {
            List<TienLuongDTO> TienLuong = new List<TienLuongDTO>();

            string query = "SELECT * FROM dbo.TienLuong WHERE MaNhanVien = N'" + Ma + "' ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TienLuongDTO tienluong = new TienLuongDTO(item);
                TienLuong.Add(tienluong);
            }

            return TienLuong;
        }
        public List<TienLuongDTO> LoadListTG(int thang,int nam)
        {
            List<TienLuongDTO> TienLuong = new List<TienLuongDTO>();

            string query = "SELECT * FROM dbo.TienLuong WHERE THANG = N'" + thang + "' AND NAM = N'" + nam + "' ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TienLuongDTO tienluong = new TienLuongDTO(item);
                TienLuong.Add(tienluong);
            }

            return TienLuong;
        }
        public void add(TienLuongDTO tienluong)
        {
            string query = "INSERT INTO dbo.TienLuong(MaNhanVien,TenNhanVien,MaHSLuong,TienLuong,Thang,Nam,GhiChu) " +
                "VALUES(N'" + tienluong.MaNhanVien + "',N'" + tienluong.TenNhanVien + "',N'" + tienluong.MaHSLuong + "',N'" + tienluong.TienLuong + "',N'" + tienluong.Thang + "',N'" + tienluong.Nam + "',N'" + tienluong.GhiChu + "') ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
          
        }

        public void Delete(string Ma)


        {
            string query = string.Format("DELETE FROM dbo.TienLuong WHERE MaNhanVien = N'{0}'", Ma);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void Update(TienLuongDTO tienluong)
        {
            string query = string.Format("UPDATE dbo.TienLuong SET TenNhanVien = N'{0}', MaHSLuong = N'{1}', TienLuong = N'{2}' , Thang = N'{3}' , Nam = N'{4}' , GhiChu = N'{5}' WHERE MaNhanVien = N'{6}' ", tienluong.TenNhanVien,tienluong.MaHSLuong,tienluong.TienLuong,tienluong.Thang,tienluong.Nam,tienluong.GhiChu,tienluong.MaNhanVien);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
