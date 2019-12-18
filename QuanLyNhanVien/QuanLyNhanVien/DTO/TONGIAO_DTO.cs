using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhanVien.DTO
{
    public class TONGIAO_DTO
    {
        private string _MaTG;
        private string _TenTG;
        private string _GhiChu;

        public TONGIAO_DTO(string MaTG, string TenTG, string GhiChu)
        {
            this.MaTG = MaTG;
            this.TenTG = TenTG;
            this.GhiChu = GhiChu;
        }
        public TONGIAO_DTO(DataRow row)
        {
            this.MaTG = row["MaTG"].ToString();
            this.TenTG = row["TenTG"].ToString();
            this.GhiChu = row["GhiChu"].ToString();

        }
        public string MaTG { get => _MaTG; set => _MaTG = value; }
        public string TenTG { get => _TenTG; set => _TenTG = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
    }
}
