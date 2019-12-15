using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DTO
{
    public class TRINHDOHOCVAN_DTO
    {
        private string _MaTDHV;
        private string _TenTDHV;
        private string _GhiChu;

        public TRINHDOHOCVAN_DTO(string MaTDHV, string TenTDHV, string GhiChu)
        {
            this.MaTDHV = MaTDHV;
            this.TenTDHV = TenTDHV;
            this.GhiChu = GhiChu;
        }

        public string MaTDHV { get => _MaTDHV; set => _MaTDHV = value; }
        public string TenTDHV { get => _TenTDHV; set => _TenTDHV = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
    }
}
