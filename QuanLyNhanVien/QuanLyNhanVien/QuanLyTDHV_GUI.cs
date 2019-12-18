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
    public partial class QuanLyTDHV_GUI : Form
    {
        public QuanLyTDHV_GUI()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            List<TRINHDOHOCVAN_DTO> danhsach = TRINHDOHOCVAN_DAL.Instance.LoadListTDHV();
            dgvTrinhDoHocVan.DataSource = danhsach;
        }
        private void DgvTrinhDoHocVan_SelectionChanged(object sender, EventArgs e)
        {
            int currentRowIndex = dgvTrinhDoHocVan.CurrentCellAddress.Y;
            if (-1 < currentRowIndex && currentRowIndex < dgvTrinhDoHocVan.RowCount)
            {
                txtMaTrinhDoHocVan.TextName = dgvTrinhDoHocVan.Rows[currentRowIndex].Cells[0].Value.ToString();
                txtTenTrinhDoHocVan.TextName = dgvTrinhDoHocVan.Rows[currentRowIndex].Cells[1].Value.ToString();
                txtGhiChu.TextName = dgvTrinhDoHocVan.Rows[currentRowIndex].Cells[2].Value.ToString();
            }
        }

        private void Btcapnhat_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvTrinhDoHocVan.CurrentCellAddress.Y;
            string MaTDHV = txtMaTrinhDoHocVan.TextName;
            string TenTDHV = txtTenTrinhDoHocVan.TextName;
            string GhiChu = txtGhiChu.TextName;
            if (-1 < currentRowIndex && currentRowIndex < dgvTrinhDoHocVan.RowCount)
            {
                string ma = dgvTrinhDoHocVan.CurrentRow.Cells[0].Value.ToString();
                TRINHDOHOCVAN_DAL.Instance.UpdateTDHV(MaTDHV, TenTDHV, GhiChu);
                MessageBox.Show("Cập nhập Thành Công " + MaTDHV);
            }
            Load();
        }

        private void Btxoa_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvTrinhDoHocVan.CurrentCellAddress.Y;
            string Ma = dgvTrinhDoHocVan.CurrentRow.Cells[0].Value.ToString();
            if (-1 < currentRowIndex && currentRowIndex < dgvTrinhDoHocVan.RowCount)
            {
                MessageBox.Show("Xóa Thành Công " + Ma);
                TRINHDOHOCVAN_DAL.Instance.DeleteTDHV(Ma);
            }
            Load();
        }
    }
}
