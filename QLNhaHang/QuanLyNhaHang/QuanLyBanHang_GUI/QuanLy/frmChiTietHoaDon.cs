using QLNH_BUS;
using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QuanLyBanHang_GUI.QuanLy
{
    public partial class frmChiTietHoaDon : Form
    {
        CHITIETHOADON_DTO ct;
        List<CHITIETHOADON_DTO> dsCT;
        List<MONAN_DTO> dsMa;
        BANAN_DTO ba;
        List<BANAN_DTO> dsBan;
        MONAN_DTO ma;
        CHITIETHOADON_BUS ctBUS=new CHITIETHOADON_BUS();
        MONAN_BUS maBUS;
        private string maHoaDon = "";
        private string tenMonAn = "";
        private float tongTien = 0;
        private string thaoTac = "";
        public frmChiTietHoaDon(string maHD)
        {
            InitializeComponent();
            maHoaDon= maHD;
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
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            //LoadDSCTHD();
                txtMaHD.Text = maHoaDon;
                LoadDSMonAn();
                LoadDSBanAn();
                dgvHoaDon.ClearSelection();
                cboDSMonAn.Text = "";
                nudSoLuong.Value = 1;
            
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
            //cboDSMonAn.DataSource = dsMa;
        }
        private void LoadDSBanAn()
        {
            dsBan = ctBUS.DSBanAn();
            cboBanAn.DataSource = dsBan;
            cboBanAn.DisplayMember = "MaBanAn";
            cboBanAn.ValueMember = "MaBanAn";
            cboBanAn.AutoCompleteMode = AutoCompleteMode.Suggest;
            // Thiết lập AutoCompleteSource để chỉ định nguồn dữ liệu cho gợi ý từ danh sách mục trong ComboBox
            cboBanAn.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboBanAn.DataSource = dsBan;
        }
        private void LoadDSCTHD(string maHoaDon)
        {
            dsCT = ctBUS.LoadDSCT(this.maHoaDon);
            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.DataSource = dsCT;
            nudSoLuong.Value = 1;
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
            ct.MaBanAn =(int)cboBanAn.SelectedValue;
            ct.MaMonAn = cboDSMonAn.SelectedIndex+1;
        }
        private bool KTTonTai(int maMonAn,string maHD)
        {
            if (ctBUS.KTTonTai(maMonAn,maHD))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int KiemTraNguyenLieu(string tenMA)
        {
            return maBUS.KiemTraNguyenLieu(tenMA);
        }
        private int LayMaNguyenLieu(int maMA)
        {
            return maBUS.LayMaNguyenLieu(maMA);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CHITIETHOADON_DTO ct=new CHITIETHOADON_DTO();
            LayThongTin(ct);
            if (ct.SoLuong<=KiemTraNguyenLieu(ct.TenMonAn))
            {
                thaoTac = "Them";
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
                int maNL = LayMaNguyenLieu(ct.MaMonAn);
                if (maBUS.CapNhatNguyenLieu(maNL,thaoTac,ct.SoLuong))
                {

                }
                tongTien = tongTien + (ct.SoLuong * ct.DonGia);
                lblTongTien.Text = tongTien.ToString();
                cboDSMonAn.Text = "";
                nudSoLuong.Value = 1;
               
            }
            else
            {
                MessageBox.Show("Không đủ nguyên liêu cho món ăn này!", "Thông báo");
            }
            dgvHoaDon.ClearSelection();
        }
        private int LaySoLuong(string maHD,int maMonAn)
        {
            return maBUS.LaySoLuong(maHD, maMonAn);
        }
        
        

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvHoaDon.SelectedRows.Count > 0)
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
        private void FocusRow(string tenMonAn)
        {
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.Cells[0].Value.ToString() == tenMonAn)
                {
                    // Tìm thấy dòng, focus vào dòng đó
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
                CHITIETHOADON_DTO ctMaMA = new CHITIETHOADON_DTO();
                LayThongTin(ctMaMA);
                if (ct.SoLuong > 1)
                {
                    if (ctBUS.GiamSL(txtMaHD.Text, cboDSMonAn.SelectedIndex + 1))
                    {
                        tenMonAn = cboDSMonAn.Text;
                        LoadDSCTHD(txtMaHD.Text);
                        FocusRow(tenMonAn);
                        tongTien = (tongTien - LayDonGia(cboDSMonAn.SelectedIndex + 1));
                        lblTongTien.Text = tongTien.ToString();
                        int maNL = LayMaNguyenLieu(ctMaMA.MaMonAn);
                        if (maBUS.CapNhatNguyenLieu(maNL, "Xoa"))
                        {

                        }
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

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            if (ctBUS.CapNhatBanAn(txtMaHD.Text, (int.Parse(cboBanAn.Text))))
            {
                if (ctBUS.ThemKhachHang(txtTenKhachHang.Text, txtSDT.Text,txtMaHD.Text)){
                    MessageBox.Show("Lập xóa đơn thành công!", "Thông báo");
                    this.Close();
                    LoadDSCTHD(txtMaHD.Text);
                }
                
            }
            else
            {
                MessageBox.Show("Lập xóa đơn thất bại!", "Thông báo");
            }

        }
        
        private void btnTangSL_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                CHITIETHOADON_DTO ct = new CHITIETHOADON_DTO();
                LayThongTin(ct);
                if (KiemTraNguyenLieu(ct.TenMonAn)!=0)
                {
                    tenMonAn = cboDSMonAn.Text;
                    if (ctBUS.TangSL(txtMaHD.Text, cboDSMonAn.SelectedIndex + 1))
                    {
                        LoadDSCTHD(txtMaHD.Text);
                        FocusRow(tenMonAn);
                        tongTien = (tongTien + LayDonGia(cboDSMonAn.SelectedIndex + 1));
                        lblTongTien.Text = tongTien.ToString();
                    }
                    int maNL = LayMaNguyenLieu(ct.MaMonAn);
                    if (maBUS.CapNhatNguyenLieu(maNL,"Them"))
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Không đủ nguyên liêu cho món ăn này!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
           
            //DialogResult dr = MessageBox.Show("Bạn không muốn lập hóa đơn này nữa?", "Thông báo", MessageBoxButtons.YesNo);
            //if (dr == DialogResult.Yes)
            //{
            //    if (ctBUS.XoaHD(this.maHoaDon,int.Parse(cboBanAn.Text)))
            //    {
            //        this.Close();
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Bạn chọn ở lại", "Thông báo");
            //}
        }

        
        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                CHITIETHOADON_DTO ct = dgvHoaDon.SelectedRows[0].DataBoundItem as CHITIETHOADON_DTO;
                CHITIETHOADON_DTO ctMaMA = new CHITIETHOADON_DTO();
                LayThongTin(ctMaMA);
                if (ctBUS.XoaMon(txtMaHD.Text, cboDSMonAn.SelectedIndex + 1))
                {
                    LoadDSCTHD(txtMaHD.Text);
                    tongTien = (tongTien - ct.DonGia * ct.SoLuong);
                    lblTongTien.Text = tongTien.ToString();
                    int maNL = LayMaNguyenLieu(ctMaMA.MaMonAn);
                    if (maBUS.CapNhatNguyenLieu(maNL, "Xoa", ct.SoLuong))
                    {

                    }
                    dgvHoaDon.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn không muốn lập hóa đơn này nữa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                int rowCount = dgvHoaDon.Rows.Count;

                foreach (DataGridViewRow row in dgvHoaDon.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string tenMonAn = row.Cells[0].Value.ToString();
                        int soLuong = (int)row.Cells[1].Value;
                        CHITIETHOADON_BUS bs = new CHITIETHOADON_BUS();
                        int kq = bs.CapNhatSoLuong(tenMonAn, soLuong);
                        if (kq == 0)
                        {
                            MessageBox.Show("Hủy thất bại");
                            return;
                        }
                        //MessageBox.Show("Đã hủy thành công");
                    }

                }

                if (ctBUS.XoaHD(this.maHoaDon, int.Parse(cboBanAn.Text)))
                {

                }
                this.Close();

            }
            else
            {
                //MessageBox.Show("Bạn chọn ở lại", "Thông báo");
            }
            //for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            //{
            //    //DataGridViewRow row = dgvHoaDon.Rows[i];
            //    //if (!row.IsNewRow)
            //    //{
            //    //    HuyMon(row);
            //    //}
            //    ////}
            //    MessageBox.Show(dgvHoaDon.Rows[i].ToString());
            //}

        }
        private void HuyMon(DataGridViewRow dt)
        {
            if (dt.Cells[1].Value != null)
            {
                CHITIETHOADON_DTO ct = dt.DataBoundItem as CHITIETHOADON_DTO;
                CHITIETHOADON_DTO ctMaMA = new CHITIETHOADON_DTO();
                LayThongTin(ctMaMA);
                int soLuong = int.Parse(dt.Cells[1].Value.ToString());
                if (ctBUS.XoaMon(txtMaHD.Text, cboDSMonAn.SelectedIndex + 1))
                {
                    LoadDSCTHD(txtMaHD.Text);
                    int maNL = LayMaNguyenLieu(ctMaMA.MaMonAn);
                    if (maBUS.CapNhatNguyenLieu(maNL, "Xoa", soLuong))
                    {
                        dgvHoaDon.ClearSelection();
                    }
                }
            }
            //CHITIETHOADON_DTO ct = dt.DataBoundItem as CHITIETHOADON_DTO;
            //    CHITIETHOADON_DTO ctMaMA = new CHITIETHOADON_DTO();
                //LayThongTin(ctMaMA);
                //if (ctBUS.XoaMon(txtMaHD.Text, cboDSMonAn.SelectedIndex + 1))
                //{
                //    LoadDSCTHD(txtMaHD.Text);
                //    //tongTien = (tongTien - ct.DonGia * ct.SoLuong);
                //    //lblTongTien.Text = tongTien.ToString();
                //    int maNL = LayMaNguyenLieu(ctMaMA.MaMonAn);
                //    if (maBUS.CapNhatNguyenLieu(maNL, "Xoa", int.Parse(dt.Cells[1].Value.ToString())))
                //    {

                //    }
                //    dgvHoaDon.ClearSelection();
                //}
            
        }
        private bool ktSo(string maBa)
        {
            int number;
                if (int.TryParse(maBa,out number)) {
                    return true;
                }
                else
                {
                    return false;
                }
        }

        private void cboBanAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ktSo(cboBanAn.Text))
            {
                if (ctBUS.CapNhatBanAn(txtMaHD.Text, (int.Parse(cboBanAn.Text))))
                {
                    LoadDSCTHD(txtMaHD.Text);
                }

            }
            else
            {

            }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvHoaDon.ClearSelection();
        }
    }
}
