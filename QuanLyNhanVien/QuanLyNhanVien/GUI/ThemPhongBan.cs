using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanVien.DTO;
using QuanLyNhanVien.DAL;

namespace QuanLyNhanVien
{
    public partial class ThemPhongBan : Form
    {
        public ThemPhongBan()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

  

        private void Btadd_Click(object sender, EventArgs e)
        {
            string tenphongban, maphongban, ghichu;
            int soluongnhanvien;
            tenphongban = TenPB.TextName.ToString();
            maphongban = MaPB.TextName.ToString();
            ghichu = GC.TextName.ToString();
            soluongnhanvien = int.Parse(SLNV.TextName.ToString());
            PHONGBAN_DTO phonbanDto = new PHONGBAN_DTO(maphongban, tenphongban, soluongnhanvien, ghichu);
            bool isExist = PHONGBAN_DAL.Instance.checkIsExist(phonbanDto.MaPB);

            if (isExist)
            {
                MessageBox.Show("Mã Đã Tồn Tại, Thêm thất bại");
            }
            else
            {
                // BAC_DAL.Instance.addBAC(Bac);
                PHONGBAN_DAL.Instance.InsertPHONGBAN(phonbanDto);
                MessageBox.Show("Thêm thành công" + "");
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            string tenphongban, maphongban, ghichu;
            int soluongnhanvien;
            tenphongban = TenPB.Text.ToString();
            maphongban = MaPB.Text.ToString();
            ghichu = GC.Text.ToString();
            soluongnhanvien = int.Parse(SLNV.TextName.ToString());
            PHONGBAN_DTO phonbanDto = new PHONGBAN_DTO(maphongban, tenphongban, soluongnhanvien, ghichu);
            bool isExist = PHONGBAN_DAL.Instance.checkIsExist(phonbanDto.MaPB);

            if (isExist)
            {
                MessageBox.Show("Mã Đã Tồn Tại, Thêm thất bại");
            }
            else
            {
                // BAC_DAL.Instance.addBAC(Bac);
                PHONGBAN_DAL.Instance.InsertPHONGBAN(phonbanDto);
                MessageBox.Show("Thêm thành công" +
                    "");
            }
        }
    }
}
