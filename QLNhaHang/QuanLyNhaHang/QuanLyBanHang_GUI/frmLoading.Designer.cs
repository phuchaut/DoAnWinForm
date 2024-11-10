namespace QuanLyBanHang_GUI
{
    partial class frmLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
            this.lblLoading = new System.Windows.Forms.Label();
            this.prbLoading = new System.Windows.Forms.ProgressBar();
            this.pcbImageLD2 = new System.Windows.Forms.PictureBox();
            this.pcbImageLD3 = new System.Windows.Forms.PictureBox();
            this.pcbImageLD1 = new System.Windows.Forms.PictureBox();
            this.tmrLoading = new System.Windows.Forms.Timer(this.components);
            this.pcbCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImageLD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImageLD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImageLD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentChild)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.lblLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoading.Location = new System.Drawing.Point(504, 548);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(107, 25);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "Loading...";
            // 
            // prbLoading
            // 
            this.prbLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.prbLoading.ForeColor = System.Drawing.Color.White;
            this.prbLoading.Location = new System.Drawing.Point(125, 531);
            this.prbLoading.Name = "prbLoading";
            this.prbLoading.Size = new System.Drawing.Size(842, 14);
            this.prbLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbLoading.TabIndex = 2;
            // 
            // pcbImageLD2
            // 
            this.pcbImageLD2.Image = global::QuanLyBanHang_GUI.Properties.Resources.BieuTuongNhaHang21;
            this.pcbImageLD2.Location = new System.Drawing.Point(379, 141);
            this.pcbImageLD2.Name = "pcbImageLD2";
            this.pcbImageLD2.Size = new System.Drawing.Size(352, 294);
            this.pcbImageLD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImageLD2.TabIndex = 6;
            this.pcbImageLD2.TabStop = false;
            // 
            // pcbImageLD3
            // 
            this.pcbImageLD3.Image = global::QuanLyBanHang_GUI.Properties.Resources.StaffLoading;
            this.pcbImageLD3.Location = new System.Drawing.Point(846, 313);
            this.pcbImageLD3.Name = "pcbImageLD3";
            this.pcbImageLD3.Size = new System.Drawing.Size(188, 192);
            this.pcbImageLD3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImageLD3.TabIndex = 5;
            this.pcbImageLD3.TabStop = false;
            // 
            // pcbImageLD1
            // 
            this.pcbImageLD1.Image = global::QuanLyBanHang_GUI.Properties.Resources.RestaurantLoading;
            this.pcbImageLD1.Location = new System.Drawing.Point(51, 12);
            this.pcbImageLD1.Name = "pcbImageLD1";
            this.pcbImageLD1.Size = new System.Drawing.Size(246, 251);
            this.pcbImageLD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImageLD1.TabIndex = 4;
            this.pcbImageLD1.TabStop = false;
            // 
            // tmrLoading
            // 
            this.tmrLoading.Tick += new System.EventHandler(this.tmrLoading_Tick);
            // 
            // pcbCurrentChild
            // 
            this.pcbCurrentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.pcbCurrentChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.pcbCurrentChild.IconChar = FontAwesome.Sharp.IconChar.X;
            this.pcbCurrentChild.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.pcbCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pcbCurrentChild.Location = new System.Drawing.Point(1056, 12);
            this.pcbCurrentChild.Name = "pcbCurrentChild";
            this.pcbCurrentChild.Size = new System.Drawing.Size(32, 32);
            this.pcbCurrentChild.TabIndex = 0;
            this.pcbCurrentChild.TabStop = false;
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.pcbCurrentChild);
            this.Controls.Add(this.pcbImageLD2);
            this.Controls.Add(this.pcbImageLD3);
            this.Controls.Add(this.pcbImageLD1);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.prbLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoading";
            this.Text = "frmLoading";
            this.Load += new System.EventHandler(this.frmLoading_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImageLD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImageLD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImageLD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ProgressBar prbLoading;
        private System.Windows.Forms.PictureBox pcbImageLD1;
        private System.Windows.Forms.PictureBox pcbImageLD3;
        private System.Windows.Forms.PictureBox pcbImageLD2;
        private System.Windows.Forms.Timer tmrLoading;
        private FontAwesome.Sharp.IconPictureBox pcbCurrentChild;
    }
}