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
        }
      

        private void Btcapnhat_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyPhongBan_GUI_Load(object sender, EventArgs e)
        {
            List<PHONGBAN_DTO> danhsach = PHONGBAN_DAL.Instance.LoadListPHONGBAN();

          /*  dgvPhongBan.Columns.Clear();
            dgvPhongBan.DataSource = null;
            dgvPhongBan.AutoGenerateColumns = false;
            dgvPhongBan.AllowUserToAddRows = false;*/
            dgvPhongBan.DataSource = danhsach;
            // Tạo danh sách cột trong dgv
         /*   var clmapb = new DataGridViewTextBoxColumn();
            clmapb.Name = "MaPB";
            clmapb.HeaderText = "Mã Phòng Ban";
            clmapb.DataPropertyName = "MaPB";
            dgvPhongBan.Columns.Add(clmapb);

            var cltenpb = new DataGridViewTextBoxColumn();
            clmapb.Name = "TenPB";
            clmapb.HeaderText = "Tên Phòng Ban";
            clmapb.DataPropertyName = "TenPB";
            dgvPhongBan.Columns.Add(cltenpb);

            var clslnv = new DataGridViewTextBoxColumn();
             clmapb.Name = "SoLuongNhanVien";
             clmapb.HeaderText = "Số Lượng Nhân Viên";
             clmapb.DataPropertyName = "SoLuongNhanVien";
            dgvPhongBan.Columns.Add(clslnv);

             var clgc = new DataGridViewTextBoxColumn();
             clmapb.Name = "GhiChu";
             clmapb.HeaderText = "Ghi Chú";
             clmapb.DataPropertyName = "GhiChu";
             dgvPhongBan.Columns.Add(clgc);
             */
        }

        private void JMetroTextBox2_Load(object sender, EventArgs e)
        {

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
