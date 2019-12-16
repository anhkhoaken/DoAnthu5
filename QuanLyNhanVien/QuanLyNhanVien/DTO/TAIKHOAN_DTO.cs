using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DTO
{
    public class TAIKHOAN_DTO
    {
        private string _MaNV;
        private string _TaiKhoan;
        private string _MatKhau;

        public TAIKHOAN_DTO(string MaNV, string TaiKhoan, string MatKhau)
        {
            this.MaNV = MaNV;
            this.TaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
        }

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string TaiKhoan { get => _TaiKhoan; set => _TaiKhoan = value; }
        public string MatKhau { get => _MatKhau; set => _MatKhau = value; }
    }
}
