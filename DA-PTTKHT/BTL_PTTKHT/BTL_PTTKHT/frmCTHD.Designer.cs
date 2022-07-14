
namespace BTL_PTTKHT
{
    partial class frmCTHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ElipseFrm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblTenDH = new System.Windows.Forms.Label();
            this.dgvCTHD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblMaDH = new System.Windows.Forms.Label();
            this.grbChiTietHD = new System.Windows.Forms.GroupBox();
            this.cmbLoaiDH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblLoaiDH = new System.Windows.Forms.Label();
            this.cmbTenDH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Picture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.numSL = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblNoteSL = new System.Windows.Forms.Label();
            this.txtMaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnTroVe = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtNgayLapHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoHD1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNgayLapHD = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.ControlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.grbThongTinKhachHang = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.ElipseClose = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipsePicture = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtSL = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.grbChiTietHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.grbThongTinKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipseFrm
            // 
            this.ElipseFrm.BorderRadius = 25;
            this.ElipseFrm.TargetControl = this;
            // 
            // lblTenDH
            // 
            this.lblTenDH.AutoSize = true;
            this.lblTenDH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenDH.Location = new System.Drawing.Point(4, 158);
            this.lblTenDH.Name = "lblTenDH";
            this.lblTenDH.Size = new System.Drawing.Size(98, 21);
            this.lblTenDH.TabIndex = 42;
            this.lblTenDH.Text = "Tên đồng hồ:";
            // 
            // dgvCTHD
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvCTHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCTHD.ColumnHeadersHeight = 30;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTHD.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCTHD.EnableHeadersVisualStyles = false;
            this.dgvCTHD.GridColor = System.Drawing.Color.White;
            this.dgvCTHD.Location = new System.Drawing.Point(642, 63);
            this.dgvCTHD.Name = "dgvCTHD";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCTHD.RowHeadersVisible = false;
            this.dgvCTHD.RowTemplate.Height = 38;
            this.dgvCTHD.RowTemplate.ReadOnly = true;
            this.dgvCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHD.Size = new System.Drawing.Size(739, 537);
            this.dgvCTHD.TabIndex = 79;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCTHD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCTHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCTHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCTHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCTHD.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvCTHD.ThemeStyle.ReadOnly = false;
            this.dgvCTHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCTHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCTHD.ThemeStyle.RowsStyle.Height = 38;
            this.dgvCTHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSP";
            this.Column1.FillWeight = 15F;
            this.Column1.HeaderText = "Mã ĐH";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSP";
            this.Column2.FillWeight = 52.41423F;
            this.Column2.HeaderText = "Tên đồng hồ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            this.Column3.FillWeight = 20F;
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DonGiaSP";
            this.Column4.FillWeight = 25F;
            this.Column4.HeaderText = "Giá";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ThanhTienSP";
            this.Column5.FillWeight = 25F;
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.Name = "Column5";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSoLuong.Location = new System.Drawing.Point(4, 272);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(76, 21);
            this.lblSoLuong.TabIndex = 43;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblMaDH
            // 
            this.lblMaDH.AutoSize = true;
            this.lblMaDH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMaDH.Location = new System.Drawing.Point(4, 101);
            this.lblMaDH.Name = "lblMaDH";
            this.lblMaDH.Size = new System.Drawing.Size(97, 21);
            this.lblMaDH.TabIndex = 1;
            this.lblMaDH.Text = "Mã đồng hồ:";
            // 
            // grbChiTietHD
            // 
            this.grbChiTietHD.Controls.Add(this.txtSL);
            this.grbChiTietHD.Controls.Add(this.label1);
            this.grbChiTietHD.Controls.Add(this.cmbLoaiDH);
            this.grbChiTietHD.Controls.Add(this.lblLoaiDH);
            this.grbChiTietHD.Controls.Add(this.cmbTenDH);
            this.grbChiTietHD.Controls.Add(this.Picture);
            this.grbChiTietHD.Controls.Add(this.txtThanhTien);
            this.grbChiTietHD.Controls.Add(this.lblThanhTien);
            this.grbChiTietHD.Controls.Add(this.numSL);
            this.grbChiTietHD.Controls.Add(this.lblNoteSL);
            this.grbChiTietHD.Controls.Add(this.lblSoLuong);
            this.grbChiTietHD.Controls.Add(this.lblTenDH);
            this.grbChiTietHD.Controls.Add(this.txtMaSP);
            this.grbChiTietHD.Controls.Add(this.lblMaDH);
            this.grbChiTietHD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grbChiTietHD.Location = new System.Drawing.Point(19, 160);
            this.grbChiTietHD.Name = "grbChiTietHD";
            this.grbChiTietHD.Size = new System.Drawing.Size(604, 325);
            this.grbChiTietHD.TabIndex = 75;
            this.grbChiTietHD.TabStop = false;
            this.grbChiTietHD.Text = "Chi tiết hóa đơn";
            // 
            // cmbLoaiDH
            // 
            this.cmbLoaiDH.BackColor = System.Drawing.Color.White;
            this.cmbLoaiDH.BorderColor = System.Drawing.Color.Black;
            this.cmbLoaiDH.BorderRadius = 5;
            this.cmbLoaiDH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiDH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiDH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiDH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiDH.FocusedState.Parent = this.cmbLoaiDH;
            this.cmbLoaiDH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLoaiDH.ForeColor = System.Drawing.Color.Black;
            this.cmbLoaiDH.HoverState.Parent = this.cmbLoaiDH;
            this.cmbLoaiDH.ItemHeight = 30;
            this.cmbLoaiDH.ItemsAppearance.Parent = this.cmbLoaiDH;
            this.cmbLoaiDH.Location = new System.Drawing.Point(105, 36);
            this.cmbLoaiDH.Name = "cmbLoaiDH";
            this.cmbLoaiDH.ShadowDecoration.Parent = this.cmbLoaiDH;
            this.cmbLoaiDH.Size = new System.Drawing.Size(320, 36);
            this.cmbLoaiDH.TabIndex = 126;
            this.cmbLoaiDH.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiDH_SelectedIndexChanged);
            // 
            // lblLoaiDH
            // 
            this.lblLoaiDH.AutoSize = true;
            this.lblLoaiDH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLoaiDH.Location = new System.Drawing.Point(4, 44);
            this.lblLoaiDH.Name = "lblLoaiDH";
            this.lblLoaiDH.Size = new System.Drawing.Size(104, 21);
            this.lblLoaiDH.TabIndex = 125;
            this.lblLoaiDH.Text = "Loại đồng hồ:";
            // 
            // cmbTenDH
            // 
            this.cmbTenDH.BackColor = System.Drawing.Color.Transparent;
            this.cmbTenDH.BorderColor = System.Drawing.Color.Black;
            this.cmbTenDH.BorderRadius = 5;
            this.cmbTenDH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenDH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenDH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenDH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenDH.FocusedState.Parent = this.cmbTenDH;
            this.cmbTenDH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTenDH.ForeColor = System.Drawing.Color.Black;
            this.cmbTenDH.HoverState.Parent = this.cmbTenDH;
            this.cmbTenDH.ItemHeight = 30;
            this.cmbTenDH.ItemsAppearance.Parent = this.cmbTenDH;
            this.cmbTenDH.Location = new System.Drawing.Point(105, 150);
            this.cmbTenDH.Name = "cmbTenDH";
            this.cmbTenDH.ShadowDecoration.Parent = this.cmbTenDH;
            this.cmbTenDH.Size = new System.Drawing.Size(320, 36);
            this.cmbTenDH.TabIndex = 124;
            this.cmbTenDH.SelectedIndexChanged += new System.EventHandler(this.cmbTenDH_SelectedIndexChanged);
            // 
            // Picture
            // 
            this.Picture.BorderRadius = 10;
            this.Picture.FillColor = System.Drawing.Color.Black;
            this.Picture.ImageRotate = 0F;
            this.Picture.Location = new System.Drawing.Point(434, 56);
            this.Picture.Name = "Picture";
            this.Picture.ShadowDecoration.Parent = this.Picture;
            this.Picture.Size = new System.Drawing.Size(159, 208);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 37;
            this.Picture.TabStop = false;
            this.Picture.Click += new System.EventHandler(this.Picture_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BorderColor = System.Drawing.Color.Black;
            this.txtThanhTien.BorderRadius = 5;
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhTien.DefaultText = "";
            this.txtThanhTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThanhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThanhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.DisabledState.Parent = this.txtThanhTien;
            this.txtThanhTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.FocusedState.Parent = this.txtThanhTien;
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThanhTien.ForeColor = System.Drawing.Color.Black;
            this.txtThanhTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.HoverState.Parent = this.txtThanhTien;
            this.txtThanhTien.Location = new System.Drawing.Point(105, 207);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PasswordChar = '\0';
            this.txtThanhTien.PlaceholderText = "";
            this.txtThanhTien.SelectedText = "";
            this.txtThanhTien.ShadowDecoration.Parent = this.txtThanhTien;
            this.txtThanhTien.Size = new System.Drawing.Size(122, 36);
            this.txtThanhTien.TabIndex = 122;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblThanhTien.Location = new System.Drawing.Point(4, 215);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(86, 21);
            this.lblThanhTien.TabIndex = 123;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // numSL
            // 
            this.numSL.BackColor = System.Drawing.Color.Transparent;
            this.numSL.BorderColor = System.Drawing.Color.Black;
            this.numSL.BorderRadius = 5;
            this.numSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSL.DisabledState.Parent = this.numSL;
            this.numSL.FocusedState.Parent = this.numSL;
            this.numSL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSL.ForeColor = System.Drawing.Color.Black;
            this.numSL.Location = new System.Drawing.Point(105, 264);
            this.numSL.Name = "numSL";
            this.numSL.ShadowDecoration.Parent = this.numSL;
            this.numSL.Size = new System.Drawing.Size(100, 36);
            this.numSL.TabIndex = 60;
            this.numSL.UpDownButtonFillColor = System.Drawing.Color.Silver;
            this.numSL.ValueChanged += new System.EventHandler(this.numSL_ValueChanged);
            // 
            // lblNoteSL
            // 
            this.lblNoteSL.AutoSize = true;
            this.lblNoteSL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNoteSL.ForeColor = System.Drawing.Color.Red;
            this.lblNoteSL.Location = new System.Drawing.Point(102, 303);
            this.lblNoteSL.Name = "lblNoteSL";
            this.lblNoteSL.Size = new System.Drawing.Size(54, 15);
            this.lblNoteSL.TabIndex = 33;
            this.lblNoteSL.Text = "Số lượng";
            // 
            // txtMaSP
            // 
            this.txtMaSP.BorderColor = System.Drawing.Color.Black;
            this.txtMaSP.BorderRadius = 5;
            this.txtMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSP.DefaultText = "";
            this.txtMaSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSP.DisabledState.Parent = this.txtMaSP;
            this.txtMaSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSP.FocusedState.Parent = this.txtMaSP;
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaSP.ForeColor = System.Drawing.Color.Black;
            this.txtMaSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSP.HoverState.Parent = this.txtMaSP;
            this.txtMaSP.Location = new System.Drawing.Point(105, 93);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.PasswordChar = '\0';
            this.txtMaSP.PlaceholderText = "";
            this.txtMaSP.SelectedText = "";
            this.txtMaSP.ShadowDecoration.Parent = this.txtMaSP;
            this.txtMaSP.Size = new System.Drawing.Size(320, 36);
            this.txtMaSP.TabIndex = 1;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnTroVe);
            this.grbChucNang.Controls.Add(this.btnLuu);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grbChucNang.Location = new System.Drawing.Point(19, 500);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(604, 146);
            this.grbChucNang.TabIndex = 77;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
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
            this.btnTroVe.Font = new System.Drawing.Font("Consolas", 13F);
            this.btnTroVe.ForeColor = System.Drawing.Color.Black;
            this.btnTroVe.HoverState.Parent = this.btnTroVe;
            this.btnTroVe.Image = global::BTL_PTTKHT.Properties.Resources.icons8_reset_24;
            this.btnTroVe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTroVe.Location = new System.Drawing.Point(460, 55);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.ShadowDecoration.Parent = this.btnTroVe;
            this.btnTroVe.Size = new System.Drawing.Size(126, 45);
            this.btnTroVe.TabIndex = 71;
            this.btnTroVe.Text = "Hủy";
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BorderColor = System.Drawing.Color.Red;
            this.btnLuu.BorderRadius = 10;
            this.btnLuu.BorderThickness = 1;
            this.btnLuu.CheckedState.Parent = this.btnLuu;
            this.btnLuu.CustomImages.Parent = this.btnLuu;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.DisabledState.Parent = this.btnLuu;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnLuu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnLuu.Font = new System.Drawing.Font("Consolas", 13F);
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.HoverState.Parent = this.btnLuu;
            this.btnLuu.Image = global::BTL_PTTKHT.Properties.Resources.icons8_fast_cart_32;
            this.btnLuu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLuu.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLuu.Location = new System.Drawing.Point(238, 31);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(195, 45);
            this.btnLuu.TabIndex = 70;
            this.btnLuu.Text = "  Thêm vào giỏ";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderColor = System.Drawing.Color.Red;
            this.btnThem.BorderRadius = 10;
            this.btnThem.BorderThickness = 1;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.DisabledState.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnThem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnThem.Font = new System.Drawing.Font("Consolas", 13F);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = global::BTL_PTTKHT.Properties.Resources.icons8_plus___50;
            this.btnThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThem.Location = new System.Drawing.Point(19, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(195, 45);
            this.btnThem.TabIndex = 67;
            this.btnThem.Text = "  Chọn ĐH mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnSua.Font = new System.Drawing.Font("Consolas", 13F);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Image = global::BTL_PTTKHT.Properties.Resources.icons8_how_many_quest_50;
            this.btnSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSua.Location = new System.Drawing.Point(19, 82);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(195, 45);
            this.btnSua.TabIndex = 68;
            this.btnSua.Text = "  Thay đổi SL";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderColor = System.Drawing.Color.Red;
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.BorderThickness = 1;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.DisabledState.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnXoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnXoa.Font = new System.Drawing.Font("Consolas", 13F);
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = global::BTL_PTTKHT.Properties.Resources.icons8_delete_48;
            this.btnXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoa.Location = new System.Drawing.Point(238, 82);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(195, 45);
            this.btnXoa.TabIndex = 69;
            this.btnXoa.Text = "  Xóa khỏi giỏ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtNgayLapHD
            // 
            this.txtNgayLapHD.BorderColor = System.Drawing.Color.Black;
            this.txtNgayLapHD.BorderRadius = 5;
            this.txtNgayLapHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgayLapHD.DefaultText = "";
            this.txtNgayLapHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNgayLapHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNgayLapHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgayLapHD.DisabledState.Parent = this.txtNgayLapHD;
            this.txtNgayLapHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgayLapHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgayLapHD.FocusedState.Parent = this.txtNgayLapHD;
            this.txtNgayLapHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNgayLapHD.ForeColor = System.Drawing.Color.Black;
            this.txtNgayLapHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgayLapHD.HoverState.Parent = this.txtNgayLapHD;
            this.txtNgayLapHD.Location = new System.Drawing.Point(105, 85);
            this.txtNgayLapHD.Name = "txtNgayLapHD";
            this.txtNgayLapHD.PasswordChar = '\0';
            this.txtNgayLapHD.PlaceholderText = "";
            this.txtNgayLapHD.SelectedText = "";
            this.txtNgayLapHD.ShadowDecoration.Parent = this.txtNgayLapHD;
            this.txtNgayLapHD.Size = new System.Drawing.Size(159, 36);
            this.txtNgayLapHD.TabIndex = 36;
            // 
            // txtSoHD1
            // 
            this.txtSoHD1.BorderColor = System.Drawing.Color.Black;
            this.txtSoHD1.BorderRadius = 5;
            this.txtSoHD1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoHD1.DefaultText = "";
            this.txtSoHD1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoHD1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoHD1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoHD1.DisabledState.Parent = this.txtSoHD1;
            this.txtSoHD1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoHD1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoHD1.FocusedState.Parent = this.txtSoHD1;
            this.txtSoHD1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoHD1.ForeColor = System.Drawing.Color.Black;
            this.txtSoHD1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoHD1.HoverState.Parent = this.txtSoHD1;
            this.txtSoHD1.Location = new System.Drawing.Point(105, 29);
            this.txtSoHD1.Name = "txtSoHD1";
            this.txtSoHD1.PasswordChar = '\0';
            this.txtSoHD1.PlaceholderText = "";
            this.txtSoHD1.SelectedText = "";
            this.txtSoHD1.ShadowDecoration.Parent = this.txtSoHD1;
            this.txtSoHD1.Size = new System.Drawing.Size(159, 36);
            this.txtSoHD1.TabIndex = 33;
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSoHD.Location = new System.Drawing.Point(4, 37);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(93, 21);
            this.lblSoHD.TabIndex = 34;
            this.lblSoHD.Text = "Số hóa đơn:";
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
            this.txtTenKH.Location = new System.Drawing.Point(427, 86);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.PlaceholderText = "";
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.ShadowDecoration.Parent = this.txtTenKH;
            this.txtTenKH.Size = new System.Drawing.Size(159, 36);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtTenNV
            // 
            this.txtTenNV.BorderColor = System.Drawing.Color.Black;
            this.txtTenNV.BorderRadius = 5;
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.DefaultText = "";
            this.txtTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.DisabledState.Parent = this.txtTenNV;
            this.txtTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.FocusedState.Parent = this.txtTenNV;
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNV.ForeColor = System.Drawing.Color.Black;
            this.txtTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.HoverState.Parent = this.txtTenNV;
            this.txtTenNV.Location = new System.Drawing.Point(427, 29);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.PlaceholderText = "";
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.ShadowDecoration.Parent = this.txtTenNV;
            this.txtTenNV.Size = new System.Drawing.Size(159, 36);
            this.txtTenNV.TabIndex = 1;
            // 
            // lblNgayLapHD
            // 
            this.lblNgayLapHD.AutoSize = true;
            this.lblNgayLapHD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNgayLapHD.Location = new System.Drawing.Point(4, 93);
            this.lblNgayLapHD.Name = "lblNgayLapHD";
            this.lblNgayLapHD.Size = new System.Drawing.Size(101, 21);
            this.lblNgayLapHD.TabIndex = 3;
            this.lblNgayLapHD.Text = "Ngày lập HD:";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenKH.Location = new System.Drawing.Point(310, 94);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(120, 21);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên khách hàng:";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenNV.Location = new System.Drawing.Point(310, 37);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(108, 21);
            this.lblTenNV.TabIndex = 1;
            this.lblTenNV.Text = "Tên nhân viên:";
            // 
            // ControlClose
            // 
            this.ControlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ControlClose.HoverState.Parent = this.ControlClose;
            this.ControlClose.IconColor = System.Drawing.Color.White;
            this.ControlClose.Location = new System.Drawing.Point(1351, 12);
            this.ControlClose.Name = "ControlClose";
            this.ControlClose.ShadowDecoration.Parent = this.ControlClose;
            this.ControlClose.Size = new System.Drawing.Size(30, 30);
            this.ControlClose.TabIndex = 78;
            this.ControlClose.Click += new System.EventHandler(this.ControlClose_Click);
            // 
            // grbThongTinKhachHang
            // 
            this.grbThongTinKhachHang.Controls.Add(this.txtNgayLapHD);
            this.grbThongTinKhachHang.Controls.Add(this.txtSoHD1);
            this.grbThongTinKhachHang.Controls.Add(this.lblSoHD);
            this.grbThongTinKhachHang.Controls.Add(this.txtTenKH);
            this.grbThongTinKhachHang.Controls.Add(this.txtTenNV);
            this.grbThongTinKhachHang.Controls.Add(this.lblNgayLapHD);
            this.grbThongTinKhachHang.Controls.Add(this.lblTenKH);
            this.grbThongTinKhachHang.Controls.Add(this.lblTenNV);
            this.grbThongTinKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grbThongTinKhachHang.Location = new System.Drawing.Point(19, 12);
            this.grbThongTinKhachHang.Name = "grbThongTinKhachHang";
            this.grbThongTinKhachHang.Size = new System.Drawing.Size(604, 142);
            this.grbThongTinKhachHang.TabIndex = 76;
            this.grbThongTinKhachHang.TabStop = false;
            this.grbThongTinKhachHang.Text = "Thông tin hóa đơn";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderRadius = 5;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "Tìm sản phẩm ...";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.Parent = this.txtTimKiem;
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedState.Parent = this.txtTimKiem;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.HoverState.Parent = this.txtTimKiem;
            this.txtTimKiem.Location = new System.Drawing.Point(853, 20);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionStart = 16;
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(316, 36);
            this.txtTimKiem.TabIndex = 74;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // ElipseClose
            // 
            this.ElipseClose.BorderRadius = 5;
            this.ElipseClose.TargetControl = this.ControlClose;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderColor = System.Drawing.Color.Red;
            this.btnThanhToan.BorderRadius = 10;
            this.btnThanhToan.BorderThickness = 1;
            this.btnThanhToan.CheckedState.Parent = this.btnThanhToan;
            this.btnThanhToan.CustomImages.Parent = this.btnThanhToan;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.DisabledState.Parent = this.btnThanhToan;
            this.btnThanhToan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnThanhToan.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Consolas", 13F);
            this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.HoverState.Parent = this.btnThanhToan;
            this.btnThanhToan.Image = global::BTL_PTTKHT.Properties.Resources.icons8_order_64;
            this.btnThanhToan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThanhToan.ImageSize = new System.Drawing.Size(25, 25);
            this.btnThanhToan.Location = new System.Drawing.Point(914, 611);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ShadowDecoration.Parent = this.btnThanhToan;
            this.btnThanhToan.Size = new System.Drawing.Size(195, 45);
            this.btnThanhToan.TabIndex = 72;
            this.btnThanhToan.Text = "  Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // txtSL
            // 
            this.txtSL.BorderColor = System.Drawing.Color.Black;
            this.txtSL.BorderRadius = 5;
            this.txtSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSL.DefaultText = "";
            this.txtSL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSL.DisabledState.Parent = this.txtSL;
            this.txtSL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSL.Enabled = false;
            this.txtSL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSL.FocusedState.Parent = this.txtSL;
            this.txtSL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSL.ForeColor = System.Drawing.Color.Black;
            this.txtSL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSL.HoverState.Parent = this.txtSL;
            this.txtSL.Location = new System.Drawing.Point(303, 207);
            this.txtSL.Name = "txtSL";
            this.txtSL.PasswordChar = '\0';
            this.txtSL.PlaceholderText = "";
            this.txtSL.SelectedText = "";
            this.txtSL.ShadowDecoration.Parent = this.txtSL;
            this.txtSL.Size = new System.Drawing.Size(122, 36);
            this.txtSL.TabIndex = 127;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(237, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 128;
            this.label1.Text = "SL kho:";
            // 
            // frmCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 666);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.grbChiTietHD);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.ControlClose);
            this.Controls.Add(this.grbThongTinKhachHang);
            this.Controls.Add(this.txtTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCTHD";
            this.Load += new System.EventHandler(this.frmCTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.grbChiTietHD.ResumeLayout(false);
            this.grbChiTietHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.grbChucNang.ResumeLayout(false);
            this.grbThongTinKhachHang.ResumeLayout(false);
            this.grbThongTinKhachHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ElipseFrm;
        public Guna.UI2.WinForms.Guna2DataGridView dgvCTHD;
        private System.Windows.Forms.GroupBox grbChiTietHD;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSL;
        private System.Windows.Forms.Label lblNoteSL;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTenDH;
        private Guna.UI2.WinForms.Guna2TextBox txtMaSP;
        private System.Windows.Forms.Label lblMaDH;
        private System.Windows.Forms.GroupBox grbChucNang;
        private Guna.UI2.WinForms.Guna2ControlBox ControlClose;
        private System.Windows.Forms.GroupBox grbThongTinKhachHang;
        private Guna.UI2.WinForms.Guna2TextBox txtNgayLapHD;
        public Guna.UI2.WinForms.Guna2TextBox txtSoHD1;
        private System.Windows.Forms.Label lblSoHD;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNV;
        private System.Windows.Forms.Label lblNgayLapHD;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblTenNV;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2GradientButton btnTroVe;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2Elipse ElipseClose;
        private Guna.UI2.WinForms.Guna2TextBox txtThanhTien;
        private System.Windows.Forms.Label lblThanhTien;
        private Guna.UI2.WinForms.Guna2Elipse ElipsePicture;
        public Guna.UI2.WinForms.Guna2PictureBox Picture;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTenDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLoaiDH;
        private System.Windows.Forms.Label lblLoaiDH;
        private Guna.UI2.WinForms.Guna2GradientButton btnThanhToan;
        private Guna.UI2.WinForms.Guna2TextBox txtSL;
        private System.Windows.Forms.Label label1;
    }
}