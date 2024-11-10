using QLNH_DAO;
using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_BUS
{
    public class DOANHTHU_BUS
    {
        DoanhThuDAO dtDAO=new DoanhThuDAO();
        public List<DOANHTHU_DTO> LoadDSDT(string ngayBD,string ngayKT)
        {
            return dtDAO.LoadDSDT(ngayBD, ngayKT);
        }
    }
}
