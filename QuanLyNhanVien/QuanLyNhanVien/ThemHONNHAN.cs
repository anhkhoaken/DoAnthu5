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
            HONNHAN_DTO newhonnhan = new HONNHAN_DTO(txbMaNV.Text,txbHoney.Text,txbTenVC.Text,int.Parse(txbDuoi15.Text), int.Parse(txbTren15.Text), int.Parse(txbTren60.Text));

            if (HONNHAN_DAL.Instance.checkIsExist(newhonnhan.MaNV))
            {
                MessageBox.Show(" đã tồn tại, thêm thất bại");
            }
            else
            {
                HONNHAN_DAL.Instance.addHonNhan(newhonnhan);
                MessageBox.Show("Thêm thành công ");
            }
        }
    }
}
