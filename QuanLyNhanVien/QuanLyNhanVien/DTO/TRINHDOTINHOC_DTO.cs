using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DTO
{
    public class TRINHDOTINHOC_DTO
    {
        private string _MaTDTH;
        private string _TenTDTH;
        private string _GhiChu;

        public TRINHDOTINHOC_DTO(string MaTDTH, string TenTDTH, string GhiChu)
        {
            this.MaTDTH = MaTDTH;
            this.TenTDTH = TenTDTH;
            this.GhiChu = GhiChu;
        }

        public string MaTDTH { get => _MaTDTH; set => _MaTDTH = value; }
        public string TenTDTH { get => _TenTDTH; set => _TenTDTH = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
    }
}
