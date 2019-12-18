using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
        public TRINHDOHOCVAN_DTO(DataRow row)
        {
            this.MaTDHV = row["MaTDHV"].ToString();
            this.TenTDHV = row["TenTDHV"].ToString();
            this.GhiChu = row["GhiChu"].ToString();

        }
        public string MaTDHV { get => _MaTDHV; set => _MaTDHV = value; }
        public string TenTDHV { get => _TenTDHV; set => _TenTDHV = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
    }
}
