using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_PTTKHT
{
    public partial class frmHoaDon : Form
    {
        NhanVien_BLL bllNhanVien;
        KhachHang_BLL bllKhachHang;
        HoaDon_BLL bllHoaDon;
        Report_BLL bllReport;

        public frmHoaDon()
        {
            InitializeComponent();
            bllNhanVien = new NhanVien_BLL();
            bllKhachHang = new KhachHang_BLL();
            bllHoaDon = new HoaDon_BLL();
            bllReport = new Report_BLL();
        }    

        public void ShowAllHoaDon()
        {
            DataTable dtTable = bllHoaDon.getAllHoaDon();
            dgvHoaDon.DataSource = dtTable;
        }

        private void btnXemCTHD_Click(object sender, EventArgs e)
        {
            frmXemHD XemHD = new frmXemHD();

            if (dgvHoaDon.SelectedRows[0].Cells[5].Value.ToString() == "Chưa thanh toán")
                XemHD.btnThanhToan.Visible = true;
            else
                XemHD.btnThanhToan.Visible = false;

            XemHD.txtSoHD.Text = dgvHoaDon.SelectedRows[0].Cells[0].Value.ToString();
            XemHD.txtTenNV.Text = dgvHoaDon.SelectedRows[0].Cells[1].Value.ToString();
            XemHD.txtTenKH.Text = dgvHoaDon.SelectedRows[0].Cells[2].Value.ToString();
            XemHD.txtNgayLapHD.Text = dgvHoaDon.SelectedRows[0].Cells[3].Value.ToString();
            XemHD.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ShowAllHoaDon();
            checkBXemHDTrongThang.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmTaoHD TaoHDFrm = new frmTaoHD();
            TaoHDFrm.ShowDialog();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            tbl_HoaDon HoaDon = new tbl_HoaDon();
            tbl_NhanVien NhanVien = new tbl_NhanVien();
            tbl_KhachHang KhachHang = new tbl_KhachHang();

            if (txtTimKiem.Text.Trim() != "")
            {
                if (!int.TryParse(txtTimKiem.Text, out parsedValue))
                {                    
                    NhanVien.TenNV = txtTimKiem.Text;
                    KhachHang.TenKH = txtTimKiem.Text;

                    DataTable dtTable = bllHoaDon.SearchCharacterHoaDon(KhachHang, NhanVien);
                    dgvHoaDon.DataSource = dtTable;

                    if (txtTimKiem.Text == "Tìm hóa đơn ...")
                        ShowAllHoaDon();
                }

                if (int.TryParse(txtTimKiem.Text, out parsedValue))
                {
                    HoaDon.SoHD = Convert.ToInt32(txtTimKiem.Text);

                    DataTable dtTable = bllHoaDon.SearchNumberHoaDon(HoaDon);
                    dgvHoaDon.DataSource = dtTable;

                    if (txtTimKiem.Text == "Tìm hóa đơn ...")
                        ShowAllHoaDon();
                }
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                txtTimKiem.Text = "Tìm hóa đơn ...";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.ForeColor = Color.Black;
            ShowAllHoaDon();
            checkBXemHDTrongThang.Checked = false;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {           
            ShowAllHoaDon();
            dgvHoaDon.Columns[4].DefaultCellStyle.Format = "N0";
            guna2Panel1.Visible = false;    
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            frm_Bill BillFrm = new frm_Bill();
            BillFrm.Report = new tbl_Report();
            BillFrm.Report.SoHD = dgvHoaDon.SelectedRows[0].Cells[0].Value.ToString();

            ReportDataSource datasource = new ReportDataSource("DataSet_Bill", bllReport.getReport(BillFrm.Report).Tables[0]);
            BillFrm.reportViewerBill.LocalReport.DataSources.Clear();
            BillFrm.reportViewerBill.LocalReport.DataSources.Add(datasource);
            BillFrm.reportViewerBill.RefreshReport();

            BillFrm.Show();
        }

        private void checkBXemHDTrongThang_Click(object sender, EventArgs e)
        {
            DataTable dtTable = bllHoaDon.XemHDTrongThang();
            if (checkBXemHDTrongThang.Checked == true)
            {
                dgvHoaDon.DataSource = dtTable;
            }

            else
                ShowAllHoaDon();
            //string dateee;
            //dateee = dtpTimTheoNgay.Value.ToString();
        }

        private void dtpTimTheoNgay_ValueChanged(object sender, EventArgs e)
        {
            tbl_HoaDon HoaDon = new tbl_HoaDon();
            HoaDon.NgayLapHoaDon = dtpTimTheoNgay.Value;
            DataTable dtTable = bllHoaDon.XemHDTheoNgay(HoaDon);
            dgvHoaDon.DataSource = dtTable;
        }

        private void btnSearchHoaDon_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value >= dtpDenNgay.Value)
            {
                MessageBox.Show("Kiểm tra lại ngày tìm hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                tbl_HoaDon HoaDon = new tbl_HoaDon();
                HoaDon.NgayLapHoaDon = dtpTuNgay.Value;
                HoaDon.NgayLapHoaDon2 = dtpDenNgay.Value;
                DataTable dtTable = bllHoaDon.XemHDTuNgayDenNgay(HoaDon);
                dgvHoaDon.DataSource = dtTable;
            }           
        }
    }
}