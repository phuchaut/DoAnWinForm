using FontAwesome.Sharp;
using QLNH_BUS;
using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_GUI.NVTiepTan
{
    public partial class frmProfileNVTiepTan : Form
    {
        NHANVIEN_DTO nvDTO = new NHANVIEN_DTO();
        private string maNV;
        private bool btnVisible = false;
        public frmProfileNVTiepTan(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }
        NHANVIEN_BUS nvBUS = new NHANVIEN_BUS();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            ((System.Windows.Forms.Button)sender).BackColor = System.Drawing.Color.FromArgb(31, 32, 71);
            ((System.Windows.Forms.Button)sender).ForeColor = System.Drawing.Color.White;
            ((IconButton)sender).IconColor = System.Drawing.Color.White;
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            ((System.Windows.Forms.Button)sender).BackColor = System.Drawing.Color.FromArgb(240, 246, 255);
            ((System.Windows.Forms.Button)sender).ForeColor = System.Drawing.Color.FromArgb(31, 32, 71);
            ((IconButton)sender).IconColor = System.Drawing.Color.FromArgb(31, 32, 71);
        }

        private void frmProfileTiepTan_Load(object sender, EventArgs e)
        {
            nvDTO = nvBUS.LayThongTinNV(this.maNV);
            txtTaiKhoan.Text = nvDTO.MaNV;
            txtHoTen.Text = nvDTO.HoTen;
            txtMatKhau.Text = nvDTO.MatKhau;
            txtChucVu.Text = "Tiếp Tân";
            lblTitle.Text = nvDTO.HoTen;
            btnCapNhat.Visible = false;
            btnVisible = true;
            btnQLSuaTT_Click(sender, e);
        }
        private void LayThongTin(NHANVIEN_DTO nvQL)
        {
            nvQL.MaNV = txtTaiKhoan.Text;
            nvQL.HoTen = txtHoTen.Text;
            nvQL.MatKhau = txtMatKhau.Text;

        }
        private void btnQLSuaTT_Click(object sender, EventArgs e)
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn cập nhật thông tin?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                NHANVIEN_DTO nvQL = new NHANVIEN_DTO();
                LayThongTin(nvQL);
                if (nvBUS.CapNhatThongTinProfile(nvQL))
                {
                    MessageBox.Show("Cập nhật thông tin quản lý thành công!", "Thông báo");
                    frmProfileTiepTan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin quản lý thất bại!", "Thông báo");
                    btnCapNhat.Visible = true;
                }
            }
            else
            {
                frmProfileTiepTan_Load(sender, e);
            }
        }
    
    }
}
