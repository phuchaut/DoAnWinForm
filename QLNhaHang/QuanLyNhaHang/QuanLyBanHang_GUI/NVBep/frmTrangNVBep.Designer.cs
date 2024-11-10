namespace QuanLyBanHang_GUI
{
    partial class frmTrangNVBep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangNVBep));
            this.pnlDuongKe = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pcbCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.pnlIconNhaHang = new System.Windows.Forms.Panel();
            this.pcbHome = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.btnNguyenLieu = new FontAwesome.Sharp.IconButton();
            this.btnQLHoaDon = new FontAwesome.Sharp.IconButton();
            this.btnQLMA = new FontAwesome.Sharp.IconButton();
            this.btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlDeskTop = new System.Windows.Forms.Panel();
            this.pnlTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentChild)).BeginInit();
            this.pnlIconNhaHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHome)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDuongKe
            // 
            this.pnlDuongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.pnlDuongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDuongKe.Location = new System.Drawing.Point(270, 69);
            this.pnlDuongKe.Name = "pnlDuongKe";
            this.pnlDuongKe.Size = new System.Drawing.Size(1110, 8);
            this.pnlDuongKe.TabIndex = 17;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(46, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Trang Thông Tin Tài Khoản";
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.pnlTieuDe.Controls.Add(this.btnMinimize);
            this.pnlTieuDe.Controls.Add(this.btnMaximize);
            this.pnlTieuDe.Controls.Add(this.btnThoat);
            this.pnlTieuDe.Controls.Add(this.lblTitle);
            this.pnlTieuDe.Controls.Add(this.pcbCurrentChild);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(270, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(1110, 69);
            this.pnlTieuDe.TabIndex = 16;
            this.pnlTieuDe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(991, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 26);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1031, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(42, 26);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1070, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(41, 26);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pcbCurrentChild
            // 
            this.pcbCurrentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.pcbCurrentChild.IconChar = FontAwesome.Sharp.IconChar.House;
            this.pcbCurrentChild.IconColor = System.Drawing.Color.White;
            this.pcbCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pcbCurrentChild.Location = new System.Drawing.Point(8, 31);
            this.pcbCurrentChild.Name = "pcbCurrentChild";
            this.pcbCurrentChild.Size = new System.Drawing.Size(32, 32);
            this.pcbCurrentChild.TabIndex = 0;
            this.pcbCurrentChild.TabStop = false;
            // 
            // pnlIconNhaHang
            // 
            this.pnlIconNhaHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.pnlIconNhaHang.Controls.Add(this.pcbHome);
            this.pnlIconNhaHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIconNhaHang.Location = new System.Drawing.Point(0, 0);
            this.pnlIconNhaHang.Name = "pnlIconNhaHang";
            this.pnlIconNhaHang.Size = new System.Drawing.Size(270, 137);
            this.pnlIconNhaHang.TabIndex = 0;
            // 
            // pcbHome
            // 
            this.pcbHome.BackgroundImage = global::QuanLyBanHang_GUI.Properties.Resources.BieuTuongNH;
            this.pcbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbHome.Image = global::QuanLyBanHang_GUI.Properties.Resources.BieuTuongNhaHang21;
            this.pcbHome.Location = new System.Drawing.Point(66, 0);
            this.pcbHome.Name = "pcbHome";
            this.pcbHome.Size = new System.Drawing.Size(130, 137);
            this.pcbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbHome.TabIndex = 0;
            this.pcbHome.TabStop = false;
            this.pcbHome.Click += new System.EventHandler(this.pcbHome_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.pnlMenu.Controls.Add(this.btnDangXuat);
            this.pnlMenu.Controls.Add(this.btnNguyenLieu);
            this.pnlMenu.Controls.Add(this.btnQLHoaDon);
            this.pnlMenu.Controls.Add(this.btnQLMA);
            this.pnlMenu.Controls.Add(this.btnTaiKhoan);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 137);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(270, 643);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnDangXuat.IconColor = System.Drawing.Color.White;
            this.btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 240);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(270, 60);
            this.btnDangXuat.TabIndex = 9;
            this.btnDangXuat.Text = "   Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnNguyenLieu
            // 
            this.btnNguyenLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNguyenLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNguyenLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNguyenLieu.FlatAppearance.BorderSize = 0;
            this.btnNguyenLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNguyenLieu.ForeColor = System.Drawing.Color.White;
            this.btnNguyenLieu.IconChar = FontAwesome.Sharp.IconChar.PlateWheat;
            this.btnNguyenLieu.IconColor = System.Drawing.Color.White;
            this.btnNguyenLieu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNguyenLieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNguyenLieu.Location = new System.Drawing.Point(0, 180);
            this.btnNguyenLieu.Margin = new System.Windows.Forms.Padding(0);
            this.btnNguyenLieu.Name = "btnNguyenLieu";
            this.btnNguyenLieu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNguyenLieu.Size = new System.Drawing.Size(270, 60);
            this.btnNguyenLieu.TabIndex = 8;
            this.btnNguyenLieu.Text = "   Nguyên liệu";
            this.btnNguyenLieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNguyenLieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNguyenLieu.UseVisualStyleBackColor = false;
            this.btnNguyenLieu.Click += new System.EventHandler(this.btnNguyenLieu_Click);
            // 
            // btnQLHoaDon
            // 
            this.btnQLHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnQLHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLHoaDon.FlatAppearance.BorderSize = 0;
            this.btnQLHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnQLHoaDon.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btnQLHoaDon.IconColor = System.Drawing.Color.White;
            this.btnQLHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHoaDon.Location = new System.Drawing.Point(0, 120);
            this.btnQLHoaDon.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLHoaDon.Name = "btnQLHoaDon";
            this.btnQLHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnQLHoaDon.Size = new System.Drawing.Size(270, 60);
            this.btnQLHoaDon.TabIndex = 6;
            this.btnQLHoaDon.Text = "   Hóa đơn cần phục vụ";
            this.btnQLHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLHoaDon.UseVisualStyleBackColor = false;
            this.btnQLHoaDon.Click += new System.EventHandler(this.btnQLHoaDon_Click);
            // 
            // btnQLMA
            // 
            this.btnQLMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnQLMA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLMA.FlatAppearance.BorderSize = 0;
            this.btnQLMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLMA.ForeColor = System.Drawing.Color.White;
            this.btnQLMA.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnQLMA.IconColor = System.Drawing.Color.White;
            this.btnQLMA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLMA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLMA.Location = new System.Drawing.Point(0, 60);
            this.btnQLMA.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLMA.Name = "btnQLMA";
            this.btnQLMA.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnQLMA.Size = new System.Drawing.Size(270, 60);
            this.btnQLMA.TabIndex = 5;
            this.btnQLMA.Text = "   Món ăn";
            this.btnQLMA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLMA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLMA.UseVisualStyleBackColor = false;
            this.btnQLMA.Click += new System.EventHandler(this.btnQLMA_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnTaiKhoan.IconColor = System.Drawing.Color.White;
            this.btnTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(270, 60);
            this.btnTaiKhoan.TabIndex = 1;
            this.btnTaiKhoan.Text = "   Thông tin tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click_1);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(65)))));
            this.pnlContainer.Controls.Add(this.pnlMenu);
            this.pnlContainer.Controls.Add(this.pnlIconNhaHang);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(270, 780);
            this.pnlContainer.TabIndex = 15;
            // 
            // pnlDeskTop
            // 
            this.pnlDeskTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeskTop.Location = new System.Drawing.Point(270, 69);
            this.pnlDeskTop.Name = "pnlDeskTop";
            this.pnlDeskTop.Size = new System.Drawing.Size(1110, 711);
            this.pnlDeskTop.TabIndex = 18;
            // 
            // frmTrangNVBep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1380, 780);
            this.Controls.Add(this.pnlDuongKe);
            this.Controls.Add(this.pnlDeskTop);
            this.Controls.Add(this.pnlTieuDe);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTrangNVBep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTrangNVBep";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentChild)).EndInit();
            this.pnlIconNhaHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbHome)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDuongKe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconButton btnNguyenLieu;
        private FontAwesome.Sharp.IconButton btnQLHoaDon;
        private FontAwesome.Sharp.IconButton btnQLMA;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Panel pnlTieuDe;
        private FontAwesome.Sharp.IconPictureBox pcbCurrentChild;
        private System.Windows.Forms.Panel pnlIconNhaHang;
        private System.Windows.Forms.PictureBox pcbHome;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlDeskTop;
    }
}