using QLNH_BUS;
using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_GUI
{
    public partial class frmProfileQL : Form
    {
        private bool btnVisible=false;
        NHANVIEN_BUS nvBUS=new NHANVIEN_BUS();
        private string loaiNV;
        public frmProfileQL(string loaiNV)
        {
            InitializeComponent();
            this.loaiNV= loaiNV;
        }

        private void ChiNhapChu(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ChiNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled |= true;
            }
        }

        private void frmProfileQL_Load(object sender, EventArgs e)
        {
            NHANVIEN_DTO thongTinQL=nvBUS.LayThongTinQL(this.loaiNV);
            txtHoTen.Text = thongTinQL.HoTen;
            txtTaiKhoan.Text = thongTinQL.MaNV;
            txtMatKhau.Text = thongTinQL.MatKhau;
            txtChucVu.Text = "Quản Lý";
            btnCapNhat.Visible = false;
            btnVisible = true;
            btnSuaTT_Click(sender, e);
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
           
            if (btnVisible == false)
            {
                txtTaiKhoan.ReadOnly = false;
                txtHoTen.ReadOnly = false;
                txtMatKhau.ReadOnly = false;
                //txtChucVu.ReadOnly = false;
                btnCapNhat.Visible = true;
                btnVisible = true;
            }
            else
            {
                txtTaiKhoan.ReadOnly = true;
                txtMatKhau.ReadOnly = true;
                txtHoTen.ReadOnly = true;
                //txtChucVu.ReadOnly = true;
                btnCapNhat.Visible = false;
                btnVisible = false;
            }
           
        }
        private void btnQLSuaTT_MouseEnter(object sender, EventArgs e)
        {
            btnSua.BackColor = System.Drawing.Color.FromArgb(31, 32, 71);
            btnSua.ForeColor = System.Drawing.Color.White;
        }

        private void btnQLSuaTT_MouseLeave(object sender, EventArgs e)
        {
            btnSua.BackColor = System.Drawing.Color.FromArgb(240, 246, 255);
            btnSua.ForeColor = System.Drawing.Color.FromArgb(31, 32, 71);
        }
        private void btnCapNhat_MouseEnter(object sender, EventArgs e)
        {
            btnCapNhat.BackColor = System.Drawing.Color.FromArgb(31, 32, 71);
            btnCapNhat.ForeColor = System.Drawing.Color.White;
        }

        private void btnCapNhat_MouseLeave(object sender, EventArgs e)
        {
            btnCapNhat.BackColor = System.Drawing.Color.FromArgb(240, 246, 255);
            btnCapNhat.ForeColor = System.Drawing.Color.FromArgb(31, 32, 71);
        }
        private void LayThongTin(NHANVIEN_DTO nvQL)
        {
            nvQL.MaNV=txtTaiKhoan.Text;
            nvQL.HoTen=txtHoTen.Text;
            nvQL.MatKhau=txtMatKhau.Text;
            string maHoaMK = Utils.MaHoaMDS(txtMatKhau.Text);
            nvQL.MatKhauMH=maHoaMK.ToString();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn cập nhật thông tin?", "Thông báo",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                NHANVIEN_DTO nvQL = new NHANVIEN_DTO();
                LayThongTin(nvQL);
                if (nvBUS.CapNhatTTQL(nvQL))
                {
                    MessageBox.Show("Cập nhật thông tin quản lý thành công!", "Thông báo");
                    frmProfileQL_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin quản lý thất bại!", "Thông báo");
                    btnCapNhat.Visible = true;
                }
            }
            else
            {
                frmProfileQL_Load(sender, e);
            }
            
        }
    }
}
