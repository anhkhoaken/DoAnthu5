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
        }

        private void QuanLyBAC_GUI_Load(object sender, EventArgs e)
        {
            List<BAC_DTO> danhsach = BAC_DAL.Instance.LoadListBAC();

            dtgDanhSachBac.DataSource = danhsach;

        }
    }
}
