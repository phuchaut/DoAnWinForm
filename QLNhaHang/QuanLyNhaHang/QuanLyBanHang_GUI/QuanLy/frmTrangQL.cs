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
using System.Windows.Media;
using FontAwesome.Sharp;
using QLNH_BUS;
using System.Threading;
using QuanLyBanHang_GUI.QuanLy;
using QLNH_DTO;

namespace QuanLyBanHang_GUI
{
    public partial class frmTrangQL : Form
    {
        Thread th;
        private string loaiNV = "";
        private string maNV = "";
        public NHANVIEN_DTO nvDangNhap = null;
        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        //private Form Profile = new frmProfiile();
        //private Form NhanVien = new frmNhanVien();
        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //constructor
        public frmTrangQL(string loaiNV, string maNV)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 55);
            pnlContainer.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.Size = new Size(1380, 780);
            this.loaiNV=loaiNV;
            this.maNV=maNV;
            //this.FormBorderStyle = FormBorderStyle.None;
        }
        //open form
        private void OpenForm(Form childForm,string tenTrang)
        {
            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle=FormBorderStyle.None;
            childForm.Dock=DockStyle.Fill;
            pnlDeskTop.Controls.Add(childForm);
            pnlDeskTop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTieuDe.Text = tenTrang;
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.colorActive);
            btnTaiKhoan_Click(btnTaiKhoan,e);
            OpenForm(new frmProfileQL(this.loaiNV),"Trang Thông Tin Quản Lý");
        }
        public void KiemTraDangNhap()
        {
            if(nvDangNhap == null)
            {
                MessageBox.Show("Nhân viên không tồn tại", "Thông báo");
            }
            else
            {
            }
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
                
                currentBtn =(IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign=ContentAlignment.MiddleCenter;
                currentBtn.IconColor=color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,140+ currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icon child
                pcbCurrentChild.IconChar= currentBtn.IconChar;
                pcbCurrentChild.IconColor=color;
            }
        }
        private void DisableButton()
        {
            if(currentBtn != null)
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
            OpenForm(new frmProfileQL(this.loaiNV), "Trang Thông Tin Quản Lý");
        }
       
       

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenForm(new frmNhanVien(),"Trang Quản Lý Nhân Viên");
        }

        private void btnQLBA_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenForm(new frmQLBA(),"Trang Quản Lý Bàn Ăn");
        }

        private void btnQLMA_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenForm(new frmQLMA(),"Trang Quản Lý Món Ăn");
        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenForm(new frmHoaDon("QL",this.maNV),"Trang Quản Lý Hóa Đơn");
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenForm(new frmDoanhThu(),"Trang Quản Lý Doanh Thu");
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenForm(new frmNguyenLieu(),"Trang Quản Lý Nguyên Liệu");
        }
        private void MoForm()
        {
            Application.Run(new frmLogin());
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Thông báo",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                th = new Thread(MoForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void pcbHome_Click(object sender, EventArgs e)
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            pcbCurrentChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            pcbCurrentChild.IconColor = System.Drawing.Color.White;
            OpenForm(new frmProfileQL(this.loaiNV), "Trang Thông Tin Quản Lý");
        }

        private void Move(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       


        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState= FormWindowState.Maximized;
            }
            else
            {
                this.WindowState= FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if( WindowState == FormWindowState.Normal||WindowState==FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorActive);
            OpenForm(new frmKhachHang(), "Trang Thông Tin Khách Hàng");
        }

        private void btnLichLamViec_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorActive);
            OpenForm(new frmLichLamViec(), "Trang Lịch Làm Việc Của Nhân Viên");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();

            }
        }
    }
}
