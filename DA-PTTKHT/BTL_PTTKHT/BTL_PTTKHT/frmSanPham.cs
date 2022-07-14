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
    public partial class frmSanPham : Form
    {
        SanPham_BLL bllSanPham;
        LoaiSP_BLL bllLoaiSP;
        NhaCC_BLL bllNhaCC;

        public frmSanPham()
        {
            InitializeComponent();
            bllSanPham = new SanPham_BLL();
            bllLoaiSP = new LoaiSP_BLL();
            bllNhaCC = new NhaCC_BLL();
        }    

        public void ShowAllSanPham()
        {
            DataTable dtTable = bllSanPham.getAllSanPham();
            dgvSanPham.DataSource = dtTable;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSP ThemSPFrm = new frmThemSP();
            ThemSPFrm.Show();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
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
            frmSuaSP SuaSPFrm = new frmSuaSP();
            SuaSPFrm.txtMaSP.Text = dgvSanPham.SelectedRows[0].Cells[0].Value.ToString();
            SuaSPFrm.txtTenSP.Text = dgvSanPham.SelectedRows[0].Cells[1].Value.ToString();
            SuaSPFrm.txtMaLSP.Text = dgvSanPham.SelectedRows[0].Cells[2].Value.ToString();
            SuaSPFrm.txtMaNCC.Text = dgvSanPham.SelectedRows[0].Cells[3].Value.ToString();
            SuaSPFrm.numSL.Value = Convert.ToDecimal(dgvSanPham.SelectedRows[0].Cells["SoLuong"].Value.ToString());
            SuaSPFrm.txtGiaMua.Text = dgvSanPham.SelectedRows[0].Cells["GiaMua"].Value.ToString();
            SuaSPFrm.txtGiaBan.Text = dgvSanPham.SelectedRows[0].Cells["GiaBan"].Value.ToString();
            SuaSPFrm.Show();
            btnSua.Enabled = false; 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hàng đang chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_SanPham SanPham = new tbl_SanPham();
                SanPham.MaSP = dgvSanPham.SelectedRows[0].Cells[0].Value.ToString();

                if (bllSanPham.DeleteSanPham(SanPham))
                {
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllSanPham();
                }

                else
                    MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;

            if (txtTimKiem.Text.Trim() != "")
            {
                tbl_SanPham SanPham = new tbl_SanPham();

                if (!int.TryParse(txtTimKiem.Text, out parsedValue))
                {
                    SanPham.MaSP = txtTimKiem.Text;
                    SanPham.TenSP = txtTimKiem.Text;
                    SanPham.MaLSP = txtTimKiem.Text;
                    SanPham.MaNCC = txtTimKiem.Text;
                    DataTable dtTable = bllSanPham.SearchCharacterSP(SanPham);
                    dgvSanPham.DataSource = dtTable;

                    if (txtTimKiem.Text == "Tìm sản phẩm ...")
                        ShowAllSanPham();
                }

                if (int.TryParse(txtTimKiem.Text, out parsedValue))
                {
                    SanPham.SoLuong = Convert.ToInt32(txtTimKiem.Text);
                    SanPham.GiaMua = Convert.ToInt32(txtTimKiem.Text);
                    SanPham.GiaBan = Convert.ToInt32(txtTimKiem.Text);
                    DataTable dtTable = bllSanPham.SearchNumberSP(SanPham);
                    dgvSanPham.DataSource = dtTable;

                    if (txtTimKiem.Text == "Tìm sản phẩm ...")
                        ShowAllSanPham();
                }
            }
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
                txtTimKiem.Text = "Tìm sản phẩm ...";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            if (txtTimKiem.Text.Trim() == "")
            {
                txtTimKiem.Text = "Tìm sản phẩm ...";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void frmSanPhamMain_Load(object sender, EventArgs e)
        {
            ShowAllSanPham();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;


            dgvSanPham.Columns["GiaMua"].DefaultCellStyle.Format = "N0";
            dgvSanPham.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
        }      
    }
}