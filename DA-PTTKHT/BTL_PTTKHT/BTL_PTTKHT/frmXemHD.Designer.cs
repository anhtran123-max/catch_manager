
namespace BTL_PTTKHT
{
    partial class frmXemHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ElipseFrm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ControlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ElipseMin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipseCloseFrm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgvCTHD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNgayLapHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNgayLapHD = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.btnInHD = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseFrm
            // 
            this.ElipseFrm.BorderRadius = 25;
            this.ElipseFrm.TargetControl = this;
            // 
            // ControlClose
            // 
            this.ControlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ControlClose.HoverState.Parent = this.ControlClose;
            this.ControlClose.IconColor = System.Drawing.Color.White;
            this.ControlClose.Location = new System.Drawing.Point(975, 12);
            this.ControlClose.Name = "ControlClose";
            this.ControlClose.ShadowDecoration.Parent = this.ControlClose;
            this.ControlClose.Size = new System.Drawing.Size(32, 32);
            this.ControlClose.TabIndex = 63;
            // 
            // ControlMin
            // 
            this.ControlMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ControlMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ControlMin.HoverState.Parent = this.ControlMin;
            this.ControlMin.IconColor = System.Drawing.Color.White;
            this.ControlMin.Location = new System.Drawing.Point(937, 12);
            this.ControlMin.Name = "ControlMin";
            this.ControlMin.ShadowDecoration.Parent = this.ControlMin;
            this.ControlMin.Size = new System.Drawing.Size(32, 32);
            this.ControlMin.TabIndex = 65;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BorderRadius = 5;
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhTien.DefaultText = "";
            this.txtThanhTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThanhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThanhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.DisabledState.Parent = this.txtThanhTien;
            this.txtThanhTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.FocusedState.Parent = this.txtThanhTien;
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.HoverState.Parent = this.txtThanhTien;
            this.txtThanhTien.Location = new System.Drawing.Point(102, 521);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PasswordChar = '\0';
            this.txtThanhTien.PlaceholderText = "";
            this.txtThanhTien.SelectedText = "";
            this.txtThanhTien.ShadowDecoration.Parent = this.txtThanhTien;
            this.txtThanhTien.Size = new System.Drawing.Size(194, 36);
            this.txtThanhTien.TabIndex = 66;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(14, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 67;
            this.label2.Text = "Thành tiền:";
            // 
            // ElipseMin
            // 
            this.ElipseMin.TargetControl = this.ControlMin;
            // 
            // ElipseCloseFrm
            // 
            this.ElipseCloseFrm.TargetControl = this.ControlClose;
            // 
            // dgvCTHD
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvCTHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCTHD.ColumnHeadersHeight = 30;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTHD.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCTHD.EnableHeadersVisualStyles = false;
            this.dgvCTHD.GridColor = System.Drawing.Color.White;
            this.dgvCTHD.Location = new System.Drawing.Point(12, 117);
            this.dgvCTHD.Name = "dgvCTHD";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCTHD.RowHeadersVisible = false;
            this.dgvCTHD.RowTemplate.Height = 38;
            this.dgvCTHD.RowTemplate.ReadOnly = true;
            this.dgvCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHD.Size = new System.Drawing.Size(996, 392);
            this.dgvCTHD.TabIndex = 80;
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
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSP";
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "Mã SP";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSP";
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Tên SP";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            this.Column3.FillWeight = 35F;
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DonGiaSP";
            this.Column4.FillWeight = 40F;
            this.Column4.HeaderText = "Giá";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ThanhTienSP";
            this.Column5.FillWeight = 40F;
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.Name = "Column5";
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
            this.txtNgayLapHD.Enabled = false;
            this.txtNgayLapHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgayLapHD.FocusedState.Parent = this.txtNgayLapHD;
            this.txtNgayLapHD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLapHD.ForeColor = System.Drawing.Color.Black;
            this.txtNgayLapHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgayLapHD.HoverState.Parent = this.txtNgayLapHD;
            this.txtNgayLapHD.Location = new System.Drawing.Point(606, 70);
            this.txtNgayLapHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayLapHD.Name = "txtNgayLapHD";
            this.txtNgayLapHD.PasswordChar = '\0';
            this.txtNgayLapHD.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtNgayLapHD.PlaceholderText = "";
            this.txtNgayLapHD.SelectedText = "";
            this.txtNgayLapHD.ShadowDecoration.Parent = this.txtNgayLapHD;
            this.txtNgayLapHD.Size = new System.Drawing.Size(309, 35);
            this.txtNgayLapHD.TabIndex = 88;
            // 
            // txtSoHD
            // 
            this.txtSoHD.BorderColor = System.Drawing.Color.Black;
            this.txtSoHD.BorderRadius = 5;
            this.txtSoHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoHD.DefaultText = "";
            this.txtSoHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoHD.DisabledState.Parent = this.txtSoHD;
            this.txtSoHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoHD.Enabled = false;
            this.txtSoHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoHD.FocusedState.Parent = this.txtSoHD;
            this.txtSoHD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHD.ForeColor = System.Drawing.Color.Black;
            this.txtSoHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoHD.HoverState.Parent = this.txtSoHD;
            this.txtSoHD.Location = new System.Drawing.Point(135, 13);
            this.txtSoHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.PasswordChar = '\0';
            this.txtSoHD.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSoHD.PlaceholderText = "";
            this.txtSoHD.SelectedText = "";
            this.txtSoHD.ShadowDecoration.Parent = this.txtSoHD;
            this.txtSoHD.Size = new System.Drawing.Size(309, 35);
            this.txtSoHD.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 87;
            this.label3.Text = "Số hóa đơn:";
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
            this.txtTenKH.Enabled = false;
            this.txtTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.FocusedState.Parent = this.txtTenKH;
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.ForeColor = System.Drawing.Color.Black;
            this.txtTenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.HoverState.Parent = this.txtTenKH;
            this.txtTenKH.Location = new System.Drawing.Point(606, 13);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtTenKH.PlaceholderText = "";
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.ShadowDecoration.Parent = this.txtTenKH;
            this.txtTenKH.Size = new System.Drawing.Size(309, 35);
            this.txtTenKH.TabIndex = 83;
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
            this.txtTenNV.Enabled = false;
            this.txtTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.FocusedState.Parent = this.txtTenNV;
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.Black;
            this.txtTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.HoverState.Parent = this.txtTenNV;
            this.txtTenNV.Location = new System.Drawing.Point(135, 70);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtTenNV.PlaceholderText = "";
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.ShadowDecoration.Parent = this.txtTenNV;
            this.txtTenNV.Size = new System.Drawing.Size(309, 35);
            this.txtTenNV.TabIndex = 81;
            // 
            // lblNgayLapHD
            // 
            this.lblNgayLapHD.AutoSize = true;
            this.lblNgayLapHD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNgayLapHD.Location = new System.Drawing.Point(484, 77);
            this.lblNgayLapHD.Name = "lblNgayLapHD";
            this.lblNgayLapHD.Size = new System.Drawing.Size(101, 21);
            this.lblNgayLapHD.TabIndex = 85;
            this.lblNgayLapHD.Text = "Ngày lập HD:";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenKH.Location = new System.Drawing.Point(484, 20);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(120, 21);
            this.lblTenKH.TabIndex = 84;
            this.lblTenKH.Text = "Tên khách hàng:";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenNV.Location = new System.Drawing.Point(18, 77);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(108, 21);
            this.lblTenNV.TabIndex = 82;
            this.lblTenNV.Text = "Tên nhân viên:";
            // 
            // btnInHD
            // 
            this.btnInHD.BorderColor = System.Drawing.Color.Red;
            this.btnInHD.BorderRadius = 10;
            this.btnInHD.BorderThickness = 1;
            this.btnInHD.CheckedState.Parent = this.btnInHD;
            this.btnInHD.CustomImages.Parent = this.btnInHD;
            this.btnInHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInHD.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInHD.DisabledState.Parent = this.btnInHD;
            this.btnInHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnInHD.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnInHD.Font = new System.Drawing.Font("Consolas", 13F);
            this.btnInHD.ForeColor = System.Drawing.Color.Black;
            this.btnInHD.HoverState.Parent = this.btnInHD;
            this.btnInHD.Image = global::BTL_PTTKHT.Properties.Resources.icons8_print_50;
            this.btnInHD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInHD.Location = new System.Drawing.Point(412, 516);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.ShadowDecoration.Parent = this.btnInHD;
            this.btnInHD.Size = new System.Drawing.Size(175, 45);
            this.btnInHD.TabIndex = 89;
            this.btnInHD.Text = "  In hóa đơn";
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
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
            this.btnThanhToan.Location = new System.Drawing.Point(812, 516);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ShadowDecoration.Parent = this.btnThanhToan;
            this.btnThanhToan.Size = new System.Drawing.Size(195, 45);
            this.btnThanhToan.TabIndex = 90;
            this.btnThanhToan.Text = "  Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // frmXemHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1019, 570);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.txtNgayLapHD);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.lblNgayLapHD);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ControlMin);
            this.Controls.Add(this.ControlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXemHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXemHD";
            this.Load += new System.EventHandler(this.frmXemHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ElipseFrm;
        private Guna.UI2.WinForms.Guna2ControlBox ControlClose;
        private Guna.UI2.WinForms.Guna2ControlBox ControlMin;
        private Guna.UI2.WinForms.Guna2TextBox txtThanhTien;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse ElipseMin;
        private Guna.UI2.WinForms.Guna2Elipse ElipseCloseFrm;
        public Guna.UI2.WinForms.Guna2DataGridView dgvCTHD;
        public Guna.UI2.WinForms.Guna2TextBox txtSoHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNgayLapHD;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblTenNV;
        public Guna.UI2.WinForms.Guna2TextBox txtNgayLapHD;
        public Guna.UI2.WinForms.Guna2TextBox txtTenKH;
        public Guna.UI2.WinForms.Guna2TextBox txtTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI2.WinForms.Guna2GradientButton btnInHD;
        public Guna.UI2.WinForms.Guna2GradientButton btnThanhToan;
    }
}