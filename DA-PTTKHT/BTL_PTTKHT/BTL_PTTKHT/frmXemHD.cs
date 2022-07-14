using Microsoft.Reporting.WinForms;
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
    public partial class frmXemHD : Form
    {
        CTHD_BLL bllCTHD;
        Report_BLL bllReport;
        HoaDon_BLL bllHoaDon;

        public frmXemHD()
        {
            InitializeComponent();
            bllCTHD = new CTHD_BLL();
            bllReport = new Report_BLL();
            bllHoaDon = new HoaDon_BLL();
        }

        public void ShowHoaDon()
        {
            tbl_CTHD CTHD = new tbl_CTHD();
            CTHD.SoHD = Convert.ToInt32(txtSoHD.Text);
            DataTable dtTable = bllCTHD.getCTHD(CTHD);
            dgvCTHD.DataSource = dtTable;
        }

        public void TongCong()
        {
            decimal Total = 0;
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(dgvCTHD.Rows[i].Cells[4].Value);
            }

            txtThanhTien.Text = Total.ToString();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            frm_Bill BillFrm = new frm_Bill();
            BillFrm.Report = new tbl_Report();
            BillFrm.Report.SoHD = txtSoHD.Text;

            ReportDataSource datasource = new ReportDataSource("DataSet_Bill", bllReport.getReport(BillFrm.Report).Tables[0]);
            BillFrm.reportViewerBill.LocalReport.DataSources.Clear();
            BillFrm.reportViewerBill.LocalReport.DataSources.Add(datasource);
            BillFrm.reportViewerBill.RefreshReport();

            BillFrm.Show();
        }

        private void frmXemHD_Load(object sender, EventArgs e)
        {            
            ShowHoaDon();
            TongCong();
            dgvCTHD.Columns[3].DefaultCellStyle.Format = "N0";
            dgvCTHD.Columns[4].DefaultCellStyle.Format = "N0";
            txtThanhTien.Text = string.Format("{0:#,##0}", decimal.Parse(txtThanhTien.Text));
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbl_HoaDon hoadon = new tbl_HoaDon();
                hoadon.SoHD = Convert.ToInt32(txtSoHD.Text);
                bllHoaDon.DaTT(hoadon);
                this.Close();
            }
        }
    }
}
