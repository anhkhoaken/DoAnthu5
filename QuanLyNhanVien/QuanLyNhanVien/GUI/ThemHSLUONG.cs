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
    public partial class ThemHSLUONG : Form
    {
        public ThemHSLUONG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            HESOLUONGNHANVIEN_DTO newheso = new HESOLUONGNHANVIEN_DTO(txbMaHS.Text,cbMaNgach.SelectedValue.ToString(),cbMaBac.SelectedValue.ToString(), float.Parse(txbHeSo.Text));

            if (HESOLUONGNHANVIEN_DAL.Instance.checkIsExist(newheso.MaHSLuong))
            {
                MessageBox.Show(" đã tồn tại, thêm thất bại");
            }
            else
            {
                HESOLUONGNHANVIEN_DAL.Instance.addHSLuong(newheso);
                MessageBox.Show("Thêm thành công ");
            }
        }

        private void ThemHSLUONG_Load(object sender, EventArgs e)
        {
            List<BAC_DTO> dsbac = BAC_DAL.Instance.LoadListBAC();
            List<NGACH_DTO> dsngach = Ngach_DAL.Instance.LoadListBoPhan();
            cbMaBac.DataSource = new BindingSource(dsbac, null);
            cbMaBac.DisplayMember = "TenBac";
            cbMaBac.ValueMember = "MaBac";
            cbMaNgach.DataSource = new BindingSource(dsngach, null);
            cbMaNgach.DisplayMember = "TenNgach";
            cbMaNgach.ValueMember = "MaNgach";
        }
    }
}
