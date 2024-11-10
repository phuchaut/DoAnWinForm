using FontAwesome.Sharp;
using QLNH_BUS;
using QLNH_DTO;
using QuanLyBanHang_GUI.NVThuNgan;
using QuanLyBanHang_GUI.NVTiepTan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_GUI
{
    public partial class frmLogin : Form
    {
        Thread thLoad;
        bool hidePass = true;
        public string loaiNV = "";
        private string maNV = "";
        NHANVIEN_BUS nvBUS = new NHANVIEN_BUS();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void MoForm(object obj)
        {
            if(loaiNV == string.Empty)
            {
                MessageBox.Show("Nhân viên không tồn tại", "Thông báo");
            }
            else
            {
                Application.Run(new frmLoading(loaiNV,maNV));
            }
            
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            //txtTaiKhoan.Text = "nv01";
            //txtMatKhau.Text = "123456";
            
        }
        private void Move(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
            else
            {
                string maHoaMK = Utils.MaHoaMDS(txtMatKhau.Text);
                NHANVIEN_DTO nvDN = nvBUS.DangNhap(txtTaiKhoan.Text, maHoaMK);
                if (nvDN != null)
                {
                    //frmTrangQL formQL = new frmTrangQL(this.loaiNV);
                    //formQL.nvDangNhap = nvDN;
                    //formQL.KiemTraDangNhap();
                    switch (nvDN.LoaiNhanVien)
                    {
                        case "QL":
                            loaiNV = "QL";
                            break;
                        case "BT":
                            loaiNV = "BT";
                            break;
                        case "NVB":
                            loaiNV = "NVB";
                            break;
                        case "TT":
                            loaiNV = "TT";
                            break;
                        case "TN":
                            loaiNV = "TN";
                            break;
                        default:
                            loaiNV = string.Empty;
                            break;
                    }
                    maNV = txtTaiKhoan.Text;
                    //this.Hide();
                    //formQL.Show();
                    this.Close();
                    thLoad = new Thread(MoForm);
                    thLoad.SetApartmentState(ApartmentState.STA);
                    thLoad.Start();
                    //this.Dispose();
                    //formQL.Show();


                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ", "Đăng nhập");
                }
            }
        }

        private void btnEye_Click(object sender, EventArgs e)
        {

            if (hidePass == true)
            {
                txtMatKhau.UseSystemPasswordChar = true;
                hidePass = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = false;
                hidePass = true;
            }

        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = txtMatKhau.Text = string.Empty;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(29, 22, 49);
            //((Button)sender).ForeColor = System.Drawing.Color.FromArgb(31, 32, 71);
            ((IconButton)sender).ForeColor = System.Drawing.Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(240, 246, 255);
            //((Button)sender).ForeColor = System.Drawing.Color.White;
            ((IconButton)sender).ForeColor = System.Drawing.Color.FromArgb(29, 22, 49);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThoat_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(240, 246, 255);
            ((Button)sender).ForeColor = System.Drawing.Color.White;
            ((IconButton)sender).IconColor = System.Drawing.Color.White;
        }
    }
}
