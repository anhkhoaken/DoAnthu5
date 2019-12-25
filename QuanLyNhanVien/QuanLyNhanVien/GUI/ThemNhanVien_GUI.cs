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
        string bac ="1";
        string ngach= "BV1";
        public ThemNhanVien_GUI()
        {
            InitializeComponent();
            LoadData();
           // HSLuong();
        }

        private void Btthem_Click(object sender, EventArgs e)
        {

            //1
           string MaNhanVien, TenNhanVien, MaBac, MaBoPhan, MaCV, MaHSLuong, MaNV, MaNgach, MaPB, MaQT, MaTG, MaTDHV, MaTDNN, MaTDTH, GhiChu, MaDT;
            MaNhanVien = txtMaNhanVien.Text.ToString().Trim();
            TenNhanVien = txtTenNhanVien.Text.ToString().Trim();
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
            //2
            NhanVien_DTO nhanvienDto = new NhanVien_DTO(MaNhanVien, TenNhanVien, MaBac, MaBoPhan, MaCV, MaHSLuong, MaNV, MaNgach, MaPB, MaQT, MaTG, MaTDHV, MaTDNN, MaTDTH, GhiChu, MaDT);
            bool isExist = NHANVIEN_DAL.Instance.checkIsExist(nhanvienDto.MaNhanVien);
            //3
            if (MaNhanVien.Count() != 0 && TenNhanVien.Count() != 0)

            {
                //4
                if (isExist)
                {
                    //5
                    MessageBox.Show("Mã Đã Tồn Tại, Thêm thất bại");
                }
                //6
                else
                {
                    //7
                    NHANVIEN_DAL.Instance.InsertNHANVIEN(nhanvienDto);
                    MessageBox.Show("Thêm thành công" + "");
                }
            }
            //8
            else
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin");
            }
        }
        private void LoadData()
        {
            List<BAC_DTO> dsBac = BAC_DAL.Instance.LoadListBAC();
            List<BOPHAN_DTO> dsBoPhan = BOPHAN_DAL.Instance.LoadListBoPhan();
            List<CHUCVU_DTO> dsChucVu = CHUCVU_DAL.Instance.LoadListChucVu();
            List<DANTOC_DTO> dsDanToc = DANTOC_DAL.Instance.LoadListDanToc();
            List<HESOLUONGNHANVIEN_DTO> dsHSL = HESOLUONGNHANVIEN_DAL.Instance.LoadListHeSo();
            List<NGACH_DTO> dsNgach = Ngach_DAL.Instance.LoadListBoPhan();
            List<HONNHAN_DTO> dsHonNhan = HONNHAN_DAL.Instance.LoadListHonNhan();
            List<PHONGBAN_DTO> dsPhongBan = PHONGBAN_DAL.Instance.LoadListPHONGBAN();
            List<QuocTich_DTO> dsQuocTich = QUOCTICH_DAL.Instance.LoadListQUOCTICH();
            List<TONGIAO_DTO> dsTonGiao = TONGIAO_DAL.Instance.LoadListTONGIAO();
            List<TRINHDOHOCVAN_DTO> dsTDHV = TRINHDOHOCVAN_DAL.Instance.LoadListTDHV();
            List<TRINHDONGOAINGU_DTO> dsTDNN = TRINHDONGOAINGU_DAL.Instance.LoadListTDNN();
            List<TRINHDOTINHOC_DTO> dsTDTH = TRINHDOTINHOC_DAL.Instance.LoadListTDTH();
            cbBac.DataSource = new BindingSource(dsBac, null);
            cbBac.DisplayMember = "TenBac";
            cbBac.ValueMember = "MaBac";

            cbNgach.DataSource = new BindingSource(dsNgach, null);
            cbNgach.DisplayMember = "TenNgach";
            cbNgach.ValueMember = "MaNgach";

            cbBoPhan.DataSource = new BindingSource(dsBoPhan, null);
            cbBoPhan.DisplayMember = "TenBoPhan";
            cbBoPhan.ValueMember = "MaBoPhan";

            cbChucVu.DataSource = new BindingSource(dsChucVu, null);
            cbChucVu.DisplayMember = "TenCV";
            cbChucVu.ValueMember = "MaCV";

            cbDanToc.DataSource = new BindingSource(dsDanToc, null);
            cbDanToc.DisplayMember = "TenDT";
            cbDanToc.ValueMember = "MaDT";

            cbHonNhan.DataSource = new BindingSource(dsHonNhan, null);
            cbHonNhan.DisplayMember = "MaNV";
            cbHonNhan.ValueMember = "MaNV";

            cbPhongBan.DataSource = new BindingSource(dsPhongBan, null);
            cbPhongBan.DisplayMember = "TenPB";
            cbPhongBan.ValueMember = "MaPB";

            cbQuocTich.DataSource = new BindingSource(dsQuocTich, null);
            cbQuocTich.DisplayMember = "TenQT";
            cbQuocTich.ValueMember = "MaQT";

            cbTonGiao.DataSource = new BindingSource(dsTonGiao, null);
            cbTonGiao.DisplayMember = "TenTG";
            cbTonGiao.ValueMember = "MaTG";

            cbTrinhDoHocVan.DataSource = new BindingSource(dsTDHV, null);
            cbTrinhDoHocVan.DisplayMember = "TenTDHV";
            cbTrinhDoHocVan.ValueMember = "MaTDHV";

            cbTrinhDoNgoaiNgu.DataSource = new BindingSource(dsTDNN, null);
            cbTrinhDoNgoaiNgu.DisplayMember = "TenTDNN";
            cbTrinhDoNgoaiNgu.ValueMember = "MaTDNN";

            cbTrinhDoTinHoc.DataSource = new BindingSource(dsTDTH, null);
            cbTrinhDoTinHoc.DisplayMember = "TenTDTH";
            cbTrinhDoTinHoc.ValueMember = "MaTDTH";

            cbHeSoLuong.DataSource = new BindingSource(dsHSL, null);
            cbHeSoLuong.DisplayMember = "HSLuong";
            cbHeSoLuong.ValueMember = "MaHSLuong";




        }

        private void CbBac_TextChanged(object sender, EventArgs e)
        {
           
             bac = cbBac.SelectedValue.ToString();
            HSLuong();



        }

        private void CbNgach_TextChanged(object sender, EventArgs e)
        {
          
             ngach = cbNgach.SelectedValue.ToString();
            HSLuong();


        }
        private void HSLuong()
        {
           /* string ma = "HS" + ngach + bac;
            List<HESOLUONGNHANVIEN_DTO> danhsach = HESOLUONGNHANVIEN_DAL.Instance.getHS(ma);
            cbHeSoLuong.DataSource = new BindingSource(danhsach, null);
            cbHeSoLuong.DisplayMember = "HSLuong";
            cbHeSoLuong.ValueMember = "MaHSLuong";*/

        }
      
        private void TxbHsLuong_Click(object sender, EventArgs e)
        {
          //  string ma = "HS" + ngach + bac;
            string ma = "HS" + cbNgach.SelectedValue.ToString() + cbBac.SelectedValue.ToString();
            HESOLUONGNHANVIEN_DTO gettt = HESOLUONGNHANVIEN_DAL.Instance.getHS(ma);
            txbHsLuong.Text = gettt.HSLuong.ToString();
          //  txbHsLuong.Text = ma;

        }

        private void ThemNhanVien_GUI_Load(object sender, EventArgs e)
        {

        }
    }
}
