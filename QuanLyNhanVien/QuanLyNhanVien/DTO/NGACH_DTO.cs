using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DTO
{
    public class NGACH_DTO
    {
        private string _MaNgach;    
        private string _TenNgach;

        public NGACH_DTO(string MaNgach, string TenNgach)
        {
            this.MaNgach = MaNgach;
            this.TenNgach = TenNgach;
        }

        public string MaNgach { get => _MaNgach; set => _MaNgach = value; }
        public string TenNgach { get => _TenNgach; set => _TenNgach = value; }
    }
}
