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

        private void ThêmQuốcTịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ThemQUOCTICH_GUI();

            f.Show();
        }

        private void QuảnLýQuốcTịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new QUANLYQUOCTICH_GUI();

            f.Show();
        }
        private void ThêmTônGIáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new THEMTONGIAO_GUI();

            f.Show();
        }

        private void QuảnLýTônGiáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyTonGiao_GUI();

            f.Show();
        }

        private void ThêmTĐHVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ThemTRINHDOHOCVAN();

            f.Show();
        }

        private void QuảnLýTĐHVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyTDHV_GUI();

            f.Show();
        }

        private void ThêmBậcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new ThemBAC_GUI();

            f.Show();
        }

        private void QuảnLýBậcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyBAC_GUI();

            f.Show();
        }

        private void ThêmTĐNNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ThemTRINHDONGOAINGU_DAL();

            f.Show();
        }

        private void QuảnLýTĐNNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyTDNN_GUI();

            f.Show();
        }

        private void ThêmTĐTHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ThemTRINHDOTINHOC_GUI();

            f.Show();
        }

        private void QuảnLýTĐTHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyTDTH_GUI();

            f.Show();
        }

        private void ThêmHSLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ThemHSLUONG();

            f.Show();
        }

        private void QuảnLýHSLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyHSLUONG();

            f.Show();
        }

        private void ThêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ThemHONNHAN();
            f.Show();
        }

        private void QuảnLýThôngTinHônNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyHonNhan();
            f.Show();
        }
    }
}
