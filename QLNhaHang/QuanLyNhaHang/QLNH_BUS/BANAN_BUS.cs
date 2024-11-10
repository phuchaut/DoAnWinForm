using QLNH_DAO;
using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_BUS
{
    public class BANAN_BUS
    {
        BANAN_DAO baDAO=new BANAN_DAO();

        public bool CapNhatTTBA(BANAN_DTO ba)
        {
            return baDAO.CapNhatTTBA(ba);
        }

        public int KiemTraBanAN(string maBanAn)
        {
            return baDAO.KiemTraBanAN(maBanAn);
        }

        public List<BANAN_DTO> LoadDSBanAn()
        {
            return baDAO.LoadDSBanAn();
        }

        public bool ThemBanAn(BANAN_DTO ba)
        {
            return baDAO.ThemBanAn(ba);
        }

        public bool XoaBanAn(int maBA)
        {
            return baDAO.XoaBanAn(maBA);
        }
    }
}
