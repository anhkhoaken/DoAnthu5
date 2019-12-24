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
    public partial class QuanLyTDTH_GUI : Form
    {
        public QuanLyTDTH_GUI()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            List<TRINHDOTINHOC_DTO> danhsach = TRINHDOTINHOC_DAL.Instance.LoadListTDTH();
            dgvTrinhDoTinHoc.DataSource = danhsach;
        }
        private void DgvTrinhDoTinHoc_SelectionChanged(object sender, EventArgs e)
        {
            int currentRowIndex = dgvTrinhDoTinHoc.CurrentCellAddress.Y;
            if (-1 < currentRowIndex && currentRowIndex < dgvTrinhDoTinHoc.RowCount)
            {
                txtMaTrinhDoTinHoc.TextName = dgvTrinhDoTinHoc.Rows[currentRowIndex].Cells[0].Value.ToString();
                txtTenTrinhDoTinHoc.TextName = dgvTrinhDoTinHoc.Rows[currentRowIndex].Cells[1].Value.ToString();
            }
        }

        private void Btcapnhat_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvTrinhDoTinHoc.CurrentCellAddress.Y;
            string MaTDTH = txtMaTrinhDoTinHoc.TextName;
            string TenTDTH = txtTenTrinhDoTinHoc.TextName;

            if (-1 < currentRowIndex && currentRowIndex < dgvTrinhDoTinHoc.RowCount)
            {
                string ma = dgvTrinhDoTinHoc.CurrentRow.Cells[0].Value.ToString();
                TRINHDOTINHOC_DAL.Instance.UpdateTDTH(MaTDTH, TenTDTH);
                MessageBox.Show("Cập nhập Thành Công " + MaTDTH);
            }
            Load();
        }

        private void Btxoa_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvTrinhDoTinHoc.CurrentCellAddress.Y;
            string Ma = dgvTrinhDoTinHoc.CurrentRow.Cells[0].Value.ToString();
            if (-1 < currentRowIndex && currentRowIndex < dgvTrinhDoTinHoc.RowCount)
            {
                MessageBox.Show("Xóa Thành Công " + Ma);
                TRINHDOTINHOC_DAL.Instance.DeleteTDTH(Ma);
            }
            Load();
        }

        private void QuanLyTDTH_GUI_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
