using System;
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
        private string _Honey;
        private string _TenVoChong;
        private int _NTDuoi15;
        private int _NTTren15;
        private int _NTTren60;

        public HONNHAN_DTO(string MaNV, string Honey, string TenVoChong, int NTDuoi15, int NTTren15, int NTTren60)
        {
            this.MaNV = MaNV;
            this.Honey = Honey;
            this.TenVoChong = TenVoChong;
            this.NTDuoi15 = NTDuoi15;
            this.NTTren15 = NTTren15;
            this.NTTren60 = NTTren60;
        }
        public HONNHAN_DTO(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.Honey = row["Honey"].ToString();
            this.TenVoChong = row["MaNV"].ToString();
            this.NTDuoi15 = int.Parse(row["NTDuoi15"].ToString());
            this.NTTren15 = int.Parse(row["NTTren15"].ToString());
            this.NTTren60 = int.Parse(row["NTTren60"].ToString());
        }

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string Honey { get => _Honey; set => _Honey = value; }
        public string TenVoChong { get => _TenVoChong; set => _TenVoChong = value; }
        public int NTDuoi15 { get => _NTDuoi15; set => _NTDuoi15 = value; }
        public int NTTren15 { get => _NTTren15; set => _NTTren15 = value; }
        public int NTTren60 { get => _NTTren60; set => _NTTren60 = value; }
    }
}
