using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.DTO;
using System.Data;

namespace QuanLyNhanVien.DAL
{
    public class HESOLUONGNHANVIEN_DAL
    {
        private static HESOLUONGNHANVIEN_DAL instance;

        public static HESOLUONGNHANVIEN_DAL Instance
        {
            get { if (instance == null) instance = new HESOLUONGNHANVIEN_DAL(); return instance; }
            private set { instance = value; }
        }
        private HESOLUONGNHANVIEN_DAL() { }

        public bool checkIsExist(string MaHSLuong)
        {
            string query = "SELECT * FROM dbo.HESOLUONGNHANVIEN WHERE MaHSLuong = N'" + MaHSLuong + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public List<HESOLUONGNHANVIEN_DTO> LoadListHeSo()
        {
            List<HESOLUONGNHANVIEN_DTO> Heso = new List<HESOLUONGNHANVIEN_DTO>();

            string query = "SELECT * FROM dbo.HESOLUONGNHANVIEN ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HESOLUONGNHANVIEN_DTO heso = new HESOLUONGNHANVIEN_DTO(item);
                Heso.Add(heso);
            }

            return Heso;
        }

        public void addHSLuong(HESOLUONGNHANVIEN_DTO heso)
        {
            string query = string.Format("INSERT INTO dbo.HESOLUONGNHANVIEN (MaHSLuong,MaNgachLuong,MaBac,HSLuong) VALUES (N'{0}',N'{1}',N'{2}',{3} )", heso.MaHSLuong,heso.MaNgachLuong,heso.MaBac,heso.HSLuong);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void DeleteHSLuong(string MaHS)
        {
            string query = string.Format("DELETE FROM dbo.HESOLUONGNHANVIEN WHERE MaHSLuong = N'{0}'", MaHS);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateHeSo(HESOLUONGNHANVIEN_DTO heso)
        {
            string query = string.Format("UPDATE dbo.DANTOC SET MaNgachLuong = N'{0}', MaBac = N'{1}', HSLuong = {2} WHERE MaDT = N'{3}' ", heso.MaNgachLuong,heso.MaBac,heso.HSLuong,heso.MaHSLuong);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
