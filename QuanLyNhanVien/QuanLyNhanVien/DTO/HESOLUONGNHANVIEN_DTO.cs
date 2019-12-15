using System;
using System.Collections.Generic;
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

        public string MaHSLuong { get => _MaHSLuong; set => _MaHSLuong = value; }
        public string MaNgachLuong { get => _MaNgachLuong; set => _MaNgachLuong = value; }
        public string MaBac { get => _MaBac; set => _MaBac = value; }
        public float HSLuong { get => _HSLuong; set => _HSLuong = value; }
    }
}
