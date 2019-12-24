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
    public partial class QuanLyHSLUONG : Form
    {
        public QuanLyHSLUONG()
        {
            InitializeComponent();
        }

        public void loaddanhsach()
        {
            List<HESOLUONGNHANVIEN_DTO> danhsach = HESOLUONGNHANVIEN_DAL.Instance.LoadListHeSo();

            dtgdanhsach.DataSource = danhsach;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dtgdanhsach.CurrentCellAddress.Y;

            HESOLUONGNHANVIEN_DTO newdt = new HESOLUONGNHANVIEN_DTO(dtgdanhsach.CurrentRow.Cells[0].Value.ToString(), txbMaNgach.Text, txbMaBac.Text,float.Parse(txbHeSo.Text));


            if (-1 < currentRowIndex && currentRowIndex < dtgdanhsach.RowCount)
            {
                MessageBox.Show("Cập nhập Thành Công " + newdt.MaHSLuong);
                HESOLUONGNHANVIEN_DAL.Instance.UpdateHeSo(newdt);
            }
            loaddanhsach();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dtgdanhsach.CurrentCellAddress.Y;
            string maheso = dtgdanhsach.CurrentRow.Cells[0].Value.ToString();

            if (-1 < currentRowIndex && currentRowIndex < dtgdanhsach.RowCount)
            {
                MessageBox.Show("Xóa Thành Công Mã " + maheso);
                HESOLUONGNHANVIEN_DAL.Instance.DeleteHSLuong(maheso);
            }
            loaddanhsach();
        }

        private void dtgdanhsach_SelectionChanged(object sender, EventArgs e)
        {
            int currentRowIndex = dtgdanhsach.CurrentCellAddress.Y;

            if (-1 < currentRowIndex && currentRowIndex < dtgdanhsach.RowCount)
            {
                txbMaHS.Text = dtgdanhsach.CurrentRow.Cells[0].Value.ToString();
                txbMaNgach.Text = dtgdanhsach.CurrentRow.Cells[1].Value.ToString();
                txbMaBac.Text = dtgdanhsach.CurrentRow.Cells[2].Value.ToString();
                txbHeSo.Text = dtgdanhsach.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
