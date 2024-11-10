namespace QuanLyBanHang_GUI
{
    partial class frmViewReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewReport));
            this.rpvChiTietHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvChiTietHoaDon
            // 
            this.rpvChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvChiTietHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rpvChiTietHoaDon.Name = "rpvChiTietHoaDon";
            this.rpvChiTietHoaDon.ServerReport.BearerToken = null;
            this.rpvChiTietHoaDon.Size = new System.Drawing.Size(800, 450);
            this.rpvChiTietHoaDon.TabIndex = 0;
            // 
            // frmViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvChiTietHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewReport";
            this.Load += new System.EventHandler(this.frmViewReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvChiTietHoaDon;
    }
}