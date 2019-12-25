using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DTO
{
    class TienLuongDTO
    {
        string _MaNhanVien;
        string _TenNhanVien;
        string _MaHSLuong;
        float _TienLuong;
        int _Thang, _Nam;
        string _GhiChu;
        public TienLuongDTO()
        {

        }
        public TienLuongDTO(DataRow row)
        {
            this.MaNhanVien = row["MaNhanVien"].ToString();
            this.TenNhanVien = row["TenNhanVien"].ToString();
            this.MaHSLuong = row["MaHSLuong"].ToString();
            this.TienLuong = float.Parse(row["TienLuong"].ToString());
            this.Thang = int.Parse(row["Thang"].ToString());
            this.Nam = int.Parse(row["Nam"].ToString());
            this.GhiChu = row["GhiChu"].ToString();
        }
        public TienLuongDTO(string MaNhanVien, string TenNhanVien, string MaHSLuong, float TienLuong, int thang, int nam,string GhiChu)
        {
            this.MaNhanVien = MaNhanVien;
            this.TenNhanVien = TenNhanVien;
            this.MaHSLuong = MaHSLuong;
            this.TienLuong = TienLuong;
            this.Thang = thang;
            this.Nam = nam;
            this.GhiChu = GhiChu;
        }

        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public string TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
        public string MaHSLuong { get => _MaHSLuong; set => _MaHSLuong = value; }
        public float TienLuong { get => _TienLuong; set => _TienLuong = value; }
     //   public DateTime Thoigian { get => thoigian; set => thoigian = value; }
        public int Thang { get => _Thang; set => _Thang = value; }
        public int Nam { get => _Nam; set => _Nam = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
    }
}
