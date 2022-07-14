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
    public partial class frmThemNV : Form
    {
        NhanVien_BLL bllNhanVien;

        public frmThemNV()
        {
            InitializeComponent();
            bllNhanVien = new NhanVien_BLL();
        }

        public bool checkData()
        {
            string notice = "";

            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                notice += "Chưa nhập số điện thoại\n";
                txtSDT.Focus();
            }

            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                notice += "Chưa nhập địa chỉ\n";
                txtDiaChi.Focus();
            }

            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                notice += "Chưa nhập tên\n";
                txtTenNV.Focus();
            }

            //if (string.IsNullOrEmpty(txtMaNV.Text))
            //{
            //    notice += "Chưa nhập mã nhân viên\n";
            //    txtMaNV.Focus();
            //}

            if ((string.IsNullOrEmpty(txtTenNV.Text)) || (string.IsNullOrEmpty(txtDiaChi.Text)) || (string.IsNullOrEmpty(txtSDT.Text)))
            {
                MessageBox.Show(notice, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        void ShowNote()
        {
            //if (txtMaNV.Text.Trim() == "")
            //{
            //    lblNoteMaNV.Text = "* Chưa nhập mã nhân viên!";
            //}

            if (txtTenNV.Text.Trim() == "")
            {
                lblNoteTenNV.Text = "* Chưa nhập tên nhân viên!";
            }

            if (txtDiaChi.Text.Trim() == "")
            {
                lblNoteDiaChi.Text = "* Chưa nhập địa chỉ!";
            }

            if (txtSDT.Text.Trim() == "")
            {
                lblNoteSDT.Text = "* Chưa nhập số điện thoại!";
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            //if (txtMaNV.Text.Trim() == "")
            //{
            //    lblNoteMaNV.Text = "* Chưa nhập mã nhân viên!";
            //}
            //else
            //    lblNoteMaNV.Text = "";
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            if (txtTenNV.Text.Trim() == "")
            {
                lblNoteTenNV.Text = "* Chưa nhập tên nhân viên!";
            }
            else
                lblNoteTenNV.Text = "";
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Trim() == "")
            {
                lblNoteDiaChi.Text = "* Chưa nhập địa chỉ!";
            }
            else
                lblNoteDiaChi.Text = "";
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text.Trim() == "")
            {
                lblNoteSDT.Text = "* Chưa nhập số điện thoại!";
            }
            else
                lblNoteSDT.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tbl_NhanVien NhanVien = new tbl_NhanVien();
                NhanVien.MaNV = "NV" + bllNhanVien.GeTSoNVDangCo().ToString();
                NhanVien.TenNV = txtTenNV.Text;
                NhanVien.NgaySinh = dtpNgaySinh.Value;
                NhanVien.DiaChi = txtDiaChi.Text;
                NhanVien.SDT = txtSDT.Text;
                NhanVien.NgayVaoLam = dtpNgayVL.Value;

                if (bllNhanVien.InsertNhanVien(NhanVien))
                {
                    MessageBox.Show("Nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Kiểm tra lại mã sp, Bạn phải trên 18 tuổi mới được nhận làm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtMaNV.Focus();
                }
            }
        }

        private void frmNhapNV_Load(object sender, EventArgs e)
        {
            ShowNote();
            dtpNgayVL.Value = DateTime.Today;
            txtMaNV.Text = "NV" + bllNhanVien.GeTSoNVDangCo().ToString();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}