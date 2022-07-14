
namespace BTL_PTTKHT
{
    partial class frm_Bill
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
            this.reportViewerBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerBill
            // 
            this.reportViewerBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerBill.LocalReport.ReportEmbeddedResource = "BTL_PTTKHT.Report.Bill.rdlc";
            this.reportViewerBill.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBill.Name = "reportViewerBill";
            this.reportViewerBill.ServerReport.BearerToken = null;
            this.reportViewerBill.Size = new System.Drawing.Size(566, 470);
            this.reportViewerBill.TabIndex = 0;
            // 
            // frm_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 470);
            this.Controls.Add(this.reportViewerBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Bill";
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewerBill;
    }
}