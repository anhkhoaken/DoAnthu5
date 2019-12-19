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
    public partial class ThemHSLUONG : Form
    {
        public ThemHSLUONG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            HESOLUONGNHANVIEN_DTO newheso = new HESOLUONGNHANVIEN_DTO(txbMaHS.Text,txbMaNgach.Text,txbMaBac.Text,float.Parse(txbHeSo.Text));

            if (HESOLUONGNHANVIEN_DAL.Instance.checkIsExist(newheso.MaHSLuong))
            {
                MessageBox.Show(" đã tồn tại, thêm thất bại");
            }
            else
            {
                HESOLUONGNHANVIEN_DAL.Instance.addHSLuong(newheso);
                MessageBox.Show("Thêm thành công ");
            }
        }
    }
}
