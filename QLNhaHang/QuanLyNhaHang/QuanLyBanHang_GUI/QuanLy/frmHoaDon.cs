using FontAwesome.Sharp;
using QLNH_BUS;
using QLNH_DTO;
using QuanLyBanHang_GUI.QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_GUI
{
    public partial class frmHoaDon : Form
    {
        private bool readOnly = true;
        private int sua = 0;
        private int them = 0;
        private string maNV = "";
        private string thaoTac = "";
        private string loaiTrang = "";
        private bool luuShow=true;
        HOADON_BUS hdBUS=new HOADON_BUS();
        HOADON_DTO hdDTO;
        public frmHoaDon(string loaiTrang, string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.loaiTrang = loaiTrang;
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

        private void btnChiTietHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chi tiết hóa đơn", "Thông báo");
        }

        private void btnChiTietHD_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(31, 32, 71);
            ((Button)sender).ForeColor = System.Drawing.Color.White;
        }

        private void btnChiTietHD_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(240, 246, 255);
            ((Button)sender).ForeColor = System.Drawing.Color.FromArgb(31, 32, 71);
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            colNgayLap.DefaultCellStyle.Format = "dd/MM/yyyy";
            colNgayTT.DefaultCellStyle.Format = "dd/MM/yyyy";
            
            dgvDSHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvDSHoaDon.AutoGenerateColumns = false;
            dgvDSHoaDon.AllowUserToResizeRows = false;
            switch (loaiTrang)
            {
                case "Bep":
                    LoadDSHoaDonChuaPhucVu();
                    AnControls();
                    break;
                case "QL":
                    LoadDSHD();
                   
                    break;
                case "TN":
                    LoadDSHD();
                    break;
                case "TT":
                    LoadDSHDTT();
                    btnThanhToan.Visible = false;
                    break;
            }
            
            dgvDSHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void AnControls()
        {
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnLamMoi.Visible = false;
            btnLuu.Visible = false;
            btnChiTiet.Location = new Point(190, 252);
            btnThanhToan.Location = new Point(23, 323);
            btnThanhToan.Text = "Xác nhận hoàn thành";
        }
        private void LoadDSHoaDonChuaPhucVu()
        {
            List<HOADON_DTO> dsHoaDon = hdBUS.LoadDSHoaDonChuaPhucVu();
            dgvDSHoaDon.DataSource = dsHoaDon;
            readOnly = false;
            KiemTraReadOnly();
        }

        private void LoadDSHD()
        {
            List<HOADON_DTO> dsHoaDon = hdBUS.LoadDSHoaDon();
            dgvDSHoaDon.DataSource = dsHoaDon;
            readOnly = false;
            KiemTraReadOnly();
        }
        private void dgvDSHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDSHoaDon.SelectedRows.Count > 0)
            {
                if (loaiTrang == "QL" ||loaiTrang=="TN")
                {
                    HOADON_DTO hd = dgvDSHoaDon.SelectedRows[0].DataBoundItem as HOADON_DTO;
                    if(hd != null)
                    {
                        txtMaHoaDon.Text = hd.MaHoaDon;
                        txtMaNVLap.Text = hd.MaNV.ToString();
                        dtpNgayLap.Value = DateTime.Parse(hd.NgayLap);
                        cboTrangThai.SelectedIndex = (hd.TrangThai == "Đã phục vụ" ? 1 : 0);
                        if (hd.NgayThanhToan == "" && hd.TrangThai == "Đã phục vụ")
                        {
                            dtpNgayThanhToan.CustomFormat = " ";
                            btnThanhToan.Visible = true;
                        }
                        else
                        {
                            if (hd.TrangThai == "Chưa phục vụ")
                            {
                                //dtpNgayThanhToan.CustomFormat = "dd/MM/yyyy";
                                dtpNgayThanhToan.CustomFormat = " ";
                                //dtpNgayThanhToan.Value = DateTime.Parse(hd.NgayThanhToan);
                                btnThanhToan.Visible = false;
                            }
                            else
                            {
                                if (dtpNgayThanhToan.Value.ToString() != "")
                                {
                                    btnThanhToan.Visible = false;
                                }
                                else
                                {
                                    dtpNgayThanhToan.CustomFormat = "dd/MM/yyyy";
                                }
                            }


                        }
                    }
                    

                }
                else
                {
                    HOADON_DTO hd = dgvDSHoaDon.SelectedRows[0].DataBoundItem as HOADON_DTO;
                    if (hd != null)
                    {
                        txtMaHoaDon.Text = hd.MaHoaDon;
                        txtMaNVLap.Text = hd.MaNV.ToString();
                        dtpNgayLap.Value = DateTime.Parse(hd.NgayLap);
                        cboTrangThai.SelectedIndex = (hd.TrangThai == "Đã phục vụ" ? 1 : 0);
                        if (hd.NgayThanhToan == "")
                        {
                            dtpNgayThanhToan.CustomFormat = " ";
                            btnThanhToan.Visible = true;
                        }
                        else
                        {
                            dtpNgayThanhToan.CustomFormat = "dd/MM/yyyy";
                            //dtpNgayThanhToan.CustomFormat = " ";
                            dtpNgayThanhToan.Value = DateTime.Parse(hd.NgayThanhToan);
                            btnThanhToan.Visible = false;


                        }
                    }
                    
                }
                
                
            }
            else
            {
                if (them == 1)
                {
                    txtMaHoaDon.Text= DateTime.Now.ToString("ddMMHHmmssfff");
                }
                else
                {
                    txtMaHoaDon.Text = string.Empty;
                }
                txtMaNVLap.Text = "";
                dtpNgayThanhToan.CustomFormat = "dd/MM/yyyy";
                dtpNgayLap.Value = DateTime.Now;
                dtpNgayThanhToan.Value = DateTime.Now;
                cboTrangThai.SelectedIndex = 0;

            }
        }
        private void LayThongTin(HOADON_DTO hdDTO)
        {
            hdDTO.MaHoaDon = txtMaHoaDon.Text;
            hdDTO.NgayLap = dtpNgayLap.Value.Date.ToString();
            dtpNgayThanhToan.CustomFormat = " ";
            hdDTO.NgayThanhToan =null;
            hdDTO.MaNV = this.maNV;
            hdDTO.TrangThai = "Chưa phục vụ";
        }
        private bool KiemTraBan()
        {
            return hdBUS.KiemTraBan();
        }
        private void LoadDSHDTT()
        {
            List<HOADON_DTO> dsHoaDon = hdBUS.LoadDSHoaDonTT();
            dgvDSHoaDon.DataSource = dsHoaDon;
            readOnly = false;
            KiemTraReadOnly();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (KiemTraBan())
            {
                dtpNgayLap.Value=DateTime.Now;
                txtMaHoaDon.Text = DateTime.Now.ToString("ddMMHHmmssfff");

                hdDTO = new HOADON_DTO();
                LayThongTin(hdDTO);
                if (hdBUS.ThemHoaDon(hdDTO))
                {
                    frmChiTietHoaDon ct = new frmChiTietHoaDon(txtMaHoaDon.Text);
                    ct.ShowDialog();
                }
                switch (loaiTrang)
                {
                    case "QL":
                        LoadDSHD();
                        break;
                    case "TN":
                        LoadDSHD();
                        break;
                    case "TT":
                        LoadDSHDTT();
                        break;
                }
                
                dtpNgayThanhToan.CustomFormat = "dd/MM/yyyy";
            }
            else
            {
                MessageBox.Show("Không còn bàn trống nào cả!", "Thông báo");
            }
            
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvDSHoaDon.SelectedRows.Count > 0)
            {

                frmXemChiTietHoaDon ct = new frmXemChiTietHoaDon(txtMaHoaDon.Text,loaiTrang) ;
                ct.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn nào để xem!", "Thông báo");
            }
        }
        private void KiemTraReadOnly()
        {
            if (readOnly == true)
            {
                txtMaHoaDon.ReadOnly = false;
                txtMaNVLap.ReadOnly = false;
                dtpNgayLap.Enabled = true;
                dtpNgayThanhToan.Enabled = true;
                cboTrangThai.Enabled = true;
                //txtMaHoaDon.Text = DateTime.Now.ToString("ddMMHHmmssfff");
                readOnly = false;
            }
            else
            {
                txtMaHoaDon.ReadOnly = true;
                txtMaNVLap.ReadOnly = true;
                dtpNgayLap.Enabled = false;
                dtpNgayThanhToan.Enabled = false;
                cboTrangThai.Enabled = false;
                cboTrangThai.SelectedIndex = 0;
                //if (them == 0)
                //{
                //    //maHD = DateTime.Now.ToString("ddMMHHmmssfff");
                //    txtMaHoaDon.Text = "";
                //    them++;
                //}
                //else
                //{
                //    txtMaHoaDon.Text = "";
                //    them--;
                //}
                
                readOnly = true;
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSHD();
            dgvDSHoaDon.ClearSelection();
            readOnly = false;
            KiemTraReadOnly();
            btnLuu.Visible = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSHoaDon.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (hdBUS.XoaHoaDon(txtMaHoaDon.Text))
                    {
                        MessageBox.Show($"Xóa hóa đơn :{txtMaHoaDon.Text} thành công!", "Thông báo");
                        switch (loaiTrang)
                        {
                            case "Bep":
                                LoadDSHoaDonChuaPhucVu();
                                break;
                            case "QL":
                                LoadDSHD();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Xóa hóa đơn :{txtMaHoaDon.Text} thất bại!", "Thông báo");
                    }

                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSHoaDon.SelectedRows.Count > 0)
            {
                if (luuShow)
                {
                    btnLuu.Visible = true;
                    luuShow = false;
                }
                else
                {
                    btnLuu.Visible = false;
                    luuShow = true;
                }
                KiemTraReadOnly();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }
        }

        private int TimMaBan(string maHD)
        {
            return hdBUS.TimMaBan(maHD);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvDSHoaDon.SelectedRows.Count > 0)
            {
               
                {
                    string mahd;
                    switch (loaiTrang)
                    {
                        case "QL":
                            DialogResult drTT = MessageBox.Show($"Bạn muốn thanh toán hóa đơn {txtMaHoaDon.Text}?", "Thông báo", MessageBoxButtons.YesNo);
                            if (drTT == DialogResult.Yes)
                            {
                                mahd = txtMaHoaDon.Text;
                                if (hdBUS.ThanhToanHD(txtMaHoaDon.Text, TimMaBan(txtMaHoaDon.Text)))
                                {
                                    MessageBox.Show($"Thanh toán hóa đơn :{txtMaHoaDon.Text} thành công!", "Thông báo");
                                    LoadDSHD();

                                    DialogResult dlr = MessageBox.Show("Bạn có muốn in ra hóa đơn không", "Thông Báo", MessageBoxButtons.YesNo);
                                    if (dlr == DialogResult.Yes)
                                    {
                                        frmViewReport f = new frmViewReport();
                                        f.LayThongTinHD(mahd);
                                        f.Show();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"Thanh toán hóa đơn :{txtMaHoaDon.Text} thất bại!", "Thông báo");
                                }
                                
                            }
                            break;
                        case "Bep":
                            DialogResult drPV = MessageBox.Show($"Bạn muốn xác nhận hoàn thành hóa đơn {txtMaHoaDon.Text}?", "Thông báo", MessageBoxButtons.YesNo);
                            if (drPV == DialogResult.Yes)
                            {
                                mahd = txtMaHoaDon.Text;
                                if (hdBUS.CapNhatPhucVu(txtMaHoaDon.Text, TimMaBan(txtMaHoaDon.Text)))
                                {
                                    MessageBox.Show($"Phục vụ hóa đơn :{txtMaHoaDon.Text} thành công!", "Thông báo");
                                    LoadDSHoaDonChuaPhucVu();
                                    //frmViewReport f = new frmViewReport();
                                    //f.LayThongTinHD(mahd);
                                    //f.Show();
                                }
                                else
                                {
                                    MessageBox.Show($"Phục vụ hóa đơn :{txtMaHoaDon.Text} thất bại!", "Thông báo");
                                }
                            }
                             
                            break;
                    }
                    
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }
        }

        

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboTrangThai.SelectedIndex == 0)
            {
                lblNgayThanhToan.Visible = false;
                dtpNgayThanhToan.Visible=false;
            }
            else
            {
                dtpNgayThanhToan.Value=DateTime.Now;
                lblNgayThanhToan.Visible = true;
                dtpNgayThanhToan.Visible = true;
                dtpNgayThanhToan.CustomFormat = "dd/MM/yyyy";
            }
        }
        private void LayThongTinSua(HOADON_DTO hd)
        {
            hd.MaHoaDon = txtMaHoaDon.Text;
            dtpNgayLap.CustomFormat = "MM/dd/yyyy";
            hd.MaNV = txtMaNVLap.Text;
            hd.NgayLap=dtpNgayLap.Text;
            dtpNgayThanhToan.CustomFormat = "MM/dd/yyyy";
            hd.NgayThanhToan=dtpNgayThanhToan.Text;
            hd.TrangThai = cboTrangThai.Text;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(dgvDSHoaDon.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có thật sự muốn sửa?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    hdDTO = new HOADON_DTO();
                    LayThongTinSua(hdDTO);
                    if (hdBUS.SuaThongTin(hdDTO))
                    {
                        MessageBox.Show("Sửa thông tin thành công!", "Thông báo");
                        switch (loaiTrang)
                        {
                            case "Bep":
                                LoadDSHoaDonChuaPhucVu();
                                break;
                            case "QL":
                                LoadDSHD();
                                break;
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin thất bại!", "Thông báo");
                    }
                }
                btnLamMoi_Click(sender, e);
                dtpNgayLap.CustomFormat = "dd/MM/yyyy";
                btnLuu.Visible = false;
                luuShow = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (dtpNgayLap.Enabled == false)
            {
                dgvDSHoaDon.ClearSelection();
                dtpNgayLap.Enabled = true;
                dtpNgayLap.Value=DateTime.Now;
            }
            else
            {
                dgvDSHoaDon.DataSource = hdBUS.TimHD(dtpNgayLap.Value.ToString("yyyy/MM/dd"));
                dtpNgayLap.Enabled = false;
            }
        }
    }
}
