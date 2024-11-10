namespace QuanLyBanHang_GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pcbIconRestaurant = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pcbStaff = new System.Windows.Forms.PictureBox();
            this.pcbCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblClear = new System.Windows.Forms.Label();
            this.pnlDuongKe2 = new System.Windows.Forms.Panel();
            this.pnlDuongKe1 = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pcbMatKhau = new System.Windows.Forms.PictureBox();
            this.pcbTaiKhoan = new System.Windows.Forms.PictureBox();
            this.btnEye = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconRestaurant)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(170, 120);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(211, 25);
            this.lblTitle2.TabIndex = 2;
            this.lblTitle2.Text = "Chúc một ngày tốt lành";
            this.lblTitle2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.White;
            this.lblTitle1.Location = new System.Drawing.Point(135, 81);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(275, 39);
            this.lblTitle1.TabIndex = 1;
            this.lblTitle1.Text = "Chào mừng trở lại!";
            this.lblTitle1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.pnlContainer.Controls.Add(this.lblTitle2);
            this.pnlContainer.Controls.Add(this.lblTitle1);
            this.pnlContainer.Controls.Add(this.pcbIconRestaurant);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(559, 600);
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // pcbIconRestaurant
            // 
            this.pcbIconRestaurant.Image = global::QuanLyBanHang_GUI.Properties.Resources.IconrestaurantLogin;
            this.pcbIconRestaurant.Location = new System.Drawing.Point(144, 178);
            this.pcbIconRestaurant.Name = "pcbIconRestaurant";
            this.pcbIconRestaurant.Size = new System.Drawing.Size(257, 280);
            this.pcbIconRestaurant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIconRestaurant.TabIndex = 0;
            this.pcbIconRestaurant.TabStop = false;
            this.pcbIconRestaurant.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.pcbStaff);
            this.pnlTitle.Controls.Add(this.pcbCurrentChild);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(559, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(541, 166);
            this.pnlTitle.TabIndex = 18;
            // 
            // pcbStaff
            // 
            this.pcbStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbStaff.Image = global::QuanLyBanHang_GUI.Properties.Resources.BieuTuongNhaHang;
            this.pcbStaff.Location = new System.Drawing.Point(0, 0);
            this.pcbStaff.Name = "pcbStaff";
            this.pcbStaff.Size = new System.Drawing.Size(541, 166);
            this.pcbStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbStaff.TabIndex = 16;
            this.pcbStaff.TabStop = false;
            this.pcbStaff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // pcbCurrentChild
            // 
            this.pcbCurrentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pcbCurrentChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.pcbCurrentChild.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.pcbCurrentChild.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.pcbCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pcbCurrentChild.IconSize = 40;
            this.pcbCurrentChild.Location = new System.Drawing.Point(489, 12);
            this.pcbCurrentChild.Name = "pcbCurrentChild";
            this.pcbCurrentChild.Size = new System.Drawing.Size(40, 40);
            this.pcbCurrentChild.TabIndex = 0;
            this.pcbCurrentChild.TabStop = false;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.txtMatKhau.Location = new System.Drawing.Point(675, 373);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(324, 30);
            this.txtMatKhau.TabIndex = 3;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.txtTaiKhoan.Location = new System.Drawing.Point(675, 296);
            this.txtTaiKhoan.Multiline = true;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(372, 30);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.Location = new System.Drawing.Point(990, 414);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(59, 25);
            this.lblClear.TabIndex = 6;
            this.lblClear.Text = "clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // pnlDuongKe2
            // 
            this.pnlDuongKe2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.pnlDuongKe2.Location = new System.Drawing.Point(613, 408);
            this.pnlDuongKe2.Name = "pnlDuongKe2";
            this.pnlDuongKe2.Size = new System.Drawing.Size(432, 2);
            this.pnlDuongKe2.TabIndex = 21;
            // 
            // pnlDuongKe1
            // 
            this.pnlDuongKe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.pnlDuongKe1.Location = new System.Drawing.Point(613, 331);
            this.pnlDuongKe1.Name = "pnlDuongKe1";
            this.pnlDuongKe1.Size = new System.Drawing.Size(432, 2);
            this.pnlDuongKe1.TabIndex = 20;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.lblLogin.Location = new System.Drawing.Point(759, 197);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(141, 45);
            this.lblLogin.TabIndex = 29;
            this.lblLogin.Text = "LOG IN";
            // 
            // pcbMatKhau
            // 
            this.pcbMatKhau.Image = global::QuanLyBanHang_GUI.Properties.Resources.Lock;
            this.pcbMatKhau.Location = new System.Drawing.Point(613, 365);
            this.pcbMatKhau.Name = "pcbMatKhau";
            this.pcbMatKhau.Size = new System.Drawing.Size(40, 40);
            this.pcbMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMatKhau.TabIndex = 31;
            this.pcbMatKhau.TabStop = false;
            this.pcbMatKhau.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pcbTaiKhoan
            // 
            this.pcbTaiKhoan.Image = global::QuanLyBanHang_GUI.Properties.Resources.User;
            this.pcbTaiKhoan.Location = new System.Drawing.Point(615, 288);
            this.pcbTaiKhoan.Name = "pcbTaiKhoan";
            this.pcbTaiKhoan.Size = new System.Drawing.Size(40, 40);
            this.pcbTaiKhoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbTaiKhoan.TabIndex = 30;
            this.pcbTaiKhoan.TabStop = false;
            // 
            // btnEye
            // 
            this.btnEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEye.FlatAppearance.BorderSize = 0;
            this.btnEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnEye.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.btnEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEye.IconSize = 30;
            this.btnEye.Location = new System.Drawing.Point(1012, 373);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(30, 30);
            this.btnEye.TabIndex = 5;
            this.btnEye.UseVisualStyleBackColor = true;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.btnLogin.FlatAppearance.BorderSize = 3;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogin.IconColor = System.Drawing.Color.Black;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.Location = new System.Drawing.Point(615, 470);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(430, 62);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThoat.IconColor = System.Drawing.Color.Black;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.Location = new System.Drawing.Point(781, 538);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 35);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "exit";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.pcbMatKhau);
            this.Controls.Add(this.pcbTaiKhoan);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnEye);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlDuongKe2);
            this.Controls.Add(this.pnlDuongKe1);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconRestaurant)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.PictureBox pcbIconRestaurant;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.PictureBox pcbStaff;
        private FontAwesome.Sharp.IconButton btnEye;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblClear;
        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.Panel pnlDuongKe2;
        private System.Windows.Forms.Panel pnlDuongKe1;
        private FontAwesome.Sharp.IconPictureBox pcbCurrentChild;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pcbTaiKhoan;
        private System.Windows.Forms.PictureBox pcbMatKhau;
        private FontAwesome.Sharp.IconButton btnThoat;
    }
}