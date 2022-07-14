using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_PTTKHT
{
    public partial class frmThongKe : Form
    {
        CTHD_BLL bllCTHD;
        HoaDon_BLL bllHoaDon;

        public frmThongKe()
        {
            InitializeComponent();
            bllCTHD = new CTHD_BLL();
            bllHoaDon = new HoaDon_BLL();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            btnSoGD.Text = bllHoaDon.GetSoGD().ToString() + " Hóa đơn giao dịch";
            btnDHDaBan.Text = bllCTHD.GetSoDongHoDaBan().ToString() + " Đồng hồ đã bán";

            string TienThu;
            TienThu = bllHoaDon.GetTongTienThu().ToString();
            TienThu = string.Format("{0:#,##0}", double.Parse(TienThu));
            btnTienThu.Text = "Thu lại " + TienThu + " VND";
        }
    }
}   
