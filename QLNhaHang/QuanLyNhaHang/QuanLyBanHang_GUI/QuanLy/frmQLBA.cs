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
    public partial class frmQLBA : Form
    {
        private int sua=0;
        private bool readOnly = true;
        private string thaoTac = "";
        BANAN_BUS baBUS = new BANAN_BUS();
        public frmQLBA()
        {
            InitializeComponent();
        }
        private void KTReadOnly()
        {
            if (readOnly == true)
            {
                txtMaBan.ReadOnly = false;
                nudSoLuongChoNgoi.Enabled = true;
                cboTrangThai.Enabled = true;
                readOnly = false;
            }
            else
            {
                txtMaBan.ReadOnly = true;
                nudSoLuongChoNgoi.Enabled = false;
                cboTrangThai.Enabled = false;
                readOnly = true;
            }

        }
        private void frmQLBA_Load(object sender, EventArgs e)
        {
            
            dgvDSBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSBan.AllowUserToResizeRows = false;
            //dgvDSBan.AutoGenerateColumns=false;
            LoadBA();
            dgvDSBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void LoadBA()
        {
            List<BANAN_DTO> dsBanAn = baBUS.LoadDSBanAn();
            dgvDSBan.DataSource = dsBanAn;
            dgvDSBan.ClearSelection();
            readOnly = false;
            KTReadOnly();
        }
        private void btnMouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(31, 32, 71);
            //((Button)sender).ForeColor = System.Drawing.Color.White;
            ((IconButton)sender).IconColor = System.Drawing.Color.White;
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(240, 246, 255);
            //((Button)sender).ForeColor = System.Drawing.Color.FromArgb(31, 32, 71);
            ((IconButton)sender).IconColor = System.Drawing.Color.FromArgb(31, 32, 71);
        }

        private void dgvDSBan_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDSBan.SelectedRows.Count > 0)
            {
                BANAN_DTO ba = dgvDSBan.SelectedRows[0].DataBoundItem as BANAN_DTO;
                txtMaBan.Text = ba.MaBanAn.ToString();
                nudSoLuongChoNgoi.Value = ba.SoChoNgoi;
                if (ba.TrangThai == 0)
                {
                    cboTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cboTrangThai.SelectedIndex = 0;
                }
                
            }
            else
            {
                txtMaBan.Text=string.Empty;
                nudSoLuongChoNgoi.Value = 0;
                cboTrangThai.SelectedIndex =1;
            }
        }
        private void btnLuu_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(31, 32, 71);
            //((Button)sender).ForeColor = System.Drawing.Color.White;
            ((IconButton)sender).IconColor = System.Drawing.Color.White;
            ((IconButton)sender).ForeColor = System.Drawing.Color.White;

        }

        private void btnLuu_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(240, 246, 255);
            //((Button)sender).ForeColor = System.Drawing.Color.FromArgb(31, 32, 71);
            ((IconButton)sender).IconColor = System.Drawing.Color.FromArgb(31, 32, 71);
            ((IconButton)sender).ForeColor = System.Drawing.Color.FromArgb(31, 32, 71);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (sua == 1)
            {
                readOnly = true;
                sua--;
            }
            
            KTReadOnly();
            dgvDSBan.ClearSelection();
            cboTrangThai.SelectedIndex = 1;
            thaoTac = "Them";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDSBan.SelectedRows.Count > 0)
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSBan.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa bàn này?", "Thông báo", MessageBoxButtons.YesNo);
                if(dr== DialogResult.Yes)
                {
                    if (baBUS.XoaBanAn(int.Parse(txtMaBan.Text)))
                    {
                        MessageBox.Show("Xóa bàn ăn thành công!", "Thông báo");
                        LoadBA();
                    }
                    else
                    {
                        MessageBox.Show("Bàn ăn này đã tồn tại trong 1 hóa đơn nào đó!", "Thông báo");
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }
            thaoTac = "";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDSBan.ClearSelection();
            readOnly = false;
            KTReadOnly();
            this.thaoTac = "";
        }
        private bool checkEmpty()
        {
            if (string.IsNullOrWhiteSpace(txtMaBan.Text) || nudSoLuongChoNgoi.Value==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool KiemTraBanAN(string maBanAn)
        {
            int kq = baBUS.KiemTraBanAN(maBanAn);
            return kq > 0;
        }
        private void LayThongTin(BANAN_DTO ba)
        {
            ba.MaBanAn = int.Parse(txtMaBan.Text);
            ba.SoChoNgoi = (int)nudSoLuongChoNgoi.Value;
            if(cboTrangThai.SelectedIndex == 0)
            {
                ba.TrangThai = 1;
            }
            else
            {
                ba.TrangThai = 0;
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
                if (checkEmpty())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
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
                                if (KiemTraBanAN(txtMaBan.Text))
                                {
                                    MessageBox.Show($"Mã bàn ăn :{txtMaBan.Text} đã tồn tại!", "Thông báo");
                                }
                                else
                                {
                                    BANAN_DTO ba = new BANAN_DTO();
                                    LayThongTin(ba);
                                    if (baBUS.ThemBanAn(ba))
                                    {
                                        MessageBox.Show("Thêm bàn ăn thành công!", "Thông báo");
                                        LoadBA();

                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm bàn ăn thât bại!", "Thông báo");
                                    }
                                    thaoTac = "";
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
                                BANAN_DTO ba = new BANAN_DTO();
                                LayThongTin(ba);
                                if (baBUS.CapNhatTTBA(ba))
                                {
                                    MessageBox.Show("Cập nhật thông tin bàn ăn thành công!", "Thông báo");
                                    LoadBA();
                                }
                                else
                                {
                                    MessageBox.Show("Cập nhật thông tin bàn ăn thât bại!", "Thông báo");
                                }
                                thaoTac = "";
                            }
                            break;
                    }
                }
            }
            
        }
    }
}
