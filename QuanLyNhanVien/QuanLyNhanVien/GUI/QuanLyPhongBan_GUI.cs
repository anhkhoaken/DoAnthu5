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
    public partial class QuanLyPhongBan_GUI : Form
    {
        public QuanLyPhongBan_GUI()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            List<PHONGBAN_DTO> danhsach = PHONGBAN_DAL.Instance.LoadListPHONGBAN();
            dgvPhongBan.DataSource = danhsach;
        }

        private void Btcapnhat_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvPhongBan.CurrentCellAddress.Y;
            string mapb = maPB.TextName;
            string tenpb = TenPB.TextName;
            int soluongnhanvien = int.Parse(slnv.TextName.ToString());
            string gc = ghichu.TextName;
            if (-1 < currentRowIndex && currentRowIndex < dgvPhongBan.RowCount)
            {
                string ma = dgvPhongBan.CurrentRow.Cells[0].Value.ToString();
                PHONGBAN_DAL.Instance.UpdatePHONGBAN(mapb, tenpb, soluongnhanvien, gc);
                MessageBox.Show("Cập nhập Thành Công " + mapb);
            }
            load();
        }

        private void xoa(object sender, EventArgs e)
        {

            int currentRowIndex = dgvPhongBan.CurrentCellAddress.Y;
            string Ma = dgvPhongBan.CurrentRow.Cells[0].Value.ToString();
            if (-1 < currentRowIndex && currentRowIndex<dgvPhongBan.RowCount)
            {
                MessageBox.Show("Xóa Thành Công " + Ma);
                PHONGBAN_DAL.Instance.DeletePHONGBAN(Ma);
            }
            load();
        }
        private void JMetroTextBox2_Load(object sender, EventArgs e)
        {
            int currentRowIndex = dgvPhongBan.CurrentCellAddress.Y;
            string Ma = dgvPhongBan.CurrentRow.Cells[0].Value.ToString();
            if (-1 < currentRowIndex && currentRowIndex < dgvPhongBan.RowCount)
            {
                MessageBox.Show("Xóa Thành Công" + Ma);
                BOPHAN_DAL.Instance.DeleteBOPHAN(Ma);
            }
            load();
        }

        private void JMetroTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void JMetroTextBox3_Load(object sender, EventArgs e)
        {

        }

        private void JMetroTextBox4_Load(object sender, EventArgs e)
        {

        }

        private void DgvPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            int currentRowIndex = dgvPhongBan.CurrentCellAddress.Y;
            if(-1 < currentRowIndex && currentRowIndex <dgvPhongBan.RowCount)
            {
                maPB.TextName = dgvPhongBan.Rows[currentRowIndex].Cells[0].Value.ToString();
                TenPB.TextName = dgvPhongBan.Rows[currentRowIndex].Cells[1].Value.ToString();
                slnv.TextName = dgvPhongBan.Rows[currentRowIndex].Cells[2].Value.ToString();
                ghichu.TextName = dgvPhongBan.Rows[currentRowIndex].Cells[3].Value.ToString();


            }
        }

        private void DgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
