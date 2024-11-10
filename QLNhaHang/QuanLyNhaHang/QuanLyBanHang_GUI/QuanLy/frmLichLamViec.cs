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

namespace QuanLyBanHang_GUI.QuanLy
{
    public partial class frmLichLamViec : Form
    {
        LICHLAMVIEC_DTO ll;
        List<LICHLAMVIEC_DTO> dsll;
        LICHLAMVIEC_BUS llBUS;
        NHANVIEN_BUS nvBUS;
        List<NHANVIEN_DTO> dsNV;
        private bool readOnly = true;
        private string thaoTac = "";
        public frmLichLamViec()
        {
            InitializeComponent();
        }
        private void LoadDSLL()
        {
            llBUS = new LICHLAMVIEC_BUS();
            dsll = llBUS.LoadDSLL();
            dgvLichLamViec.AutoGenerateColumns = false;
            dgvLichLamViec.DataSource = dsll;

        }
        private void frmLichLamViec_Load(object sender, EventArgs e)
        {
            LoadDSLL();
            LoadDSNV();
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
        private void LoadDSNV()
        {
            dsNV = new List<NHANVIEN_DTO>();
            nvBUS=new NHANVIEN_BUS();
            dsNV = nvBUS.LoadDSNV();
            cboDSNV.DataSource = dsNV;
            cboDSNV.DisplayMember = "MaNV";
            cboDSNV.ValueMember = "MaNV";
        }
        private void dgvLichLamViec_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvLichLamViec.SelectedRows.Count > 0)
            {
                ll = dgvLichLamViec.SelectedRows[0].DataBoundItem as LICHLAMVIEC_DTO;
                txtThu.Text = ll.Thu.ToString();
                txtCa.Text= ll.Ca.ToString();
                cboDSNV.Text=ll.MaNhanVien;
            }
            else
            {
                txtCa.Text=txtThu.Text=string.Empty;
                cboDSNV.Text = null;
            }
        }
        private void KTReadOnly()
        {
            if (readOnly == true)
            {
                txtThu.ReadOnly = false;
                txtCa.ReadOnly = false;
                cboDSNV.Enabled = true;
                readOnly = false;
            }
            else
            {
                txtThu.ReadOnly = true;
                txtCa.ReadOnly = true;
                cboDSNV.Enabled = false;
                readOnly = true;
            }

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLichLamViec.SelectedRows.Count > 0)
            {
                KTReadOnly();
                if (thaoTac == "")
                {
                    thaoTac = "Sua";
                }
                else
                {
                    thaoTac = "";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvLichLamViec.ClearSelection();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvLichLamViec.SelectedRows.Count > 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để thao tác!", "Thông báo");
            }
            else
            {
                if (thaoTac == "")
                {
                    MessageBox.Show("Vui lòng sửa thông tin trước khi lưu!", "Thông báo");
                }
                else
                {
                    int thu = int.Parse(txtThu.Text);
                    int ca = int.Parse(txtCa.Text);
                    string maNV = cboDSNV.Text;
                    if (llBUS.CapNhatLichLamViec(thu, ca, maNV))
                    {
                        MessageBox.Show("Cập nhật lịch làm việc thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật lịch làm việc thất bại!", "Thông báo");
                    }
                }

            }
           
        }
    }
}
