using QLNH_DAO;
using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_BUS
{
    public class NHANVIEN_BUS
    {
        NHANVIEN_DAO nvDAO = new NHANVIEN_DAO();
        public NHANVIEN_DTO DangNhap(string maNV, string matKhau)
        {
            return nvDAO.KiemTraDangNhap(maNV, matKhau);
        }
        public List<NHANVIEN_DTO> LoadDSNV()
        {
            return nvDAO.LoadDSNV();
        }
        public NHANVIEN_DTO LayThongTinQL(string maNV)
        {
            return nvDAO.LayThongTinQL(maNV);
        }
        public bool XoaNhanVien(string maNV)
        {
            return nvDAO.XoaNhanVien(maNV);
        }
        public bool ThemNhanVien(NHANVIEN_DTO nv)
        {
            return nvDAO.ThemNhanVien(nv);
        }
        public bool CapNhatTTNV(NHANVIEN_DTO nv)
        {
            return nvDAO.CapNhatTTNV(nv);
        }
        public int KiemTraMaNV(string maNV)
        {
            return nvDAO.KiemTraMaNV(maNV);
        }

        public bool CapNhatTTQL(NHANVIEN_DTO nvQL)
        {
            return nvDAO.CapNhatTTQL(nvQL);
        }

        public bool CapNhatThongTinProfile(NHANVIEN_DTO nvQL)
        {
            return nvDAO.CapNhatThongTinProfile(nvQL);
        }

        public NHANVIEN_DTO LayThongTinNV(string maNV)
        {
            return nvDAO.LayThongTinNV(maNV);
        }

        public List<NHANVIEN_DTO> TimNhanVien(string tenNV)
        {
            return nvDAO.TimNhanVien(tenNV);
        }

        public string LayMaNV()
        {
            return nvDAO.LayMaNV();
        }
    }
}
