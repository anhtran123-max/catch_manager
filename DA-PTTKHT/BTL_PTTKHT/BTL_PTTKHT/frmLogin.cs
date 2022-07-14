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
    public partial class frmLogin : Form
    {
        User_BLL bllUser;

        public frmLogin()
        {
            InitializeComponent();
            bllUser = new User_BLL();
        }

        void CheckBox()
        {
            tbl_User User = new tbl_User();
            User.UserName = txtTenDN.Text;
            User.Password = txtMK.Text;
            //string quyen = "";
            if (bllUser.PhQuyen(User) == "Admin" )
            {
                frmMainn MainFrm = new frmMainn();
                MainFrm.lblXinChao.Text = "Xin chào: " + txtTenDN.Text;
                MainFrm.Show();
                this.Hide();
            }

            if (bllUser.PhQuyen(User) == "User")
            {
                frmDiemDanh DiemDanhFrm = new frmDiemDanh();
                DiemDanhFrm.Show();
                this.Hide();
            }

            if (bllUser.PhQuyen(User) == "Fail")
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            CheckBox();
        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox1.Checked)
            {
                txtMK.PasswordChar = '\0';
            }

            else
                txtMK.PasswordChar = '\u25CF';
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtMK.PasswordChar = '\u25CF';
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
