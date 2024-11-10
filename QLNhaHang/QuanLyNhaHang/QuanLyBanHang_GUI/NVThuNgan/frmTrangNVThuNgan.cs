using FontAwesome.Sharp;
using QuanLyBanHang_GUI.NVBep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using QLNH_BUS;
using QLNH_DTO;
using QuanLyBanHang_GUI.QuanLy;

namespace QuanLyBanHang_GUI.NVThuNgan
{
    public partial class frmTrangNVThuNgan : Form
    {
        Thread th;
        private Form currentChildForm;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        NHANVIEN_BUS nvBUS;
        NHANVIEN_DTO nvDTO;
        private string loaiNV;
        private string maNV;
        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmTrangNVThuNgan(string loaiNV,string maNV)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 55);
            pnlContainer.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.loaiNV = loaiNV;
            this.maNV = maNV;
        }
        private void OpenForm(Form childform,string tenForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnlDeskTop.Controls.Add(childform);
            pnlDeskTop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lblTitle.Text = tenForm;

        }
        private struct RGBColors
        {
            public static System.Drawing.Color colorActive = System.Drawing.Color.FromArgb(102, 96, 216);
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(172, 126, 241);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(249, 118, 176);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253, 138, 114);
            //public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(95, 77, 221);
            //public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249, 88, 155);
            //public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(24, 161, 251);
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
        
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorActive);
            OpenForm(new frmProfileThuNgan( maNV), "Trang Thông Tin Tài Khoản");
        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenForm(new frmHoaDon(loaiNV, maNV), "Trang Thông Tin Hóa Đơn");
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenForm(new frmDoanhThu(), "Trang Thông Tin Doanh Thu");

        }
        private void MoForm()
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

        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void LayThongTin(string maNV)
        {
            nvBUS=new NHANVIEN_BUS();
            nvDTO = new NHANVIEN_DTO();
            nvDTO=nvBUS.LayThongTinQL(maNV);
        }
        private void frmTrangNVTiepTan_Load(object sender, EventArgs e)
        {
            LayThongTin(this.maNV); 
            OpenForm(new frmProfileThuNgan( this.maNV), "Trang Thông Tin Tài Khoản");
            
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

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorActive);
            OpenForm(new frmKhachHang(), "Trang Thông Tin Khách Hàng");
        }
    }
}
