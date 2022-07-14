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
    public partial class frmSuaKH : Form
    {
        KhachHang_BLL bllKhachHang;

        public frmSuaKH()
        {
            InitializeComponent();
            bllKhachHang = new KhachHang_BLL();
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

            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                notice += "Chưa nhập tên\n";
                txtTenKH.Focus();
            }

            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                notice += "Chưa nhập mã khách hàng\n";
                txtMaKH.Focus();
            }

            if (string.IsNullOrEmpty(txtMaKH.Text) || (string.IsNullOrEmpty(txtTenKH.Text)) || (string.IsNullOrEmpty(txtDiaChi.Text)) || (string.IsNullOrEmpty(txtSDT.Text)))
            {
                MessageBox.Show(notice, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        void ShowNote()
        {
            //if (txtMaKH.Text.Trim() == "")
            //{
            //    lblNoteMaKH.Text = "* Chưa nhập mã khách hàng!";
            //}

            if (txtTenKH.Text.Trim() == "")
            {
                lblNoteTenKH.Text = "* Chưa nhập tên khách hàng!";
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

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            if (txtTenKH.Text.Trim() == "")
            {
                lblNoteTenKH.Text = "* Chưa nhập tên khách hàng!";
            }
            else
                lblNoteTenKH.Text = "";
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tbl_KhachHang KhachHang = new tbl_KhachHang();
                KhachHang.MaKH = txtMaKH.Text;
                KhachHang.TenKH = txtTenKH.Text;
                KhachHang.NgSinh = dtpNgaySinh.Value;
                KhachHang.DiaChi = txtDiaChi.Text;
                KhachHang.SDT = txtSDT.Text;

                if (bllKhachHang.UpdateKhachHang(KhachHang))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Kiểm tra lại mã khách hàng, Khách hàng phải trên 4 tuổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtMaKH.Focus();
                }
            }
        }

        private void frmSuaKH_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            ShowNote();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
