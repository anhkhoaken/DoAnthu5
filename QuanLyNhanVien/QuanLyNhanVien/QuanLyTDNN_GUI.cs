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
    public partial class QuanLyTDNN_GUI : Form
    {
        public QuanLyTDNN_GUI()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            List<TRINHDONGOAINGU_DTO> danhsach = TRINHDONGOAINGU_DAL.Instance.LoadListTDNN();
            dgvTrinhDoNgoaiNgu.DataSource = danhsach;
        }

        private void DgvTrinhDoNgoaiNgu_SelectionChanged(object sender, EventArgs e)
        {
            int currentRowIndex = dgvTrinhDoNgoaiNgu.CurrentCellAddress.Y;
            if (-1 < currentRowIndex && currentRowIndex < dgvTrinhDoNgoaiNgu.RowCount)
            {
                txtMaTrinhDoNgoaiNgu.TextName = dgvTrinhDoNgoaiNgu.Rows[currentRowIndex].Cells[0].Value.ToString();
                txtTenTrinhDoNgoaiNgu.TextName = dgvTrinhDoNgoaiNgu.Rows[currentRowIndex].Cells[1].Value.ToString();
            }
        }

        private void Txtcapnhat_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvTrinhDoNgoaiNgu.CurrentCellAddress.Y;
            string MaTDNN = txtMaTrinhDoNgoaiNgu.TextName;
            string TenTDNN = txtTenTrinhDoNgoaiNgu.TextName;
          
            if (-1 < currentRowIndex && currentRowIndex < dgvTrinhDoNgoaiNgu.RowCount)
            {
                string ma = dgvTrinhDoNgoaiNgu.CurrentRow.Cells[0].Value.ToString();
                TRINHDONGOAINGU_DAL.Instance.UpdateTDNN(MaTDNN,TenTDNN);
                MessageBox.Show("Cập nhập Thành Công " + MaTDNN);
            }
            Load();
        }

        private void Txtxoa_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvTrinhDoNgoaiNgu.CurrentCellAddress.Y;
            string Ma = dgvTrinhDoNgoaiNgu.CurrentRow.Cells[0].Value.ToString();
            if (-1 < currentRowIndex && currentRowIndex < dgvTrinhDoNgoaiNgu.RowCount)
            {
                MessageBox.Show("Xóa Thành Công " + Ma);
                TRINHDONGOAINGU_DAL.Instance.DeleteTDNN(Ma);
            }
            Load();
        }
    }
}
