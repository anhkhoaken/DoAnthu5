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
    public partial class QuanLyChucVu_GUI : Form
    {
        public QuanLyChucVu_GUI()
        {
            InitializeComponent();
            loadListDanhChucVu();
        }
        void loadListDanhChucVu()
        {
            List<CHUCVU_DTO> danhsach = CHUCVU_DAL.Instance.LoadListChucVu();

            dtgChucVu.DataSource = danhsach;
        }

        private void QuanLyChucVu_GUI_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dtgChucVu.CurrentCellAddress.Y;
            string MaCV = dtgChucVu.CurrentRow.Cells[0].Value.ToString();

            if (-1 < currentRowIndex && currentRowIndex < dtgChucVu.RowCount)
            {
                MessageBox.Show("Xóa Thành Công Chức Vụ " + MaCV);
                CHUCVU_DAL.Instance.DeleteChucVu(MaCV);
            }
            loadListDanhChucVu();
        }

        private void dtgChucVu_SelectionChanged(object sender, EventArgs e)
        {
            int currentRowIndex = dtgChucVu.CurrentCellAddress.Y;

            if (-1 < currentRowIndex && currentRowIndex < dtgChucVu.RowCount)
            {
                txbMaChucVu.Text = dtgChucVu.CurrentRow.Cells[0].Value.ToString();
                txbTenChucVu.Text = dtgChucVu.CurrentRow.Cells[1].Value.ToString();
                txbHeSoCV.Text = dtgChucVu.CurrentRow.Cells[2].Value.ToString();
                txbGhiChu.Text = dtgChucVu.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dtgChucVu.CurrentCellAddress.Y;
            CHUCVU_DTO chucvu = new CHUCVU_DTO(dtgChucVu.CurrentRow.Cells[0].Value.ToString(), txbTenChucVu.Text, float.Parse(txbHeSoCV.Text), txbGhiChu.Text);


            if (-1 < currentRowIndex && currentRowIndex < dtgChucVu.RowCount)
            {
                MessageBox.Show("Cập nhập Thành Công " + chucvu.MaCV);
                CHUCVU_DAL.Instance.UpdateChucVu(chucvu);
            }
            loadListDanhChucVu();
        }
    }
}
