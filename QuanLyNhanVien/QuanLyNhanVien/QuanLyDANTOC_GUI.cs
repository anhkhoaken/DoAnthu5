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
    public partial class QuanLyDANTOC_GUI : Form
    {
        public QuanLyDANTOC_GUI()
        {
            InitializeComponent();
        }
        public void loaddanhsach()
        {
            List<DANTOC_DTO> danhsach = DANTOC_DAL.Instance.LoadListDanToc();

            dtgdanhsach.DataSource = danhsach;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dtgdanhsach.CurrentCellAddress.Y;

            DANTOC_DTO newdt = new DANTOC_DTO(dtgdanhsach.CurrentRow.Cells[0].Value.ToString(), TxbTenDanToc.Text, txbGhiChu.Text);


            if (-1 < currentRowIndex && currentRowIndex < dtgdanhsach.RowCount)
            {
                MessageBox.Show("Cập nhập Thành Công " + newdt.MaDT);
                DANTOC_DAL.Instance.UpdateDanToc(newdt);
            }
            loaddanhsach();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dtgdanhsach.CurrentCellAddress.Y;
            string MaDT = dtgdanhsach.CurrentRow.Cells[0].Value.ToString();

            if (-1 < currentRowIndex && currentRowIndex < dtgdanhsach.RowCount)
            {
                MessageBox.Show("Xóa Thành Công Mã Dân Tộc " + MaDT);
                DANTOC_DAL.Instance.DeleteDantoc(MaDT);
            }
            loaddanhsach();
        }

        private void dtgdanhsach_SelectionChanged(object sender, EventArgs e)
        {
            int currentRowIndex = dtgdanhsach.CurrentCellAddress.Y;

            if (-1 < currentRowIndex && currentRowIndex < dtgdanhsach.RowCount)
            {
                txbMaDanToc.Text = dtgdanhsach.CurrentRow.Cells[0].Value.ToString();
                TxbTenDanToc.Text = dtgdanhsach.CurrentRow.Cells[1].Value.ToString();
                txbGhiChu.Text = dtgdanhsach.CurrentRow.Cells[2].Value.ToString();
            }
        }
    }
}
