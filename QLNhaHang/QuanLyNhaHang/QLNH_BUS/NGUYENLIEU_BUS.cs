using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_BUS
{
    public class NGUYENLIEU_BUS
    {
        NGUYENLIEU_DAO nlDAO = new NGUYENLIEU_DAO();

        

        public bool KiemTraMaNV(int maNV)
        {
            return nlDAO.KTNguyenLieu(maNV);
        }

        public List<NGUYENLIEU_DTO> loadDSNL()
        {
            return nlDAO.loadDSNL();
        }

        public bool ThemNguyenLieu(NGUYENLIEU_DTO nl)
        {
            return nlDAO.ThemNguyenLieu(nl);
        }

        public bool XoaNguyenLieu(int maNL)
        {
            return nlDAO.XoaNguyenLieu(maNL);
        }
        public bool CapNhatNL(NGUYENLIEU_DTO nl)
        {
            return nlDAO.CapNhatNL(nl);
        }
    }
}
