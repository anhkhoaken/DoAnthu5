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
    }
}
