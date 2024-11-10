using QLNH_BUS;
using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace QuanLyBanHang_GUI.QuanLy
{
    public partial class frmXemChiTietHoaDon : Form
    {
        CHITIETHOADON_DTO ct;
        List<CHITIETHOADON_DTO> dsCT;
        CHITIETHOADON_BUS ctBUS = new CHITIETHOADON_BUS();
        List<MONAN_DTO> dsMa;
        MONAN_DTO ma;
        MONAN_BUS maBUS;
        BANAN_DTO ba;
        List<BANAN_DTO> dsBan;
        private string maHoaDon = "";
        private string tenMonAn = "";
        private float tongTien = 0;
        private string loaiTrang = "";
        public frmXemChiTietHoaDon(string maHD,string loaiTrang)
        {
            InitializeComponent();
            this.maHoaDon = maHD;
            this.loaiTrang = loaiTrang;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Move(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void LoadDSCTHD(string maHoaDon)
        {
            dsCT = ctBUS.LoadDSCT(this.maHoaDon);
            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.DataSource = dsCT;
            dgvHoaDon.ClearSelection();
        }
        private void LoadDSMonAn()
        {
            dsMa = ctBUS.LoadDSMonAn();
            cboDSMonAn.DataSource = dsMa;
            cboDSMonAn.DisplayMember = "TenMonAn";
            cboDSMonAn.ValueMember = "MaMonAn";
            cboDSMonAn.AutoCompleteMode = AutoCompleteMode.Suggest;
            // Thiết lập AutoCompleteSource để chỉ định nguồn dữ liệu cho gợi ý từ danh sách mục trong ComboBox
            cboDSMonAn.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboDSMonAn.DataSource = dsMa;
        }
        private CHITIETHOADON_DTO LayThongTin(string maHD)
        {
            return ctBUS.LayThongTin(maHD);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int MaBanAn()
        {
            return ctBUS.TimMaBanAn(this.maHoaDon);
        }
        private void TinhTongTien()
        {
            decimal total = 0;

            // Duyệt qua từng hàng trong DataGridView
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                // Kiểm tra xem hàng có dữ liệu không
                if (!row.IsNewRow)
                {
                    // Lấy giá trị của cột đơn giá và số lượng
                    decimal donGia = Convert.ToDecimal(row.Cells[2].Value);
                    int soLuong = Convert.ToInt32(row.Cells[1].Value);

                    // Tính tổng tiền của hàng và cộng vào tổng tiền tổng cộng
                    total += donGia * soLuong;
                }
            }

            // Gán giá trị tổng tiền vào Label
            lblTongTien.Text = total.ToString();
        }
        private void frmXemChiTietHoaDon_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = maHoaDon;
            ct = new CHITIETHOADON_DTO();
            ct=LayThongTin( maHoaDon);
            txtTenKhachHang.Text = ct.TenKH;
            txtSDT.Text = ct.SDT;
            LoadDSCTHD(maHoaDon);
            LoadDSMonAn();
            //LoadDSBanAn();
            cboBanAn.Text = MaBanAn().ToString();
            cboDSMonAn.Text = "";
            nudSoLuong.Value = 1;
            
            dgvHoaDon.ClearSelection();
            TinhTongTien();
            if (loaiTrang == "Bep")
            {
                AnControls();
                nudSoLuong.Value = 0;
            }
            //btnLapHD.Visible = false;
        }
        private void AnControls()
        {
            lblTenKhachHang.Visible = false;
            lblsdt.Visible  = false;
            lblmaBanAn.Location = new Point(108, 106);
            lblTenMA.Location = new Point(108, 154);
            lblSoLuong.Location = new Point(108, 202);
            txtTenKhachHang.Visible=false;
            txtSDT.Visible=false;
            cboBanAn.Location = new Point(305, 108);
            cboDSMonAn.Location = new Point(305, 156);
            nudSoLuong.Location = new Point(305, 204);
            btnXoaMon.Visible = false;
            btnTangSoLuong.Visible = false;
            btnLamMoi.Visible = false;
            btnGiamSL.Visible = false;
            btnThem.Visible = false;
            btnLapHD.Visible = false;
            txtMaHD.ReadOnly = true;
            nudSoLuong.ReadOnly = true;
            cboBanAn.Enabled = false;
            cboDSMonAn.Enabled = false;
            dgvHoaDon.Location = new Point(112, 254);
            btnHuy.Location = new Point(502, 773);
            dgvHoaDon.Size = new Size(525, 465);
            //txtMaHD.Enabled = false;
        }
        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {

                CHITIETHOADON_DTO ctHD = dgvHoaDon.SelectedRows[0].DataBoundItem as CHITIETHOADON_DTO;
                if (ctHD != null)
                {
                    cboDSMonAn.Text = ctHD.TenMonAn;
                    nudSoLuong.Value = ctHD.SoLuong;
                }

            }
            else
            {
                //cboDSMonAn.SelectedIndex =0;
                nudSoLuong.Value = 1;
            }
        }
        private void FocusRow(string tenMonAn)
        {
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.Cells[0].Value.ToString() == tenMonAn)
                {
                    // Tìm thấy dòng, focus vào dòng đó
                    row.Selected = true;
                    dgvHoaDon.CurrentCell = row.Cells[0];
                    dgvHoaDon.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void btnGiamSL_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                CHITIETHOADON_DTO ct = dgvHoaDon.SelectedRows[0].DataBoundItem as CHITIETHOADON_DTO;
                if (ct.SoLuong > 1)
                {
                    if (ctBUS.GiamSL(txtMaHD.Text, cboDSMonAn.SelectedIndex + 1))
                    {
                        tenMonAn = cboDSMonAn.Text;
                        LoadDSCTHD(txtMaHD.Text);
                        FocusRow(tenMonAn);
                        tongTien = float.Parse(lblTongTien.Text);
                        tongTien = (tongTien - LayDonGia(cboDSMonAn.SelectedIndex + 1));
                        lblTongTien.Text = tongTien.ToString();
                    }

                }
                else
                {
                    btnXoaMon_Click(sender, e);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }

        }
        private float LayDonGia(int maMonAn)
        {
            maBUS = new MONAN_BUS();
            return maBUS.LayDonGia(maMonAn);
        }
        private void LayThongTin(CHITIETHOADON_DTO ct)
        {
            ct.MaHoaDon = maHoaDon;
            ct.TenMonAn = cboDSMonAn.Text;
            ct.SoLuong = (int)nudSoLuong.Value;
            ct.DonGia = LayDonGia(cboDSMonAn.SelectedIndex + 1);
            ct.MaBanAn = int.Parse(cboBanAn.Text);
            ct.MaMonAn = cboDSMonAn.SelectedIndex + 1;
        }
        private bool KTTonTai(int maMonAn, string maHD)
        {
            if (ctBUS.KTTonTai(maMonAn, maHD))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnTangSoLuong_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {

                tenMonAn = cboDSMonAn.Text;
                if (ctBUS.TangSL(txtMaHD.Text, cboDSMonAn.SelectedIndex + 1))
                {
                    LoadDSCTHD(txtMaHD.Text);
                    FocusRow(tenMonAn);
                    tongTien = float.Parse(lblTongTien.Text);
                    tongTien = (tongTien + LayDonGia(cboDSMonAn.SelectedIndex + 1));
                    lblTongTien.Text = tongTien.ToString();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                CHITIETHOADON_DTO ct = dgvHoaDon.SelectedRows[0].DataBoundItem as CHITIETHOADON_DTO;
                if (ctBUS.XoaMon(txtMaHD.Text, cboDSMonAn.SelectedIndex + 1))
                {
                    LoadDSCTHD(txtMaHD.Text);
                    tongTien = (tongTien - ct.DonGia * ct.SoLuong);
                    lblTongTien.Text = tongTien.ToString();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboDSMonAn.Text != "")
            {
                CHITIETHOADON_DTO ct = new CHITIETHOADON_DTO();
                LayThongTin(ct);
                if (KTTonTai(ct.MaMonAn, ct.MaHoaDon))
                {
                    if (ctBUS.CapNhatMonAn(ct.MaMonAn, (int)nudSoLuong.Value, ct.MaHoaDon))
                    {
                        LoadDSCTHD(ct.MaHoaDon);
                    }
                }
                else
                {
                    if (ctBUS.ThemCTHD(ct))
                    {
                        LoadDSCTHD(this.maHoaDon);

                    }

                }
                tongTien = tongTien + (ct.SoLuong * ct.DonGia);
                lblTongTien.Text = tongTien.ToString();
                //MessageBox.Show(cboBanAn.Text);
                cboDSMonAn.Text = "";
                nudSoLuong.Value = 1;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 món để thêm!", "Thông báo");
            }
            
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            //if (ctBUS.CapNhatBanAn(txtMaHD.Text, (int.Parse(cboBanAn.Text))))
            //{
                if (ctBUS.ThemKhachHang(txtTenKhachHang.Text, txtSDT.Text,txtMaHD.Text))
                {
                    MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo");
                    this.Close();
                    LoadDSCTHD(txtMaHD.Text);
                }
            //}
            else
            {
                MessageBox.Show("Lưu hóa đơn thất bại!", "Thông báo");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvHoaDon.ClearSelection();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void dgvHoaDon_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {

                CHITIETHOADON_DTO ctHD = dgvHoaDon.SelectedRows[0].DataBoundItem as CHITIETHOADON_DTO;
                if (ctHD != null)
                {
                    cboDSMonAn.Text = ctHD.TenMonAn;
                    nudSoLuong.Value = ctHD.SoLuong;
                }

            }
            else
            {
                //cboDSMonAn.SelectedIndex = 0;
                nudSoLuong.Value = 1;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //private void cboBanAn_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int maBa;
        //    if(int.TryParse(cboBanAn.Text, out maBa))
        //    {
        //        if (ctBUS.CapNhatBanAn(txtMaHD.Text, (int.Parse(cboBanAn.Text))))
        //        {
        //            //MessageBox.Show("Cập nhật bàn thành công!", "Thông báo");
        //            //this.Close();
        //            //LoadDSCTHD(txtMaHD.Text);
        //        }
        //    }

        //    //else
        //    //{
        //    //    MessageBox.Show("Lập xóa đơn thất bại!", "Thông báo");
        //    //}
        //}
    }
}
