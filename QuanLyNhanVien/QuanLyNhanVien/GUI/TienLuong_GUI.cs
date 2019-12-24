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

namespace QuanLyNhanVien.GUI
{
    public partial class TienLuong_GUI : Form
    {
        public TienLuong_GUI()
        {
            InitializeComponent();
            LoadTienLuong();
        }

        private void Btxuatbc_Click(object sender, EventArgs e)
        {
           
            copyAllToClipboard();
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
  
        private void copyAllToClipboard()
        {
            //1
            dgvtienluong.SelectAll();
            DataObject dataObj = dgvtienluong.GetClipboardContent();
            //2
            if (dataObj != null)
            {
                //3
                Clipboard.SetDataObject(dataObj);
            }
        }
        private void LoadTienLuong()
        {
            //1
            List<NhanVien_DTO> DsNhanVien = NHANVIEN_DAL.Instance.LoadListNHANVIEN();
            List<TienLuongDTO> dsTienLuong = new List<TienLuongDTO>();
            List<HESOLUONGNHANVIEN_DTO> dsHeSoLuong = new List<HESOLUONGNHANVIEN_DTO>();
           
            //2
            for(int i=0;i<DsNhanVien.Count;i++)
            {
                //3
                List<Cong_DTO> dsCong = Cong_DAL.Instance.Load(DsNhanVien[i].MaNhanVien,int.Parse(DateTime.Now.Month.ToString()), int.Parse(DateTime.Now.Year.ToString()));
                string MaNhanVien = DsNhanVien[i].MaNhanVien;
                string TenNhanVien = DsNhanVien[i].TenNhanVien;
                string HeSoLuong = DsNhanVien[i].MaHSLuong;
                List<HeSoPhuCap_DTO> dshspc = HeSoPhuCap_DAL.Instance.Load(dsCong[0].MaHSPC.ToString());
                HESOLUONGNHANVIEN_DTO gettt = HESOLUONGNHANVIEN_DAL.Instance.getHS(HeSoLuong);
                float TienLuong = float.Parse(gettt.HSLuong.ToString() ) * 10000 * dsCong[0].NgayCong * dshspc[0].TenHSPC;
                int thang = int.Parse(DateTime.Now.Month.ToString());
                int nam = int.Parse(DateTime.Now.Year.ToString());
                TienLuongDTO tienluong = new TienLuongDTO(MaNhanVien, TenNhanVien, HeSoLuong, TienLuong, thang, nam);
                dsTienLuong.Add(tienluong);
                //4
                if (!TienLuongDAL.Instance.checkIsExist(tienluong.MaNhanVien, tienluong.Thang, tienluong.Nam))
                {
                    //5
                    TienLuongDAL.Instance.add(tienluong);
                }
            }
            //6
            dgvtienluong.DataSource = dsTienLuong;
        }
        private void Btxem_Click(object sender, EventArgs e)
        {
            List<TienLuongDTO> dsTienLuong = new List<TienLuongDTO>();
            dsTienLuong = TienLuongDAL.Instance.LoadListTG(int.Parse(dtpThoiGian.Value.Month.ToString()), int.Parse(dtpThoiGian.Value.Year.ToString()));
            dgvtienluong.DataSource = dsTienLuong;

        }

        private void Dgvtienluong_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
