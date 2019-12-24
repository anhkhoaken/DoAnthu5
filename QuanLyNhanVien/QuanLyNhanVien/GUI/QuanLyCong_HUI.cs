using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.DAL;
using QuanLyNhanVien.DTO;
using System.Windows.Forms;

namespace QuanLyNhanVien.GUI
{
    public partial class QuanLyCong_HUI : Form
    {
        public QuanLyCong_HUI()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            List<Cong_DTO> ds = Cong_DAL.Instance.LoadList();
            dgvcong.DataSource = ds;
        }

        private void BtCapNhat_Click(object sender, EventArgs e)
        {
            //1
            int currentRowIndex = dgvcong.CurrentCellAddress.Y;

           // 2
           if(txtNgayCong.Text.ToString().Length !=0 && int.Parse(txtNgayCong.Text.ToString())>=0 && int.Parse(txtNgayCong.Text.ToString()) < DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
            {
                //3
                string TenNhanVien = txtTenNhanVien.Text;
                int NgayCong = int.Parse(txtNgayCong.Text.ToString());
                string mahspc = txtHSPC.Text;
                int thang = int.Parse(txtThang.Text.ToString());
                int nam = int.Parse(txtnam.Text.ToString());

                //4
                if (-1 < currentRowIndex && currentRowIndex < dgvcong.RowCount)
                {
                    //5
                    string ma = dgvcong.CurrentRow.Cells[0].Value.ToString();
                    MessageBox.Show("Cập nhập Thành Công " + ma);
                    Cong_DTO cong = new Cong_DTO(ma, TenNhanVien, NgayCong, mahspc, thang, nam);
                    Cong_DAL.Instance.Update(cong);
                }
                //6
                Load();
            }
           //7
           else
            {
                MessageBox.Show("Vui Lòng Nhập Lại Số Ngày Công");
            }
            
        }

        private void BtXoa_Click(object sender, EventArgs e)
        {
            //1
            int currentRowIndex = dgvcong.CurrentCellAddress.Y;
            string mabac = dgvcong.CurrentRow.Cells[0].Value.ToString();
            //2
            if (-1 < currentRowIndex && currentRowIndex < dgvcong.RowCount)
            {
                //3
                MessageBox.Show("Xóa Thành Công " + mabac);
                Cong_DAL.Instance.Delete(mabac);
            }
            //4
            Load();
        }

        private void Dgvcong_SelectionChanged(object sender, EventArgs e)
        {
            int currentRowIndex = dgvcong.CurrentCellAddress.Y;

            if (-1 < currentRowIndex && currentRowIndex < dgvcong.RowCount)
            {
                txtMaNhanVien.Text = dgvcong.CurrentRow.Cells[0].Value.ToString();
                txtTenNhanVien.Text = dgvcong.CurrentRow.Cells[1].Value.ToString();
                txtNgayCong.Text = dgvcong.CurrentRow.Cells[2].Value.ToString();
                txtHSPC.Text = dgvcong.CurrentRow.Cells[3].Value.ToString();
                txtThang.Text = dgvcong.CurrentRow.Cells[4].Value.ToString();
                txtnam.Text = dgvcong.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void QuanLyCong_HUI_Load(object sender, EventArgs e)
        {

        }

        private void Btxem_Click(object sender, EventArgs e)
        {
            int thang, nam;
            thang=int.Parse(dtpthoigian.Value.Month.ToString());
            nam = int.Parse(dtpthoigian.Value.Year.ToString());
            List<Cong_DTO>ds= Cong_DAL.Instance.Load(thang, nam);
            dgvcong.DataSource = ds;
        }
    }
}
