using QuanLyNhanVien.DAL;
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
    public partial class QuanLyNhanVien_GUI : Form
    {
        public QuanLyNhanVien_GUI()
        {
            InitializeComponent();
            Load();
            LoadData();

        }

        private void DgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            int currentRowIndex = dgvNhanVien.CurrentCellAddress.Y;

            if (-1 < currentRowIndex && currentRowIndex < dgvNhanVien.RowCount)
            {
                txtMaNhanVien.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtTenNhanVien.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                cbBac.Text= dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                cbBoPhan.Text= dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                cbChucVu.Text= dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
                cbHeSoLuong.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
                cbHonNhan.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
                cbNgach.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
                cbPhongBan.Text = dgvNhanVien.CurrentRow.Cells[8].Value.ToString();
                cbQuocTich.Text = dgvNhanVien.CurrentRow.Cells[9].Value.ToString();
                cbTonGiao.Text = dgvNhanVien.CurrentRow.Cells[10].Value.ToString();
                cbTrinhDoHocVan.Text = dgvNhanVien.CurrentRow.Cells[11].Value.ToString();
                cbTrinhDoNgoaiNgu.Text = dgvNhanVien.CurrentRow.Cells[12].Value.ToString();
                cbTrinhDoTinHoc.Text = dgvNhanVien.CurrentRow.Cells[13].Value.ToString();
                txtGhiChu.Text = dgvNhanVien.CurrentRow.Cells[14].Value.ToString();
                cbDanToc.Text = dgvNhanVien.CurrentRow.Cells[15].Value.ToString();
            }
        }

        private void Btcapnhat_Click(object sender, EventArgs e)
        {
            //1
            int currentRowIndex = dgvNhanVien.CurrentCellAddress.Y;
            string MaNhanVien, TenNhanVien, MaBac, MaBoPhan, MaCV, MaHSLuong, MaNV, MaNgach, MaPB, MaQT, MaTG, MaTDHV, MaTDNN, MaTDTH, GhiChu, MaDT;
            MaNhanVien = txtMaNhanVien.Text.ToString();
            TenNhanVien = txtTenNhanVien.Text.ToString().Trim();
            MaBac = cbBac.SelectedValue.ToString();
            MaBoPhan = cbBoPhan.SelectedValue.ToString();
            MaCV = cbChucVu.SelectedValue.ToString();
            MaNgach = cbNgach.SelectedValue.ToString();
            MaPB = cbPhongBan.SelectedValue.ToString();
            MaQT = cbQuocTich.SelectedValue.ToString();
            MaTG = cbTonGiao.SelectedValue.ToString();
            MaTDHV = cbTrinhDoHocVan.SelectedValue.ToString();
            MaTDNN = cbTrinhDoNgoaiNgu.SelectedValue.ToString();
            MaTDTH = cbTrinhDoTinHoc.SelectedValue.ToString();
            GhiChu = txtGhiChu.Text.ToString();
            MaDT = cbDanToc.SelectedValue.ToString();
            MaNV = cbHonNhan.SelectedValue.ToString();
            MaHSLuong = cbHeSoLuong.SelectedValue.ToString();
            //2
            if (-1 < currentRowIndex && currentRowIndex < dgvNhanVien.RowCount)
            {
                string ma = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                //3
                if(TenNhanVien.Count()<=0)
                {
                    //4
                    MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin");
                }
                //5
                else
                {
                    //6
                    
                    NHANVIEN_DAL.Instance.UpdateNHANVIEN(MaNhanVien, TenNhanVien, MaBac, MaBoPhan, MaCV, MaHSLuong, MaNV, MaNgach, MaPB, MaQT, MaTG, MaTDHV, MaTDNN, MaTDTH, GhiChu, MaDT);
                    MessageBox.Show("Cập nhập Thành Công " + ma);
                    suacongluong(MaNhanVien, TenNhanVien);
                    
                }
               
            }
            //7
            Load();
        }
        private void suacongluong(string ma,string ten)
        {
            List<Cong_DTO> dscong = Cong_DAL.Instance.LoadId(ma);
            List<TienLuongDTO> dsluong = TienLuongDAL.Instance.Load(ma);
            for(int i=0;i<dscong.Count;i++)
            {
                Cong_DTO cong = new Cong_DTO(ma,ten,dscong[i].NgayCong,dscong[i].MaHSPC,dscong[i].Thang,dscong[i].Nam);
                Cong_DAL.Instance.Update(cong);
            }
            for (int i = 0; i < dsluong.Count; i++)
            {
                TienLuongDTO luong = new TienLuongDTO(ma, ten, dsluong[i].MaHSLuong, dsluong[i].TienLuong, dsluong[i].Thang, dsluong[i].Nam,dsluong[i].GhiChu);
                TienLuongDAL.Instance.Update(luong);
              
            }
        }
        private void Btuatbc_Click(object sender, EventArgs e)
        {

            copyAlltoClipboard();
            //4
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        private void copyAlltoClipboard()
        {
            //1
            dgvNhanVien.SelectAll();
            DataObject dataObj = dgvNhanVien.GetClipboardContent();
            //2
            if (dataObj != null)
            {
                //3
                Clipboard.SetDataObject(dataObj);
            }
        }
        private void Btxoa_Click(object sender, EventArgs e)
        {
            //1
            int currentRowIndex = dgvNhanVien.CurrentCellAddress.Y;
            string Ma = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            //2
            if (-1 < currentRowIndex && currentRowIndex < dgvNhanVien.RowCount)
            {
                //3
                MessageBox.Show("Xóa Thành Công " + Ma);
                NHANVIEN_DAL.Instance.DeleteNHANVIEN(Ma);
            }
            //4
            Load();
        }
        private void Load()
        {

            List<NhanVien_DTO> danhsach = NHANVIEN_DAL.Instance.LoadListNHANVIEN();

            dgvNhanVien.DataSource = danhsach;

            for (int i = 0; i <= dgvNhanVien.Columns.Count - 1; i++)
            {
                //store autosized widths
                int colw = dgvNhanVien.Columns[i].Width;
                //remove autosizing
                dgvNhanVien.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                dgvNhanVien.Columns[i].Width = colw;
            }
        }
        private void LoadData()
        {
            cbchin.Items.Add("Tìm Kiếm Theo Mã Nhân Viên");
            cbchin.Items.Add("Tìm Kiếm Theo Tên Nhân Viên");
            List<BAC_DTO> dsBac = BAC_DAL.Instance.LoadListBAC();
            List<BOPHAN_DTO> dsBoPhan = BOPHAN_DAL.Instance.LoadListBoPhan();
            List<CHUCVU_DTO> dsChucVu = CHUCVU_DAL.Instance.LoadListChucVu();
            List<DANTOC_DTO> dsDanToc = DANTOC_DAL.Instance.LoadListDanToc();
            List<HESOLUONGNHANVIEN_DTO> dsHSL = HESOLUONGNHANVIEN_DAL.Instance.LoadListHeSo();
            List<NGACH_DTO> dsngach = Ngach_DAL.Instance.LoadListBoPhan();
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

            cbBoPhan.DataSource = new BindingSource(dsBoPhan, null);
            cbBoPhan.DisplayMember = "TenBoPhan";
            cbBoPhan.ValueMember = "MaBoPhan";

            cbChucVu.DataSource = new BindingSource(dsChucVu, null);
            cbChucVu.DisplayMember = "TenCV";
            cbChucVu.ValueMember = "MaCV";

            cbDanToc.DataSource = new BindingSource(dsDanToc, null);
            cbDanToc.DisplayMember = "TenDT";
            cbDanToc.ValueMember = "MaDT";

            cbHeSoLuong.DataSource = new BindingSource(dsHSL, null);
            cbHeSoLuong.DisplayMember = "MaHSLuong";
            cbHeSoLuong.ValueMember = "MaHSLuong";

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
            cbTrinhDoHocVan.DisplayMember = "MaTDHV";
            cbTrinhDoHocVan.ValueMember = "TenTDHV";

            cbTrinhDoNgoaiNgu.DataSource = new BindingSource(dsTDNN, null);
            cbTrinhDoNgoaiNgu.DisplayMember = "TenTDNN";
            cbTrinhDoNgoaiNgu.ValueMember = "MaTDNN";

            cbTrinhDoTinHoc.DataSource = new BindingSource(dsTDTH, null);
            cbTrinhDoTinHoc.DisplayMember = "TenTDTH";
            cbTrinhDoTinHoc.ValueMember = "MaTDTH";
            cbNgach.DataSource = new BindingSource(dsngach, null);
            cbNgach.DisplayMember = "TenNgach";
            cbNgach.ValueMember = "MaNgach";




        }

        private void Cttimkiem_Click(object sender, EventArgs e)
        {
            //1
            string chon = cbchin.Text;
            //2
            if (chon == "Tìm Kiếm Theo Mã Nhân Viên")
            {
                //3
                List<NhanVien_DTO> danhsach = NHANVIEN_DAL.Instance.LoadListNhanVienByID(txttimkiem.TextValue.ToString());
                //4
                if(danhsach.Count!=0)
                {
                    //5
                    dgvNhanVien.DataSource = danhsach;
                }
                //6
                else
                {
                    MessageBox.Show("Không có nhân viên");
                }

                
            }
            //7
            else if (chon == "Tìm Kiếm Theo Tên Nhân Viên")
            {
                //8
                List<NhanVien_DTO> danhsach = NHANVIEN_DAL.Instance.LoadListNhanVienByName(txttimkiem.TextValue.ToString());
                //9
                if (danhsach.Count != 0)
                {
                    //10
                    dgvNhanVien.DataSource = danhsach;
                }
                //11
                else
                {
                    MessageBox.Show("Không có nhân viên");
                }
            }
            //12
            else
            {
                MessageBox.Show("Vui Lòng Chọn Mục Tìm Kiếm ");
            }
        }

        private void QuanLyNhanVien_GUI_Load(object sender, EventArgs e)
        {

        }
    }
}
