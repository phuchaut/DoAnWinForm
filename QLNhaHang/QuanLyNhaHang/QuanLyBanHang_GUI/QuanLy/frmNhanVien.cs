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
    public partial class frmNhanVien : Form
    {
        private bool readOnly = true;
        private int sua = 0;
        private string thaoTac = "";
        NHANVIEN_BUS nvBUS = new NHANVIEN_BUS();
        public frmNhanVien()
        {
            InitializeComponent();
          

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvDSNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSNV.AllowUserToResizeRows = false;
            dgvDSNV.AutoGenerateColumns = false;
            LoadNV();
            cboLoaiNV.SelectedIndex = 0;
            colNgaySinh.DefaultCellStyle.Format = "dd/MM/yyyy";
            
            dgvDSNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadNV()
        {
            List<NHANVIEN_DTO> dsNV = nvBUS.LoadDSNV();
            //dgvDSNV.AutoGenerateColumns = false;
            dgvDSNV.DataSource = dsNV;
            dgvDSNV.ClearSelection();
            readOnly = false;
            KTReadOnly();
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
        private void KTReadOnly()
        {
            if (readOnly == true)
            {
                txtMaNV.ReadOnly = false;
                txtHoTen.ReadOnly = false;
                txtDiaChi.ReadOnly = false;
                txtCCCD.ReadOnly = false;
                txtLuong.ReadOnly = false;
                dtpNgaySinh.Enabled = true;
                cboLoaiNV.Enabled = true;
                radNam.Enabled = true;
                radNu.Enabled = true;
                readOnly = false;
                txtMatKhau.ReadOnly = false;
            }
            else
            {
                txtMaNV.ReadOnly = true;
                txtHoTen.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                txtCCCD.ReadOnly = true;
                txtLuong.ReadOnly = true;
                txtMatKhau.ReadOnly = true;
                dtpNgaySinh.Enabled = false;
                cboLoaiNV.Enabled = false;
                radNam.Enabled = false;
                radNu.Enabled = false;
                readOnly = true;
            }

        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (sua == 1)
            {
                readOnly = true;
                sua--;
            }
            string maNVCaoNhat = nvBUS.LayMaNV();

            // Tách phần chữ và phần số
            string prefix = maNVCaoNhat.Substring(0, 2); // "nv"
            string numberPart = maNVCaoNhat.Substring(2); // "01"
            string newText = "";
            // Chuyển đổi phần số thành số nguyên
            int number;
            if (int.TryParse(numberPart, out number))
            {
                // Tăng giá trị số lên 1
                number++;

                // Ghép phần chữ và phần số đã tăng lên lại
                newText = prefix + number.ToString("D2");

                // Đưa giá trị mới vào TextBox
                txtMaNV.Text = newText;
            }
            else
            {
                // Xử lý trường hợp phần số không hợp lệ (nếu cần)
                MessageBox.Show("Chuỗi không hợp lệ");
            }

            KTReadOnly();
            dgvDSNV.ClearSelection();
            txtMaNV.Text = newText;
            thaoTac = "Them";
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (dgvDSNV.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    NHANVIEN_DTO nv = dgvDSNV.SelectedRows[0].DataBoundItem as NHANVIEN_DTO;
                    if (nvBUS.XoaNhanVien(nv.MaNV))
                    {
                        MessageBox.Show($"Xóa nhân viên với mã nhân viên: {nv.MaNV}, tên:{nv.HoTen} thành công!", "Thông báo");
                        LoadNV();
                    }
                    else
                    {
                        MessageBox.Show($"Xóa nhân viên với mã nhân viên: {nv.MaNV} thất bại!", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show($"Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }
            thaoTac = "";

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (dgvDSNV.SelectedRows.Count > 0)
            {
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
                KTReadOnly();
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }
            
           
        }

        private void dgvDSNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSNV.SelectedRows.Count > 0)
            {
                NHANVIEN_DTO nv = dgvDSNV.SelectedRows[0].DataBoundItem as NHANVIEN_DTO;
                txtMaNV.Text = nv.MaNV;
                txtHoTen.Text = nv.HoTen;
                dtpNgaySinh.Value = nv.NgaySinh;
                txtCCCD.Text = nv.CCCD;
                txtMatKhau.Text = nv.MatKhau;
                switch (nv.LoaiNhanVien)
                {
                    case "BT":
                        cboLoaiNV.SelectedIndex = 0; break;
                    case "TN":
                        cboLoaiNV.SelectedIndex = 1; break;
                    case "NVB":
                        cboLoaiNV.SelectedIndex = 2; break;
                    case "TT":
                        cboLoaiNV.SelectedIndex = 3; break;
                }
                cboLoaiNV.Text = nv.LoaiNhanVien;
                txtLuong.Text = nv.Luong.ToString();
                if (nv.Phai == "Nam")
                {
                    radNam.Checked = true;
                    //radNu.Checked = false; ;
                }
                else
                {
                    radNu.Checked = true;
                    //radNam.Checked = false;
                }
                txtDiaChi.Text = nv.DiaChi;
            }
            else
            {
                txtMaNV.Text = txtHoTen.Text = txtCCCD.Text = txtLuong.Text = txtDiaChi.Text = string.Empty;
                dtpNgaySinh.Value = DateTime.Now;
                cboLoaiNV.SelectedIndex = 0;
            }
        }
        private void btnMouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(31, 32, 71);
            //((Button)sender).ForeColor = System.Drawing.Color.White;
            ((IconButton)sender).IconColor = System.Drawing.Color.White;
            ((IconButton)sender).ForeColor = System.Drawing.Color.White;
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(240, 246, 255);
            //((Button)sender).ForeColor = System.Drawing.Color.FromArgb(31, 32, 71);
            ((IconButton)sender).IconColor = System.Drawing.Color.FromArgb(31, 32, 71);
            ((IconButton)sender).ForeColor = System.Drawing.Color.FromArgb(31, 32, 71);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadNV();
            dgvDSNV.ClearSelection();
            readOnly = false;
            KTReadOnly();
            this.thaoTac = "";
            

        }
        private bool checkDuoi18Tuoi()
        {
            int namHienTai=DateTime.Now.Year;
            int namSinh = dtpNgaySinh.Value.Year;
            if(namHienTai - namSinh < 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checkEmpty()
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                            string.IsNullOrWhiteSpace(txtCCCD.Text) || string.IsNullOrWhiteSpace(txtLuong.Text) ||
                            string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool KiemTraMaNV(string maNV)
        {
            int kq = nvBUS.KiemTraMaNV(maNV);
            return kq > 0;
        }
        private void LayThongTin(NHANVIEN_DTO nv)
        {
            string matKhauMH = Utils.MaHoaMDS(txtMatKhau.Text);
            nv.MaNV = txtMaNV.Text;
            nv.HoTen = txtHoTen.Text;
            nv.CCCD = txtCCCD.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.Luong = decimal.Parse(txtLuong.Text);
            nv.MatKhau = txtMatKhau.Text;
            nv.MatKhauMH=matKhauMH;
            nv.LoaiNhanVien = cboLoaiNV.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            if (radNam.Checked)
            {
                nv.Phai = radNam.Text;
            }
            else
            {
                nv.Phai = radNu.Text;
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
                switch(thaoTac)
                {
                    case "Them":
                        if (checkEmpty())
                        {
                            MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo");
                        }
                        
                        else
                        {
                            if (checkDuoi18Tuoi())
                            {
                                MessageBox.Show("Tuổi chưa đủ 18!", "Thông Báo");
                            }
                            else
                            {
                                if (KiemTraMaNV(txtMaNV.Text))
                                {
                                    MessageBox.Show($"Mã nhân viên :{txtMaNV.Text} đã tồn tại!", "Thông báo");
                                }
                                else
                                {
                                    NHANVIEN_DTO nv = new NHANVIEN_DTO();
                                    LayThongTin(nv);
                                    if (nvBUS.ThemNhanVien(nv))
                                    {
                                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                                        LoadNV();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm nhân viên thât bại!", "Thông báo");
                                    }
                                    thaoTac = "";
                                }

                            }
                        }
                        
                        break;
                    case "Sua":
                        if (checkDuoi18Tuoi() && checkEmpty())
                        {
                            MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo");
                        }
                        else
                        {
                            NHANVIEN_DTO nv = new NHANVIEN_DTO();
                            LayThongTin(nv);
                            if (nvBUS.CapNhatTTNV(nv))
                            {
                                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo");
                                LoadNV();
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thông tin nhân viên thât bại!", "Thông báo");
                            }
                            thaoTac = "";
                        }
                        break;
                }
            }
        }

        private void dgvDSNV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.CellStyle.BackColor = System.Drawing.Color.FromArgb(31, 32, 71);
                e.CellStyle.ForeColor = Color.White;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.ReadOnly == true)
            {
                dgvDSNV.ClearSelection();
                txtHoTen.ReadOnly = false;
            }
            else
            {
                dgvDSNV.DataSource = nvBUS.TimNhanVien(txtHoTen.Text.Trim());
                txtHoTen.ReadOnly = true;
            }
            
        }
    }
}
