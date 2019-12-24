using QuanLyNhanVien.DAL;
using QuanLyNhanVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class ThemCHUCVU_GUI : Form
    {
        public ThemCHUCVU_GUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MaChucVu = txbMaChucVu.Text;
            string TenChucVu = txbTenChucVu.Text;
            float HeSo = float.Parse(txbHeSoCV.Text);
            string GhiChu = txbGhiChu.Text;

            CHUCVU_DTO chucvu = new CHUCVU_DTO(MaChucVu,TenChucVu,HeSo,GhiChu);

            if (CHUCVU_DAL.Instance.checkIsExist(chucvu.MaCV))
            {
                MessageBox.Show("Mã Chức Vụ đã tồn tại, thêm thất bại");
            }
            else
            {
                CHUCVU_DAL.Instance.addChucVu(chucvu);
                MessageBox.Show("Thêm thành công Chức Vụ");
            }
        }
    }
}
