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
    public partial class QuanLyNGACH_GUI : Form
    {
        public QuanLyNGACH_GUI()
        {
            InitializeComponent();
            loaddanhsach();
        }
        public void loaddanhsach()
        {
            List<NGACH_DTO> danhsach = Ngach_DAL.Instance.LoadListBoPhan();

            dtgdanhsach.DataSource = danhsach;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dtgdanhsach.CurrentCellAddress.Y;

            NGACH_DTO ngach = new NGACH_DTO(txbMaNgach.Text, txbTenNgach.Text);


            if (-1 < currentRowIndex && currentRowIndex < dtgdanhsach.RowCount)
            {
                MessageBox.Show("Cập nhập Thành Công " + ngach.MaNgach);
                Ngach_DAL.Instance.UpdateNGACH(ngach);
            }
            loaddanhsach();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dtgdanhsach.CurrentCellAddress.Y;

            NGACH_DTO ngach = new NGACH_DTO(txbMaNgach.Text, txbTenNgach.Text);


            if (-1 < currentRowIndex && currentRowIndex < dtgdanhsach.RowCount)
            {
                MessageBox.Show("Xóa Thành Công " + ngach.MaNgach);
                Ngach_DAL.Instance.DeleteNgach(ngach.MaNgach);
            }
            loaddanhsach();
        }

        private void Dtgdanhsach_SelectionChanged(object sender, EventArgs e)
        {
            int currentRowIndex = dtgdanhsach.CurrentCellAddress.Y;

            if (-1 < currentRowIndex && currentRowIndex < dtgdanhsach.RowCount)
            {
                txbMaNgach.Text = dtgdanhsach.CurrentRow.Cells[0].Value.ToString();
                txbTenNgach.Text = dtgdanhsach.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void Dtgdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
