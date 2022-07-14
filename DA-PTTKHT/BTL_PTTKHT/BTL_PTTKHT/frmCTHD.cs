using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_PTTKHT
{
    public partial class frmCTHD : Form
    {        
        SanPham_BLL bllSanPham;
        CTHD_BLL bllCTHD;
        HoaDon_BLL bllHoaDon;
        LoaiSP_BLL bllLoaiSP;

        public frmCTHD()
        {
            InitializeComponent();            
            bllSanPham = new SanPham_BLL();
            bllCTHD = new CTHD_BLL();
            bllHoaDon = new HoaDon_BLL();
            bllLoaiSP = new LoaiSP_BLL();
        }

        private void FillcmbLoaiDH()
        {
            cmbLoaiDH.DisplayMember = "TenLSP";
            cmbLoaiDH.DataSource = bllLoaiSP.FillCmbTenLSP();
        }

        private void FillcmbTenDH()
        {
            tbl_LoaiSP LoaiSP = new tbl_LoaiSP();
            LoaiSP.TenLSP = cmbLoaiDH.Text;
            cmbTenDH.DisplayMember = "TenSP";
            cmbTenDH.DataSource = bllLoaiSP.getTenSP(LoaiSP);
        }

       private void GetSLTon()
        {
            tbl_SanPham SanPham = new tbl_SanPham();
            SanPham.MaSP = txtMaSP.Text;
            txtSL.Text = bllSanPham.GetSLTon(SanPham).ToString();
        }

        //private AutoCompleteStringCollection GetAutoSourceCollectionFromDataTableGetTenSP()
        //{
        //    AutoCompleteStringCollection autoSourceCollection = new AutoCompleteStringCollection();
        //    foreach (DataRow row in bllSanPham.getTenSP().Rows)
        //    {
        //        autoSourceCollection.Add(row[0].ToString());
        //    }
        //    return autoSourceCollection;
        //}

        private void ShowAllCTHD()
        {
            tbl_CTHD CTHD = new tbl_CTHD();


            CTHD.SoHD = Convert.ToInt32(txtSoHD1.Text);
            DataTable dtTable = bllCTHD.getCTHD(CTHD);
            dgvCTHD.DataSource = dtTable;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            tbl_CTHD CTHD = new tbl_CTHD();
            tbl_SanPham SanPham = new tbl_SanPham();

            if (txtTimKiem.Text.Trim() != "")
            {
                CTHD.SoHD = Convert.ToInt32(txtSoHD1.Text);

                if (!int.TryParse(txtTimKiem.Text, out parsedValue))
                {
                    CTHD.MaSP = txtTimKiem.Text;
                    SanPham.TenSP = txtTimKiem.Text;

                    DataTable dtTable1 = bllCTHD.SearchCharacterCTHD(CTHD, SanPham);
                    dgvCTHD.DataSource = dtTable1;

                    if (txtTimKiem.Text == "Tìm sản phẩm ...")
                        ShowAllCTHD();
                }


                if (int.TryParse(txtTimKiem.Text, out parsedValue))
                {
                    CTHD.SoLuong = Convert.ToInt32(txtTimKiem.Text);
                    CTHD.DonGiaSP = Convert.ToDecimal(txtTimKiem.Text);
                    CTHD.ThanhTienSP = Convert.ToDecimal(txtTimKiem.Text);

                    DataTable dtTable1 = bllCTHD.SearchNumberCTHD(CTHD);
                    dgvCTHD.DataSource = dtTable1;

                    if (txtTimKiem.Text == "Tìm sản phẩm ...")
                        ShowAllCTHD();
                }
            }
        }

        private void cmbTenDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbl_SanPham SanPham = new tbl_SanPham();
            if (cmbTenDH.Text.Trim() != "")
            {
                SanPham.TenSP = cmbTenDH.Text;
                bllSanPham.getMaSP(SanPham);
            }
            txtMaSP.Text = SanPham.MaSP;

            SanPham.MaSP = txtMaSP.Text;
            txtThanhTien.Text = (bllSanPham.GetGiaBan(SanPham) * numSL.Value).ToString();
            txtThanhTien.Text = string.Format("{0:#,##0}", decimal.Parse(txtThanhTien.Text));
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                txtTimKiem.Text = "Tìm sản phẩm ...";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.ForeColor = Color.Black;
        }

        public void ShowInformationOfHoaDon()
        {
            DataTable dtTable = bllHoaDon.getInformationOfHoaDon();
            foreach (DataRow row in dtTable.Rows)
            {
                foreach (DataColumn column in dtTable.Columns)
                {
                    txtSoHD1.Text = row["SOHD"].ToString();
                    txtTenNV.Text = row["TENNV"].ToString();
                    txtTenKH.Text = row["TENKH"].ToString();
                    txtNgayLapHD.Text = row["NGAYLAPHOADON"].ToString();
                }
            }
        }

        void ResetBox()
        {
            cmbLoaiDH.SelectedIndex = 0;
            numSL.Value = 0;
        }      

        void OpenBox()
        {
            cmbLoaiDH.DropDownHeight = 200;
            cmbLoaiDH.KeyDown += (s, e) => e.Handled = false;
            cmbLoaiDH.KeyPress += (s, e) => e.Handled = false;
            cmbLoaiDH.KeyUp += (s, e) => e.Handled = false;

            cmbTenDH.DropDownHeight = 200;
            cmbTenDH.KeyDown += (s, e) => e.Handled = false;
            cmbTenDH.KeyPress += (s, e) => e.Handled = false;
            cmbTenDH.KeyUp += (s, e) => e.Handled = false;

            numSL.Enabled = true;
        }

        void CloseBox()
        {
            //var keyDown = (s, e) => e.Handled = true;
            //var keyPress = (s, e) => e.Handled = true;
            //var keyUp = (s, e) => e.Handled = true;

            //cmbLoaiDH.KeyDown += keyDown;
            //cmbLoaiDH.KeyPress += keyPress;
            //cmbLoaiDH.KeyUp += keyUp;


            cmbLoaiDH.DropDownHeight = 1;
            cmbLoaiDH.KeyDown += (s, e) => e.Handled = true;
            cmbLoaiDH.KeyPress += (s, e) => e.Handled = true;
            cmbLoaiDH.KeyUp += (s, e) => e.Handled = true;

            cmbTenDH.DropDownHeight = 1;
            cmbTenDH.KeyDown += (s, e) => e.Handled = true;
            cmbTenDH.KeyPress += (s, e) => e.Handled = true;
            cmbTenDH.KeyUp += (s, e) => e.Handled = true;

            numSL.Enabled = false;
        }

        bool checkThemSua = false;

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtSL.Text) == 0)
            {
                OpenBox();
                btnLuu.Enabled = false;
            }

            else
            {
                OpenBox();
            }
                
            ResetBox();          
            checkThemSua = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTroVe.Enabled = true;

            if (numSL.Value == 0)
            {
                lblNoteSL.Text = "* Chưa nhập số lượng!";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (checkThemSua == true)
            {
                if (numSL.Value == 0)
                {
                    MessageBox.Show("Chưa nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                else
                {
                    tbl_CTHD CTHD = new tbl_CTHD();
                    CTHD.SoHD = Convert.ToInt32(txtSoHD1.Text);
                    CTHD.MaSP = txtMaSP.Text;
                    CTHD.SoLuong = Convert.ToInt32(numSL.Value);

                    if (bllCTHD.InsertCTHD(CTHD))
                    {
                        ShowAllCTHD();
                        CloseBox();
                        MessageBox.Show("Nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dgvCTHD.RowCount == 1)
                        {
                            btnThanhToan.Enabled = false;
                        }
                        else if (dgvCTHD.RowCount > 1)
                            btnThanhToan.Enabled = true;

                        btnLuu.Enabled = false;
                        btnThem.Enabled = true;
                    }

                    else
                    {
                        MessageBox.Show("Đã có sản phẩm trong giỏ hàng hoặc không đủ hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmbTenDH.Focus();
                    }
                }
            }

            if (checkThemSua == false)
            {
                if (numSL.Value == 0)
                {
                    MessageBox.Show("Chưa nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                else
                {
                    tbl_CTHD CTHD = new tbl_CTHD();
                    CTHD.SoHD = Convert.ToInt32(txtSoHD1.Text);
                    CTHD.MaSP = dgvCTHD.SelectedRows[0].Cells[0].Value.ToString();
                    CTHD.SoLuong = Convert.ToInt32(numSL.Value);

                    if (bllCTHD.UpdateCTHD(CTHD))
                    {
                        ShowAllCTHD();
                        CloseBox();
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLuu.Enabled = false;
                        btnThem.Enabled = true;
                        btnSua.Enabled = false;
                    }

                    else
                    {
                        MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CloseBox();
            numSL.Enabled = true;
            checkThemSua = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnTroVe.Enabled = true;

            if (numSL.Value == 0)
            {
                lblNoteSL.Text = "* Chưa nhập số lượng!";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Chưa chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tbl_CTHD CTHD = new tbl_CTHD();
                    CTHD.SoHD = Convert.ToInt32(txtSoHD1.Text);
                    CTHD.MaSP = txtMaSP.Text;

                    if (bllCTHD.DeleteCTHD(CTHD))
                    {
                        ResetBox();
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dgvCTHD.RowCount == 2)
                        {
                            btnThanhToan.Enabled = false;
                        }
                        else if (dgvCTHD.RowCount > 2)
                            btnThanhToan.Enabled = true;

                        ShowAllCTHD();
                    }

                    else
                        MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy thao tác??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CloseBox();
                ResetBox();
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnTroVe.Enabled = false;
            }
        }       

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            tbl_SanPham SanPham = new tbl_SanPham();
            int index = e.RowIndex;
            if (index >= 0)
            {
                CloseBox();
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                txtMaSP.Text = dgvCTHD.Rows[index].Cells[0].Value.ToString();
                SanPham.MaSP = txtMaSP.Text;
                cmbLoaiDH.Text = bllSanPham.getTenLSP(SanPham).ToString();
                cmbTenDH.Text = bllSanPham.getTenSP(SanPham).ToString();
                //cmbLoaiDH.SelectedText = bllSanPham.getTenLSP(SanPham).ToString();
                numSL.Value = Convert.ToDecimal(dgvCTHD.Rows[index].Cells[2].Value.ToString());
            }
        }

        private void ControlClose_Click(object sender, EventArgs e)
        {
            tbl_HoaDon hoadon = new tbl_HoaDon();
            hoadon.SoHD = Convert.ToInt32(txtSoHD1.Text);
            bllHoaDon.ChuaTT(hoadon);

            frmMainn MainnFrm = new frmMainn();
            openChildForm(new frmHoaDon());
            MainnFrm.btnTrangChu.FillColor = Color.White;
            MainnFrm.btnHoaDon.FillColor = Color.FromArgb(244, 222, 226);
            MainnFrm.btnNhanVien.FillColor = Color.White;
            MainnFrm.btnKhachHang.FillColor = Color.White;
            MainnFrm.btnSanPham.FillColor = Color.White;
            MainnFrm.Show();
        }

        private void numSL_ValueChanged(object sender, EventArgs e)
        {
            if (numSL.Value == 0)
            {
                lblNoteSL.Text = "* Chưa nhập số lượng!";
                txtThanhTien.Text = "0";
            }
            else
            {
                lblNoteSL.Text = "";
                tbl_SanPham SanPham = new tbl_SanPham();
                SanPham.MaSP = txtMaSP.Text;
                txtThanhTien.Text = (bllSanPham.GetGiaBan(SanPham) * numSL.Value).ToString();
                txtThanhTien.Text = string.Format("{0:#,##0}", decimal.Parse(txtThanhTien.Text));
            }                
        }

        #region Form
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            frmMainn MainnFrm = new frmMainn();
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainnFrm.panelChildForm.Controls.Add(childForm);
            MainnFrm.panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        private void frmCTHD_Load(object sender, EventArgs e)
        {
            //frmHoaDon HoaDon = new frmHoaDon();
            //txtSoHD1.Text = HoaDon.txtSoHD.Text;         
            
            lblNoteSL.Text = "";
            txtSoHD1.Enabled = false;
            txtTenNV.Enabled = false;
            txtTenKH.Enabled = false;
            txtNgayLapHD.Enabled = false;
            txtMaSP.Enabled = false;

            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThanhToan.Enabled = false;
            CloseBox();
            //FillcmbTenDH();
            FillcmbLoaiDH();
            //cmbTenDH.AutoCompleteMode = AutoCompleteMode.Suggest;
            //cmbTenDH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //cmbTenDH.AutoCompleteCustomSource = GetAutoSourceCollectionFromDataTableGetTenSP();
            ShowInformationOfHoaDon();
            ShowAllCTHD();
            dgvCTHD.Columns[3].DefaultCellStyle.Format = "N0";
            dgvCTHD.Columns[4].DefaultCellStyle.Format = "N0";
        }

        public void getPicture()
        {
            tbl_SanPham SanPham = new tbl_SanPham();
            SanPham.MaSP = txtMaSP.Text;

            if (bllSanPham.GetPhoto(SanPham) == null)
            {
                Picture.Image = null;
            }

            else
            {
                MemoryStream ms = new MemoryStream(bllSanPham.GetPhoto(SanPham));
                Picture.Image = Image.FromStream(ms);
                //Picture.Click += new EventHandler(d);
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            getPicture();
            GetSLTon();
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            frmXemHinhSP XemHinh = new frmXemHinhSP();
            XemHinh.Picture.Image = Picture.Image;
            XemHinh.Show();
        }

        private void cmbLoaiDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillcmbTenDH();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbl_HoaDon hoadon = new tbl_HoaDon();
                hoadon.SoHD = Convert.ToInt32(txtSoHD1.Text);
                bllHoaDon.DaTT(hoadon);
                this.Close();
                //frm_Bill Bill = new frm_Bill();
                //Bill.Show();

            }
             

            //frmMainn MainnFrm = new frmMainn();
            //openChildForm(new frmHoaDon());
            //MainnFrm.btnTrangChu.FillColor = Color.White;
            //MainnFrm.btnHoaDon.FillColor = Color.FromArgb(244, 222, 226);
            //MainnFrm.btnNhanVien.FillColor = Color.White;
            //MainnFrm.btnKhachHang.FillColor = Color.White;
            //MainnFrm.btnSanPham.FillColor = Color.White;
            //MainnFrm.Show();
        }


        private void EnablebtnLuu()
        {
            if (txtSL.Text == "0")
                btnLuu.Enabled = false;
            else
                btnLuu.Enabled = true;
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            EnablebtnLuu();
        }
    }
}