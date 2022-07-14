
namespace BTL_PTTKHT
{
    partial class frmDiemDanh
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
            this.dtpNgayLam = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNgayDD = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cmTenNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnTroVe = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDD = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // ElipseFrm
            // 
            this.ElipseFrm.BorderRadius = 25;
            this.ElipseFrm.TargetControl = this;
            // 
            // dtpNgayLam
            // 
            this.dtpNgayLam.BorderRadius = 5;
            this.dtpNgayLam.Checked = true;
            this.dtpNgayLam.CheckedState.Parent = this.dtpNgayLam;
            this.dtpNgayLam.Enabled = false;
            this.dtpNgayLam.FillColor = System.Drawing.Color.White;
            this.dtpNgayLam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLam.HoverState.Parent = this.dtpNgayLam;
            this.dtpNgayLam.Location = new System.Drawing.Point(169, 157);
            this.dtpNgayLam.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayLam.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayLam.Name = "dtpNgayLam";
            this.dtpNgayLam.ShadowDecoration.Parent = this.dtpNgayLam;
            this.dtpNgayLam.Size = new System.Drawing.Size(316, 36);
            this.dtpNgayLam.TabIndex = 104;
            this.dtpNgayLam.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.dtpNgayLam.Value = new System.DateTime(2021, 12, 6, 21, 8, 52, 863);
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderColor = System.Drawing.Color.Black;
            this.txtMaNV.BorderRadius = 5;
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNV.DefaultText = "";
            this.txtMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.DisabledState.Parent = this.txtMaNV;
            this.txtMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.FocusedState.Parent = this.txtMaNV;
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNV.ForeColor = System.Drawing.Color.Black;
            this.txtMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.HoverState.Parent = this.txtMaNV;
            this.txtMaNV.Location = new System.Drawing.Point(169, 43);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PasswordChar = '\0';
            this.txtMaNV.PlaceholderText = "";
            this.txtMaNV.SelectedText = "";
            this.txtMaNV.ShadowDecoration.Parent = this.txtMaNV;
            this.txtMaNV.Size = new System.Drawing.Size(316, 36);
            this.txtMaNV.TabIndex = 94;
            // 
            // lblNgayDD
            // 
            this.lblNgayDD.AutoSize = true;
            this.lblNgayDD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNgayDD.Location = new System.Drawing.Point(37, 165);
            this.lblNgayDD.Name = "lblNgayDD";
            this.lblNgayDD.Size = new System.Drawing.Size(128, 21);
            this.lblNgayDD.TabIndex = 98;
            this.lblNgayDD.Text = "Ngày điểm danh:";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenNV.Location = new System.Drawing.Point(37, 108);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(108, 21);
            this.lblTenNV.TabIndex = 97;
            this.lblTenNV.Text = "Tên nhân viên:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMaNV.Location = new System.Drawing.Point(37, 51);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(107, 21);
            this.lblMaNV.TabIndex = 95;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            // 
            // cmTenNV
            // 
            this.cmTenNV.BackColor = System.Drawing.Color.Transparent;
            this.cmTenNV.BorderColor = System.Drawing.Color.Black;
            this.cmTenNV.BorderRadius = 5;
            this.cmTenNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmTenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmTenNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmTenNV.FocusedState.Parent = this.cmTenNV;
            this.cmTenNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmTenNV.ForeColor = System.Drawing.Color.Black;
            this.cmTenNV.HoverState.Parent = this.cmTenNV;
            this.cmTenNV.ItemHeight = 30;
            this.cmTenNV.ItemsAppearance.Parent = this.cmTenNV;
            this.cmTenNV.Location = new System.Drawing.Point(166, 100);
            this.cmTenNV.Name = "cmTenNV";
            this.cmTenNV.ShadowDecoration.Parent = this.cmTenNV;
            this.cmTenNV.Size = new System.Drawing.Size(319, 36);
            this.cmTenNV.TabIndex = 111;
            this.cmTenNV.SelectedIndexChanged += new System.EventHandler(this.cmTenNV_SelectedIndexChanged);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BorderColor = System.Drawing.Color.Red;
            this.btnTroVe.BorderRadius = 10;
            this.btnTroVe.BorderThickness = 1;
            this.btnTroVe.CheckedState.Parent = this.btnTroVe;
            this.btnTroVe.CustomImages.Parent = this.btnTroVe;
            this.btnTroVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTroVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTroVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTroVe.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTroVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTroVe.DisabledState.Parent = this.btnTroVe;
            this.btnTroVe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnTroVe.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnTroVe.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnTroVe.ForeColor = System.Drawing.Color.Black;
            this.btnTroVe.HoverState.Parent = this.btnTroVe;
            this.btnTroVe.Image = global::BTL_PTTKHT.Properties.Resources.icons8_back_arrow_50;
            this.btnTroVe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTroVe.Location = new System.Drawing.Point(304, 219);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.ShadowDecoration.Parent = this.btnTroVe;
            this.btnTroVe.Size = new System.Drawing.Size(155, 45);
            this.btnTroVe.TabIndex = 112;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnDD
            // 
            this.btnDD.BorderColor = System.Drawing.Color.Red;
            this.btnDD.BorderRadius = 10;
            this.btnDD.BorderThickness = 1;
            this.btnDD.CheckedState.Parent = this.btnDD;
            this.btnDD.CustomImages.Parent = this.btnDD;
            this.btnDD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDD.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDD.DisabledState.Parent = this.btnDD;
            this.btnDD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnDD.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnDD.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnDD.ForeColor = System.Drawing.Color.Black;
            this.btnDD.HoverState.Parent = this.btnDD;
            this.btnDD.Image = global::BTL_PTTKHT.Properties.Resources.icons8_rename_50;
            this.btnDD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDD.Location = new System.Drawing.Point(74, 219);
            this.btnDD.Name = "btnDD";
            this.btnDD.ShadowDecoration.Parent = this.btnDD;
            this.btnDD.Size = new System.Drawing.Size(155, 45);
            this.btnDD.TabIndex = 110;
            this.btnDD.Text = "  Điểm danh";
            this.btnDD.Click += new System.EventHandler(this.btnDD_Click);
            // 
            // frmDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(528, 290);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.cmTenNV);
            this.Controls.Add(this.btnDD);
            this.Controls.Add(this.dtpNgayLam);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblNgayDD);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblMaNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDiemDanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDiemDanh";
            this.Load += new System.EventHandler(this.frmDiemDanh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ElipseFrm;
        private Guna.UI2.WinForms.Guna2ComboBox cmTenNV;
        private Guna.UI2.WinForms.Guna2GradientButton btnDD;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayLam;
        public Guna.UI2.WinForms.Guna2TextBox txtMaNV;
        private System.Windows.Forms.Label lblNgayDD;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton btnTroVe;
    }
}