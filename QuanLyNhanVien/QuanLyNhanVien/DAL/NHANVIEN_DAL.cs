using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.DTO;


namespace QuanLyNhanVien.DAL
{
    class NHANVIEN_DAL
    {
        private static NHANVIEN_DAL instance;
        public static NHANVIEN_DAL Instance
        {
            get { if (instance == null) instance = new NHANVIEN_DAL(); return instance; }
            private set { instance = value; }
        }
        private NHANVIEN_DAL() { }
        public bool checkIsExist(string MaPB)
        {
            string query = "SELECT * FROM dbo.PHONGBAN WHERE MaPB = N'" + MaPB + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public List<NhanVien_DTO> LoadListNHANVIEN()
        {
            List<NhanVien_DTO> NhanVien = new List<NhanVien_DTO>();

            string query = "SELECT * FROM dbo.NhanVien ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien_DTO nhanvien = new NhanVien_DTO(item);
                NhanVien.Add(nhanvien);
            }

            return NhanVien;
        }
        public bool InsertNHANVIEN(NhanVien_DTO nhanvien)
        {
            string query = "INSERT INTO dbo.NHANVIEN(MaNhanVien,TenNhanVien,MaBac,MaBoPhan,MaCV,MaHSLuong,MaNV,MaNgach,MaPB,MaQT,MaTG,MaTDHV,MaTDNN,MaTDTH,GhiChu,MaDT) " +
                "VALUES(N'" + nhanvien.MaNhanVien + "',N'" + nhanvien.TenNhanVien + "',N'" + nhanvien.MaBac + "',N'" + nhanvien.MaBoPhan + "',N'" + nhanvien.MaCV + "',N'" + nhanvien.MaHSLuong + "',N'" + nhanvien.MaNV + "',N'" + nhanvien.MaNghach + "',N'" + nhanvien.MaPB + "',N'" + nhanvien.MaQT + "',N'" + nhanvien.MaTG + "',N'" + nhanvien.MaTDHV + "',N'" + nhanvien.MaTDNN + "',N'" + nhanvien.MaTDTH + "',N'" + nhanvien.GhiChu + "' ,N'" + nhanvien.MaDT + "') ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public void UpdateNHANVIEN(string MaNhanVien, string TenNhanVien,string MaBac, string MaBoPhan, string MaCV, string MaHSLuong, string MaNV, string MaNgach, string MaPB, string MaQT, string MaTG, string MaTDHV, string MaTDNN, string MaTDTH, string GhiChu, string MaDT)
        {
            string query = string.Format("UPDATE dbo.NhanVien SET TenNhanVien = N'{0}' , MaBac = N'{1}' , MaBoPhan = N'{2}', MaCV = N'{3}', MaHSLuong = N'{4}' , MaNV = N'{5}' , MaNgach = N'{6}' , MaPB = N'{7}' , MaQT = N'{8}' , MaTG = N'{9}' , MaTDHV = N'{10}' , MaTDNN = N'{11}' , MaTDTH = N'{12}' , GhiChu = N'{13}' , MaDT = N'{14}' WHERE MaNhanVien = N'{15}' ",  TenNhanVien,  MaBac,  MaBoPhan,  MaCV,  MaHSLuong,  MaNV,  MaNgach,  MaPB,  MaQT,  MaTG,  MaTDHV,  MaTDNN,  MaTDTH,  GhiChu, MaDT, MaNhanVien);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void DeleteNHANVIEN(string MaNhanVien)
        {
            string query = string.Format("DELETE FROM dbo.NhanVien WHERE MaNhanVien = N'{0}'", MaNhanVien);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
