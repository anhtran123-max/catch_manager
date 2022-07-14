
namespace BTL_PTTKHT
{
    partial class frmXemHinhSP
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
            this.Picture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ElipsePiture = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipseFrm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ControlMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Picture.ImageRotate = 0F;
            this.Picture.Location = new System.Drawing.Point(0, 41);
            this.Picture.Name = "Picture";
            this.Picture.ShadowDecoration.Parent = this.Picture;
            this.Picture.Size = new System.Drawing.Size(374, 463);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // ElipsePiture
            // 
            this.ElipsePiture.BorderRadius = 25;
            // 
            // ElipseFrm
            // 
            this.ElipseFrm.BorderRadius = 25;
            this.ElipseFrm.TargetControl = this;
            // 
            // ControlMin
            // 
            this.ControlMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ControlMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ControlMin.HoverState.Parent = this.ControlMin;
            this.ControlMin.IconColor = System.Drawing.Color.White;
            this.ControlMin.Location = new System.Drawing.Point(300, 5);
            this.ControlMin.Name = "ControlMin";
            this.ControlMin.ShadowDecoration.Parent = this.ControlMin;
            this.ControlMin.Size = new System.Drawing.Size(30, 30);
            this.ControlMin.TabIndex = 95;
            // 
            // ControlClose
            // 
            this.ControlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ControlClose.HoverState.Parent = this.ControlClose;
            this.ControlClose.IconColor = System.Drawing.Color.White;
            this.ControlClose.Location = new System.Drawing.Point(336, 5);
            this.ControlClose.Name = "ControlClose";
            this.ControlClose.ShadowDecoration.Parent = this.ControlClose;
            this.ControlClose.Size = new System.Drawing.Size(30, 30);
            this.ControlClose.TabIndex = 94;
            // 
            // frmXemHinhSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 504);
            this.Controls.Add(this.ControlMin);
            this.Controls.Add(this.ControlClose);
            this.Controls.Add(this.Picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXemHinhSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXemHinhSP";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse ElipsePiture;
        public Guna.UI2.WinForms.Guna2PictureBox Picture;
        private Guna.UI2.WinForms.Guna2Elipse ElipseFrm;
        private Guna.UI2.WinForms.Guna2ControlBox ControlMin;
        private Guna.UI2.WinForms.Guna2ControlBox ControlClose;
    }
}