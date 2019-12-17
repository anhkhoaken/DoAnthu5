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
    public partial class QuanLyBOPHAN_GUI : Form
    {
        public QuanLyBOPHAN_GUI()
        {
            InitializeComponent();
            LoadListBoPhan();
        }

        public void LoadListBoPhan()
        {
            List<BOPHAN_DTO> danhsach = BOPHAN_DAL.Instance.LoadListBoPhan();

            dtgdsBoPhan.DataSource = danhsach;
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dtgdsBoPhan.CurrentCellAddress.Y;
            BOPHAN_DTO bophan = new BOPHAN_DTO(dtgdsBoPhan.CurrentRow.Cells[0].Value.ToString(), txbTenBoPhan.Text, txbPhongBan.Text, txbGhiChu.Text);


            if (-1 < currentRowIndex && currentRowIndex < dtgdsBoPhan.RowCount)
            {
                MessageBox.Show("Cập nhập Thành Công " + bophan.MaBoPhan);
                BOPHAN_DAL.Instance.UpdateBOPHAN(bophan);
            }
            LoadListBoPhan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dtgdsBoPhan.CurrentCellAddress.Y;
            string MaBoPhan = dtgdsBoPhan.CurrentRow.Cells[0].Value.ToString();

            if (-1 < currentRowIndex && currentRowIndex < dtgdsBoPhan.RowCount)
            {
                MessageBox.Show("Xóa Thành Công Bộ Phận " + MaBoPhan);
                BOPHAN_DAL.Instance.DeleteBOPHAN(MaBoPhan);
            }
            LoadListBoPhan();
        }

        private void dtgdsBoPhan_SelectionChanged(object sender, EventArgs e)
        {
            int currentRowIndex = dtgdsBoPhan.CurrentCellAddress.Y;

            if (-1 < currentRowIndex && currentRowIndex < dtgdsBoPhan.RowCount)
            {
                txbMaBoPhan.Text = dtgdsBoPhan.CurrentRow.Cells[0].Value.ToString();
                txbTenBoPhan.Text = dtgdsBoPhan.CurrentRow.Cells[1].Value.ToString();
                txbPhongBan.Text = dtgdsBoPhan.CurrentRow.Cells[2].Value.ToString();
                txbGhiChu.Text = dtgdsBoPhan.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
