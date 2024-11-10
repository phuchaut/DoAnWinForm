namespace QuanLyBanHang_GUI.NVThuNgan
{
    partial class frmHoaDonThuNgan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonThuNgan));
            this.btnThanhToan = new FontAwesome.Sharp.IconButton();
            this.btnChiTiet = new FontAwesome.Sharp.IconButton();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.dtpNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnLamMoi = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.txtMaNVLap = new System.Windows.Forms.TextBox();
            this.lblNhanVienLap = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblNgayThanhToan = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.pcbHoaDon = new System.Windows.Forms.PictureBox();
            this.colNgayTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNVLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDSHoaDon = new System.Windows.Forms.DataGridView();
            this.pnlHoaDon = new System.Windows.Forms.Panel();
            this.grbTTHoaDon = new System.Windows.Forms.GroupBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlBills = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).BeginInit();
            this.pnlHoaDon.SuspendLayout();
            this.grbTTHoaDon.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlBills.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnThanhToan.FlatAppearance.BorderSize = 3;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThanhToan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThanhToan.Location = new System.Drawing.Point(24, 447);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(326, 59);
            this.btnThanhToan.TabIndex = 12;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            this.btnThanhToan.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnThanhToan.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiTiet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnChiTiet.FlatAppearance.BorderSize = 2;
            this.btnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnChiTiet.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChiTiet.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnChiTiet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChiTiet.Location = new System.Drawing.Point(191, 388);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(158, 42);
            this.btnChiTiet.TabIndex = 11;
            this.btnChiTiet.Text = "Chi tiết hóa đơn";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            this.btnChiTiet.MouseEnter += new System.EventHandler(this.btnChiTietHD_MouseEnter);
            this.btnChiTiet.MouseLeave += new System.EventHandler(this.btnChiTietHD_MouseLeave);
            // 
            // btnLuu
            // 
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnLuu.FlatAppearance.BorderSize = 2;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnLuu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.IconSize = 32;
            this.btnLuu.Location = new System.Drawing.Point(24, 388);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(145, 42);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "  Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnLuu.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnLuu.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Enabled = false;
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Chưa phục vụ",
            "Đã phục vụ"});
            this.cboTrangThai.Location = new System.Drawing.Point(191, 199);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(158, 28);
            this.cboTrangThai.TabIndex = 4;
            this.cboTrangThai.SelectionChangeCommitted += new System.EventHandler(this.cboTrangThai_SelectedIndexChanged);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(20, 204);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(89, 20);
            this.lblTrangThai.TabIndex = 13;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // dtpNgayThanhToan
            // 
            this.dtpNgayThanhToan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThanhToan.Enabled = false;
            this.dtpNgayThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThanhToan.Location = new System.Drawing.Point(190, 252);
            this.dtpNgayThanhToan.Name = "dtpNgayThanhToan";
            this.dtpNgayThanhToan.Size = new System.Drawing.Size(159, 27);
            this.dtpNgayThanhToan.TabIndex = 5;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Enabled = false;
            this.dtpNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(190, 149);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(159, 27);
            this.dtpNgayLap.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnThem.FlatAppearance.BorderSize = 2;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.Location = new System.Drawing.Point(24, 310);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(55, 55);
            this.btnThem.TabIndex = 6;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnThem.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnSua.FlatAppearance.BorderSize = 2;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnSua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.Location = new System.Drawing.Point(204, 310);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(55, 55);
            this.btnSua.TabIndex = 8;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnSua.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnSua.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 2;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnLamMoi.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnLamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLamMoi.Location = new System.Drawing.Point(294, 310);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(55, 55);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            this.btnLamMoi.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnLamMoi.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnXoa.FlatAppearance.BorderSize = 2;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.Location = new System.Drawing.Point(114, 310);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(55, 55);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnXoa.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // txtMaNVLap
            // 
            this.txtMaNVLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtMaNVLap.Location = new System.Drawing.Point(190, 97);
            this.txtMaNVLap.Name = "txtMaNVLap";
            this.txtMaNVLap.ReadOnly = true;
            this.txtMaNVLap.Size = new System.Drawing.Size(160, 27);
            this.txtMaNVLap.TabIndex = 2;
            // 
            // lblNhanVienLap
            // 
            this.lblNhanVienLap.AutoSize = true;
            this.lblNhanVienLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVienLap.Location = new System.Drawing.Point(20, 100);
            this.lblNhanVienLap.Name = "lblNhanVienLap";
            this.lblNhanVienLap.Size = new System.Drawing.Size(140, 20);
            this.lblNhanVienLap.TabIndex = 4;
            this.lblNhanVienLap.Text = "Mã nhân viên lập:";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtMaHoaDon.Location = new System.Drawing.Point(191, 44);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.ReadOnly = true;
            this.txtMaHoaDon.Size = new System.Drawing.Size(160, 27);
            this.txtMaHoaDon.TabIndex = 1;
            // 
            // lblNgayThanhToan
            // 
            this.lblNgayThanhToan.AutoSize = true;
            this.lblNgayThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThanhToan.Location = new System.Drawing.Point(20, 259);
            this.lblNgayThanhToan.Name = "lblNgayThanhToan";
            this.lblNgayThanhToan.Size = new System.Drawing.Size(135, 20);
            this.lblNgayThanhToan.TabIndex = 0;
            this.lblNgayThanhToan.Text = "Ngày thanh toán:";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLap.Location = new System.Drawing.Point(20, 152);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(79, 20);
            this.lblNgayLap.TabIndex = 0;
            this.lblNgayLap.Text = "Ngày lập:";
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.Location = new System.Drawing.Point(20, 44);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(101, 20);
            this.lblMaHoaDon.TabIndex = 0;
            this.lblMaHoaDon.Text = "Mã hóa đơn:";
            // 
            // pcbHoaDon
            // 
            this.pcbHoaDon.Image = global::QuanLyBanHang_GUI.Properties.Resources.HoaDon;
            this.pcbHoaDon.Location = new System.Drawing.Point(250, 12);
            this.pcbHoaDon.Name = "pcbHoaDon";
            this.pcbHoaDon.Size = new System.Drawing.Size(217, 198);
            this.pcbHoaDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbHoaDon.TabIndex = 0;
            this.pcbHoaDon.TabStop = false;
            // 
            // colNgayTT
            // 
            this.colNgayTT.DataPropertyName = "NgayThanhToan";
            this.colNgayTT.HeaderText = "Ngày thanh toán";
            this.colNgayTT.MinimumWidth = 6;
            this.colNgayTT.Name = "colNgayTT";
            this.colNgayTT.ReadOnly = true;
            this.colNgayTT.Width = 125;
            // 
            // colNgayLap
            // 
            this.colNgayLap.DataPropertyName = "NgayLap";
            this.colNgayLap.HeaderText = "Ngày lập";
            this.colNgayLap.MinimumWidth = 6;
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.ReadOnly = true;
            this.colNgayLap.Width = 125;
            // 
            // colMaNVLap
            // 
            this.colMaNVLap.DataPropertyName = "MaNV";
            this.colMaNVLap.HeaderText = "Mã nhân viên lập";
            this.colMaNVLap.MinimumWidth = 6;
            this.colMaNVLap.Name = "colMaNVLap";
            this.colMaNVLap.ReadOnly = true;
            this.colMaNVLap.Width = 125;
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "MaHoaDon";
            this.colMaHD.HeaderText = "Mã hóa đơn";
            this.colMaHD.MinimumWidth = 6;
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.ReadOnly = true;
            this.colMaHD.Width = 125;
            // 
            // dgvDSHoaDon
            // 
            this.dgvDSHoaDon.AllowUserToResizeRows = false;
            this.dgvDSHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colMaNVLap,
            this.colNgayLap,
            this.colNgayTT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvDSHoaDon.MultiSelect = false;
            this.dgvDSHoaDon.Name = "dgvDSHoaDon";
            this.dgvDSHoaDon.ReadOnly = true;
            this.dgvDSHoaDon.RowHeadersVisible = false;
            this.dgvDSHoaDon.RowHeadersWidth = 51;
            this.dgvDSHoaDon.RowTemplate.Height = 24;
            this.dgvDSHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHoaDon.Size = new System.Drawing.Size(725, 427);
            this.dgvDSHoaDon.TabIndex = 13;
            this.dgvDSHoaDon.SelectionChanged += new System.EventHandler(this.dgvDSHoaDon_SelectionChanged);
            // 
            // pnlHoaDon
            // 
            this.pnlHoaDon.Controls.Add(this.dgvDSHoaDon);
            this.pnlHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHoaDon.Location = new System.Drawing.Point(0, 221);
            this.pnlHoaDon.Name = "pnlHoaDon";
            this.pnlHoaDon.Size = new System.Drawing.Size(725, 439);
            this.pnlHoaDon.TabIndex = 1;
            // 
            // grbTTHoaDon
            // 
            this.grbTTHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTTHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.grbTTHoaDon.Controls.Add(this.btnThanhToan);
            this.grbTTHoaDon.Controls.Add(this.btnChiTiet);
            this.grbTTHoaDon.Controls.Add(this.btnLuu);
            this.grbTTHoaDon.Controls.Add(this.cboTrangThai);
            this.grbTTHoaDon.Controls.Add(this.lblTrangThai);
            this.grbTTHoaDon.Controls.Add(this.dtpNgayThanhToan);
            this.grbTTHoaDon.Controls.Add(this.dtpNgayLap);
            this.grbTTHoaDon.Controls.Add(this.btnThem);
            this.grbTTHoaDon.Controls.Add(this.btnSua);
            this.grbTTHoaDon.Controls.Add(this.btnLamMoi);
            this.grbTTHoaDon.Controls.Add(this.btnXoa);
            this.grbTTHoaDon.Controls.Add(this.txtMaNVLap);
            this.grbTTHoaDon.Controls.Add(this.lblNhanVienLap);
            this.grbTTHoaDon.Controls.Add(this.txtMaHoaDon);
            this.grbTTHoaDon.Controls.Add(this.lblNgayThanhToan);
            this.grbTTHoaDon.Controls.Add(this.lblNgayLap);
            this.grbTTHoaDon.Controls.Add(this.lblMaHoaDon);
            this.grbTTHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.grbTTHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTHoaDon.Location = new System.Drawing.Point(731, 12);
            this.grbTTHoaDon.Name = "grbTTHoaDon";
            this.grbTTHoaDon.Size = new System.Drawing.Size(357, 636);
            this.grbTTHoaDon.TabIndex = 4;
            this.grbTTHoaDon.TabStop = false;
            this.grbTTHoaDon.Text = "Thông tin hóa đơn";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.Controls.Add(this.pnlHoaDon);
            this.pnlContainer.Controls.Add(this.pnlBills);
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(725, 660);
            this.pnlContainer.TabIndex = 3;
            // 
            // pnlBills
            // 
            this.pnlBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(224)))), ((int)(((byte)(221)))));
            this.pnlBills.Controls.Add(this.pcbHoaDon);
            this.pnlBills.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBills.Location = new System.Drawing.Point(0, 0);
            this.pnlBills.Name = "pnlBills";
            this.pnlBills.Size = new System.Drawing.Size(725, 221);
            this.pnlBills.TabIndex = 0;
            // 
            // frmHoaDonThuNgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.grbTTHoaDon);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHoaDonThuNgan";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDonThuNgan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).EndInit();
            this.pnlHoaDon.ResumeLayout(false);
            this.grbTTHoaDon.ResumeLayout(false);
            this.grbTTHoaDon.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlBills.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnThanhToan;
        private FontAwesome.Sharp.IconButton btnChiTiet;
        private FontAwesome.Sharp.IconButton btnLuu;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.DateTimePicker dtpNgayThanhToan;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private FontAwesome.Sharp.IconButton btnXoa;
        private System.Windows.Forms.TextBox txtMaNVLap;
        private System.Windows.Forms.Label lblNhanVienLap;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblNgayThanhToan;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.PictureBox pcbHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNVLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridView dgvDSHoaDon;
        private System.Windows.Forms.Panel pnlHoaDon;
        private System.Windows.Forms.GroupBox grbTTHoaDon;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlBills;
    }
}