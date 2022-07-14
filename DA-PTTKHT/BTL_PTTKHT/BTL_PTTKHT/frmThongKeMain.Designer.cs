
namespace BTL_PTTKHT
{
    partial class frmThongKeMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ElipseFrm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cmbYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbLoaiTK = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTK = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbMonth = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelChildForm = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseFrm
            // 
            this.ElipseFrm.BorderRadius = 25;
            this.ElipseFrm.TargetControl = this;
            // 
            // cmbYear
            // 
            this.cmbYear.BackColor = System.Drawing.Color.Transparent;
            this.cmbYear.BorderRadius = 5;
            this.cmbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbYear.FocusedState.Parent = this.cmbYear;
            this.cmbYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbYear.HoverState.Parent = this.cmbYear;
            this.cmbYear.ItemHeight = 30;
            this.cmbYear.ItemsAppearance.Parent = this.cmbYear;
            this.cmbYear.Location = new System.Drawing.Point(407, 12);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.ShadowDecoration.Parent = this.cmbYear;
            this.cmbYear.Size = new System.Drawing.Size(179, 36);
            this.cmbYear.TabIndex = 0;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // cmbLoaiTK
            // 
            this.cmbLoaiTK.BackColor = System.Drawing.Color.Transparent;
            this.cmbLoaiTK.BorderRadius = 5;
            this.cmbLoaiTK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiTK.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiTK.FocusedState.Parent = this.cmbLoaiTK;
            this.cmbLoaiTK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLoaiTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbLoaiTK.HoverState.Parent = this.cmbLoaiTK;
            this.cmbLoaiTK.ItemHeight = 30;
            this.cmbLoaiTK.ItemsAppearance.Parent = this.cmbLoaiTK;
            this.cmbLoaiTK.Location = new System.Drawing.Point(821, 12);
            this.cmbLoaiTK.Name = "cmbLoaiTK";
            this.cmbLoaiTK.ShadowDecoration.Parent = this.cmbLoaiTK;
            this.cmbLoaiTK.Size = new System.Drawing.Size(262, 36);
            this.cmbLoaiTK.TabIndex = 1;
            this.cmbLoaiTK.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiTK_SelectedIndexChanged);
            // 
            // cmbTK
            // 
            this.cmbTK.BackColor = System.Drawing.Color.Transparent;
            this.cmbTK.BorderRadius = 5;
            this.cmbTK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTK.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTK.FocusedState.Parent = this.cmbTK;
            this.cmbTK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTK.HoverState.Parent = this.cmbTK;
            this.cmbTK.ItemHeight = 30;
            this.cmbTK.ItemsAppearance.Parent = this.cmbTK;
            this.cmbTK.Location = new System.Drawing.Point(117, 12);
            this.cmbTK.Name = "cmbTK";
            this.cmbTK.ShadowDecoration.Parent = this.cmbTK;
            this.cmbTK.Size = new System.Drawing.Size(262, 36);
            this.cmbTK.TabIndex = 2;
            this.cmbTK.SelectedIndexChanged += new System.EventHandler(this.cmbTK_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.BackColor = System.Drawing.Color.Transparent;
            this.cmbMonth.BorderRadius = 5;
            this.cmbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMonth.FocusedState.Parent = this.cmbMonth;
            this.cmbMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMonth.HoverState.Parent = this.cmbMonth;
            this.cmbMonth.ItemHeight = 30;
            this.cmbMonth.ItemsAppearance.Parent = this.cmbMonth;
            this.cmbMonth.Location = new System.Drawing.Point(614, 12);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.ShadowDecoration.Parent = this.cmbMonth;
            this.cmbMonth.Size = new System.Drawing.Size(179, 36);
            this.cmbMonth.TabIndex = 3;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.dgv);
            this.panelChildForm.Controls.Add(this.chart);
            this.panelChildForm.Location = new System.Drawing.Point(12, 67);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.ShadowDecoration.Parent = this.panelChildForm;
            this.panelChildForm.Size = new System.Drawing.Size(1211, 529);
            this.panelChildForm.TabIndex = 4;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Đồng hồ";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1211, 529);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.White;
            this.dgv.Location = new System.Drawing.Point(66, 37);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 38;
            this.dgv.RowTemplate.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1092, 434);
            this.dgv.TabIndex = 71;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv.ThemeStyle.ReadOnly = false;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.ThemeStyle.RowsStyle.Height = 38;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmThongKeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 608);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbTK);
            this.Controls.Add(this.cmbLoaiTK);
            this.Controls.Add(this.cmbYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKeMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmThongKeMain";
            this.Load += new System.EventHandler(this.frmThongKeMain_Load);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ElipseFrm;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMonth;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTK;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLoaiTK;
        private Guna.UI2.WinForms.Guna2ComboBox cmbYear;
        private Guna.UI2.WinForms.Guna2GradientPanel panelChildForm;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart;
        public Guna.UI2.WinForms.Guna2DataGridView dgv;
    }
}