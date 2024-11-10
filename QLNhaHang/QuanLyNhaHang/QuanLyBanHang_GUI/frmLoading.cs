using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using QuanLyBanHang_GUI.NVThuNgan;
using QuanLyBanHang_GUI.NVTiepTan;
using QLNH_BUS;
using QLNH_DTO;

namespace QuanLyBanHang_GUI
{
    public partial class frmLoading : Form
    {
        //frmLogin f=new frmLogin();
        string loaiNV = "";
        private string maNhanVien = "";
        NHANVIEN_BUS nvBUS;
        NHANVIEN_DTO nvDTO;
        Thread thTrangChu;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmLoading(string loaiNV,string maNV)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.loaiNV = loaiNV;
            this.maNhanVien= maNV;
            prbLoading.Value = 0;
            tmrLoading.Start();
        }
        private void LayThongTinNhanVien(string maNV)
        {
            nvBUS= new NHANVIEN_BUS();
            nvDTO= nvBUS.LayThongTinQL(maNV);
        }
        private void Move(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void MoFormTrangChu()
        {
            switch (this.loaiNV)
            {
                case "QL":
                    Application.Run(new frmTrangQL(this.loaiNV,this.maNhanVien));
                    break;
                case "NVB":
                    Application.Run(new frmTrangNVBep(this.loaiNV, this.maNhanVien));
                    break;
                case "TT":
                    Application.Run(new frmTrangNVTiepTan(this.loaiNV, this.maNhanVien));
                    break;
                case "TN":
                    Application.Run(new frmTrangNVThuNgan(this.loaiNV, this.maNhanVien));
                    break;
                case "BT":
                    Application.Run(new frmTrangNVBep(this.loaiNV, this.maNhanVien));
                    break;
                default:
                    break;
            }
        }
        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            if(prbLoading.Value <100) {
                prbLoading.PerformStep();
                //prbLoading.Value += 5;
            }
            else
            {
                
                tmrLoading.Stop();
               
                thTrangChu = new Thread(MoFormTrangChu);
                thTrangChu.SetApartmentState(ApartmentState.STA);
                thTrangChu.Start();
                this.Close();
            }
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            LayThongTinNhanVien(maNhanVien);
        }
    }
}
