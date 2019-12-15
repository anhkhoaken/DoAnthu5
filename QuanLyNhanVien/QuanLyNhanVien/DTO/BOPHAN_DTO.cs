using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DTO
{
    public class BOPHAN_DTO
    {
        private string _MaBoPhan;
        private string _TenBoPhan;
        private string _PhongBan;
        private string _GhiChu;

        public BOPHAN_DTO()
        {
          
        }

        public BOPHAN_DTO(string MaBoPhan, string TenBoPhan, string PhongBan, string GhiChu)
        {
            _MaBoPhan = MaBoPhan;
            _TenBoPhan = TenBoPhan;
            _PhongBan = PhongBan;
            _GhiChu = GhiChu;
        }

        public string MaBoPhan { get => _MaBoPhan; set => _MaBoPhan = value; }
        public string TenBoPhan { get => _TenBoPhan; set => _TenBoPhan = value; }
        public string PhongBan { get => _PhongBan; set => _PhongBan = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
    }
}
