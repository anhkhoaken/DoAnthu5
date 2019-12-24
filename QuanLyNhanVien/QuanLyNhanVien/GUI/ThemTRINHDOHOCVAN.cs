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
    public partial class ThemTRINHDOHOCVAN : Form
    {
        public ThemTRINHDOHOCVAN()
        {
            InitializeComponent();
        }

        private void Btthem_Click(object sender, EventArgs e)
        {
            string MaTrinhDoHocVan = txtMaTrinhDoHocVan.TextName;
            string TenTrinhDoHocVan = txtTenTrinhDoHocVan.TextName;
            string GhiChu = txtGhiChu.TextName;

            TRINHDOHOCVAN_DTO TrinhDoHocVan = new TRINHDOHOCVAN_DTO(MaTrinhDoHocVan, TenTrinhDoHocVan, GhiChu);

            bool isExist = TRINHDOHOCVAN_DAL.Instance.checkIsExist(TrinhDoHocVan.MaTDHV);

            if (isExist)
            {
                MessageBox.Show("Mã Đã Tồn Tại, Thêm thất bại");
            }
            else
            {
                TRINHDOHOCVAN_DAL.Instance.InsertTDHV(TrinhDoHocVan);
                MessageBox.Show("Thêm thành công" +
                    "");
            }
        }
    }
}
