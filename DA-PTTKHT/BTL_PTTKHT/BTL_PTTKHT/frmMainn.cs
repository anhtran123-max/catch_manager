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
    public partial class frmMainn : Form
    {
        public frmMainn()
        {
            InitializeComponent();
            CollapseMenu();
            customizeDesing();
        }    

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
            if (this.panelMenu.Width > 200)
            {
                btnThongKe.Text = "Statistics";
            }
            else
                btnThongKe.Text = "";
        }
             
        private void CollapseMenu()
        {
            if(this.panelMenu.Width > 200)
            {
                panelMenu.Width = 85;
                btnMenu.Dock = DockStyle.Top;
                this.Size = new Size(1334, 659);
                //frmMainn Mainn = new frmMainn();
                //Mainn.Width = 1334;
                //Mainn.Height = 659;

                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.Padding = new Padding(0);
                }
        
                //this.Hide();
                //Mainn.Show();
            }

            else 
            {
                panelMenu.Width = 227;
                btnMenu.Dock = DockStyle.None;
                this.Size = new Size(1468, 659);
                //frmMainn Mainn = new frmMainn();
                //Mainn.Width = 1486;
                //Mainn.Height = 659;

                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }

                //this.Hide();
                //Mainn.Show();
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {            
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTrangChu());
            btnTrangChu.FillColor = Color.FromArgb(244, 222, 226);
            btnHoaDon.FillColor = Color.White;
            btnNhanVien.FillColor = Color.White;
            btnKhachHang.FillColor = Color.White;
            btnSanPham.FillColor = Color.White;
            btnTTSP.FillColor = Color.White;
            btnLSPNCC.FillColor = Color.White;
            btnThongKe.FillColor = Color.White;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
            btnTrangChu.FillColor = Color.White;
            btnHoaDon.FillColor = Color.White;
            btnNhanVien.FillColor = Color.FromArgb(244, 222, 226);
            btnKhachHang.FillColor = Color.White;
            btnSanPham.FillColor = Color.White;
            btnTTSP.FillColor = Color.White;
            btnLSPNCC.FillColor = Color.White;
            btnThongKe.FillColor = Color.White;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKhachHang());
            btnTrangChu.FillColor = Color.White;
            btnHoaDon.FillColor = Color.White;
            btnNhanVien.FillColor = Color.White;
            btnKhachHang.FillColor = Color.FromArgb(244, 222, 226);
            btnSanPham.FillColor = Color.White;
            btnTTSP.FillColor = Color.White;
            btnLSPNCC.FillColor = Color.White;
            btnThongKe.FillColor = Color.White;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProductSubMenu); 
        }
        private void btnTTSP_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSanPham());
            btnTrangChu.FillColor = Color.White;
            btnHoaDon.FillColor = Color.White;
            btnNhanVien.FillColor = Color.White;
            btnKhachHang.FillColor = Color.White;
            btnSanPham.FillColor = Color.FromArgb(244, 222, 226);
            btnTTSP.FillColor = Color.FromArgb(244, 222, 226);
            btnLSPNCC.FillColor = Color.White;
            btnThongKe.FillColor = Color.White;
        }

        private void btnLSPNCC_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLoaiSP_NCC());
            btnTrangChu.FillColor = Color.White;
            btnHoaDon.FillColor = Color.White;
            btnNhanVien.FillColor = Color.White;
            btnKhachHang.FillColor = Color.White;
            btnSanPham.FillColor = Color.FromArgb(244, 222, 226);
            btnTTSP.FillColor = Color.White;
            btnLSPNCC.FillColor = Color.FromArgb(244, 222, 226);
            btnThongKe.FillColor = Color.White;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHoaDon());
            btnTrangChu.FillColor = Color.White;
            btnHoaDon.FillColor = Color.FromArgb(244, 222, 226);
            btnNhanVien.FillColor = Color.White;
            btnKhachHang.FillColor = Color.White;
            btnSanPham.FillColor = Color.White;
            btnTTSP.FillColor = Color.White;
            btnLSPNCC.FillColor = Color.White;
            btnThongKe.FillColor = Color.White;
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmThongKeMain());
            btnTrangChu.FillColor = Color.White;
            btnHoaDon.FillColor = Color.White;
            btnNhanVien.FillColor = Color.White;
            btnKhachHang.FillColor = Color.White;
            btnSanPham.FillColor = Color.White;
            btnTTSP.FillColor = Color.White;
            btnLSPNCC.FillColor = Color.White;
            btnThongKe.FillColor = Color.FromArgb(244, 222, 226);
        }

        private void frmMainn_Load(object sender, EventArgs e)
        {
            openChildForm(new frmTrangChu());
            btnTrangChu.FillColor = Color.FromArgb(244, 222, 226);
            btnHoaDon.FillColor = Color.White;
            btnNhanVien.FillColor = Color.White;
            btnKhachHang.FillColor = Color.White;
            btnSanPham.FillColor = Color.White;
            btnThongKe.FillColor = Color.White;
            //btnThongKe.Dock = DockStyle.Top;

            if (this.panelMenu.Width > 200)
            {
                btnThongKe.Text = "Statistics";
            }
            else
                btnThongKe.Text = "";
        }

        private void customizeDesing()
        {
            panelProductSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelProductSubMenu.Visible == true)
                panelProductSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
                btnThongKe.Dock = DockStyle.None;
            }
            else
            {
                subMenu.Visible = false;
                btnThongKe.Dock = DockStyle.Top;
            }                
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.watchstore.vn/");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin LoginFrm = new frmLogin();
            LoginFrm.Show();
        }

       
    }
}
