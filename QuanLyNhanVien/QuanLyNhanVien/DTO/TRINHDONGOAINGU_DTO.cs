using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DTO
{
    public class TRINHDONGOAINGU_DTO
    {
        private string _MaTDNN;
        private string _TenTDNN;
        private string _GhiChu;

        public TRINHDONGOAINGU_DTO(string MaTDNN, string TenTDNN, string GhiChu)
        {
            this.MaTDNN = MaTDNN;
            this.TenTDNN = TenTDNN;
            this.GhiChu = GhiChu;
        }

        public string MaTDNN { get => _MaTDNN; set => _MaTDNN = value; }
        public string TenTDNN { get => _TenTDNN; set => _TenTDNN = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
    }
}
