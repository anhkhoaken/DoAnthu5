using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DTO
{
    public class DANTOC_DTO
    {
        private string _MaDT;
        private string _TenDT;
        private string _GhiChu;

        public DANTOC_DTO(string MaDT, string TenDT, string GhiChu)
        {
            this.MaDT = MaDT;
            this.TenDT = TenDT;
            this.GhiChu = GhiChu;
        }

        public string MaDT { get => _MaDT; set => _MaDT = value; }
        public string TenDT { get => _TenDT; set => _TenDT = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
    }
}
