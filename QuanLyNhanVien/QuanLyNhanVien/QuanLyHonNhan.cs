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
    public partial class QuanLyHonNhan : Form
    {
        public QuanLyHonNhan()
        {
            InitializeComponent();
        }

        public void loaddanhsach()
        {
            List<HONNHAN_DTO> danhsach = HONNHAN_DAL.Instance.LoadListHonNhan();

            dtgdanhsach.DataSource = danhsach;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dtgdanhsach.CurrentCellAddress.Y;

            HONNHAN_DTO newdt = new HONNHAN_DTO(dtgdanhsach.CurrentRow.Cells[0].Value.ToString(), txbHoney.Text,txbTenVC.Text,int.Parse(txbDuoi15.Text), int.Parse(txbTren15.Text), int.Parse(txbTren60.Text));


            if (-1 < currentRowIndex && currentRowIndex < dtgdanhsach.RowCount)
            {
                MessageBox.Show("Cập nhập Thành Công " + newdt.MaNV);
                HONNHAN_DAL.Instance.UpdateHonNhan(newdt);
            }
            loaddanhsach();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dtgdanhsach.CurrentCellAddress.Y;
            string maNV = dtgdanhsach.CurrentRow.Cells[0].Value.ToString();

            if (-1 < currentRowIndex && currentRowIndex < dtgdanhsach.RowCount)
            {
                MessageBox.Show("Xóa Thành Công Mã " + maNV);
                HONNHAN_DAL.Instance.DeleteHonNhan(maNV);
            }
            loaddanhsach();
        }

        private void dtgdanhsach_SelectionChanged(object sender, EventArgs e)
        {
            int currentRowIndex = dtgdanhsach.CurrentCellAddress.Y;

            if (-1 < currentRowIndex && currentRowIndex < dtgdanhsach.RowCount)
            {
                txbMaNV.Text = dtgdanhsach.CurrentRow.Cells[0].Value.ToString();
                txbHoney.Text = dtgdanhsach.CurrentRow.Cells[1].Value.ToString();
                txbTenVC.Text = dtgdanhsach.CurrentRow.Cells[2].Value.ToString();
                txbDuoi15.Text = dtgdanhsach.CurrentRow.Cells[3].Value.ToString();
                txbTren15.Text = dtgdanhsach.CurrentRow.Cells[4].Value.ToString();
                txbTren60.Text = dtgdanhsach.CurrentRow.Cells[5].Value.ToString();

            }
        }
    }
}
