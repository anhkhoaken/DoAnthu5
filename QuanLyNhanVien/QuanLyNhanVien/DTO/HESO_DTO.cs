using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhanVien.DTO
{
    public class HeSo_DTO
    {
        private string _MaHS;
        private string _HeSo;
        private string _GhiChu;

        public HeSo_DTO(string MaTG, string TenTG, string GhiChu)
        {
            this.MaHS = MaHS;
            this.HeSo = HeSo;
            this.GhiChu = GhiChu;
        }
        public TONGIAO_DTO(DataRow row)
        {
            this.MaHS = row["MaHS"].ToString();
            this.HeSo = row["HeSo"].ToString();
            this.GhiChu = row["GhiChu"].ToString();

        }
        public string MaHS { get => _MaHS; set => _MaHS = value; }
        public string HeSo { get => _HeSo; set => _HeSo = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
    }
}
