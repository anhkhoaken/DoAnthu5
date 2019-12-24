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
    public partial class ThemNgach_GUI : Form
    {
        public ThemNgach_GUI()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            NGACH_DTO ngach = new NGACH_DTO(txbMaNgach.Text, txbTenNgach.Text);

            bool isExist = Ngach_DAL.Instance.checkIsExist(txbMaNgach.Text);

            if (isExist)
            {
                MessageBox.Show("Mã Ngạch Đã Tồn Tại, Thêm thất bại");
            }
            else
            {
                Ngach_DAL.Instance.addNgach(ngach);
                MessageBox.Show("Thêm thành công Ngạch mới" +
                    "");
            }
        }
    }
}
