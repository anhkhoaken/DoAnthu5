using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhanVien.DTO
{
    class HeSoPhuCap_DTO
    {
        string _MaHSPC;
        float _TenHSPC;

        public HeSoPhuCap_DTO() { }
        public HeSoPhuCap_DTO(DataRow row)
        {
            this.MaHSPC = row["MaHSPC"].ToString();
            this.TenHSPC = float.Parse(row["HSPC"].ToString());
        }
        public HeSoPhuCap_DTO(string MaHSPC, float TenHSPC)
        {
            _MaHSPC = MaHSPC;
            _TenHSPC = TenHSPC;
        }

        public string MaHSPC { get => _MaHSPC; set => _MaHSPC = value; }
        public float TenHSPC { get => _TenHSPC; set => _TenHSPC = value; }
    }
}
