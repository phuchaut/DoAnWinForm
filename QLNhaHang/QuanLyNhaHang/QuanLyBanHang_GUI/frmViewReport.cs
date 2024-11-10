using OfficeOpenXml;
using QLNH_BUS;
using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_GUI
{
    public partial class frmViewReport : Form
    {
        public frmViewReport()
        {
            InitializeComponent();
        }

        private void frmViewReport_Load(object sender, EventArgs e)
        {

            this.rpvChiTietHoaDon.RefreshReport();
        }
        public void LayThongTinHD(string mahd)
        {
            HOADON_BUS bs = new HOADON_BUS();
            HOADON_DTO hd = bs.LayThongTinHoaDon(mahd);
            List<CHITIETHOADON_DTO> lsCT = (new CHITIETHOADON_BUS()).LayDanhSachCT(mahd);
            rpvChiTietHoaDon.LocalReport.ReportEmbeddedResource = "QuanLyBanHang_GUI.rpChiTietHoaDon.rdlc";
            rpvChiTietHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paNguoiLap", hd.MaNV));
            rpvChiTietHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paNgayLap", hd.NgayLap));
            rpvChiTietHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("paMaHoaDon", hd.MaHoaDon));
            rpvChiTietHoaDon.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsChiTietHoaDon", lsCT));
            rpvChiTietHoaDon.RefreshReport();
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Đặt ngữ cảnh cấp phép
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    int sum = 0;
                    // Tạo một trang tính mới
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("ChiTietHoaDon");

                    // Thêm tiêu đề cột
                    worksheet.Cells[1, 3].Value = "HÓA ĐƠN";
                    ExcelRange rangeHeader = worksheet.Cells[2, 2, 2, 4];
                    rangeHeader.Merge = true;
                    worksheet.Cells[2, 2].Value = $"Ngày lập: {hd.NgayLap}";
                    ExcelRange rangeHeader1 = worksheet.Cells[3, 2, 3, 4];
                    rangeHeader1.Merge = true;
                    worksheet.Cells[3, 2].Value = $"Người lập:{hd.MaNV}";
                    rangeHeader.Merge = true;
                    ExcelRange rangeHeader2 = worksheet.Cells[4, 2, 4, 4];
                    rangeHeader2.Merge = true;
                    worksheet.Cells[4, 2].Value = $"Mã hóa đơn: {hd.MaHoaDon}";
                    worksheet.Cells[5, 1].Value = "STT";
                    worksheet.Cells[5, 2].Value = "Tên món ăn";
                    worksheet.Cells[5, 3].Value = "Số lượng";
                    worksheet.Cells[5, 4].Value = "Đơn giá";
                    worksheet.Cells[5, 5].Value = "Thành tiền";


                    // Điền dữ liệu vào các ô
                    int row = 6; // Dòng bắt đầu điền dữ liệu
                    int rowsum = 6;
                    int STT = 1;
                    foreach (var ct in lsCT)
                    {
                        worksheet.Cells[row, 1].Value = STT;
                        worksheet.Cells[row, 2].Value = ct.TenMonAn;
                        worksheet.Cells[row, 3].Value = ct.SoLuong;
                        worksheet.Cells[row, 4].Value = ct.DonGia;
                        worksheet.Cells[row, 5].Value = ct.ThanhTien;
                        STT++;
                        row++;
                    }
                    ExcelRange rangeHeader3 = worksheet.Cells[rowsum + lsCT.Count, 1, rowsum + lsCT.Count, 4];
                    rangeHeader3.Merge = true;

                    for (int i = rowsum; i < rowsum + lsCT.Count; i++)
                    {
                        sum = sum + int.Parse(worksheet.Cells[i, 5].Value.ToString());
                    }
                    worksheet.Cells[rowsum + lsCT.Count, 1].Value = "TỔNG TIỀN";
                    worksheet.Cells[rowsum + lsCT.Count, 5].Value = sum;
                    // Lưu tệp Excel

                    string filePath = $@"D:\file{hd.MaHoaDon + DateTime.Now.ToString("ddMMHHmmssfff")}.xlsx";
                    FileInfo excelFile = new FileInfo(filePath);
                    worksheet.Cells.AutoFitColumns();
                    excelPackage.SaveAs(excelFile);

                    // Hiển thị thông báo khi hoàn thành
                    MessageBox.Show("Báo cáo đã được xuất ra Excel tại: " + filePath);
                }
            
        }
    }
}
