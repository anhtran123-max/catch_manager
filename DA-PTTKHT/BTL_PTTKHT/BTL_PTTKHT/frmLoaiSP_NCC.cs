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
    public partial class frmLoaiSP_NCC : Form
    {
        LoaiSP_BLL bllLoaiSP;
        NhaCC_BLL bllNhaCC;

        public frmLoaiSP_NCC()
        {
            InitializeComponent();
            bllLoaiSP = new LoaiSP_BLL();
            bllNhaCC = new NhaCC_BLL();
        }

        #region Loại sản phẩm
        public void ShowAllLoaiSP()
        {
            DataTable dtTable = bllLoaiSP.getAllLoaiSP();
            dgvLSP.DataSource = dtTable;
        }

        public bool checkDataLSP()
        {
            string notice = "";

            if (string.IsNullOrEmpty(txtTenLSP.Text))
            {
                notice += "Chưa nhập tên loại sản phẩm\n";
                txtTenLSP.Focus();
            }

            if (string.IsNullOrEmpty(txtMaLSP.Text))
            {
                notice += "Chưa nhập mã loại sản phẩm\n";
                txtMaLSP.Focus();
            }

            if (string.IsNullOrEmpty(txtMaLSP.Text) || (string.IsNullOrEmpty(txtTenLSP.Text)))
            {
                MessageBox.Show(notice, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        void ResetBoxLSP()
        {
            txtMaLSP.Clear();
            txtTenLSP.Clear();
        }

        void OpenBoxLSP()
        {
            //txtMaLSP.Enabled = true;
            txtTenLSP.Enabled = true;
        }

        void CloseBoxLSP()
        {
            txtMaLSP.Enabled = false;
            txtTenLSP.Enabled = false;
        }

        void ClearNoteLSP()
        {
            //lblNoteMaLSP.Text = "";
            lblNoteTenLSP.Text = "";
        }

        void ShowNoteLSP()
        {
            //if (txtMaLSP.Text.Trim() == "")
            //{
            //    lblNoteMaLSP.Text = "* Chưa nhập mã loại sản phẩm!";
            //}

            if (txtTenLSP.Text.Trim() == "")
            {
                lblNoteTenLSP.Text = "* Chưa nhập tên loại sản phẩm!";
            }
        }

        private void txtMaLSP_TextChanged(object sender, EventArgs e)
        {
            //if (txtMaLSP.Text.Trim() == "")
            //{
            //    lblNoteMaLSP.Text = "* Chưa nhập mã loại sản phẩm!";
            //}
            //else
            //    lblNoteTenLSP.Text = "";
        }

        private void txtTenLSP_TextChanged(object sender, EventArgs e)
        {
            if (txtTenLSP.Text.Trim() == "")
            {
                lblNoteTenLSP.Text = "* Chưa nhập tên loại sản phẩm!";
            }
            else
                lblNoteTenLSP.Text = "";
        }

        bool checkThemSuaLSP = false;

        private void btnThemLSP_Click(object sender, EventArgs e)
        {
            txtMaLSP.Text = "DH" + bllLoaiSP.GeTSoNCCDangCo().ToString();

            {
                OpenBoxLSP();
                ShowNoteLSP();
                checkThemSuaLSP = true;
                btnLuuLSP.Enabled = true;
                btnSuaLSP.Enabled = false;
                btnXoaLSP.Enabled = false;
                btnTroVeLSP.Enabled = true;
             

            }
        }

        private void btnLuuLSP_Click(object sender, EventArgs e)
        {
            {
                if (checkThemSuaLSP == true)
                {
                    if (checkDataLSP())
                    {
                        tbl_LoaiSP LoaiSP = new tbl_LoaiSP();
                        LoaiSP.MaLSP = "DH" + bllLoaiSP.GeTSoNCCDangCo().ToString();
                        LoaiSP.TenLSP = txtTenLSP.Text;

                        if (bllLoaiSP.InsertLoaiSP(LoaiSP))
                        {
                            ShowAllLoaiSP();
                            CloseBoxLSP();
                            MessageBox.Show("Nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLuuLSP.Enabled = false;
                            btnThemLSP.Enabled = true;
                        }

                        else
                        {
                            MessageBox.Show("Kiểm tra lại mã loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtMaLSP.Focus();
                        }
                    }
                }

                if (checkThemSuaLSP == false)
                {
                    if (checkDataLSP())
                    {
                        tbl_LoaiSP LoaiSP = new tbl_LoaiSP();
                        LoaiSP.MaLSP = txtMaLSP.Text;
                        LoaiSP.TenLSP = txtTenLSP.Text;

                        if (bllLoaiSP.UpdateLoaiSP(LoaiSP))
                        {
                            ShowAllLoaiSP();
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CloseBoxLSP();
                            btnLuuLSP.Enabled = false;
                            btnThemLSP.Enabled = true;
                            btnSuaLSP.Enabled = false;
                        }

                        else
                        {
                            MessageBox.Show("Kiểm tra lại mã loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtMaLSP.Focus();
                        }
                    }
                }
            }
        }

        private void btnSuaLSP_Click(object sender, EventArgs e)
        {
            OpenBoxLSP();
            ShowNoteLSP();
            txtMaLSP.ReadOnly = true;
            checkThemSuaLSP = false;
            btnThemLSP.Enabled = false;
            btnLuuLSP.Enabled = true;
            btnXoaLSP.Enabled = false;
            btnTroVeLSP.Enabled = true;
        }

        private void btnXoaLSP_Click(object sender, EventArgs e)
        {
            {
                if (txtMaLSP.Text == "")
                {
                    MessageBox.Show("Chưa chọn loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tbl_LoaiSP LoaiSP = new tbl_LoaiSP();
                        LoaiSP.MaLSP = txtMaLSP.Text;

                        if (bllLoaiSP.DeleteLoaiSP(LoaiSP))
                        {
                            ResetBoxLSP();
                            ClearNoteLSP();
                            btnSuaLSP.Enabled = false;
                            btnXoaLSP.Enabled = false;
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ShowAllLoaiSP();
                        }

                        else
                            MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void btnTroVeLSP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy thao tác??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ResetBoxLSP();
                CloseBoxLSP();
                ClearNoteLSP();
                btnThemLSP.Enabled = true;
                btnLuuLSP.Enabled = false;
                btnSuaLSP.Enabled = false;
                btnXoaLSP.Enabled = false;
                btnTroVeLSP.Enabled = false;
            }
        }

        private void dgvLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                CloseBoxLSP();

                btnThemLSP.Enabled = true;
                btnSuaLSP.Enabled = true;
                btnLuuLSP.Enabled = false;
                btnXoaLSP.Enabled = true;
                txtMaLSP.Text = dgvLSP.Rows[index].Cells[0].Value.ToString();
                txtTenLSP.Text = dgvLSP.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void txtTimKiemLSP_TextChanged(object sender, EventArgs e)
        {
            tbl_LoaiSP LoaiSP = new tbl_LoaiSP();
            LoaiSP.MaLSP = txtTimKiemLSP.Text;
            LoaiSP.TenLSP = txtTimKiemLSP.Text;
            DataTable dtTable = bllLoaiSP.SearchLSP(LoaiSP);
            dgvLSP.DataSource = dtTable;

            if (txtTimKiemLSP.Text == "Tìm loại sản phẩm ...")
                ShowAllLoaiSP();
        }

        private void txtTimKiemLSP_Enter(object sender, EventArgs e)
        {
            txtTimKiemLSP.Clear();
            txtTimKiemLSP.ForeColor = Color.Black;
        }

        private void txtTimKiemLSP_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemLSP.Text.Trim() == "")
            {
                txtTimKiemLSP.Text = "Tìm loại sản phẩm ...";
                txtTimKiemLSP.ForeColor = Color.Silver;
            }
        }
        #endregion

        #region Nhà cung cấp
        public void ShowAllNhaCC()
        {
            DataTable dtTable = bllNhaCC.getAllNhaCC();
            dgvNCC.DataSource = dtTable;
        }

        public bool checkDataNCC()
        {
            string notice = "";

            if (string.IsNullOrEmpty(txtTenNCC.Text))
            {
                notice += "Chưa nhập tên nhà cung cấp\n";
                txtTenNCC.Focus();
            }

            if (string.IsNullOrEmpty(txtMaNCC.Text))
            {
                notice += "Chưa nhập mã nhà cung cấp\n";
                txtMaNCC.Focus();
            }

            if (string.IsNullOrEmpty(txtMaNCC.Text) || (string.IsNullOrEmpty(txtTenNCC.Text)))
            {
                MessageBox.Show(notice, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        void ResetBoxNCC()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
        }

        void OpenBoxNCC()
        {
            //txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = true;
        }

        void CloseBoxNCC()
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
        }

        void ShowNoteNCC()
        {
            //if (txtMaNCC.Text.Trim() == "")
            //{
            //    lblNoteMaNCC.Text = "* Chưa nhập mã nhà cung cấp!";
            //}

            if (txtTenNCC.Text.Trim() == "")
            {
                lblNoteTenNCC.Text = "* Chưa nhập tên nhà cung cấp!";
            }
        }

        void ClearNoteNCC()
        {
            //lblNoteMaNCC.Text = "";
            lblNoteTenNCC.Text = "";
        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {
            //if (txtMaNCC.Text.Trim() == "")
            //{
            //    lblNoteMaNCC.Text = "* Chưa nhập mã nhà cung cấp!";
            //}
            //else
            //    lblNoteMaNCC.Text = "";
        }

        private void txtTenNCC_TextChanged(object sender, EventArgs e)
        {
            if (txtTenNCC.Text.Trim() == "")
            {
                lblNoteTenNCC.Text = "* Chưa nhập tên nhà cung cấp!";
            }
            else
                lblNoteTenNCC.Text = "";
        }

        bool checkThemSuaNCC = false;

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "NCC" + bllNhaCC.GeTSoNCCDangCo().ToString();
            OpenBoxNCC();
            ShowNoteNCC();
            checkThemSuaNCC = true;
            btnLuuNCC.Enabled = true;
            btnSuaNCC.Enabled = false;
            btnXoaNCC.Enabled = false;
            btnTroVeNCC.Enabled = true;
        }

        private void btnLuuNCC_Click(object sender, EventArgs e)
        {
            if (checkThemSuaNCC == true)
            {
                if (checkDataNCC())
                {
                    tbl_NhaCungCap NhaCC = new tbl_NhaCungCap();
                    NhaCC.MaNCC = bllNhaCC.GeTSoNCCDangCo().ToString();
                    NhaCC.TenNCC = txtTenNCC.Text;

                    if (bllNhaCC.InsertNhaCC(NhaCC))
                    {
                        ShowAllNhaCC();
                        CloseBoxNCC();
                        MessageBox.Show("Nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLuuNCC.Enabled = false;
                        btnThemNCC.Enabled = true;
                    }

                    else
                    {
                        MessageBox.Show("Kiểm tra lại mã nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtMaNCC.Focus();
                    }
                }
            }

            if (checkThemSuaNCC == false)
            {
                if (checkDataNCC())
                {
                    tbl_NhaCungCap NhaCC = new tbl_NhaCungCap();
                    NhaCC.MaNCC = txtMaNCC.Text;
                    NhaCC.TenNCC = txtTenNCC.Text;

                    if (bllNhaCC.UpdateNhaCC(NhaCC))
                    {
                        ShowAllNhaCC();
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CloseBoxNCC();
                        btnLuuNCC.Enabled = false;
                        btnThemNCC.Enabled = true;
                        btnSuaNCC.Enabled = false;
                    }

                    else
                    {
                        MessageBox.Show("Kiểm tra lại mã loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtMaNCC.Focus();
                    }
                }
            }
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            OpenBoxNCC();
            ShowNoteNCC();
            txtMaNCC.ReadOnly = true;
            checkThemSuaNCC = false;
            btnThemNCC.Enabled = false;
            btnLuuNCC.Enabled = true;
            btnXoaNCC.Enabled = false;
            btnTroVeNCC.Enabled = true;
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Chưa chọn nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tbl_NhaCungCap NhaCC = new tbl_NhaCungCap();
                    NhaCC.MaNCC = txtMaNCC.Text;

                    if (bllNhaCC.DeleteNhaCC(NhaCC))
                    {
                        ResetBoxNCC();
                        ClearNoteNCC();
                        btnSuaNCC.Enabled = false;
                        btnXoaNCC.Enabled = false;
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowAllNhaCC();
                    }

                    else
                        MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnTroVeNCC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy thao tác??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ResetBoxNCC();
                CloseBoxNCC();
                ClearNoteNCC();
                btnThemNCC.Enabled = true;
                btnLuuNCC.Enabled = false;
                btnSuaNCC.Enabled = false;
                btnXoaNCC.Enabled = false;
                btnTroVeNCC.Enabled = false;
            }
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                CloseBoxNCC();

                btnThemNCC.Enabled = true;
                btnSuaNCC.Enabled = true;
                btnLuuNCC.Enabled = false;
                btnXoaNCC.Enabled = true;
                txtMaNCC.Text = dgvNCC.Rows[index].Cells[0].Value.ToString();
                txtTenNCC.Text = dgvNCC.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void txtTimKiemNCC_TextChanged(object sender, EventArgs e)
        {
            tbl_NhaCungCap NhaCC = new tbl_NhaCungCap();
            NhaCC.MaNCC = txtTimKiemNCC.Text;
            NhaCC.TenNCC = txtTimKiemNCC.Text;
            DataTable dtTable = bllNhaCC.SearchNCC(NhaCC);
            dgvNCC.DataSource = dtTable;

            if (txtTimKiemNCC.Text == "Tìm nhà cung cấp ...")
                ShowAllNhaCC();
        }

        private void txtTimKiemNCC_Enter(object sender, EventArgs e)
        {
            txtTimKiemNCC.Clear();
            txtTimKiemNCC.ForeColor = Color.Black;
        }

        private void txtTimKiemNCC_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemNCC.Text.Trim() == "")
            {
                txtTimKiemNCC.Text = "Tìm nhà cung cấp ...";
                txtTimKiemNCC.ForeColor = Color.Silver;
            }
        }
        #endregion

        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            ShowAllLoaiSP();
            CloseBoxLSP();
            ClearNoteLSP();
            btnLuuLSP.Enabled = false;
            btnXoaLSP.Enabled = false;
            btnSuaLSP.Enabled = false;
            btnTroVeLSP.Enabled = false;
           

            ShowAllNhaCC();
            CloseBoxNCC();
            ClearNoteNCC();
            btnLuuNCC.Enabled = false;
            btnXoaNCC.Enabled = false;
            btnSuaNCC.Enabled = false;
            btnTroVeNCC.Enabled = false;
        }
    }
}