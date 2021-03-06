﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DTO
{
    public class HONNHAN_DTO
    {
        private string _MaNV;
        private string _TenVoChong;
        private int _NTDuoi15;
        private int _NTTren15;
        private int _NTTren60;

        public HONNHAN_DTO(string MaNV, string TenVoChong, int NTDuoi15, int NTTren15, int NTTren60)
        {
            this.MaNV = MaNV;
            this.TenVoChong = TenVoChong;
            //this.NTDuoi15 = 1;
            //this.NTTren15 = 1;
            //this.NTTren60 = 1;
            this.NTDuoi15 = NTDuoi15;
            this.NTTren15 = NTTren15;
            this.NTTren60 = NTTren60;
        }
        public HONNHAN_DTO(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
          
            this.TenVoChong = row["TenVoChong"].ToString();
            this.NTDuoi15 = int.Parse(row["NTDuoi15"].ToString());
            this.NTTren15 = int.Parse(row["NTTren15"].ToString());
            this.NTTren60 = int.Parse(row["NTTren60"].ToString());
            //this.NTDuoi15 = 1;
            //this.NTTren15 = 1;
            //this.NTTren60 = 1;
        }

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string TenVoChong { get => _TenVoChong; set => _TenVoChong = value; }
        public int NTDuoi15 { get => _NTDuoi15; set => _NTDuoi15 = value; }
        public int NTTren15 { get => _NTTren15; set => _NTTren15 = value; }
        public int NTTren60 { get => _NTTren60; set => _NTTren60 = value; }
    }
}
