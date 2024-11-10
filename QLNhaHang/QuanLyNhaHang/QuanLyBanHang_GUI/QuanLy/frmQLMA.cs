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
    public partial class frmQLMA : Form
    {
        private int sua = 0;
        private bool readOnly = true;
        private string thaoTac = "";
        MONAN_BUS monAnBUS=new MONAN_BUS();
        NGUYENLIEU_DTO nl;
        List<NGUYENLIEU_DTO> dsnl;
        NGUYENLIEU_BUS nlBUS;
        public frmQLMA()
        {
            InitializeComponent();
        }
        private void btnMouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(31, 32, 71);
            ((Button)sender).ForeColor = System.Drawing.Color.White;
            ((IconButton)sender).IconColor = System.Drawing.Color.White;
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(240, 246, 255);
            ((Button)sender).ForeColor = System.Drawing.Color.FromArgb(31, 32, 71);
            ((IconButton)sender).IconColor = System.Drawing.Color.FromArgb(31, 32, 71);
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

        private void frmQLMA_Load(object sender, EventArgs e)
        {
            
            dgvDSMonAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSMonAn.AllowUserToResizeRows = false;
            dgvDSMonAn.AutoGenerateColumns = false;
            LoadDSMA();
            LoadDSNL();
            cboTrangThai.SelectedIndex = 1;
            dgvDSMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadDSMA()
        {
            List<MONAN_DTO> dsMonAn = monAnBUS.LoadDSMonAn();
            dgvDSMonAn.DataSource = dsMonAn;
        }
        private void LoadDSNL()
        {
            nlBUS=new NGUYENLIEU_BUS();
            dsnl=nlBUS.loadDSNL();
            cboDSNguyenLieu.DataSource = dsnl;
            cboDSNguyenLieu.DisplayMember = "TenNguyenLieu";
            cboDSNguyenLieu.ValueMember = "TenNguyenLieu";
        }
        private void dgvDSMonAn_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDSMonAn.SelectedRows.Count > 0)
            {
                MONAN_DTO ma = dgvDSMonAn.SelectedRows[0].DataBoundItem as MONAN_DTO;
                txtMaMonAn.Text=ma.MaMonAn.ToString();
                txtTenMonAn.Text= ma.TenMonAn.ToString();
                cboLoaiMonAn.SelectedIndex = ma.MaLoaiMonAn - 1;
                nudDonGia.Value = ma.DonGia;
                //txtTenNL.Text=ma.TenNguyenLieu.ToString();
                if (ma.TenNguyenLieu != "")
                {
                    cboDSNguyenLieu.Text = ma.TenNguyenLieu;
                }
                else
                {
                    cboDSNguyenLieu.Text = null;
                }
                nudSoLuongNL.Value=ma.SoLuongNguyenLieu;
                cboTrangThai.SelectedIndex = ma.TrangThai;
            }
            else
            {
                txtMaMonAn.Text = txtTenMonAn.Text= string.Empty;
                cboDSNguyenLieu.Text = null;
                nudDonGia.Value = 0;
                cboLoaiMonAn.Text=string.Empty;
                nudSoLuongNL.Value = 0;
                cboTrangThai.SelectedIndex=0;
            }
        }
        private void KiemTraReadonly()
        {
            if (readOnly == true)
            {
                txtMaMonAn.ReadOnly = false;
                txtTenMonAn.ReadOnly=false;
                nudSoLuongNL.ReadOnly=false;
                //txtTenNL.ReadOnly=false;
                cboDSNguyenLieu.Enabled= true;
                cboLoaiMonAn.Enabled = true;
                nudDonGia.Enabled = true;
                cboTrangThai.Enabled = true;
                cboTrangThai.SelectedIndex = 1;
                nudSoLuongNL.Enabled = true;
                readOnly = false;
            }
            else
            {
                txtMaMonAn.ReadOnly = true;
                txtTenMonAn.ReadOnly = true;
                //txtTenNL.ReadOnly = true;
                cboDSNguyenLieu.Enabled = false;
                nudSoLuongNL.ReadOnly = true;
                cboLoaiMonAn.Enabled = false;
                nudDonGia.Enabled = false;
                cboTrangThai.Enabled = false;
                nudSoLuongNL.Enabled = false;
                readOnly = true;
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSMA();
            dgvDSMonAn.ClearSelection();
            readOnly = false;
            KiemTraReadonly();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (sua == 1)
            {
                readOnly = true; 
                sua--;
            }
            KiemTraReadonly();
            dgvDSMonAn.ClearSelection();
            cboTrangThai.SelectedIndex = 1;
            cboDSNguyenLieu.Text=string.Empty;
            thaoTac = "Them";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDSMonAn.SelectedRows.Count > 0) {
                if (sua == 0)
                {
                    //readOnly = true;
                    sua++;
                    thaoTac = "Sua";
                }
                else
                {
                    sua--;
                    if (thaoTac == "")
                    {
                        thaoTac = "Sua";
                    }
                    else
                    {
                        thaoTac = "";
                    }

                }
                KiemTraReadonly();
                thaoTac = "Sua";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDSMonAn.SelectedRows.Count>0)
            {
                if (monAnBUS.XoaMonAn(int.Parse(txtMaMonAn.Text)))
                {
                    MessageBox.Show($"Xóa món ăn : {txtTenMonAn.Text} thành công!", "Thông báo");
                    LoadDSMA();
                }
                else
                {
                    MessageBox.Show($"Xóa món ăn : {txtTenMonAn.Text} thất bại!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show($"Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }
            
        }
        private bool CheckEmpty()
        {
            if(string.IsNullOrWhiteSpace(txtMaMonAn.Text)|| string.IsNullOrWhiteSpace(txtTenMonAn.Text))
                //string.IsNullOrWhiteSpace(txtTenNL.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (thaoTac == "")
            {
                MessageBox.Show("Bạn chưa chọn hành động nào để thao tác!", "Thông báo");
            }
            else
            {
                switch (thaoTac)
                {
                    case "Them":
                        if (CheckEmpty())
                        {
                            MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
                        }
                        else
                        {
                            if (monAnBUS.CheckTonTai(int.Parse(txtMaMonAn.Text)))
                            {
                                MessageBox.Show("Mã món ăn đã tồn tại!", "Thông báo");
                            }
                            else
                            {
                                MONAN_DTO ma = new MONAN_DTO();
                                ma.MaMonAn = int.Parse(txtMaMonAn.Text);
                                ma.TenMonAn = txtTenMonAn.Text;
                                ma.MaLoaiMonAn = cboLoaiMonAn.SelectedIndex;
                                ma.DonGia = nudDonGia.Value;
                                ma.SoLuongNguyenLieu = (int)nudSoLuongNL.Value;
                                ma.TenNguyenLieu = cboDSNguyenLieu.Text;
                                ma.TrangThai = 1;

                                if (monAnBUS.ThemMonAn(ma))
                                {
                                    MessageBox.Show($"Thêm món {ma.TenMonAn} thành công", "Thông báo");
                                    LoadDSMA();
                                }
                                else
                                {
                                    MessageBox.Show($"Thêm món {ma.TenMonAn} thất bại", "Thông báo");
                                }
                            }
                            
                            
                        }
                        break;
                    case "Sua":
                        if (CheckEmpty())
                        {
                            MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
                        }
                        else
                        {
                            MONAN_DTO ma = new MONAN_DTO();
                            ma.MaMonAn = int.Parse(txtMaMonAn.Text);
                            ma.TenMonAn = txtTenMonAn.Text;
                            ma.MaLoaiMonAn = cboLoaiMonAn.SelectedIndex+1;
                            ma.DonGia = nudDonGia.Value;
                            ma.SoLuongNguyenLieu = (int)nudSoLuongNL.Value;
                            ma.TenNguyenLieu = cboDSNguyenLieu.Text;
                            ma.TrangThai = cboTrangThai.SelectedIndex;

                            if (monAnBUS.CapNhatMonAn(ma))
                            {
                                MessageBox.Show($"Cập nhật thông tin món {ma.TenMonAn} thành công", "Thông báo");
                                LoadDSMA();
                            }

                        }
                        break;
                }
                
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTenMonAn.ReadOnly == true)
            {
                dgvDSMonAn.ClearSelection();
                txtTenMonAn.ReadOnly = false;
            }
            else
            {
                dgvDSMonAn.DataSource = monAnBUS.TimMonAn(txtTenMonAn.Text.Trim());
                txtTenMonAn.ReadOnly = true;
            }
        }
    }
}
