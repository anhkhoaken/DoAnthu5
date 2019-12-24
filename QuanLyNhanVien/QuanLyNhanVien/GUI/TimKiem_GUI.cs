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

namespace QuanLyNhanVien.GUI
{
    public partial class TimKiem_GUI : Form
    {
        public TimKiem_GUI()
        {
            InitializeComponent();
        }

        private void Bttimkiem_Click(object sender, EventArgs e)
        {
            string chon = cbchon.Text;
            if (chon == "Tìm Kiếm Theo Mã Nhân Viên")
            {
                List<NhanVien_DTO> danhsach = NHANVIEN_DAL.Instance.LoadListNhanVienByID(txttimkiem.TextName.ToString());

                dgvnhanvien.DataSource = danhsach;
            }
           else if (chon == "Tìm Kiếm Theo Tên Nhân Viên")
            {
                List<NhanVien_DTO> danhsach = NHANVIEN_DAL.Instance.LoadListNhanVienByName(txttimkiem.TextName.ToString());

                dgvnhanvien.DataSource = danhsach;
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Mục Tìm Kiếm ");
            }
        }

        private void TimKiem_GUI_Load(object sender, EventArgs e)
        {
            cbchon.Items.Add("Tìm Kiếm Theo Mã Nhân Viên");
            cbchon.Items.Add("Tìm Kiếm Theo Tên Nhân Viên");
        }
    }
}
