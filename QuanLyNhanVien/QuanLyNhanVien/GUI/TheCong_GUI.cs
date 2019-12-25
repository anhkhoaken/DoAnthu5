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

namespace QuanLyNhanVien.GUI
{
    public partial class TheCong_GUI : Form
    {
        string ma="";
        public TheCong_GUI()
        {
            InitializeComponent();
            Load();
            
            //LoadName();
        }
        private void Load()
        {
            List<NhanVien_DTO> dsNhanVien = NHANVIEN_DAL.Instance.LoadListNHANVIEN();
            List<HeSoPhuCap_DTO> dsHeSoPhuCap = HeSoPhuCap_DAL.Instance.LoadList();
            cbHSPC.DataSource = new BindingSource(dsHeSoPhuCap, null);
            cbHSPC.DisplayMember = "TenHSPC";
            cbHSPC.ValueMember = "MaHSPC";

            cbMaNhanVien.DataSource = new BindingSource(dsNhanVien, null);
            cbMaNhanVien.DisplayMember = "MaNhanVien";
            cbMaNhanVien.ValueMember = "MaNhanVien";
            
        }
        private void LoadName(string ma)
        {
            List<NhanVien_DTO> dsNhanVien = NHANVIEN_DAL.Instance.LoadListNhanVienByID(ma);
           for(int i=0;i<dsNhanVien.Count;i++)
            {
                txtTenNhanVien.Text = dsNhanVien[i].TenNhanVien;
            }
        }
        private void Btthem_Click(object sender, EventArgs e)
        {
            //1dat
            if (txtNgayCong.Text.ToString().Length != 0 && int.Parse(txtNgayCong.Text.ToString()) < DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
            {
                //2
                string MaNhanVien = cbMaNhanVien.SelectedValue.ToString();
                string TenNhanVien = txtTenNhanVien.Text.ToString();
                string HeSoPhuCap = cbHSPC.SelectedValue.ToString();
                int ngaycong = int.Parse(txtNgayCong.Text.ToString());
                int thang = int.Parse(dateTimePicker1.Value.Month.ToString());
                int nam = int.Parse(dateTimePicker1.Value.Year.ToString());
                Cong_DTO cong = new Cong_DTO(MaNhanVien, TenNhanVien, ngaycong, HeSoPhuCap, thang, nam);
                //3
                if (!Cong_DAL.Instance.check(thang, nam, MaNhanVien))
                {
                    //4
                    Cong_DAL.Instance.add(cong);
                    MessageBox.Show("Chấm Công Thành Công");
                }
                //5
                else
                {
                    //6
                    MessageBox.Show("Nhân Viên Này Đã Được Chấm Công");
                }
            }
            //7
            else
            {
                MessageBox.Show("Nhập Ngày Công");

            }

        }

        private void CbMaNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ma = cbMaNhanVien.Text.ToString();
            LoadName(ma);
        }

        private void CbMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            this.ma = cbMaNhanVien.Text.ToString();
            LoadName(ma);
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            //1
            if (txtNgayCong.Text.ToString().Length != 0)
            {
                //2
                string MaNhanVien = cbMaNhanVien.SelectedValue.ToString();
                string TenNhanVien = txtTenNhanVien.Text.ToString();
                string HeSoPhuCap = cbHSPC.SelectedValue.ToString();
                int ngaycong = int.Parse(txtNgayCong.Text.ToString());
                int thang = int.Parse(dateTimePicker1.Value.Month.ToString());
                int nam = int.Parse(dateTimePicker1.Value.Year.ToString());
                Cong_DTO cong = new Cong_DTO(MaNhanVien, TenNhanVien, ngaycong, HeSoPhuCap, thang, nam);
                //3
                if (!Cong_DAL.Instance.check(thang, nam, MaNhanVien))
                {
                    //4
                    Cong_DAL.Instance.add(cong);
                    MessageBox.Show("Chấm Công Thành Công");
                }
                //5
                else
                {
                    //6
                    MessageBox.Show("Nhân Viên Này Đã Được Chấm Công");
                }
            }
            //7
            else
            {
                MessageBox.Show("Nhập Ngày Công");

            }
        }
    }
}
