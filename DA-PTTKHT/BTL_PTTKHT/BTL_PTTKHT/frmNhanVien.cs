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
    public partial class frmNhanVien : Form
    {
        NhanVien_BLL bllNhanVien;
        public frmNhanVien()
        {
            InitializeComponent();
            bllNhanVien = new NhanVien_BLL();

        }

        public void ShowAllNhanVien()
        {
            DataTable dtTable = bllNhanVien.getAllNhanVien();
            dgvNhanVien.DataSource = dtTable;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNV NhapNV = new frmThemNV();
            NhapNV.ShowDialog();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaNV SuaNVfrm = new frmSuaNV();
            SuaNVfrm.txtMaNV.Text = dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString();
            SuaNVfrm.txtTenNV.Text = dgvNhanVien.SelectedRows[0].Cells[1].Value.ToString();
            SuaNVfrm.dtpNgaySinh.Value = Convert.ToDateTime(dgvNhanVien.SelectedRows[0].Cells[2].Value.ToString());
            SuaNVfrm.txtDiaChi.Text = dgvNhanVien.SelectedRows[0].Cells[3].Value.ToString();
            SuaNVfrm.txtSDT.Text = dgvNhanVien.SelectedRows[0].Cells[4].Value.ToString();
            SuaNVfrm.dtpNgayVL.Value = Convert.ToDateTime(dgvNhanVien.SelectedRows[0].Cells[5].Value.ToString());
            SuaNVfrm.ShowDialog();
            btnSua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hàng đang chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_NhanVien NhanVien = new tbl_NhanVien();
                NhanVien.MaNV = dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString();

                if (bllNhanVien.DeleteNhanVien(NhanVien))
                {
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllNhanVien();
                }

                else
                    MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            tbl_NhanVien NhanVien = new tbl_NhanVien();
            NhanVien.MaNV = txtTimKiem.Text;
            NhanVien.TenNV = txtTimKiem.Text;
            //NhanVien.NgaySinh = (txtTimKiem.Text);
            NhanVien.DiaChi = txtTimKiem.Text;
            NhanVien.SDT = txtTimKiem.Text;
            //NhanVien.NgayVaoLam = Convert.ToDateTime(txtTimKiem.Text);
            DataTable dtTable = bllNhanVien.SearchNhanVien(NhanVien);
            dgvNhanVien.DataSource = dtTable;

            if (txtTimKiem.Text == "Tìm nhân viên ...")
                ShowAllNhanVien();
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            if (txtTimKiem.Text.Trim() == "")
            {
                txtTimKiem.Text = "Tìm nhân viên ...";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            txtTimKiem.TextAlign = HorizontalAlignment.Left;
            txtTimKiem.Clear();
            txtTimKiem.ForeColor = Color.Black;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            if (txtTimKiem.Text.Trim() == "")
            {
                txtTimKiem.Text = "Tìm nhân viên ...";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void frmNhanVienMain_Load(object sender, EventArgs e)
        {
            ShowAllNhanVien();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }       
    }
}