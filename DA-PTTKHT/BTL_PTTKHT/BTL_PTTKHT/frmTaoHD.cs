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
    public partial class frmTaoHD : Form
    {
        NhanVien_BLL bllNhanVien;
        KhachHang_BLL bllKhachHang;
        HoaDon_BLL bllHoaDon;

        public frmTaoHD()
        {
            InitializeComponent();
            bllNhanVien = new NhanVien_BLL();
            bllKhachHang = new KhachHang_BLL();
            bllHoaDon = new HoaDon_BLL();
        }

        private AutoCompleteStringCollection GetAutoSourceCollectionFromDataTableGetTenNV()
        {
            AutoCompleteStringCollection autoSourceCollection = new AutoCompleteStringCollection();
            foreach (DataRow row in bllNhanVien.getTenNV().Rows)
            {
                autoSourceCollection.Add(row[0].ToString());
            }
            return autoSourceCollection;
        }

        private AutoCompleteStringCollection GetAutoSourceCollectionFromDataTableGetTenKH()
        {
            AutoCompleteStringCollection autoSourceCollection = new AutoCompleteStringCollection();
            foreach (DataRow row in bllKhachHang.getTenKH().Rows)
            {
                autoSourceCollection.Add(row[0].ToString());
            }
            return autoSourceCollection;
        }

        public void FillCmbTenNV()
        {
            tbl_NhanVien NhanVien = new tbl_NhanVien();
            cmbTenNV.DisplayMember = "TenNV";
            cmbTenNV.DataSource = bllNhanVien.getTenNV();
        }

        private void cmbTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbl_NhanVien NhanVien = new tbl_NhanVien();
            if (cmbTenNV.Text.Trim() != "")
            {
                NhanVien.TenNV = cmbTenNV.Text;
                bllNhanVien.getMaNV(NhanVien);
            }
            txtMaNV.Text = NhanVien.MaNV;
        }

        public void FillCmbTenKH()
        {
            tbl_KhachHang KhachHang = new tbl_KhachHang();
            cmbTenKH.DisplayMember = "TenKH";
            cmbTenKH.DataSource = bllKhachHang.getTenKH();
        }

        private void cmbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbl_KhachHang KhachHang = new tbl_KhachHang();
            if (cmbTenKH.Text.Trim() != "")
            {
                KhachHang.TenKH = cmbTenKH.Text;
                bllKhachHang.getMaKH(KhachHang);
            }
            txtMaKH.Text = KhachHang.MaKH;
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            tbl_HoaDon HoaDon = new tbl_HoaDon();
            HoaDon.MaNV = txtMaNV.Text;
            HoaDon.MaKH = txtMaKH.Text;
            HoaDon.NgayLapHoaDon = dtpNgayLapHD.Value;

            if (bllHoaDon.InsertHoaDon(HoaDon))
            {
                MessageBox.Show("Tạo hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                frmCTHD CTHD = new frmCTHD();
                CTHD.txtSoHD1.Text = txtSoHD.Text;
                CTHD.ShowDialog();
                this.Close();               
            }

            else
            {
                MessageBox.Show("Lỗi tạo hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frmTaoHD_Load(object sender, EventArgs e)
        {
            dtpNgayLapHD.Value = DateTime.Now;
            txtSoHD.Text = bllHoaDon.GetSoHD().ToString();

            txtSoHD.Enabled = false;
            txtMaNV.Enabled = false;
            txtMaKH.Enabled = false;

            FillCmbTenNV();
            cmbTenNV.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbTenNV.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbTenNV.AutoCompleteCustomSource = GetAutoSourceCollectionFromDataTableGetTenNV();

            FillCmbTenKH();
            cmbTenKH.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbTenKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbTenKH.AutoCompleteCustomSource = GetAutoSourceCollectionFromDataTableGetTenKH();
        }

        private void ControlClose_Click(object sender, EventArgs e)
        {
          
        }
    }
}
