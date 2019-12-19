using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DTO
{
    public class HESOLUONGNHANVIEN_DTO
    {
        private string _MaHSLuong;
        private string _MaNgachLuong;
        private string _MaBac;
        private float _HSLuong;

        public HESOLUONGNHANVIEN_DTO(string MaHSLuong, string MaNgachLuong, string MaBac, float HSLuong)
        {
            this.MaHSLuong = MaHSLuong;
            this.MaNgachLuong = MaNgachLuong;
            this.MaBac = MaBac;
            this.HSLuong = HSLuong;
        }
        public HESOLUONGNHANVIEN_DTO(DataRow row)
        {
            this.MaHSLuong = row["MaHSLuong"].ToString();
            this.MaNgachLuong = row["MaNgachLuong"].ToString();
            this.MaBac = row["MaBac"].ToString();
            this.HSLuong = float.Parse(row["HSLuong"].ToString());
        }

        public string MaHSLuong { get => _MaHSLuong; set => _MaHSLuong = value; }
        public string MaNgachLuong { get => _MaNgachLuong; set => _MaNgachLuong = value; }
        public string MaBac { get => _MaBac; set => _MaBac = value; }
        public float HSLuong { get => _HSLuong; set => _HSLuong = value; }
    }
}
