using FontAwesome.Sharp;
using QuanLyBanHang_GUI.NVBep;
using QuanLyBanHang_GUI.NVThuNgan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QuanLyBanHang_GUI
{
    public partial class frmTrangNVBep : Form
    {
        Thread th;
        private string maNV = "";
        private string loaiTrang = "Bep";
        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private string loaiNV;
        //private Form Profile = new frmProfiile();
        //private Form NhanVien = new frmNhanVien();
        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //constructor
        public frmTrangNVBep(string loaiNV, string maNV)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 55);
            pnlContainer.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.maNV = maNV;
            this.loaiNV = loaiNV;
        //this.FormBorderStyle = FormBorderStyle.None;
    }
        //open form
        private void OpenForm(Form childForm,string tenForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDeskTop.Controls.Add(childForm);
            pnlDeskTop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = tenForm;
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.colorActive);
            btnTaiKhoan_Click_1(btnTaiKhoan, e);
            OpenForm(new frmProfileBep(maNV), "Trang Thông Tin Tài Khoản");
        }
        //Structs
        private struct RGBColors
        {
            public static System.Drawing.Color colorActive = System.Drawing.Color.FromArgb(102, 96, 216);
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(172, 126, 241);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(249, 118, 176);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253, 138, 114);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(95, 77, 221);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249, 88, 155);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(24, 161, 251);
        }
        //methods
        private void ActivateButton(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, 140 + currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icon child
                pcbCurrentChild.IconChar = currentBtn.IconChar;
                pcbCurrentChild.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = System.Drawing.Color.FromArgb(31, 32, 71);
                currentBtn.ForeColor = System.Drawing.Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void btnTaiKhoan_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorActive);
            OpenForm(new frmProfileBep(maNV), "Trang Thông Tin Tài Khoản");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if(dr==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnQLMA_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenForm(new frmQLMA(), "Trang Thông Tin Món Ăn");
        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenForm(new frmHoaDon(loaiTrang,this.maNV), "Trang Thông Tin Hóa Đơn");
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenForm(new frmNguyenLieu(), "Trang Thông Tin Nguyên Liệu");
        }
        private void MoForm(object obj)
        {
            Application.Run(new frmLogin());
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                th = new Thread(MoForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }
        private void Move(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void pcbHome_Click(object sender, EventArgs e)
        {
        }
    }
}
