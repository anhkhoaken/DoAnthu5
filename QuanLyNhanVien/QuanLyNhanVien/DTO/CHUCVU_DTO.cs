using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DTO
{
    public class CHUCVU_DTO
    {
        private string _MaCV;
        private string _TenCV;
        private string _HeSoCV;
        private string _GhiChu;

        public CHUCVU_DTO()
        {
        }

        public CHUCVU_DTO(string MaCV, string TenCV, string HeSoCV, string GhiChu)
        {
            _MaCV = MaCV;
            _TenCV = TenCV;
            _HeSoCV = HeSoCV;
            _GhiChu = GhiChu;
        }

        public string MaCV { get => _MaCV; set => _MaCV = value; }
        public string TenCV { get => _TenCV; set => _TenCV = value; }
        public string HeSoCV { get => _HeSoCV; set => _HeSoCV = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
    }
}
