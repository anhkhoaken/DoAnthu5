using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.DTO;

namespace QuanLyNhanVien.DAL
{
    public class HONNHAN_DAL
    {
        private static HONNHAN_DAL instance;

        public static HONNHAN_DAL Instance
        {
            get { if (instance == null) instance = new HONNHAN_DAL(); return instance; }
            private set { instance = value; }
        }
        private HONNHAN_DAL() { }

        public bool checkIsExist(string MaNV)
        {
            string query = "SELECT * FROM dbo.HONNHAN WHERE MaNV = N'" + MaNV + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public List<HONNHAN_DTO> LoadListHonNhan()
        {
            List<HONNHAN_DTO> HonNhan = new List<HONNHAN_DTO>();

            string query = "SELECT * FROM dbo.HONNHAN ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HONNHAN_DTO honnhan = new HONNHAN_DTO(item);
                HonNhan.Add(honnhan);
            }

            return HonNhan;
        }

        public void addHonNhan(HONNHAN_DTO honnhan)
        {
            string query = string.Format("INSERT INTO dbo.HONNHAN (MaNV,Honey,TenVoChong,NTDuoi15,NTTren15,NTTren60) VALUES (N'{0}',N'{1}',N'{2}',{3},{4},{5} )", honnhan.MaNV,honnhan.Honey,honnhan.TenVoChong,honnhan.NTDuoi15,honnhan.NTTren15,honnhan.NTTren60);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void DeleteHonNhan(string MaNV)
        {
            string query = string.Format("DELETE FROM dbo.HONNHAN WHERE MaNV = N'{0}'", MaNV);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateHonNhan(HONNHAN_DTO honnhan)
        {
            string query = string.Format("UPDATE dbo.HONNHAN SET Honey = N'{0}', TenVoChong = N'{1}', NTDuoi15 = {2}, NTTren15 = {3}, NTTren60 = {4} WHERE MaNV = N'{5}' ", honnhan.Honey,honnhan.TenVoChong,honnhan.NTDuoi15,honnhan.NTTren15,honnhan.NTTren60,honnhan.MaNV);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
