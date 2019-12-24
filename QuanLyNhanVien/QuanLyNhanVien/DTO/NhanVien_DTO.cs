using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace QuanLyNhanVien.DTO
{
    class NhanVien_DTO
    {
        private string _MaNhanVien;
        private string _TenNhanVien;
        private string _MaBac;
        private string _MaBoPhan;
        private string _MaCV;
        private string _MaHSLuong;
        private string _MaNV;
        private string _MaNghach;
        private string __MaPB;
        private string _MaQT;
        private string _MaTG;
        private string _MaTDHV;
        private string _MaTDNN;
        private string _MaTDTH;
        private string _GhiChu;
        private string _MaDT;
        public NhanVien_DTO() { }
       

        public NhanVien_DTO(string MaNhanVien, string TenNhanVien, string MaBac, string MaBoPhan, string MaCV, string MaHSLuong, string MaNV, string MaNghach, string MaPB, string MaQT, string MaTG, string MaTDHV, string MaTDNN, string MaTDTH, string GhiChu,string MaDT)
        {
            _MaNhanVien = MaNhanVien;
            _TenNhanVien = TenNhanVien;
            _MaBac = MaBac;
            _MaBoPhan = MaBoPhan;
            _MaCV = MaCV;
            _MaHSLuong = MaHSLuong;
            _MaNV = MaNV;
            _MaNghach = MaNghach;
            __MaPB = MaPB;
            _MaQT = MaQT;
            _MaTG = MaTG;
            _MaTDHV = MaTDHV;
            _MaTDNN = MaTDNN;
            _MaTDTH = MaTDTH;
            _GhiChu = GhiChu;
            _MaDT = MaDT;
        }
        public NhanVien_DTO(DataRow row)
        {
            this.MaNhanVien = row["MaNhanVien"].ToString();
            this.TenNhanVien = row["TenNhanVien"].ToString();
            this.MaBac = row["MaBac"].ToString();
            this.MaBoPhan = row["MaBoPhan"].ToString();
            this.MaCV = row["MaCV"].ToString();
            this.MaHSLuong = row["MaHSLuong"].ToString();
            this.MaNV = row["MaNV"].ToString();
            this.MaNghach = row["MaNgach"].ToString();
            this.MaPB = row["MaPB"].ToString();
            this.MaQT = row["MaQT"].ToString();
            this.MaTG = row["MaTG"].ToString();
            this.MaTDHV = row["MaTDHV"].ToString();
            this.MaTDNN = row["MaTDNN"].ToString();
            this.MaTDTH = row["MaTDTH"].ToString();
            this.GhiChu = row["GhiChu"].ToString();
            this.MaDT = row["MaDT"].ToString();

        }

        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public string TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
        public string MaBac { get => _MaBac; set => _MaBac = value; }
        public string MaBoPhan { get => _MaBoPhan; set => _MaBoPhan = value; }
        public string MaCV { get => _MaCV; set => _MaCV = value; }
        public string MaHSLuong { get => _MaHSLuong; set => _MaHSLuong = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string MaNghach { get => _MaNghach; set => _MaNghach = value; }
        public string MaPB { get => __MaPB; set => __MaPB = value; }
        public string MaQT { get => _MaQT; set => _MaQT = value; }
        public string MaTG { get => _MaTG; set => _MaTG = value; }
        public string MaTDHV { get => _MaTDHV; set => _MaTDHV = value; }
        public string MaTDNN { get => _MaTDNN; set => _MaTDNN = value; }
        public string MaTDTH { get => _MaTDTH; set => _MaTDTH = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
        public string MaDT { get => _MaDT; set => _MaDT = value; }
    }
}
