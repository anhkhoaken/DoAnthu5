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
    public partial class ThemHONNHAN : Form
    {
        public ThemHONNHAN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!checkInput())
            {
                MessageBox.Show("Vui long nhập đầy đủ thông tin");
                return;
            }
            HONNHAN_DTO newhonnhan = new HONNHAN_DTO(cbMaNhanVien.SelectedValue.ToString(),txbTenVC.Text,int.Parse(txbDuoi15.Text), int.Parse(txbTren15.Text), int.Parse(txbTren60.Text));

            if (HONNHAN_DAL.Instance.checkIsExist(newhonnhan.MaNV))
            {
                MessageBox.Show("Thông tin đã tồn tại, thêm thất bại");
            }
            else
            {
                HONNHAN_DAL.Instance.addHonNhan(newhonnhan);
                MessageBox.Show("Thêm thành công ");
            }
        }
        bool checkInput()
        {
            if (txbTenVC.Text.Length < 3)
                return false;
            else if (txbDuoi15.Text.Length < 1)
                return false;
            else if (txbTren15.Text.Length < 1)
                return false;
            else if (txbTren60.Text.Length < 1)
                return false;
            return true;
        }

        private void ThemHONNHAN_Load(object sender, EventArgs e)
        {
            List<NhanVien_DTO> dsnhanvien = NHANVIEN_DAL.Instance.LoadListNHANVIEN();
            cbMaNhanVien.DataSource = new BindingSource(dsnhanvien,null);
            cbMaNhanVien.DisplayMember = "MaNhanVien";
            cbMaNhanVien.ValueMember = "MaNhanVien";
        }
    }
}
