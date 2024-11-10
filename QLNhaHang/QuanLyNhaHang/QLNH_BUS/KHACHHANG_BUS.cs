using QLNH_DAO;
using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_BUS
{
    public class KHACHHANG_BUS
    {
        KHACHHANG_DAO khDAO=new KHACHHANG_DAO();
        public List<KHACHHANG_DTO> LoadDSKH()
        {
            return khDAO.LoadDSKH();
        }
    }
}
