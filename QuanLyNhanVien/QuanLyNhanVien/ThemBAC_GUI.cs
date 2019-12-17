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
    public partial class ThemBAC_GUI : Form
    {
        public ThemBAC_GUI()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaBac = txbMaBac.Text;
            string TenBac = TxbTenBac.Text;

            BAC_DTO Bac = new BAC_DTO(MaBac, TenBac);

            bool isExist = BAC_DAL.Instance.checkIsExist(Bac.MaBac);

            if (isExist)
            {
                MessageBox.Show("Mã Bậc Đã Tồn Tại, Thêm thất bại");
            }
            else
            {
                BAC_DAL.Instance.addBAC(Bac);
                MessageBox.Show("Thêm thành công Bậc mới" +
                    "");
            }
        }
    }
}
