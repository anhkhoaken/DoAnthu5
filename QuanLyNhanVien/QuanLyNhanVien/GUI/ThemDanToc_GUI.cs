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
    public partial class ThemDanToc_GUI : Form
    {
        public ThemDanToc_GUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MaDT = txbMaDanToc.Text;
            string TenDT = TxbTenDanToc.Text;
            string GhiChu = txbGhiChu.Text;

            DANTOC_DTO dantoc = new DANTOC_DTO(MaDT,TenDT, GhiChu);

            if (DANTOC_DAL.Instance.checkIsExist(dantoc.MaDT))
            {
                MessageBox.Show("Mã Dân Tộc đã tồn tại, thêm thất bại");
            }
            else
            {
                DANTOC_DAL.Instance.addDanToc(dantoc);
                MessageBox.Show("Thêm thành công Dân tộc");
            }
        }
    }
}
