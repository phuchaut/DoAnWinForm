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

namespace QuanLyBanHang_GUI
{
    public partial class frmDoanhThu : Form
    {
        DOANHTHU_BUS dtBUS=new DOANHTHU_BUS();
        DOANHTHU_DTO dt;
        List<DOANHTHU_DTO> dsDT;
        private string ngayBD;
        private string ngayKT;
        private float tongTien = 0;
        public frmDoanhThu()
        {
            InitializeComponent();
        }
        private void btnMouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(31, 32, 71);
            ((Button)sender).ForeColor = System.Drawing.Color.White;
            //((IconButton)sender).IconColor = System.Drawing.Color.White;
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(240, 246, 255);
            ((Button)sender).ForeColor = System.Drawing.Color.FromArgb(31, 32, 71);
            //((IconButton)sender).IconColor = System.Drawing.Color.FromArgb(31, 32, 71);
        }
        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            dgvDoanhThu.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dtpNgayKetThuc.Value=DateTime.Now;
            dtpNgayBatDau.Value=DateTime.Now;
            ngayBD = dtpNgayBatDau.Value.ToString("yyyy/MM/dd");
            ngayKT = dtpNgayKetThuc.Value.ToString("yyyy/MM/dd");
            LoadDSDT(ngayBD, ngayKT);
        }
        private void LoadDSDT(string ngayBD,string ngayKT)
        {
            dsDT=new List<DOANHTHU_DTO>();
            dsDT= dtBUS.LoadDSDT(ngayBD, ngayKT);
            dgvDoanhThu.AutoGenerateColumns = false;
            dgvDoanhThu.DataSource= dsDT;
            tongTien = 0;
            foreach (DataGridViewRow row in dgvDoanhThu.Rows)
            {
                tongTien = tongTien + float.Parse(row.Cells[1].Value.ToString());
            }
            lblTongDT.Text = tongTien.ToString("#,##0 đồng");
        }
        private void btnChiTietDT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chi tiết doanh thu", "Thông báo");
        }

        private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            ngayBD = dtpNgayBatDau.Value.ToString("yyyy/MM/dd");
            ngayKT = dtpNgayKetThuc.Value.ToString("yyyy/MM/dd");
            LoadDSDT(ngayBD, ngayKT);
        }

        private void dtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            ngayBD = dtpNgayBatDau.Value.ToString("yyyy/MM/dd");
            ngayKT = dtpNgayKetThuc.Value.ToString("yyyy/MM/dd");
            LoadDSDT(ngayBD, ngayKT);
        }
    }
}
