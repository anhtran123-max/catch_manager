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
    public partial class frmThongKeMain : Form
    {
        HoaDon_BLL bllHoaDon;
        ChamCong_BLL bllChamCong;
        SanPham_BLL bllSanPham;

        public frmThongKeMain()
        {
            InitializeComponent();
            bllHoaDon = new HoaDon_BLL();
            bllChamCong = new ChamCong_BLL();
            bllSanPham = new SanPham_BLL();
        }   

        private void LoadCombobox()
        {
            cmbTK.Items.Add("-- Chọn thống kê --");
            cmbTK.Items.Add("Thống kê doanh thu");
            cmbTK.Items.Add("Thống kê sản phẩm đã bán");
            cmbTK.Items.Add("Thống kê lương nhân viên");
            cmbTK.Items.Add("Thống kê hàng tồn kho");
            cmbTK.SelectedIndex = 0;           

            cmbYear.Items.Add("-- Chọn năm --");
            cmbYear.SelectedIndex = 0;
            for (int a = 2015; a < 2026; a++)
            {
                cmbYear.Items.Add(a);
            }        

            cmbMonth.Items.Add("-- Chọn tháng --");
            cmbMonth.SelectedIndex = 0;
            for (int a = 1; a < 13; a++)
            {
                cmbMonth.Items.Add(a);
            }

            //cmbLoaiTK.Items.Add("-- Chọn loại thống kê --");
            cmbLoaiTK.Items.Add("Thống kê theo biểu đồ");
            cmbLoaiTK.Items.Add("Thống kê theo bảng");
            cmbLoaiTK.SelectedIndex = 0;
        }

        //private Form activeForm = null;
        //private void openChildForm(Form childForm)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    panelChildForm.Controls.Add(childForm);
        //    panelChildForm.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}

        private void getDHBanThangNam()
        {
            tbl_HoaDon HoaDon = new tbl_HoaDon();
            HoaDon.Nam = Convert.ToInt32(cmbYear.Text);
            HoaDon.Thang = Convert.ToInt32(cmbMonth.Text);

            chart.Series.Clear();
            chart.Series.Add("Đồng hồ");
            chart.DataSource = bllHoaDon.ThongKe_SP_NamThang(HoaDon);
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";

            chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart.ChartAreas["ChartArea1"].AxisY.Interval = 1;

            chart.Series["Đồng hồ"].XValueMember = "Tên đồng hồ";
            chart.Series["Đồng hồ"].YValueMembers = "SL";

            dgv.DataSource = bllHoaDon.ThongKe_SP_NamThang(HoaDon);
        }

        private void getDHBanNam()
        {
            tbl_HoaDon HoaDon = new tbl_HoaDon();
            HoaDon.Nam = Convert.ToInt32(cmbYear.Text);
            chart.Series.Clear();
            chart.Series.Add("Đồng hồ");
            chart.DataSource = bllHoaDon.ThongKe_SP_Nam(HoaDon);
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";

            chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart.ChartAreas["ChartArea1"].AxisY.Interval = 1;

            chart.Series["Đồng hồ"].XValueMember = "Tên đồng hồ";
            chart.Series["Đồng hồ"].YValueMembers = "SL";

            dgv.DataSource = bllHoaDon.ThongKe_SP_Nam(HoaDon);
        }

        private void getDoanhThuThangNam()
        {
            chart.Series.Clear();
            chart.Series.Add("Doanh thu");
            tbl_HoaDon HoaDon = new tbl_HoaDon();
            HoaDon.Thang = Convert.ToInt32(cmbMonth.Text);
            HoaDon.Nam = Convert.ToInt32(cmbYear.Text);
            chart.DataSource = bllHoaDon.ThongKe_DoanhThu_ThangNam(HoaDon);
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Thu nhập";

            chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart.ChartAreas["ChartArea1"].AxisY.Interval = 10000000;

            chart.Series["Doanh thu"].XValueMember = "Tháng";
            chart.Series["Doanh thu"].YValueMembers = "Thành tiền";

            dgv.DataSource = bllHoaDon.ThongKe_DoanhThu_ThangNam(HoaDon);
        }

        private void getDoanhThuNam()
        {
            chart.Series.Clear();
            chart.Series.Add("Doanh thu");
            tbl_HoaDon HoaDon = new tbl_HoaDon();
            HoaDon.Nam = Convert.ToInt32(cmbYear.Text);
            chart.DataSource = bllHoaDon.ThongKe_DoanhThu_Nam(HoaDon);
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Thu nhập";

            chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart.ChartAreas["ChartArea1"].AxisY.Interval = 10000000;

            chart.Series["Doanh thu"].XValueMember = "Năm";
            chart.Series["Doanh thu"].YValueMembers = "Thành tiền";

            dgv.DataSource = bllHoaDon.ThongKe_DoanhThu_Nam(HoaDon);
        }

        private void GetLuongNam()
        {
            chart.Series.Clear();
            chart.Series.Add("Tiền lương");

            tbl_ChamCong CC = new tbl_ChamCong();
            CC.Nam = Convert.ToInt32(cmbYear.Text);
            chart.DataSource = bllChamCong.ThongKe_LuongNam(CC);
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Thu nhập";

            chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart.ChartAreas["ChartArea1"].AxisY.Interval = 100000;

            chart.Series["Tiền lương"].XValueMember = "Tên nhân viên";
            chart.Series["Tiền lương"].YValueMembers = "Tiền lương";

            dgv.DataSource = bllChamCong.ThongKe_LuongNam(CC);
        }

        private void cmbTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTK.SelectedIndex == 0)
            {
                cmbYear.Enabled = false;
                cmbMonth.Enabled = false;
            }

            if ((cmbTK.SelectedIndex == 1) || (cmbTK.SelectedIndex == 2) || (cmbTK.SelectedIndex == 3))
            {
                cmbYear.Enabled = true;
                chart.DataSource = null;
                dgv.DataSource = null;
                cmbYear.Visible = true;
                cmbMonth.Visible = true;
                cmbLoaiTK.Enabled = true;
            }

            if (cmbTK.SelectedIndex == 4)
            {
                cmbYear.Visible = false;
                cmbMonth.Visible = false;
                cmbLoaiTK.SelectedIndex = 1;
                cmbLoaiTK.Enabled = false;
                dgv.DataSource = bllSanPham.ThongKeSLTon();
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex == 0)
            {
                cmbMonth.Enabled = false;
            }

            if (cmbYear.SelectedIndex != 0)
            {
                cmbMonth.Enabled = true;
            }

            if ((cmbYear.SelectedIndex != 0) && (cmbTK.SelectedIndex == 1))
            {
                cmbMonth.Enabled = true;
                getDoanhThuNam();
            }

            if ((cmbYear.SelectedIndex != 0) && (cmbTK.SelectedIndex == 2))
            {
                cmbMonth.Enabled = true;
                getDHBanNam();
            }          

            if ((cmbYear.SelectedIndex != 0) && (cmbTK.SelectedIndex == 3))
            {
                //cmbMonth.Enabled = true;
                cmbMonth.Visible = false;
                GetLuongNam();
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbMonth.SelectedIndex != 0) && (cmbTK.SelectedIndex == 1))
            {
                cmbMonth.Enabled = true;
                getDoanhThuThangNam();
            }

            if ((cmbMonth.SelectedIndex != 0) && (cmbTK.SelectedIndex == 2))
            {
                cmbMonth.Enabled = true;
                getDHBanThangNam();
            }

            if ((cmbMonth.SelectedIndex != 0) && (cmbTK.SelectedIndex == 3))
            {
                cmbMonth.Enabled = true;
                GetLuongNam();
            }
        }

        private void cmbLoaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiTK.SelectedIndex == 0)
            {
                chart.Visible = true;
                dgv.Visible = false;
            }

            if (cmbLoaiTK.SelectedIndex == 1)
            {
                chart.Visible = false;
                dgv.Visible = true;
            }
        }

      

      

        private void frmThongKeMain_Load(object sender, EventArgs e)
        {
            cmbYear.Enabled = false;
            cmbMonth.Enabled = false;

            LoadCombobox();
        }

       
    }
}

