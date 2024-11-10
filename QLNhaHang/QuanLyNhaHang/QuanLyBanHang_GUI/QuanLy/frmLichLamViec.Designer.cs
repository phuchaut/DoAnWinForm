namespace QuanLyBanHang_GUI.QuanLy
{
    partial class frmLichLamViec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCa = new System.Windows.Forms.TextBox();
            this.txtThu = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenNguyenLieu = new System.Windows.Forms.Label();
            this.lblMaNguyenLieu = new System.Windows.Forms.Label();
            this.dgvLichLamViec = new System.Windows.Forms.DataGridView();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnLamMoi = new FontAwesome.Sharp.IconButton();
            this.pcbNguyenLieu = new System.Windows.Forms.PictureBox();
            this.cboDSNV = new System.Windows.Forms.ComboBox();
            this.colThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).BeginInit();
            this.grbChiTiet.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCa
            // 
            this.txtCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCa.Location = new System.Drawing.Point(168, 88);
            this.txtCa.Name = "txtCa";
            this.txtCa.ReadOnly = true;
            this.txtCa.Size = new System.Drawing.Size(154, 27);
            this.txtCa.TabIndex = 1;
            // 
            // txtThu
            // 
            this.txtThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThu.Location = new System.Drawing.Point(168, 34);
            this.txtThu.Name = "txtThu";
            this.txtThu.ReadOnly = true;
            this.txtThu.Size = new System.Drawing.Size(154, 27);
            this.txtThu.TabIndex = 1;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(17, 148);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(116, 20);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Mã Nhân viên:";
            // 
            // lblTenNguyenLieu
            // 
            this.lblTenNguyenLieu.AutoSize = true;
            this.lblTenNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguyenLieu.Location = new System.Drawing.Point(17, 94);
            this.lblTenNguyenLieu.Name = "lblTenNguyenLieu";
            this.lblTenNguyenLieu.Size = new System.Drawing.Size(35, 20);
            this.lblTenNguyenLieu.TabIndex = 0;
            this.lblTenNguyenLieu.Text = "Ca:";
            // 
            // lblMaNguyenLieu
            // 
            this.lblMaNguyenLieu.AutoSize = true;
            this.lblMaNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNguyenLieu.Location = new System.Drawing.Point(17, 40);
            this.lblMaNguyenLieu.Name = "lblMaNguyenLieu";
            this.lblMaNguyenLieu.Size = new System.Drawing.Size(42, 20);
            this.lblMaNguyenLieu.TabIndex = 0;
            this.lblMaNguyenLieu.Text = "Thứ:";
            // 
            // dgvLichLamViec
            // 
            this.dgvLichLamViec.AllowUserToResizeRows = false;
            this.dgvLichLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLichLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichLamViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichLamViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThu,
            this.colCa,
            this.colMaNV,
            this.colLoaiNhanVien});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichLamViec.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvLichLamViec.Location = new System.Drawing.Point(3, 182);
            this.dgvLichLamViec.MultiSelect = false;
            this.dgvLichLamViec.Name = "dgvLichLamViec";
            this.dgvLichLamViec.ReadOnly = true;
            this.dgvLichLamViec.RowHeadersVisible = false;
            this.dgvLichLamViec.RowHeadersWidth = 51;
            this.dgvLichLamViec.RowTemplate.Height = 24;
            this.dgvLichLamViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichLamViec.Size = new System.Drawing.Size(722, 466);
            this.dgvLichLamViec.TabIndex = 8;
            this.dgvLichLamViec.SelectionChanged += new System.EventHandler(this.dgvLichLamViec_SelectionChanged);
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChiTiet.Controls.Add(this.btnLuu);
            this.grbChiTiet.Controls.Add(this.cboDSNV);
            this.grbChiTiet.Controls.Add(this.btnSua);
            this.grbChiTiet.Controls.Add(this.btnLamMoi);
            this.grbChiTiet.Controls.Add(this.txtCa);
            this.grbChiTiet.Controls.Add(this.txtThu);
            this.grbChiTiet.Controls.Add(this.lblSoLuong);
            this.grbChiTiet.Controls.Add(this.lblTenNguyenLieu);
            this.grbChiTiet.Controls.Add(this.lblMaNguyenLieu);
            this.grbChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChiTiet.Location = new System.Drawing.Point(740, 33);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(348, 558);
            this.grbChiTiet.TabIndex = 13;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Thông tin chi tiết";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(224)))), ((int)(((byte)(221)))));
            this.pnlContainer.Controls.Add(this.pcbNguyenLieu);
            this.pnlContainer.Controls.Add(this.dgvLichLamViec);
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(725, 660);
            this.pnlContainer.TabIndex = 12;
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnSua.FlatAppearance.BorderSize = 2;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnSua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 40;
            this.btnSua.Location = new System.Drawing.Point(21, 202);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(147, 55);
            this.btnSua.TabIndex = 5;
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
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnLamMoi.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnLamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLamMoi.IconSize = 40;
            this.btnLamMoi.Location = new System.Drawing.Point(185, 202);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(138, 55);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            this.btnLamMoi.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnLamMoi.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // pcbNguyenLieu
            // 
            this.pcbNguyenLieu.Image = global::QuanLyBanHang_GUI.Properties.Resources.LichLamVienc;
            this.pcbNguyenLieu.Location = new System.Drawing.Point(0, 0);
            this.pcbNguyenLieu.Name = "pcbNguyenLieu";
            this.pcbNguyenLieu.Size = new System.Drawing.Size(725, 176);
            this.pcbNguyenLieu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbNguyenLieu.TabIndex = 0;
            this.pcbNguyenLieu.TabStop = false;
            // 
            // cboDSNV
            // 
            this.cboDSNV.Enabled = false;
            this.cboDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cboDSNV.FormattingEnabled = true;
            this.cboDSNV.Location = new System.Drawing.Point(168, 143);
            this.cboDSNV.Name = "cboDSNV";
            this.cboDSNV.Size = new System.Drawing.Size(155, 28);
            this.cboDSNV.TabIndex = 7;
            // 
            // colThu
            // 
            this.colThu.DataPropertyName = "Thu";
            this.colThu.HeaderText = "Thứ";
            this.colThu.MinimumWidth = 6;
            this.colThu.Name = "colThu";
            this.colThu.ReadOnly = true;
            // 
            // colCa
            // 
            this.colCa.DataPropertyName = "Ca";
            this.colCa.HeaderText = "Ca";
            this.colCa.MinimumWidth = 6;
            this.colCa.Name = "colCa";
            this.colCa.ReadOnly = true;
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNhanVien";
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            // 
            // colLoaiNhanVien
            // 
            this.colLoaiNhanVien.DataPropertyName = "LoaiNhanVien";
            this.colLoaiNhanVien.HeaderText = "Loại nhân viên";
            this.colLoaiNhanVien.MinimumWidth = 6;
            this.colLoaiNhanVien.Name = "colLoaiNhanVien";
            this.colLoaiNhanVien.ReadOnly = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnLuu.FlatAppearance.BorderSize = 2;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnLuu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.IconSize = 40;
            this.btnLuu.Location = new System.Drawing.Point(21, 282);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(302, 55);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "  Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnLuu.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnLuu.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // frmLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLichLamViec";
            this.Text = "frmLichLamViec";
            this.Load += new System.EventHandler(this.frmLichLamViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).EndInit();
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbNguyenLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private System.Windows.Forms.TextBox txtCa;
        private System.Windows.Forms.TextBox txtThu;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTenNguyenLieu;
        private System.Windows.Forms.Label lblMaNguyenLieu;
        private System.Windows.Forms.DataGridView dgvLichLamViec;
        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.PictureBox pcbNguyenLieu;
        private System.Windows.Forms.ComboBox cboDSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiNhanVien;
        private FontAwesome.Sharp.IconButton btnLuu;
    }
}