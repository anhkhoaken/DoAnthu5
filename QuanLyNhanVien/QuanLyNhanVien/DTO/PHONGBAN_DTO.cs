using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DTO
{
    public class PHONGBAN_DTO
    {
        private string _MaPB;
        private string _TenPB;
        private int _SoLuongNhanVien;
        private string _GhiChu;

        public PHONGBAN_DTO()
        {
        }
        public PHONGBAN_DTO(DataRow row)
        {
            this._MaPB = row["MaPB"].ToString();
            this._TenPB =row["TenPB"].ToString();
            this._SoLuongNhanVien = int.Parse(row["SoLuongNhanVien"].ToString());   
            this._GhiChu = row["GhiChu"].ToString();

        }
        public PHONGBAN_DTO(string MaPB, string TenPB, int SoLuongNhanVien, string GhiChu)
        {
            _MaPB = MaPB;
            _TenPB = TenPB;
            _SoLuongNhanVien = SoLuongNhanVien;
            _GhiChu = GhiChu;
        }

        public string MaPB { get => _MaPB; set => _MaPB = value; }
        public string TenPB { get => _TenPB; set => _TenPB = value; }
        public int SoLuongNhanVien { get => _SoLuongNhanVien; set => _SoLuongNhanVien = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
    }
}
