using QLNH_DAO;
using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_BUS
{
    public class HOADON_BUS
    {
        HOADON_DAO hdDAO = new HOADON_DAO();
        
        public List<HOADON_DTO> LoadDSHoaDon()
        {
            return hdDAO.LoadDSHoaDon();
        }
        public bool XoaHoaDon(string maHD)
        {
            return hdDAO.XoaHoaDon(maHD);
        }
        public bool ThanhToanHD(string maHD,int maBan)
        {
            return hdDAO.ThanhToanHD(maHD,maBan);
        }

        public bool ThemHoaDon(HOADON_DTO hdDTO)
        {
            return hdDAO.ThemHoaDon(hdDTO);
        }

        public bool SuaThongTin(HOADON_DTO hdDTO)
        {
            return hdDAO.SuaThongTin(hdDTO);
        }

        public int TimMaBan(string maHD)
        {
            return hdDAO.TimMaBan(maHD);
        }

        public HOADON_DTO LayThongTinHoaDon(string mahd)
        {
            return (new HOADON_DAO()).LayThongTinHoaDon(mahd);
        }

        public bool KiemTraBan()
        {
            return hdDAO.KiemTraBan();
        }

        public List<HOADON_DTO> LoadDSHoaDonChuaPhucVu()
        {
            return hdDAO.LoadDSHoaDonChuaPhucVu();
        }

        public bool CapNhatPhucVu(string maHD, int maBA)
        {
            return hdDAO.CapNhatPhucVu(maHD, maBA);
        }

        public List<HOADON_DTO> LoadDSHoaDonTT()
        {
            return hdDAO.LoadDSHoaDonTT();
        }

        public List<HOADON_DTO> TimHD(string ngayLap)
        {
            return hdDAO.TimHD(ngayLap);
        }

       
    }
}
