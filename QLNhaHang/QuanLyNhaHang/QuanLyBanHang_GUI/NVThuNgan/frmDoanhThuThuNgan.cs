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

namespace QuanLyBanHang_GUI.NVThuNgan
{
    public partial class frmDoanhThuThuNgan : Form
    {
        DOANHTHU_BUS dtBUS = new DOANHTHU_BUS();
        DOANHTHU_DTO dt;
        List<DOANHTHU_DTO> dsDT;

        public frmDoanhThuThuNgan()
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
            dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadDSDT();
        }
        private void LoadDSDT()
        {
            //dsDT = new List<DOANHTHU_DTO>();
            //dsDT = dtBUS.LoadDSDT();
            //dgvDoanhThu.AutoGenerateColumns = false;
            //dgvDoanhThu.DataSource = dsDT;

        }
        private void btnChiTietDT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chi tiết doanh thu", "Thông báo");
        }
    }
}
