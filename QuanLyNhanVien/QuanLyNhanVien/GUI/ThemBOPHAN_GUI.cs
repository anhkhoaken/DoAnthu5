﻿using QuanLyNhanVien.DAL;
using QuanLyNhanVien.DTO;
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
    public partial class ThemBOPHAN_GUI : Form
    {
        public ThemBOPHAN_GUI()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            List<PHONGBAN_DTO> dsphongban = PHONGBAN_DAL.Instance.LoadListPHONGBAN();
            cbphongban.DataSource = new BindingSource(dsphongban, null);
            cbphongban.DisplayMember = "TenPB";
            cbphongban.ValueMember = "MaPB";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            BOPHAN_DTO bophan = new BOPHAN_DTO(txbMaBoPhan.Text, txbTenBoPhan.Text, cbphongban.SelectedValue.ToString(), txbGhiChu.Text);

            if (BOPHAN_DAL.Instance.checkIsExist(bophan.MaBoPhan))
            {
                MessageBox.Show("Mã bộ phận đã tồn tại, thêm thất bại");
            }
            else
            {
                BOPHAN_DAL.Instance.addBophan(bophan);
                MessageBox.Show("Thêm thành công Bộ Phận");
            }
        }

        private void ThemBOPHAN_GUI_Load(object sender, EventArgs e)
        {

        }
    }
}
