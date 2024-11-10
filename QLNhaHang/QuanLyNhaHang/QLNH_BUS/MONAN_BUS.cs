using QLNH_DAO;
using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_BUS
{
    public class MONAN_BUS
    {
        MONAN_DAO monAnDAO=new MONAN_DAO();
        public List<MONAN_DTO> LoadDSMonAn()
        {
            return monAnDAO.LoadDSMonAn();
        }
        public bool XoaMonAn(int maMA)
        {
            return monAnDAO.XoaMonAn(maMA);
        }
        public bool ThemMonAn(MONAN_DTO ma)
        {
            return monAnDAO.ThemMonAn(ma);
        }
        public bool CapNhatMonAn(MONAN_DTO ma)
        {
            return monAnDAO.CapNhatMonAn(ma);
        }

        public bool CheckTonTai(int maMA)
        {
            return monAnDAO.CheckTonTai(maMA);
        }

        public float LayDonGia(int maMonAn)
        {
            return monAnDAO.LayDonGia(maMonAn);
        }

        public int LaySoLuong(string maHD, int maMonAn)
        {
            return monAnDAO.LaySoLuong(maHD,maMonAn);
        }

        public int KiemTraNguyenLieu(string tenMA)
        {
            return monAnDAO.KiemTraNguyenLieu(tenMA);
        }

        public int LayMaNguyenLieu(int maMA)
        {
            return monAnDAO.LayMaNguyenLieu(maMA);
        }

        public bool CapNhatNguyenLieu(int maNL,string thaoTac,int soLuong=1)
        {
            return monAnDAO.CapNhatNguyenLieu(maNL, thaoTac,soLuong);
        }

        public List<MONAN_DTO> TimMonAn(string tenMA)
        {
            return monAnDAO.TimMonAn(tenMA);
        }
    }
}
