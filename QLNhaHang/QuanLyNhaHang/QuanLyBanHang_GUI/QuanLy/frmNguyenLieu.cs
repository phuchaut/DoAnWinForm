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
    public partial class frmNguyenLieu : Form
    {
        private bool readOnly = true;
        private int sua = 0;
        private string thaoTac = "";
        NGUYENLIEU_BUS nlBUS=new NGUYENLIEU_BUS();
        public frmNguyenLieu()
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
        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
           
            dgvNguyenLieu.AutoGenerateColumns = false;
            dgvNguyenLieu.AllowUserToResizeRows = false;
            dgvNguyenLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
            dgvNguyenLieu.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            LoadDSNL();
        }
        private void ChiNhapChu(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void LoadDSNL()
        {
            List<NGUYENLIEU_DTO> dsNL = nlBUS.loadDSNL();
            dgvNguyenLieu.DataSource = dsNL;
            readOnly = false;
            KiemTraReadOnly();
        }
        private void dgvNguyenLieu_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvNguyenLieu.SelectedRows.Count > 0)
            {
                NGUYENLIEU_DTO nl = dgvNguyenLieu.SelectedRows[0].DataBoundItem as NGUYENLIEU_DTO;
                txtMaNguyenLieu.Text = nl.MaNguyenLieu.ToString();
                txtTenNguyenLieu.Text = nl.TenNguyenLieu;
                nudSoLuong.Value=nl.SoLuong;
                nudDonGia.Value=nl.DonGiaNguyenLieu;
            }
            else
            {
                txtMaNguyenLieu.Text = txtTenNguyenLieu.Text = string.Empty;
                nudSoLuong.Value = nudDonGia.Value = 0;
            }
        }
        private void KiemTraReadOnly()
        {
            if (readOnly == true)
            {
                txtMaNguyenLieu.ReadOnly = false;
                txtTenNguyenLieu.ReadOnly = false;
                nudSoLuong.ReadOnly = false;
                nudDonGia.ReadOnly = false;
                readOnly = false;
            }
            else
            {
                txtMaNguyenLieu.ReadOnly = true;
                txtTenNguyenLieu.ReadOnly = true;
                nudSoLuong.ReadOnly = true;
                nudDonGia.ReadOnly = true;
                readOnly = true;
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvNguyenLieu.ClearSelection();
            readOnly = false;
            KiemTraReadOnly();
            thaoTac = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (sua == 1)
            {
                readOnly = true;
                sua--;
            }
            thaoTac = "Them";
            KiemTraReadOnly();
            dgvNguyenLieu.ClearSelection();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNguyenLieu.SelectedRows.Count > 0)
            {
                KiemTraReadOnly();
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
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn xóa?", "Thông báo");
            if (dr == DialogResult.Yes)
            {
                if (dgvNguyenLieu.SelectedRows.Count > 0)
                {
                    if (nlBUS.XoaNguyenLieu(int.Parse(txtMaNguyenLieu.Text)))
                    {
                        MessageBox.Show($"Xóa nguyên liệu :{txtMaNguyenLieu.Text} thành công!", "Thông báo");
                        LoadDSNL();
                    }
                    else
                    {
                        MessageBox.Show($"Xóa nguyên liệu :{txtMaNguyenLieu.Text} thất bại!", "Thông báo");
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
                }
            }
            
            thaoTac = "";
        }
        private bool checkEmpty()
        {
            if (string.IsNullOrWhiteSpace(txtMaNguyenLieu.Text) || string.IsNullOrWhiteSpace(txtTenNguyenLieu.Text) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool KTNguyenLieu(int maNguyenLieu)
        {
            return nlBUS.KiemTraMaNV(maNguyenLieu);
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
                        if (checkEmpty())
                        {
                            MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo");
                        }

                        else
                        {
                            if (KTNguyenLieu(int.Parse(txtMaNguyenLieu.Text)))
                            {
                                MessageBox.Show($"Mã nguyên liệu :{txtMaNguyenLieu.Text} đã tồn tại!", "Thông báo");
                            }
                            else
                            {
                                NGUYENLIEU_DTO nl = new NGUYENLIEU_DTO();
                                nl.MaNguyenLieu =int.Parse(txtMaNguyenLieu.Text);
                                nl.TenNguyenLieu = txtTenNguyenLieu.Text;
                                nl.SoLuong = (int)nudSoLuong.Value;
                                nl.DonGiaNguyenLieu=nudDonGia.Value;
                                nl.TrangThai = 1;
                                if (nlBUS.ThemNguyenLieu(nl))
                                {
                                    MessageBox.Show("Thêm nguyên liệu thành công!", "Thông báo");
                                    LoadDSNL();
                                }
                                else
                                {
                                    MessageBox.Show("Thêm nguyên liệu thât bại!", "Thông báo");
                                }
                            }

                        }
                        

                        break;
                    case "Sua":
                        if (checkEmpty())
                        {
                            MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo");
                        }
                        else
                        {
                            NGUYENLIEU_DTO nl = new NGUYENLIEU_DTO();
                            nl.MaNguyenLieu = int.Parse(txtMaNguyenLieu.Text);
                            nl.TenNguyenLieu = txtTenNguyenLieu.Text;
                            nl.SoLuong = (int)nudSoLuong.Value;
                            nl.DonGiaNguyenLieu = nudDonGia.Value;
                            if (nlBUS.CapNhatNL(nl))
                            {
                                MessageBox.Show("Cập nhật thông tin nguyên liệu thành công!", "Thông báo");
                                LoadDSNL();
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thông tin nguyên liệu thât bại!", "Thông báo");
                            }
                        }
                        break;
                }
            }
        
        }
    }
}
