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
    public partial class frmSuaSP : Form
    {
        LoaiSP_BLL bllLoaiSP;
        NhaCC_BLL bllNhaCC;
        SanPham_BLL bllSanPham;

        public frmSuaSP()
        {
            InitializeComponent();
            bllLoaiSP = new LoaiSP_BLL();
            bllNhaCC = new NhaCC_BLL();
            bllSanPham = new SanPham_BLL();
        }

        public void FillCmbTenLSP()
        {
            tbl_LoaiSP LoaiSP = new tbl_LoaiSP();
            cmbTenLSP.DisplayMember = "TenLSP";
            cmbTenLSP.DataSource = bllLoaiSP.FillCmbTenLSP();
        }

        public void FillCmbTenNCC()
        {
            tbl_NhaCungCap NhaCC = new tbl_NhaCungCap();
            cmbTenNCC.DisplayMember = "TenNCC";
            cmbTenNCC.DataSource = bllNhaCC.FillCmbTenNCC();
        }

        public bool CheckData()
        {
            string notice = "";

            if (string.IsNullOrEmpty(txtGiaBan.Text))
            {
                notice += "Chưa nhập giá bán\n";
                txtGiaBan.Focus();
            }

            if (string.IsNullOrEmpty(txtGiaMua.Text))
            {
                notice += "Chưa nhập giá mua\n";
                txtGiaMua.Focus();
            }

            if (numSL.Value == 0)
            {
                notice += "Chưa nhập số lượng\n";
                numSL.Focus();
            }

            if (string.IsNullOrEmpty(txtTenSP.Text))
            {
                notice += "Chưa nhập tên sản phẩm\n";
                txtTenSP.Focus();
            }

            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                notice += "Chưa nhập mã sản phẩm\n";
                txtMaSP.Focus();
            }

            if ((string.IsNullOrEmpty(txtGiaBan.Text)) || (string.IsNullOrEmpty(txtGiaMua.Text)) || (numSL.Value == 0) || (string.IsNullOrEmpty(txtTenSP.Text)) || (string.IsNullOrEmpty(txtMaSP.Text)))
            {
                MessageBox.Show(notice, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        void ShowNote()
        {
            //if (txtMaSP.Text.Trim() == "")
            //{
            //    lblNoteMaSP.Text = "* Chưa nhập mã sản phẩm!";
            //}

            if (txtTenSP.Text.Trim() == "")
            {
                lblNoteTenSP.Text = "* Chưa nhập tên sản phẩm!";
            }

            if (numSL.Value == 0)
            {
                lblNoteSL.Text = "* Chưa nhập số lượng!";
            }

            if (txtGiaMua.Text.Trim() == "")
            {
                lblNoteGiaMua.Text = "* Chưa nhập giá mua!";
            }

            if (txtGiaBan.Text.Trim() == "")
            {
                lblNoteGiaBan.Text = "* Chưa nhập giá bán!";
            }
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSP.Text.Trim() == "")
            {
                lblNoteTenSP.Text = "* Chưa nhập tên sản phẩm!";
            }
            else
                lblNoteTenSP.Text = "";
        }

        private void numSL_ValueChanged(object sender, EventArgs e)
        {
            if (numSL.Value == 0)
            {
                lblNoteSL.Text = "* Chưa nhập số lượng!";
            }
            else
                lblNoteSL.Text = "";
        }

        private void txtGiaMua_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaMua.Text.Trim() == "")
            {
                lblNoteGiaMua.Text = "* Chưa nhập giá mua!";
            }
            else
                lblNoteGiaMua.Text = "";
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaBan.Text.Trim() == "")
            {
                lblNoteGiaBan.Text = "* Chưa nhập giá bán!";
            }
            else
                lblNoteGiaBan.Text = "";
        }

        private void cmbTenLSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbl_LoaiSP LoaiSP = new tbl_LoaiSP();
            if (cmbTenLSP.Text.Trim() != "")
            {
                LoaiSP.TenLSP = cmbTenLSP.Text;
                bllLoaiSP.getMaLSP(LoaiSP);
            }
            txtMaLSP.Text = LoaiSP.MaLSP;
        }

        private void cmbTenNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbl_NhaCungCap NhaCC = new tbl_NhaCungCap();
            if (cmbTenNCC.Text.Trim() != "")
            {
                NhaCC.TenNCC = cmbTenNCC.Text;
                bllNhaCC.getMaNCC(NhaCC);
            }
            txtMaNCC.Text = NhaCC.MaNCC;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tbl_SanPham SanPham = new tbl_SanPham();
                SanPham.MaSP = txtMaSP.Text;
                SanPham.TenSP = txtTenSP.Text;
                SanPham.MaLSP = txtMaLSP.Text;
                SanPham.MaNCC = txtMaNCC.Text;
                SanPham.SoLuong = Convert.ToInt32(numSL.Value);
                SanPham.GiaMua = Convert.ToDecimal(txtGiaMua.Text);
                SanPham.GiaBan = Convert.ToDecimal(txtGiaBan.Text);

                byte[] images = null;
                FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Stream);
                images = brs.ReadBytes((int)Stream.Length);

                SanPham.HinhAnh = images;

                if (bllSanPham.UpdateSanPham(SanPham))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Kiểm tra lại mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtMaSP.Focus();
                }
            }
        }

        private void frmSuaSP_Load(object sender, EventArgs e)
        {
            ShowNote();
            FillCmbTenLSP();
            FillCmbTenNCC();
            getPicture();
            txtMaNCC.Enabled = false;
            txtMaLSP.Enabled = false;
            txtMaSP.Enabled = false;
        }

        string imgLocation;
        private void btnThemHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png|*.png|jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                picSanPham.ImageLocation = imgLocation;
            }
        }

        public void getPicture()
        {
            tbl_SanPham SanPham = new tbl_SanPham();
            SanPham.MaSP = txtMaSP.Text;

            if (bllSanPham.GetPhoto(SanPham) == null)
            {
                picSanPham.Image = null;
            }

            else
            {
                MemoryStream ms = new MemoryStream(bllSanPham.GetPhoto(SanPham));
                picSanPham.Image = Image.FromStream(ms);
                //Picture.Click += new EventHandler(d);
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGiaMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}