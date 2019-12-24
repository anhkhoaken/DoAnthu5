using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DTO
{
    class Cong_DTO
    {
        string _MaNhanVien;
        string _TenNhanVien;
        int _NgayCong;
        string _MaHSPC;
        int _Thang;
        int _Nam;

        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public string TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
        public int NgayCong { get => _NgayCong; set => _NgayCong = value; }
        public string MaHSPC { get => _MaHSPC; set => _MaHSPC = value; }
        public int Thang { get => _Thang; set => _Thang = value; }
        public int Nam { get => _Nam; set => _Nam = value; }

        public Cong_DTO()
        {

        }

        public Cong_DTO(string MaNhanVien, string TenNhanVien, int NgayCong, string MaHSPC,int Thang, int Nam)
        {
            this.MaNhanVien = MaNhanVien;
            this.TenNhanVien = TenNhanVien;
            this.NgayCong = NgayCong;
            this.MaHSPC = MaHSPC;
            this.Thang = Thang;
            this.Nam = Nam;
        }
        public Cong_DTO(DataRow row)
        {
            this.MaNhanVien = row["MaNhanVien"].ToString();
            this.TenNhanVien = row["TenNhanVien"].ToString();
            this.NgayCong = int.Parse(row["NgayCong"].ToString());
            this.MaHSPC = row["MaHSPC"].ToString();
            this.Thang = int.Parse(row["Thang"].ToString());
            this.Nam = int.Parse(row["Nam"].ToString());
        }
    }
}
