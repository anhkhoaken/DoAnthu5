using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanVien.DTO;
using QuanLyNhanVien.DAL;

namespace QuanLyNhanVien
{
    public partial class QuanLyTonGiao_GUI : Form
    {
        public QuanLyTonGiao_GUI()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            List<TONGIAO_DTO> danhsach = TONGIAO_DAL.Instance.LoadListTONGIAO();
            dgvTonGiao.DataSource = danhsach;
        }
        private void Btthem_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvTonGiao.CurrentCellAddress.Y;
            string MaTonGiao = txtMaTonGiao.TextName;
            string TenTonGiao = txtTenTonGiao.TextName;
            string GhiChu = txtGhiChu.TextName;
            if (-1 < currentRowIndex && currentRowIndex < dgvTonGiao.RowCount)
            {
                string ma = dgvTonGiao.CurrentRow.Cells[0].Value.ToString();
                TONGIAO_DAL.Instance.UpdateTONGIAO(MaTonGiao, TenTonGiao, GhiChu);
                MessageBox.Show("Cập nhập Thành Công " + MaTonGiao);
            }
            Load();
        }

        private void Btxoa_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvTonGiao.CurrentCellAddress.Y;
            string Ma = dgvTonGiao.CurrentRow.Cells[0].Value.ToString();
            if (-1 < currentRowIndex && currentRowIndex < dgvTonGiao.RowCount)
            {
                MessageBox.Show("Xóa Thành Công " + Ma);
                TONGIAO_DAL.Instance.DeleteTONGIAO(Ma);
            }
            Load();
        }

        private void DgvTonGiao_SelectionChanged(object sender, EventArgs e)
        {
            int currentRowIndex = dgvTonGiao.CurrentCellAddress.Y;
            if (-1 < currentRowIndex && currentRowIndex < dgvTonGiao.RowCount)
            {
                txtMaTonGiao.TextName = dgvTonGiao.Rows[currentRowIndex].Cells[0].Value.ToString();
                txtTenTonGiao.TextName = dgvTonGiao.Rows[currentRowIndex].Cells[1].Value.ToString();
                txtGhiChu.TextName = dgvTonGiao.Rows[currentRowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
