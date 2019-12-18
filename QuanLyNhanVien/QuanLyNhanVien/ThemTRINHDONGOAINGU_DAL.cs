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
    public partial class ThemTRINHDONGOAINGU_DAL : Form
    {
        public ThemTRINHDONGOAINGU_DAL()
        {
            InitializeComponent();
        }

        private void Btthem_Click(object sender, EventArgs e)
        {
            string MaTrinhDoNgoaiNgu = txtMaTrinhDoNgoaiNgu.TextName;
            string TenTrinhDoNgoaiNgu = txtTenTrinhDoNgoaiNgu.TextName;

            TRINHDONGOAINGU_DTO TDNN = new TRINHDONGOAINGU_DTO(MaTrinhDoNgoaiNgu, TenTrinhDoNgoaiNgu);

            bool isExist = TRINHDONGOAINGU_DAL.Instance.checkIsExist(TDNN.MaTDNN);

            if (isExist)
            {
                MessageBox.Show("Mã Đã Tồn Tại, Thêm thất bại");
            }
            else
            {
                TRINHDONGOAINGU_DAL.Instance.InsertTDNN(TDNN);
                MessageBox.Show("Thêm thành công" +
                    "");
            }
        }
    }
}
