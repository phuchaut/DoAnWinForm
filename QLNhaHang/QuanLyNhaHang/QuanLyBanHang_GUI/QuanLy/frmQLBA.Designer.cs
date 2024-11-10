namespace QuanLyBanHang_GUI
{
    partial class frmQLBA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLBA));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pcbBan = new System.Windows.Forms.PictureBox();
            this.dgvDSBan = new System.Windows.Forms.DataGridView();
            this.colMaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLChoNgoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSoLuongCho = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.nudSoLuongChoNgoi = new System.Windows.Forms.NumericUpDown();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.lblMaBan = new System.Windows.Forms.Label();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnLamMoi = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBan)).BeginInit();
            this.grbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongChoNgoi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(224)))), ((int)(((byte)(221)))));
            this.pnlContainer.Controls.Add(this.pcbBan);
            this.pnlContainer.Controls.Add(this.dgvDSBan);
            this.pnlContainer.Location = new System.Drawing.Point(3, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(684, 660);
            this.pnlContainer.TabIndex = 1;
            // 
            // pcbBan
            // 
            this.pcbBan.Image = global::QuanLyBanHang_GUI.Properties.Resources.Ban;
            this.pcbBan.Location = new System.Drawing.Point(207, 0);
            this.pcbBan.Name = "pcbBan";
            this.pcbBan.Size = new System.Drawing.Size(265, 154);
            this.pcbBan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBan.TabIndex = 12;
            this.pcbBan.TabStop = false;
            // 
            // dgvDSBan
            // 
            this.dgvDSBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBan,
            this.colTrangThai,
            this.colSLChoNgoi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSBan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSBan.Location = new System.Drawing.Point(2, 160);
            this.dgvDSBan.MultiSelect = false;
            this.dgvDSBan.Name = "dgvDSBan";
            this.dgvDSBan.ReadOnly = true;
            this.dgvDSBan.RowHeadersVisible = false;
            this.dgvDSBan.RowHeadersWidth = 51;
            this.dgvDSBan.RowTemplate.Height = 24;
            this.dgvDSBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSBan.Size = new System.Drawing.Size(682, 494);
            this.dgvDSBan.TabIndex = 9;
            this.dgvDSBan.SelectionChanged += new System.EventHandler(this.dgvDSBan_SelectionChanged);
            // 
            // colMaBan
            // 
            this.colMaBan.DataPropertyName = "MaBanAn";
            this.colMaBan.HeaderText = "Ma Ban";
            this.colMaBan.MinimumWidth = 6;
            this.colMaBan.Name = "colMaBan";
            this.colMaBan.ReadOnly = true;
            this.colMaBan.Width = 125;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trang Thai";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Width = 125;
            // 
            // colSLChoNgoi
            // 
            this.colSLChoNgoi.DataPropertyName = "SoChoNgoi";
            this.colSLChoNgoi.HeaderText = "So Luong";
            this.colSLChoNgoi.MinimumWidth = 6;
            this.colSLChoNgoi.Name = "colSLChoNgoi";
            this.colSLChoNgoi.ReadOnly = true;
            this.colSLChoNgoi.Width = 125;
            // 
            // lblSoLuongCho
            // 
            this.lblSoLuongCho.AutoSize = true;
            this.lblSoLuongCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongCho.Location = new System.Drawing.Point(15, 87);
            this.lblSoLuongCho.Name = "lblSoLuongCho";
            this.lblSoLuongCho.Size = new System.Drawing.Size(147, 20);
            this.lblSoLuongCho.TabIndex = 3;
            this.lblSoLuongCho.Text = "Số lượng chỗ ngồi:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(15, 131);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(89, 20);
            this.lblTrangThai.TabIndex = 4;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChiTiet.Controls.Add(this.nudSoLuongChoNgoi);
            this.grbChiTiet.Controls.Add(this.cboTrangThai);
            this.grbChiTiet.Controls.Add(this.btnLuu);
            this.grbChiTiet.Controls.Add(this.btnThem);
            this.grbChiTiet.Controls.Add(this.lblMaBan);
            this.grbChiTiet.Controls.Add(this.btnSua);
            this.grbChiTiet.Controls.Add(this.btnLamMoi);
            this.grbChiTiet.Controls.Add(this.btnXoa);
            this.grbChiTiet.Controls.Add(this.lblSoLuongCho);
            this.grbChiTiet.Controls.Add(this.lblTrangThai);
            this.grbChiTiet.Controls.Add(this.txtMaBan);
            this.grbChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.grbChiTiet.Location = new System.Drawing.Point(702, 12);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(386, 611);
            this.grbChiTiet.TabIndex = 6;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Thông tin chi tiết";
            // 
            // nudSoLuongChoNgoi
            // 
            this.nudSoLuongChoNgoi.Enabled = false;
            this.nudSoLuongChoNgoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.nudSoLuongChoNgoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.nudSoLuongChoNgoi.Location = new System.Drawing.Point(180, 83);
            this.nudSoLuongChoNgoi.Name = "nudSoLuongChoNgoi";
            this.nudSoLuongChoNgoi.Size = new System.Drawing.Size(188, 27);
            this.nudSoLuongChoNgoi.TabIndex = 2;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Enabled = false;
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Đã Được Đặt",
            "Còn Trống"});
            this.cboTrangThai.Location = new System.Drawing.Point(180, 126);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(188, 28);
            this.cboTrangThai.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnLuu.FlatAppearance.BorderSize = 2;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnLuu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.IconSize = 40;
            this.btnLuu.Location = new System.Drawing.Point(216, 256);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(153, 55);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "  Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnLuu.MouseEnter += new System.EventHandler(this.btnLuu_MouseEnter);
            this.btnLuu.MouseLeave += new System.EventHandler(this.btnLuu_MouseLeave);
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
            this.btnThem.IconSize = 40;
            this.btnThem.Location = new System.Drawing.Point(20, 179);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(55, 55);
            this.btnThem.TabIndex = 4;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnThem.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // lblMaBan
            // 
            this.lblMaBan.AutoSize = true;
            this.lblMaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBan.Location = new System.Drawing.Point(15, 43);
            this.lblMaBan.Name = "lblMaBan";
            this.lblMaBan.Size = new System.Drawing.Size(69, 20);
            this.lblMaBan.TabIndex = 8;
            this.lblMaBan.Text = "Mã bàn:";
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
            this.btnSua.IconSize = 40;
            this.btnSua.Location = new System.Drawing.Point(216, 179);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(55, 55);
            this.btnSua.TabIndex = 6;
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
            this.btnLamMoi.IconSize = 40;
            this.btnLamMoi.Location = new System.Drawing.Point(314, 179);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(55, 55);
            this.btnLamMoi.TabIndex = 7;
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
            this.btnXoa.IconSize = 40;
            this.btnXoa.Location = new System.Drawing.Point(118, 179);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(55, 55);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnXoa.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // txtMaBan
            // 
            this.txtMaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtMaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.txtMaBan.Location = new System.Drawing.Point(180, 40);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.ReadOnly = true;
            this.txtMaBan.Size = new System.Drawing.Size(188, 27);
            this.txtMaBan.TabIndex = 1;
            // 
            // frmQLBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLBA";
            this.Text = "frmQLBA";
            this.Load += new System.EventHandler(this.frmQLBA_Load);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBan)).EndInit();
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongChoNgoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblSoLuongCho;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.Label lblMaBan;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.DataGridView dgvDSBan;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private FontAwesome.Sharp.IconButton btnXoa;
        private System.Windows.Forms.PictureBox pcbBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLChoNgoi;
        private FontAwesome.Sharp.IconButton btnLuu;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.NumericUpDown nudSoLuongChoNgoi;
    }
}