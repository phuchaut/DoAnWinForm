using QLNH_DAO;
using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_BUS
{
    public class CHITIETHOADON_BUS
    {
        CHITIETHOADON_DAO ctDAO=new CHITIETHOADON_DAO();

        public bool CapNhatMonAn(int maMonAn,int soLuong,string maHD)
        {
            return ctDAO.CapNhatMonAn(maMonAn,soLuong,maHD);
        }

        public List<BANAN_DTO> DSBanAn()
        {
            return ctDAO.DSBanAn();
        }

        public bool GiamSL(string maHD, int maMonAn)
        {
            return ctDAO.GiamSL(maHD, maMonAn);
        }
        public bool TangSL(string maHD, int maMonAn)
        {
            return ctDAO.TangSL(maHD, maMonAn);
        }
        public bool KTTonTai(int maMonAn,string maHD)
        {
            return ctDAO.KTTonTai(maMonAn, maHD);
        }

        public List<CHITIETHOADON_DTO> LoadDSCT(string maHD)
        {
            return ctDAO.LoadDSCT(maHD);
        }

        public List<MONAN_DTO> LoadDSMonAn()
        {
            return ctDAO.LoadDSMonAn();
        }

        

        public bool ThemCTHD(CHITIETHOADON_DTO ct)
        {
            return ctDAO.ThemCTHD(ct);
        }

        public int TimMaBanAn(string maHD)
        {
            return ctDAO.TimMaBanAn(maHD);
        }

        public bool XoaHD(string maHoaDon,int maBan)
        {
            return ctDAO.XoaHD(maHoaDon,maBan);
        }

        public bool XoaMon(string maHD, int maMonAn)
        {
            return ctDAO.XoaMon(maHD, maMonAn);
        }

        public bool CapNhatBanAn(string maHD,int maBA)
        {
            return ctDAO.CapNhatBanAn(maHD,maBA);
        }

        public List<CHITIETHOADON_DTO> LayDanhSachCT(string mahd)
        {
            return (new CHITIETHOADON_DAO()).LayDanhSachCT(mahd);
        }

        public int CapNhatSoLuong(string tenMonAn, int soLuong)
        {
            return (new CHITIETHOADON_DAO()).CapNhatSoLuong(tenMonAn, soLuong);
        }

        public bool ThemKhachHang(string tenKH, string sdt,string maHD)
        {
            return ctDAO.ThemKhachHang(tenKH, sdt,maHD);
        }

        public CHITIETHOADON_DTO LayThongTin(string maHD)
        {
            return ctDAO.LayThongTin(maHD);
        }
    }
}
