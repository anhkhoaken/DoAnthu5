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
    public partial class QUANLYQUOCTICH_GUI : Form
    {
        public QUANLYQUOCTICH_GUI()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            List<QuocTich_DTO> danhsach = QUOCTICH_DAL.Instance.LoadListQUOCTICH();
            dgvQuocTich.DataSource = danhsach;
        }

        private void Btcapnhat_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvQuocTich.CurrentCellAddress.Y;
            string MaQuocTich = txtMaQuocTich.TextName;
            string TenQuocTich = txtTenQuocTich.TextName;
            string GhiChu = txtGhiChu.TextName;
            if (-1 < currentRowIndex && currentRowIndex < dgvQuocTich.RowCount)
            {
                string ma = dgvQuocTich.CurrentRow.Cells[0].Value.ToString();
                QUOCTICH_DAL.Instance.UpdateQUOCTICH(MaQuocTich, TenQuocTich, GhiChu);
                MessageBox.Show("Cập nhập Thành Công " + MaQuocTich);
            }
            load();
        }

        private void Btxoa_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvQuocTich.CurrentCellAddress.Y;
            string Ma = dgvQuocTich.CurrentRow.Cells[0].Value.ToString();
            if (-1 < currentRowIndex && currentRowIndex < dgvQuocTich.RowCount)
            {
                MessageBox.Show("Xóa Thành Công " + Ma);
                QUOCTICH_DAL.Instance.DeleteQUOCTICH(Ma);
            }
            load();
        }

        private void DgvQuocTich_SelectionChanged(object sender, EventArgs e)
        {
            int currentRowIndex = dgvQuocTich.CurrentCellAddress.Y;
            if (-1 < currentRowIndex && currentRowIndex < dgvQuocTich.RowCount)
            {
                txtMaQuocTich.TextName = dgvQuocTich.Rows[currentRowIndex].Cells[0].Value.ToString();
                txtTenQuocTich.TextName = dgvQuocTich.Rows[currentRowIndex].Cells[1].Value.ToString();
                txtGhiChu.TextName = dgvQuocTich.Rows[currentRowIndex].Cells[2].Value.ToString();
            


            }
        }
    }
}
