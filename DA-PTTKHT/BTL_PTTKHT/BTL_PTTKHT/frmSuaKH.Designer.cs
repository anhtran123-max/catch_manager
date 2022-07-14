
namespace BTL_PTTKHT
{
    partial class frmSuaKH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ElipseFrm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblNoteSDT = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNoteDiaChi = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNoteTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.ElipseMin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ControlMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ElipseCloseFrm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // ElipseFrm
            // 
            this.ElipseFrm.BorderRadius = 25;
            this.ElipseFrm.TargetControl = this;
            // 
            // lblNoteSDT
            // 
            this.lblNoteSDT.AutoSize = true;
            this.lblNoteSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNoteSDT.ForeColor = System.Drawing.Color.Red;
            this.lblNoteSDT.Location = new System.Drawing.Point(140, 378);
            this.lblNoteSDT.Name = "lblNoteSDT";
            this.lblNoteSDT.Size = new System.Drawing.Size(76, 15);
            this.lblNoteSDT.TabIndex = 124;
            this.lblNoteSDT.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.BorderColor = System.Drawing.Color.Black;
            this.txtSDT.BorderRadius = 5;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.Parent = this.txtSDT;
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedState.Parent = this.txtSDT;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.HoverState.Parent = this.txtSDT;
            this.txtSDT.Location = new System.Drawing.Point(133, 339);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.ShadowDecoration.Parent = this.txtSDT;
            this.txtSDT.Size = new System.Drawing.Size(316, 36);
            this.txtSDT.TabIndex = 123;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // lblNoteDiaChi
            // 
            this.lblNoteDiaChi.AutoSize = true;
            this.lblNoteDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNoteDiaChi.ForeColor = System.Drawing.Color.Red;
            this.lblNoteDiaChi.Location = new System.Drawing.Point(140, 321);
            this.lblNoteDiaChi.Name = "lblNoteDiaChi";
            this.lblNoteDiaChi.Size = new System.Drawing.Size(43, 15);
            this.lblNoteDiaChi.TabIndex = 122;
            this.lblNoteDiaChi.Text = "Địa chỉ";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderRadius = 5;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.CheckedState.Parent = this.dtpNgaySinh;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.HoverState.Parent = this.dtpNgaySinh;
            this.dtpNgaySinh.Location = new System.Drawing.Point(133, 168);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.ShadowDecoration.Parent = this.dtpNgaySinh;
            this.dtpNgaySinh.Size = new System.Drawing.Size(316, 36);
            this.dtpNgaySinh.TabIndex = 121;
            this.dtpNgaySinh.Value = new System.DateTime(2021, 12, 6, 21, 8, 52, 863);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderColor = System.Drawing.Color.Black;
            this.txtDiaChi.BorderRadius = 5;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.Parent = this.txtDiaChi;
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.FocusedState.Parent = this.txtDiaChi;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.HoverState.Parent = this.txtDiaChi;
            this.txtDiaChi.Location = new System.Drawing.Point(133, 225);
            this.txtDiaChi.MaxLength = 100;
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.ShadowDecoration.Parent = this.txtDiaChi;
            this.txtDiaChi.Size = new System.Drawing.Size(316, 93);
            this.txtDiaChi.TabIndex = 116;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // lblNoteTenKH
            // 
            this.lblNoteTenKH.AutoSize = true;
            this.lblNoteTenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNoteTenKH.ForeColor = System.Drawing.Color.Red;
            this.lblNoteTenKH.Location = new System.Drawing.Point(140, 150);
            this.lblNoteTenKH.Name = "lblNoteTenKH";
            this.lblNoteTenKH.Size = new System.Drawing.Size(90, 15);
            this.lblNoteTenKH.TabIndex = 120;
            this.lblNoteTenKH.Text = "Tên khách hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.BorderColor = System.Drawing.Color.Black;
            this.txtTenKH.BorderRadius = 5;
            this.txtTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKH.DefaultText = "";
            this.txtTenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.DisabledState.Parent = this.txtTenKH;
            this.txtTenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.FocusedState.Parent = this.txtTenKH;
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKH.ForeColor = System.Drawing.Color.Black;
            this.txtTenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.HoverState.Parent = this.txtTenKH;
            this.txtTenKH.Location = new System.Drawing.Point(133, 111);
            this.txtTenKH.MaxLength = 200;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.PlaceholderText = "";
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.ShadowDecoration.Parent = this.txtTenKH;
            this.txtTenKH.Size = new System.Drawing.Size(316, 36);
            this.txtTenKH.TabIndex = 113;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // txtMaKH
            // 
            this.txtMaKH.BorderColor = System.Drawing.Color.Black;
            this.txtMaKH.BorderRadius = 5;
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.DefaultText = "";
            this.txtMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.DisabledState.Parent = this.txtMaKH;
            this.txtMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.FocusedState.Parent = this.txtMaKH;
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaKH.ForeColor = System.Drawing.Color.Black;
            this.txtMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.HoverState.Parent = this.txtMaKH;
            this.txtMaKH.Location = new System.Drawing.Point(133, 54);
            this.txtMaKH.MaxLength = 10;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PasswordChar = '\0';
            this.txtMaKH.PlaceholderText = "";
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.ShadowDecoration.Parent = this.txtMaKH;
            this.txtMaKH.Size = new System.Drawing.Size(316, 36);
            this.txtMaKH.TabIndex = 111;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSDT.Location = new System.Drawing.Point(16, 347);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(41, 21);
            this.lblSDT.TabIndex = 118;
            this.lblSDT.Text = "SĐT:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDiaChi.Location = new System.Drawing.Point(16, 233);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(60, 21);
            this.lblDiaChi.TabIndex = 117;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNgaySinh.Location = new System.Drawing.Point(16, 176);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(83, 21);
            this.lblNgaySinh.TabIndex = 115;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenKH.Location = new System.Drawing.Point(16, 119);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(120, 21);
            this.lblTenKH.TabIndex = 114;
            this.lblTenKH.Text = "Tên khách hàng:";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMaKH.Location = new System.Drawing.Point(16, 62);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(119, 21);
            this.lblMaKH.TabIndex = 112;
            this.lblMaKH.Text = "Mã khách hàng:";
            // 
            // ElipseMin
            // 
            this.ElipseMin.TargetControl = this.ControlMin;
            // 
            // ControlMin
            // 
            this.ControlMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ControlMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ControlMin.HoverState.Parent = this.ControlMin;
            this.ControlMin.IconColor = System.Drawing.Color.White;
            this.ControlMin.Location = new System.Drawing.Point(389, 15);
            this.ControlMin.Name = "ControlMin";
            this.ControlMin.ShadowDecoration.Parent = this.ControlMin;
            this.ControlMin.Size = new System.Drawing.Size(30, 30);
            this.ControlMin.TabIndex = 110;
            // 
            // ControlClose
            // 
            this.ControlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ControlClose.HoverState.Parent = this.ControlClose;
            this.ControlClose.IconColor = System.Drawing.Color.White;
            this.ControlClose.Location = new System.Drawing.Point(425, 15);
            this.ControlClose.Name = "ControlClose";
            this.ControlClose.ShadowDecoration.Parent = this.ControlClose;
            this.ControlClose.Size = new System.Drawing.Size(30, 30);
            this.ControlClose.TabIndex = 109;
            // 
            // btnSua
            // 
            this.btnSua.BorderColor = System.Drawing.Color.Red;
            this.btnSua.BorderRadius = 10;
            this.btnSua.BorderThickness = 1;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.DisabledState.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnSua.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Image = global::BTL_PTTKHT.Properties.Resources.icons8_rename_50;
            this.btnSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.Location = new System.Drawing.Point(300, 400);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(131, 45);
            this.btnSua.TabIndex = 108;
            this.btnSua.Text = "Update";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // ElipseCloseFrm
            // 
            this.ElipseCloseFrm.TargetControl = this.ControlClose;
            // 
            // frmSuaKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(471, 460);
            this.Controls.Add(this.lblNoteSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblNoteDiaChi);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblNoteTenKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.ControlClose);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.ControlMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSuaKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuaKH";
            this.Load += new System.EventHandler(this.frmSuaKH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ElipseFrm;
        private System.Windows.Forms.Label lblNoteSDT;
        private System.Windows.Forms.Label lblNoteDiaChi;
        private System.Windows.Forms.Label lblNoteTenKH;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaKH;
        private Guna.UI2.WinForms.Guna2ControlBox ControlClose;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2ControlBox ControlMin;
        private Guna.UI2.WinForms.Guna2Elipse ElipseMin;
        private Guna.UI2.WinForms.Guna2Elipse ElipseCloseFrm;
        public Guna.UI2.WinForms.Guna2TextBox txtSDT;
        public Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        public Guna.UI2.WinForms.Guna2TextBox txtTenKH;
        public Guna.UI2.WinForms.Guna2TextBox txtMaKH;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
    }
}