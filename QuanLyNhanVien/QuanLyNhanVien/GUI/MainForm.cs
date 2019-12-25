using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanVien.GUI;

namespace QuanLyNhanVien
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void QuảnLýLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new TienLuong_GUI();
           
            f.Show();
        }

        private void ThêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ThemNhanVien_GUI();
           
            f.Show();
        }

        private void QuảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyNhanVien_GUI();
          
            f.Show();

        }

        private void QuảnLýPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyPhongBan_GUI();
          
            f.Show();
        }

        private void ThêmPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ThemPhongBan();
           
            f.Show();
        }

        private void ThêmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new TheCong_GUI();
          
            f.Show();
        }

        private void QuảnLýCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyCong_HUI();
           
            f.Show();
        }

        private void ThêmBậcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ThemBAC_GUI();

            f.Show();
        }

        private void QuảnLýBậcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyBAC_GUI();

            f.Show();

        }

        private void ThêmBộPhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ThemBOPHAN_GUI();

            f.Show();
        }

        private void QuảnLýBộPhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyBOPHAN_GUI();

            f.Show();
        }

        private void ThêmChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ThemCHUCVU_GUI();

            f.Show();
        }

        private void QuảnLýChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyChucVu_GUI();

            f.Show();
        }

        private void HệSốLượngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyHSLUONG();

            f.Show();
        }

        private void HệSốPhụCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
        } 

        private void ThêmHệSốLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyNGACH_GUI();

            f.Show();
        }
        
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BộPhậmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
