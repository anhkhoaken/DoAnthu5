using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DTO
{
    public class BAC_DTO
    {
        private string _MaBac;
        private string _TenBac;

        public BAC_DTO()
        {

        }

        public BAC_DTO(string MaBac, string TenBac)
        {
            _MaBac = MaBac;
            _TenBac = TenBac;
        }

        public string MaBac { get => _MaBac; set => _MaBac = value; }
        public string TenBac { get => _TenBac; set => _TenBac = value; }
    }
}
