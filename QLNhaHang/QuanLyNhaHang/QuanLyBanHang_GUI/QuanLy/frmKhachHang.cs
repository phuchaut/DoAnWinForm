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

namespace QuanLyBanHang_GUI.QuanLy
{
    public partial class frmKhachHang : Form
    {
        KHACHHANG_DTO kh;
        List<KHACHHANG_DTO> dsKhach;
        KHACHHANG_BUS khBUS;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadDSKH();
            dgvDSKhachHang.ClearSelection();
        }
        private void LoadDSKH()
        {
            khBUS = new KHACHHANG_BUS();
            dgvDSKhachHang.DataSource= khBUS.LoadDSKH();
            
            
        }

        private void dgvDSMonAn_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDSKhachHang.SelectedRows.Count > 0)
            {
                KHACHHANG_DTO kh = dgvDSKhachHang.SelectedRows[0].DataBoundItem as KHACHHANG_DTO;
                txtHoTen.Text = kh.HoTen;
                txtSoDienThoai.Text = kh.SDT;
            }
            else
            {
                txtHoTen.Text=txtSoDienThoai.Text=string.Empty;
            }
           
        }
    }
}
