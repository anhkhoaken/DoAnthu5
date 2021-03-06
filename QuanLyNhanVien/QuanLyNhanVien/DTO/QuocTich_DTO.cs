﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhanVien.DTO
{
    public class QuocTich_DTO
    {
        private string _MaQT;
        private string _TenQT;
        private string _GhiChu;

        public QuocTich_DTO(string MaQT, string TenQT, string GhiChu)
        {
            this.MaQT = MaQT;
            this.TenQT = TenQT;
            this.GhiChu = GhiChu;
        }
        public QuocTich_DTO(DataRow row)
        {
            this.MaQT = row["MaQT"].ToString();
            this.TenQT = row["TenQT"].ToString();
            this.GhiChu = row["GhiChu"].ToString();

        }
        public string MaQT { get => _MaQT; set => _MaQT = value; }
        public string TenQT { get => _TenQT; set => _TenQT = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
    }
}
