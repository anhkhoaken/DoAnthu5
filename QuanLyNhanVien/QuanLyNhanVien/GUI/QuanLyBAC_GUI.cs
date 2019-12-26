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
    public partial class QuanLyBAC_GUI : Form
    {
        public QuanLyBAC_GUI()
        {
            InitializeComponent();
            loaddanhsach();
        }
        public void loaddanhsach()
        {
            List<BAC_DTO> danhsach = BAC_DAL.Instance.LoadListBAC();

            dtgDanhSachBac.DataSource = danhsach;
        }


        private void QuanLyBAC_GUI_Load(object sender, EventArgs e)
        {
          
        }

        private void dtgDanhSachBac_SelectionChanged(object sender, EventArgs e)
        {
            int currentRowIndex = dtgDanhSachBac.CurrentCellAddress.Y;

            if(-1 < currentRowIndex && currentRowIndex < dtgDanhSachBac.RowCount)
            {
                txbMaBac.Text = dtgDanhSachBac.CurrentRow.Cells[0].Value.ToString();
                txbTenBac.Text = dtgDanhSachBac.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dtgDanhSachBac.CurrentCellAddress.Y;

            string tenBac = txbTenBac.Text;
            

            if (-1 < currentRowIndex && currentRowIndex < dtgDanhSachBac.RowCount)
            {
                string mabac = dtgDanhSachBac.CurrentRow.Cells[0].Value.ToString();
                MessageBox.Show("Cập nhập Thành Công " + mabac);
                BAC_DAL.Instance.UpdateBAC(mabac,tenBac);
            }
            loaddanhsach();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dtgDanhSachBac.CurrentCellAddress.Y;
            string mabac = dtgDanhSachBac.CurrentRow.Cells[0].Value.ToString();
            
            if (-1 < currentRowIndex && currentRowIndex < dtgDanhSachBac.RowCount)
            {
                MessageBox.Show("Xóa Thành Công Mã Bậc " + mabac);
                BAC_DAL.Instance.DeleteBAC(mabac);
            }
            loaddanhsach();
        }

        private void DtgDanhSachBac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
