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
    public partial class frmDiemDanh : Form
    {
        NhanVien_BLL bllNhanVien;
        ChamCong_BLL bllChamCong;

        public frmDiemDanh()
        {
            InitializeComponent();
            bllNhanVien = new NhanVien_BLL();
            bllChamCong = new ChamCong_BLL();
        }

        private void GetTenNV()
        {
            cmTenNV.DisplayMember = "TenNV";
            cmTenNV.DataSource = bllNhanVien.getTenNV();
        }

        private void GetMaNV()
        {
            tbl_NhanVien NhanVien = new tbl_NhanVien();
            if (cmTenNV.Text.Trim() != "")
            {
                NhanVien.TenNV = cmTenNV.Text;
                bllNhanVien.getMaNV(NhanVien);
            }
            txtMaNV.Text = NhanVien.MaNV;
        }

        private void frmDiemDanh_Load(object sender, EventArgs e)
        {
            GetTenNV();
            dtpNgayLam.Value = DateTime.Now;
        }

        private void cmTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetMaNV();
        }

        private void btnDD_Click(object sender, EventArgs e)
        {
            tbl_ChamCong cc = new tbl_ChamCong();
            cc.MaNV = txtMaNV.Text;;
            string Date = dtpNgayLam.Value.ToString("yyyy-MM-dd");
            cc.NgayLam = Convert.ToDateTime(Date);
            //cc.NgayLam = (dtpNgayLam.Value);

            if (bllChamCong.InsertChamCong(cc))
            {
                MessageBox.Show("Điểm danh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMainn MainFrm = new frmMainn();
                MainFrm.pnlNhanVien.Visible = false;
                MainFrm.lblXinChao.Text = "Xin chào: " + cmTenNV.Text;
                MainFrm.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Hôm nay đã điểm danh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                frmMainn MainFrm = new frmMainn();
                MainFrm.pnlNhanVien.Visible = false;
                MainFrm.lblXinChao.Text = "Xin chào: " + cmTenNV.Text;
                MainFrm.Show();
                this.Close();
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmLogin LoginFrm = new frmLogin();
            LoginFrm.Show();
            this.Close();
        }
    }
}
