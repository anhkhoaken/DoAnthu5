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


namespace QuanLyNhanVien
{
    public partial class THEMTONGIAO_GUI : Form
    {
        public THEMTONGIAO_GUI()
        {
            InitializeComponent();
        }

        private void Btthem_Click(object sender, EventArgs e)
        {
            string matongiao = txtMaTonGiao.TextName;
            string tentongiao = txtTenTonGiao.TextName;
            string ghichu = txtGhiChu.TextName;

            TONGIAO_DTO tongiao = new TONGIAO_DTO(matongiao, tentongiao, ghichu);

            bool isExist = TONGIAO_DAL.Instance.checkIsExist(tongiao.MaTG);

            if (isExist)
            {
                MessageBox.Show("Mã Đã Tồn Tại, Thêm thất bại");
            }
            else
            {
                TONGIAO_DAL.Instance.InsertTONGIAO(tongiao);
                MessageBox.Show("Thêm thành công" +
                    "");
            }
        }
    }
}
