using QuanLyNhanVien.DAL;
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
    public partial class Form1 : Form
    {
        string TaiKhoan;
        string MatKhau;

        public Form1()
        {
            InitializeComponent();
        }

        public void getText()
        {
            TaiKhoan = TxbTaiKhoan.Text;
            MatKhau = TxbMatKhau.Text;
        }

        bool DangNhap()
        {
            return TAIKHOAN_DAL.Instance.Login(TaiKhoan, MatKhau);
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            getText();
            if (DangNhap())
            {
                MessageBox.Show("Dang Nhap Thanh Cong");
            }
            else
            {
                MessageBox.Show("Dang Nhap Khong Thanh Cong");
            }

        }
    }
}
