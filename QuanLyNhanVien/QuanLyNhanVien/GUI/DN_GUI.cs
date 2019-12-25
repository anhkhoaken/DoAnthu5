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


namespace QuanLyNhanVien.GUI
{
    public partial class DN_GUI : Form
    {
        string TaiKhoan;
        string MatKhau;
        public DN_GUI()
        {
            InitializeComponent();
        }
        public void getText()
        {
            TaiKhoan = txttendangnhap.Text.ToString();
            MatKhau = txtmatkhau.Text.ToString();
        }

        bool DangNhap(string ten,string matkhau)
        {
            return TAIKHOAN_DAL.Instance.Login(ten, matkhau);
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RectangleShape1_Click(object sender, EventArgs e)
        {
            string TaiKhoan = txttendangnhap.TextName.ToString();
            string MatKhau = txtmatkhau.TextName.ToString();
            if (TaiKhoan.Count() != 0 && MatKhau.Count() != 0)
            {
                if (DangNhap(TaiKhoan,MatKhau))
                {
                    MessageBox.Show("Đăng Nhập Thành Công");
                    Form f = new MainForm();

                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dang Nhap Khong Thanh Cong");
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Điền đầy đủ thông tin");
            }
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            string TaiKhoan = txttendangnhap.TextName.ToString();
            string MatKhau = txtmatkhau.TextName.ToString();
            if (TaiKhoan.Count() != 0 && MatKhau.Count() != 0)
            {
                if (DangNhap(TaiKhoan, MatKhau))
                {
                    MessageBox.Show("Đăng Nhập Thành Công");
                    Form f = new MainForm();

                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dang Nhap Khong Thanh Cong");
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Điền đầy đủ thông tin");
            }
           
        }
    }

}
