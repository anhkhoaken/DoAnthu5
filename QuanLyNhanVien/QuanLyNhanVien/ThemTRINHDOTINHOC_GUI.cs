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
    public partial class ThemTRINHDOTINHOC_GUI : Form
    {
        public ThemTRINHDOTINHOC_GUI()
        {
            InitializeComponent();
        }

        private void Btthem_Click(object sender, EventArgs e)
        {
            string MaTrinhDoTinHoc = txtMaTrinhDoTinHoc.TextName;
            string TenTrinhDoTinHoc = txtTenTrinhDoTinHoc.TextName;

            TRINHDOTINHOC_DTO TDTH = new TRINHDOTINHOC_DTO(MaTrinhDoTinHoc, TenTrinhDoTinHoc);

            bool isExist = TRINHDOTINHOC_DAL.Instance.checkIsExist(TDTH.MaTDTH);

            if (isExist)
            {
                MessageBox.Show("Mã Đã Tồn Tại, Thêm thất bại");
            }
            else
            {
                TRINHDOTINHOC_DAL.Instance.InsertTDTH(TDTH);
                MessageBox.Show("Thêm thành công" +
                    "");
            }
        }
    }
}
