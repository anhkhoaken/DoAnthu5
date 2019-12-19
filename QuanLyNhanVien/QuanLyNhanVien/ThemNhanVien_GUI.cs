using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanVien.DTO;
using QuanLyNhanVien.DAL;

namespace QuanLyNhanVien
{
    public partial class ThemNhanVien_GUI : Form
    {
        public ThemNhanVien_GUI()
        {
            InitializeComponent();
            LoadData();
        }

        private void Btthem_Click(object sender, EventArgs e)
        {
          /*  string MaNhanVien, TenNhanVien, MaBac, MaBoPhan, MaCV, MaHSLuong, MaNV, MaNgach, MaPB, MaQT, MaTG, MaTDHV, MaTDNN, MaTDTH, GhiChu, MaDT;
            MaNhanVien = txtMaNhanVien.Text.ToString();
            TenNhanVien = txtTenNhanVien.Text.ToString();
            MaBac = cbBac.SelectedValue.ToString();
            MaBoPhan=cbBoPhan.SelectedValue.ToString();
            MaCV=cbChucVu.SelectedValue.ToString();
            MaNgach=cbNgach.SelectedValue.ToString();
            MaPB=cbPhongBan.SelectedValue.ToString();
            MaQT=cbQuocTich.SelectedValue.ToString();
            MaTG=cbTonGiao.SelectedValue.ToString();
            MaTDHV=cbTrinhDoHocVan.SelectedValue.ToString();
            MaTDNN=cbTrinhDoNgoaiNgu.SelectedValue.ToString();
            MaTDTH=cbTrinhDoTinHoc.SelectedValue.ToString();
            GhiChu = txtGhiChu.Text.ToString();
            MaDT=cbDanToc.SelectedValue.ToString();
            MaNV=cbHonNhan.SelectedValue.ToString();
            MaHSLuong=cbHeSoLuong.SelectedValue.ToString();

            NhanVien_DTO nhanvienDto = new NhanVien_DTO(MaNhanVien, TenNhanVien, MaBac, MaBoPhan, MaCV, MaHSLuong, MaNV, MaNgach, MaPB, MaQT, MaTG, MaTDHV, MaTDNN, MaTDTH, GhiChu, MaDT);
            bool isExist = NHANVIEN_DAL.Instance.checkIsExist(nhanvienDto.MaNhanVien);

            if (isExist)
            {
                MessageBox.Show("Mã Đã Tồn Tại, Thêm thất bại");
            }
            else
            {
                // BAC_DAL.Instance.addBAC(Bac);
                NHANVIEN_DAL.Instance.InsertNHANVIEN(nhanvienDto);
                MessageBox.Show("Thêm thành công" + "");
            }*/
        }
        private void LoadData()
        {
            List<BAC_DTO> dsBac = BAC_DAL.Instance.LoadListBAC();
            List<BOPHAN_DTO> dsBoPhan = BOPHAN_DAL.Instance.LoadListBoPhan();
            List<CHUCVU_DTO> dsChucVu = CHUCVU_DAL.Instance.LoadListChucVu();
            List<TRINHDOHOCVAN_DTO> dsTDHV = TRINHDOHOCVAN_DAL.Instance.LoadListTDHV();
            cbBac.DataSource = new BindingSource(dsBac, null);
            cbBac.DisplayMember = "TenBac";
            cbBac.ValueMember = "MaBac";

         /*   cbBoPhan.DataSource = new BindingSource(dsBoPhan, null);
            cbBac.DisplayMember = "TenBoPhan";
            cbBac.ValueMember = "MaBoPhan";*/
        }
    }
}
