namespace QuanLyBanHang_GUI
{
    partial class frmQLMA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLMA));
            this.dgvDSMonAn = new System.Windows.Forms.DataGridView();
            this.colMaMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.cboDSNguyenLieu = new System.Windows.Forms.ComboBox();
            this.nudSoLuongNL = new System.Windows.Forms.NumericUpDown();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.nudDonGia = new System.Windows.Forms.NumericUpDown();
            this.pcbMonAn = new System.Windows.Forms.PictureBox();
            this.cboLoaiMonAn = new System.Windows.Forms.ComboBox();
            this.txtMaMonAn = new System.Windows.Forms.TextBox();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblTenNguyenLieu = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblLoaiMonAn = new System.Windows.Forms.Label();
            this.lblTenMonAn = new System.Windows.Forms.Label();
            this.lblMaMonAn = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnLamMoi = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonAn)).BeginInit();
            this.grbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMonAn)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSMonAn
            // 
            this.dgvDSMonAn.AllowUserToResizeRows = false;
            this.dgvDSMonAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMA,
            this.colTenMA,
            this.colLoaiMA,
            this.colDonGia,
            this.colTenNguyenLieu,
            this.colSoLuongNguyenLieu});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSMonAn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSMonAn.Location = new System.Drawing.Point(3, 3);
            this.dgvDSMonAn.MultiSelect = false;
            this.dgvDSMonAn.Name = "dgvDSMonAn";
            this.dgvDSMonAn.ReadOnly = true;
            this.dgvDSMonAn.RowHeadersVisible = false;
            this.dgvDSMonAn.RowHeadersWidth = 51;
            this.dgvDSMonAn.RowTemplate.Height = 24;
            this.dgvDSMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSMonAn.Size = new System.Drawing.Size(723, 551);
            this.dgvDSMonAn.TabIndex = 13;
            this.dgvDSMonAn.SelectionChanged += new System.EventHandler(this.dgvDSMonAn_SelectionChanged);
            // 
            // colMaMA
            // 
            this.colMaMA.DataPropertyName = "MaMonAn";
            this.colMaMA.HeaderText = "Mã món ăn";
            this.colMaMA.MinimumWidth = 6;
            this.colMaMA.Name = "colMaMA";
            this.colMaMA.ReadOnly = true;
            this.colMaMA.Width = 125;
            // 
            // colTenMA
            // 
            this.colTenMA.DataPropertyName = "TenMonAn";
            this.colTenMA.HeaderText = "Tên món ăn";
            this.colTenMA.MinimumWidth = 6;
            this.colTenMA.Name = "colTenMA";
            this.colTenMA.ReadOnly = true;
            this.colTenMA.Width = 125;
            // 
            // colLoaiMA
            // 
            this.colLoaiMA.DataPropertyName = "TenLoaiMonAn";
            this.colLoaiMA.HeaderText = "Loại món ăn";
            this.colLoaiMA.MinimumWidth = 6;
            this.colLoaiMA.Name = "colLoaiMA";
            this.colLoaiMA.ReadOnly = true;
            this.colLoaiMA.Width = 125;
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            this.colDonGia.Width = 125;
            // 
            // colTenNguyenLieu
            // 
            this.colTenNguyenLieu.DataPropertyName = "TenNguyenLieu";
            this.colTenNguyenLieu.HeaderText = "Tên nguyên liệu";
            this.colTenNguyenLieu.MinimumWidth = 6;
            this.colTenNguyenLieu.Name = "colTenNguyenLieu";
            this.colTenNguyenLieu.ReadOnly = true;
            this.colTenNguyenLieu.Width = 125;
            // 
            // colSoLuongNguyenLieu
            // 
            this.colSoLuongNguyenLieu.DataPropertyName = "SoLuongNguyenLieu";
            this.colSoLuongNguyenLieu.HeaderText = "Số lượng nguyên liệu";
            this.colSoLuongNguyenLieu.MinimumWidth = 6;
            this.colSoLuongNguyenLieu.Name = "colSoLuongNguyenLieu";
            this.colSoLuongNguyenLieu.ReadOnly = true;
            this.colSoLuongNguyenLieu.Width = 125;
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChiTiet.Controls.Add(this.btnTimKiem);
            this.grbChiTiet.Controls.Add(this.cboDSNguyenLieu);
            this.grbChiTiet.Controls.Add(this.nudSoLuongNL);
            this.grbChiTiet.Controls.Add(this.cboTrangThai);
            this.grbChiTiet.Controls.Add(this.lblTrangThai);
            this.grbChiTiet.Controls.Add(this.nudDonGia);
            this.grbChiTiet.Controls.Add(this.pcbMonAn);
            this.grbChiTiet.Controls.Add(this.cboLoaiMonAn);
            this.grbChiTiet.Controls.Add(this.txtMaMonAn);
            this.grbChiTiet.Controls.Add(this.txtTenMonAn);
            this.grbChiTiet.Controls.Add(this.lblMoTa);
            this.grbChiTiet.Controls.Add(this.lblTenNguyenLieu);
            this.grbChiTiet.Controls.Add(this.lblDonGia);
            this.grbChiTiet.Controls.Add(this.lblLoaiMonAn);
            this.grbChiTiet.Controls.Add(this.lblTenMonAn);
            this.grbChiTiet.Controls.Add(this.lblMaMonAn);
            this.grbChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.grbChiTiet.Location = new System.Drawing.Point(738, 30);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(356, 630);
            this.grbChiTiet.TabIndex = 3;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Chi tiết món ăn:";
            // 
            // cboDSNguyenLieu
            // 
            this.cboDSNguyenLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDSNguyenLieu.Enabled = false;
            this.cboDSNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cboDSNguyenLieu.FormattingEnabled = true;
            this.cboDSNguyenLieu.Items.AddRange(new object[] {
            ""});
            this.cboDSNguyenLieu.Location = new System.Drawing.Point(158, 272);
            this.cboDSNguyenLieu.Name = "cboDSNguyenLieu";
            this.cboDSNguyenLieu.Size = new System.Drawing.Size(195, 28);
            this.cboDSNguyenLieu.TabIndex = 6;
            // 
            // nudSoLuongNL
            // 
            this.nudSoLuongNL.Enabled = false;
            this.nudSoLuongNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.nudSoLuongNL.Location = new System.Drawing.Point(201, 326);
            this.nudSoLuongNL.Name = "nudSoLuongNL";
            this.nudSoLuongNL.Size = new System.Drawing.Size(152, 27);
            this.nudSoLuongNL.TabIndex = 7;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Enabled = false;
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Hết",
            "Còn"});
            this.cboTrangThai.Location = new System.Drawing.Point(158, 223);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(195, 28);
            this.cboTrangThai.TabIndex = 5;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(10, 229);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(89, 20);
            this.lblTrangThai.TabIndex = 9;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // nudDonGia
            // 
            this.nudDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDonGia.Enabled = false;
            this.nudDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.nudDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.nudDonGia.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudDonGia.Location = new System.Drawing.Point(158, 175);
            this.nudDonGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudDonGia.Name = "nudDonGia";
            this.nudDonGia.Size = new System.Drawing.Size(195, 27);
            this.nudDonGia.TabIndex = 4;
            // 
            // pcbMonAn
            // 
            this.pcbMonAn.Image = global::QuanLyBanHang_GUI.Properties.Resources.MonAn;
            this.pcbMonAn.Location = new System.Drawing.Point(3, 409);
            this.pcbMonAn.Name = "pcbMonAn";
            this.pcbMonAn.Size = new System.Drawing.Size(350, 208);
            this.pcbMonAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMonAn.TabIndex = 0;
            this.pcbMonAn.TabStop = false;
            // 
            // cboLoaiMonAn
            // 
            this.cboLoaiMonAn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboLoaiMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiMonAn.Enabled = false;
            this.cboLoaiMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cboLoaiMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.cboLoaiMonAn.FormattingEnabled = true;
            this.cboLoaiMonAn.Items.AddRange(new object[] {
            "Món Hấp Xào",
            "Món Nóng",
            "Món Nướng",
            "Món Chiên",
            "Món Tráng Miệng",
            "Món Uống"});
            this.cboLoaiMonAn.Location = new System.Drawing.Point(158, 126);
            this.cboLoaiMonAn.Name = "cboLoaiMonAn";
            this.cboLoaiMonAn.Size = new System.Drawing.Size(195, 28);
            this.cboLoaiMonAn.TabIndex = 3;
            // 
            // txtMaMonAn
            // 
            this.txtMaMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtMaMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.txtMaMonAn.Location = new System.Drawing.Point(158, 26);
            this.txtMaMonAn.Name = "txtMaMonAn";
            this.txtMaMonAn.ReadOnly = true;
            this.txtMaMonAn.Size = new System.Drawing.Size(195, 27);
            this.txtMaMonAn.TabIndex = 1;
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtTenMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.txtTenMonAn.Location = new System.Drawing.Point(158, 78);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.ReadOnly = true;
            this.txtTenMonAn.Size = new System.Drawing.Size(148, 27);
            this.txtTenMonAn.TabIndex = 2;
            this.txtTenMonAn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChiNhapChu);
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(10, 331);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(168, 20);
            this.lblMoTa.TabIndex = 2;
            this.lblMoTa.Text = "Số lượng nguyên liệu:";
            // 
            // lblTenNguyenLieu
            // 
            this.lblTenNguyenLieu.AutoSize = true;
            this.lblTenNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguyenLieu.Location = new System.Drawing.Point(10, 277);
            this.lblTenNguyenLieu.Name = "lblTenNguyenLieu";
            this.lblTenNguyenLieu.Size = new System.Drawing.Size(131, 20);
            this.lblTenNguyenLieu.TabIndex = 2;
            this.lblTenNguyenLieu.Text = "Tên nguyên liệu:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(10, 181);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(71, 20);
            this.lblDonGia.TabIndex = 2;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblLoaiMonAn
            // 
            this.lblLoaiMonAn.AutoSize = true;
            this.lblLoaiMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiMonAn.Location = new System.Drawing.Point(10, 134);
            this.lblLoaiMonAn.Name = "lblLoaiMonAn";
            this.lblLoaiMonAn.Size = new System.Drawing.Size(106, 20);
            this.lblLoaiMonAn.TabIndex = 2;
            this.lblLoaiMonAn.Text = "Loại món ăn:";
            // 
            // lblTenMonAn
            // 
            this.lblTenMonAn.AutoSize = true;
            this.lblTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMonAn.Location = new System.Drawing.Point(10, 85);
            this.lblTenMonAn.Name = "lblTenMonAn";
            this.lblTenMonAn.Size = new System.Drawing.Size(102, 20);
            this.lblTenMonAn.TabIndex = 2;
            this.lblTenMonAn.Text = "Tên món ăn:";
            // 
            // lblMaMonAn
            // 
            this.lblMaMonAn.AutoSize = true;
            this.lblMaMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMonAn.Location = new System.Drawing.Point(10, 37);
            this.lblMaMonAn.Name = "lblMaMonAn";
            this.lblMaMonAn.Size = new System.Drawing.Size(97, 20);
            this.lblMaMonAn.TabIndex = 2;
            this.lblMaMonAn.Text = "Mã món ăn:";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlContainer.Controls.Add(this.btnLuu);
            this.pnlContainer.Controls.Add(this.btnThem);
            this.pnlContainer.Controls.Add(this.btnSua);
            this.pnlContainer.Controls.Add(this.dgvDSMonAn);
            this.pnlContainer.Controls.Add(this.btnLamMoi);
            this.pnlContainer.Controls.Add(this.btnXoa);
            this.pnlContainer.Location = new System.Drawing.Point(3, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(729, 660);
            this.pnlContainer.TabIndex = 4;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnLuu.FlatAppearance.BorderSize = 2;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnLuu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.IconSize = 40;
            this.btnLuu.Location = new System.Drawing.Point(578, 576);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(128, 55);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnLuu.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnLuu.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnThem.FlatAppearance.BorderSize = 2;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 40;
            this.btnThem.Location = new System.Drawing.Point(192, 576);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(55, 55);
            this.btnThem.TabIndex = 8;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnThem.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnSua.FlatAppearance.BorderSize = 2;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnSua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 40;
            this.btnSua.Location = new System.Drawing.Point(372, 576);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(55, 55);
            this.btnSua.TabIndex = 10;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnSua.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnSua.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 2;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnLamMoi.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnLamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLamMoi.IconSize = 40;
            this.btnLamMoi.Location = new System.Drawing.Point(462, 576);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(55, 55);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            this.btnLamMoi.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnLamMoi.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnXoa.FlatAppearance.BorderSize = 2;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 40;
            this.btnXoa.Location = new System.Drawing.Point(282, 576);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(55, 55);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnXoa.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimKiem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 25;
            this.btnTimKiem.Location = new System.Drawing.Point(312, 75);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(41, 25);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            this.btnTimKiem.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnTimKiem.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // frmQLMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.grbChiTiet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLMA";
            this.Text = "frmQLMA";
            this.Load += new System.EventHandler(this.frmQLMA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonAn)).EndInit();
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMonAn)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDSMonAn;
        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblTenNguyenLieu;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblLoaiMonAn;
        private System.Windows.Forms.Label lblTenMonAn;
        private System.Windows.Forms.Label lblMaMonAn;
        private System.Windows.Forms.TextBox txtMaMonAn;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private System.Windows.Forms.ComboBox cboLoaiMonAn;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.PictureBox pcbMonAn;
        private System.Windows.Forms.NumericUpDown nudDonGia;
        private FontAwesome.Sharp.IconButton btnLuu;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.NumericUpDown nudSoLuongNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongNguyenLieu;
        private System.Windows.Forms.ComboBox cboDSNguyenLieu;
        private FontAwesome.Sharp.IconButton btnTimKiem;
    }
}