using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanVien.DAL;
using QuanLyNhanVien.DTO;

namespace QuanLyNhanVien
{
    public partial class ThemQUOCTICH_GUI : Form
    {
        public ThemQUOCTICH_GUI()
        {
            InitializeComponent();
        }

        private void RectangleShape1_Click(object sender, EventArgs e)
        {
            string maquoctich = txtMaQuocTich.TextName;
            string tenquoctich = txtTenQuocTich.TextName;
            string ghichu = txtGhiChu.TextName;

            QuocTich_DTO quoctich = new QuocTich_DTO(maquoctich, tenquoctich, ghichu);

            bool isExist = QUOCTICH_DAL.Instance.checkIsExist(quoctich.MaQT);

            if (isExist)
            {
                MessageBox.Show("Mã Đã Tồn Tại, Thêm thất bại");
            }
            else
            {
                QUOCTICH_DAL.Instance.InsertQUOCTICH(quoctich);
                MessageBox.Show("Thêm thành công" +
                    "");
            }
        }
    }
}
