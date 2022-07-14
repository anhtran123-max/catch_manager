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
    public partial class frmKhachHang : Form
    {
        KhachHang_BLL bllKhachHang;

        public frmKhachHang()
        {
            InitializeComponent();
            bllKhachHang = new KhachHang_BLL();
        }

        public void ShowAllKhachHang()
        {
            DataTable dtTable = bllKhachHang.getAllKhachHang();
            dgvKhachHang.DataSource = dtTable;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemKH NhapKH = new frmThemKH();
            NhapKH.ShowDialog();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
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
            frmSuaKH SuaKHFrm = new frmSuaKH();
            SuaKHFrm.txtMaKH.Text = dgvKhachHang.SelectedRows[0].Cells[0].Value.ToString();
            SuaKHFrm.txtTenKH.Text = dgvKhachHang.SelectedRows[0].Cells[1].Value.ToString();
            SuaKHFrm.dtpNgaySinh.Value = Convert.ToDateTime(dgvKhachHang.SelectedRows[0].Cells[2].Value.ToString());
            SuaKHFrm.txtDiaChi.Text = dgvKhachHang.SelectedRows[0].Cells[3].Value.ToString();
            SuaKHFrm.txtSDT.Text = dgvKhachHang.SelectedRows[0].Cells[4].Value.ToString();
            SuaKHFrm.ShowDialog();
            btnSua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_KhachHang KhachHang = new tbl_KhachHang();
                KhachHang.MaKH = dgvKhachHang.SelectedRows[0].Cells[0].Value.ToString();

                if (bllKhachHang.DeleteKhachHang(KhachHang))
                {
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllKhachHang();
                }

                else
                    MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            tbl_KhachHang KhachHang = new tbl_KhachHang();
            KhachHang.MaKH = txtTimKiem.Text;
            KhachHang.TenKH = txtTimKiem.Text;
            //KhachHang.NgSinh = Convert.ToDateTime(txtTimKiem.Text);
            KhachHang.DiaChi = txtTimKiem.Text;
            KhachHang.SDT = txtTimKiem.Text;
            DataTable dtTable = bllKhachHang.SearchKhachHang(KhachHang);
            dgvKhachHang.DataSource = dtTable;

            if (txtTimKiem.Text == "Tìm khách hàng ...")
                ShowAllKhachHang();
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.ForeColor = Color.Black;
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                txtTimKiem.Text = "Tìm khách hàng ...";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            if (txtTimKiem.Text.Trim() == "")
            {
                txtTimKiem.Text = "Tìm khách hàng ...";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            ShowAllKhachHang();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
    }
}