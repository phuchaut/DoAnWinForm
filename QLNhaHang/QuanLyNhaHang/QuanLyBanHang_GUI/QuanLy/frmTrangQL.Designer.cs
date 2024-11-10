namespace QuanLyBanHang_GUI
{
    partial class frmTrangQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangQL));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.btnKhachHang = new FontAwesome.Sharp.IconButton();
            this.btnLichLamViec = new FontAwesome.Sharp.IconButton();
            this.btnNguyenLieu = new FontAwesome.Sharp.IconButton();
            this.btnDoanhThu = new FontAwesome.Sharp.IconButton();
            this.btnQLHoaDon = new FontAwesome.Sharp.IconButton();
            this.btnQLMA = new FontAwesome.Sharp.IconButton();
            this.btnQLBA = new FontAwesome.Sharp.IconButton();
            this.btnQLNV = new FontAwesome.Sharp.IconButton();
            this.btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.pnlIconNhaHang = new System.Windows.Forms.Panel();
            this.pcbHome = new System.Windows.Forms.PictureBox();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pcbCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.pnlDeskTop = new System.Windows.Forms.Panel();
            this.pnlContainer.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlIconNhaHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHome)).BeginInit();
            this.pnlTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentChild)).BeginInit();
            this.SuspendLayout();
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
            this.pnlContainer.TabIndex = 11;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.pnlMenu.Controls.Add(this.btnDangXuat);
            this.pnlMenu.Controls.Add(this.btnKhachHang);
            this.pnlMenu.Controls.Add(this.btnLichLamViec);
            this.pnlMenu.Controls.Add(this.btnNguyenLieu);
            this.pnlMenu.Controls.Add(this.btnDoanhThu);
            this.pnlMenu.Controls.Add(this.btnQLHoaDon);
            this.pnlMenu.Controls.Add(this.btnQLMA);
            this.pnlMenu.Controls.Add(this.btnQLBA);
            this.pnlMenu.Controls.Add(this.btnQLNV);
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
            this.btnDangXuat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnDangXuat.IconColor = System.Drawing.Color.White;
            this.btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 540);
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
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnKhachHang.IconColor = System.Drawing.Color.White;
            this.btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 480);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(0);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(270, 60);
            this.btnKhachHang.TabIndex = 8;
            this.btnKhachHang.Text = "   Khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnLichLamViec
            // 
            this.btnLichLamViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnLichLamViec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLichLamViec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLichLamViec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichLamViec.FlatAppearance.BorderSize = 0;
            this.btnLichLamViec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichLamViec.ForeColor = System.Drawing.Color.White;
            this.btnLichLamViec.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.btnLichLamViec.IconColor = System.Drawing.Color.White;
            this.btnLichLamViec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLichLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichLamViec.Location = new System.Drawing.Point(0, 420);
            this.btnLichLamViec.Margin = new System.Windows.Forms.Padding(0);
            this.btnLichLamViec.Name = "btnLichLamViec";
            this.btnLichLamViec.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLichLamViec.Size = new System.Drawing.Size(270, 60);
            this.btnLichLamViec.TabIndex = 10;
            this.btnLichLamViec.Text = "   Lịch làm việc";
            this.btnLichLamViec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichLamViec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLichLamViec.UseVisualStyleBackColor = false;
            this.btnLichLamViec.Click += new System.EventHandler(this.btnLichLamViec_Click);
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
            this.btnNguyenLieu.Location = new System.Drawing.Point(0, 360);
            this.btnNguyenLieu.Margin = new System.Windows.Forms.Padding(0);
            this.btnNguyenLieu.Name = "btnNguyenLieu";
            this.btnNguyenLieu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNguyenLieu.Size = new System.Drawing.Size(270, 60);
            this.btnNguyenLieu.TabIndex = 7;
            this.btnNguyenLieu.Text = "   Nguyên liệu";
            this.btnNguyenLieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNguyenLieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNguyenLieu.UseVisualStyleBackColor = false;
            this.btnNguyenLieu.Click += new System.EventHandler(this.btnNguyenLieu_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnDoanhThu.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnDoanhThu.IconColor = System.Drawing.Color.White;
            this.btnDoanhThu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoanhThu.Location = new System.Drawing.Point(0, 300);
            this.btnDoanhThu.Margin = new System.Windows.Forms.Padding(0);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDoanhThu.Size = new System.Drawing.Size(270, 60);
            this.btnDoanhThu.TabIndex = 6;
            this.btnDoanhThu.Text = "   Doanh thu";
            this.btnDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoanhThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnQLHoaDon
            // 
            this.btnQLHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnQLHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLHoaDon.FlatAppearance.BorderSize = 0;
            this.btnQLHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnQLHoaDon.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnQLHoaDon.IconColor = System.Drawing.Color.White;
            this.btnQLHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHoaDon.Location = new System.Drawing.Point(0, 240);
            this.btnQLHoaDon.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLHoaDon.Name = "btnQLHoaDon";
            this.btnQLHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnQLHoaDon.Size = new System.Drawing.Size(270, 60);
            this.btnQLHoaDon.TabIndex = 5;
            this.btnQLHoaDon.Text = "   Hóa đơn";
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
            this.btnQLMA.Location = new System.Drawing.Point(0, 180);
            this.btnQLMA.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLMA.Name = "btnQLMA";
            this.btnQLMA.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnQLMA.Size = new System.Drawing.Size(270, 60);
            this.btnQLMA.TabIndex = 4;
            this.btnQLMA.Text = "   Quản lý món ăn";
            this.btnQLMA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLMA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLMA.UseVisualStyleBackColor = false;
            this.btnQLMA.Click += new System.EventHandler(this.btnQLMA_Click);
            // 
            // btnQLBA
            // 
            this.btnQLBA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnQLBA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLBA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLBA.FlatAppearance.BorderSize = 0;
            this.btnQLBA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLBA.ForeColor = System.Drawing.Color.White;
            this.btnQLBA.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnQLBA.IconColor = System.Drawing.Color.White;
            this.btnQLBA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLBA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLBA.Location = new System.Drawing.Point(0, 120);
            this.btnQLBA.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLBA.Name = "btnQLBA";
            this.btnQLBA.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnQLBA.Size = new System.Drawing.Size(270, 60);
            this.btnQLBA.TabIndex = 3;
            this.btnQLBA.Text = "   Quản lý bàn ăn";
            this.btnQLBA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLBA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLBA.UseVisualStyleBackColor = false;
            this.btnQLBA.Click += new System.EventHandler(this.btnQLBA_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnQLNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNV.FlatAppearance.BorderSize = 0;
            this.btnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNV.ForeColor = System.Drawing.Color.White;
            this.btnQLNV.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnQLNV.IconColor = System.Drawing.Color.White;
            this.btnQLNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.Location = new System.Drawing.Point(0, 60);
            this.btnQLNV.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnQLNV.Size = new System.Drawing.Size(270, 60);
            this.btnQLNV.TabIndex = 2;
            this.btnQLNV.Text = "   Quản lý nhân viên";
            this.btnQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNV.UseVisualStyleBackColor = false;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
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
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
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
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.pnlTieuDe.Controls.Add(this.btnMinimize);
            this.pnlTieuDe.Controls.Add(this.btnMaximize);
            this.pnlTieuDe.Controls.Add(this.btnThoat);
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Controls.Add(this.pcbCurrentChild);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(270, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(1110, 69);
            this.pnlTieuDe.TabIndex = 12;
            this.pnlTieuDe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(989, 0);
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
            this.btnMaximize.Location = new System.Drawing.Point(1029, 0);
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
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(46, 37);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(120, 20);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Trang Quản Lý";
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
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.pnlLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine.Location = new System.Drawing.Point(270, 69);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(1110, 8);
            this.pnlLine.TabIndex = 13;
            // 
            // pnlDeskTop
            // 
            this.pnlDeskTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeskTop.Location = new System.Drawing.Point(270, 77);
            this.pnlDeskTop.Name = "pnlDeskTop";
            this.pnlDeskTop.Size = new System.Drawing.Size(1110, 703);
            this.pnlDeskTop.TabIndex = 14;
            this.pnlDeskTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // frmTrangQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1380, 780);
            this.Controls.Add(this.pnlDeskTop);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.pnlTieuDe);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTrangQL";
            this.Text = "Quản Lý Nhà Hàng";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlIconNhaHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbHome)).EndInit();
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentChild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlIconNhaHang;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconButton btnNguyenLieu;
        private FontAwesome.Sharp.IconButton btnDoanhThu;
        private FontAwesome.Sharp.IconButton btnQLHoaDon;
        private FontAwesome.Sharp.IconButton btnQLMA;
        private FontAwesome.Sharp.IconButton btnQLBA;
        private FontAwesome.Sharp.IconButton btnQLNV;
        private System.Windows.Forms.PictureBox pcbHome;
        private System.Windows.Forms.Panel pnlTieuDe;
        private FontAwesome.Sharp.IconPictureBox pcbCurrentChild;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Panel pnlDeskTop;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnThoat;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private FontAwesome.Sharp.IconButton btnKhachHang;
        private FontAwesome.Sharp.IconButton btnLichLamViec;
    }
}

