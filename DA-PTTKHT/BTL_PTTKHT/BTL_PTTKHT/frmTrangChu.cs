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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            lblText1.Parent = picTrangChu;
            lblText1.BackColor = Color.Transparent;

            lblText2.Parent = picTrangChu;
            lblText2.BackColor = Color.Transparent;

            lblText3.Parent = picTrangChu;
            lblText3.BackColor = Color.Transparent;

            lblJPWatches.Parent = picJP;
            lblJPWatches.BackColor = Color.Transparent;
            lblJP1.Parent = picJP;
            lblJP1.BackColor = Color.Transparent;
            lblJP2.Parent = picJP;
            lblJP2.BackColor = Color.Transparent;

            lblTSWatch.Parent = picSw;
            lblTSWatch.BackColor = Color.Transparent;
            lblSW1.Parent = picSw;
            lblSW1.BackColor = Color.Transparent;
            lblSW2.Parent = picSw;
            lblSW2.BackColor = Color.Transparent;

            lblAWatches.Parent = picA;
            lblAWatches.BackColor = Color.Transparent;
            lblA1.Parent = picA;
            lblA1.BackColor = Color.Transparent;
            lblA2.Parent = picA;
            lblA2.BackColor = Color.Transparent;
        }

        private void picTrangChu_MouseHover(object sender, EventArgs e)
        {
            lblText1.Font = new Font("Consolas", 25, FontStyle.Bold);
            lblText2.Font = new Font("Segoe UI", 38, FontStyle.Bold);
            lblText3.Font = new Font("Segoe UI", 20, FontStyle.Bold);
        }

        private void picTrangChu_MouseLeave(object sender, EventArgs e)
        {
            lblText1.Font = new Font("Consolas", 20, FontStyle.Bold);
            lblText2.Font = new Font("Segoe UI", 35, FontStyle.Bold);
            lblText3.Font = new Font("Segoe UI", 15, FontStyle.Bold);
        }

        private void picJP_MouseHover(object sender, EventArgs e)
        {
            picJP.ImageSize = new Size(330,330);
            picJP.BorderRadius = 2;
        }

        private void picJP_MouseLeave(object sender, EventArgs e)
        {
            picJP.ImageSize = new Size(310, 310);
            picJP.BorderRadius = 2;
        }

        private void picSw_MouseHover(object sender, EventArgs e)
        {
            picSw.ImageSize = new Size(330, 330);
            picSw.BorderRadius = 2;
        }

        private void picSw_MouseLeave(object sender, EventArgs e)
        {
            picSw.ImageSize = new Size(310, 310);
            picSw.BorderRadius = 2;
        }

        private void picA_MouseHover(object sender, EventArgs e)
        {
            picA.ImageSize = new Size(330, 330);
            picA.BorderRadius = 2;
        }

        private void picA_MouseLeave(object sender, EventArgs e)
        {
            picA.ImageSize = new Size(310, 310);
            picA.BorderRadius = 2;
        }

        private void picDH1_MouseHover(object sender, EventArgs e)
        {
            picDH1.Image = BTL_PTTKHT.Properties.Resources.ĐH_1_1_Home;
            lblDH1.BackColor = Color.Black;
            lblDH1.ForeColor = Color.White;
        }

        private void picDH1_MouseLeave(object sender, EventArgs e)
        {
            picDH1.Image = BTL_PTTKHT.Properties.Resources.ĐH_1_Home1;
            lblDH1.BackColor = Color.White;
            lblDH1.ForeColor = Color.Black;
        }

        private void picDH1_MouseMove(object sender, MouseEventArgs e)
        {
            picDH1.Image = BTL_PTTKHT.Properties.Resources.icons8_apple_watch_64;
            lblDH1.BackColor = Color.Black;
            lblDH1.ForeColor = Color.White;
        }

        private void picDH2_MouseHover(object sender, EventArgs e)
        {
            picDH2.Image = BTL_PTTKHT.Properties.Resources.ĐH_2_2_Home;
            lblDH2.BackColor = Color.Black;
            lblDH2.ForeColor = Color.White;
        }

        private void picDH2_MouseLeave(object sender, EventArgs e)
        {
            picDH2.Image = BTL_PTTKHT.Properties.Resources.ĐH_2_Home;
            lblDH2.BackColor = Color.White;
            lblDH2.ForeColor = Color.Black;
        }

        private void picDH3_MouseHover(object sender, EventArgs e)
        {
            picDH3.Image = BTL_PTTKHT.Properties.Resources.ĐH_3_3_Home;
            lblDH3.BackColor = Color.Black;
            lblDH3.ForeColor = Color.White;
        }

        private void picDH3_MouseLeave(object sender, EventArgs e)
        {
            picDH3.Image = BTL_PTTKHT.Properties.Resources.ĐH_3_Home;
            lblDH3.BackColor = Color.White;
            lblDH3.ForeColor = Color.Black;
        }

        private void picDH1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.watchstore.vn/products/dong-ho-citizen-ak5000-54a-4974374296085-123");
        }

        private void picDH2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.watchstore.vn/products/dong-ho-citizen-au1062-56e-4974374236272-393");
        }

        private void picDH3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.watchstore.vn/products/dong-ho-seiko-snzg09k1-4954628108890-802");
        }

        private void btnMess_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.messenger.com/t/323358378596082/?messaging_source=source%3Apages%3Amessage_shortlink");
        }

        private void btnZalo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://zalo.me/4455668531311407892");
        }
    }
}
