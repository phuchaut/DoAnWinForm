using QLNH_DAO;
using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_BUS
{
    public class LICHLAMVIEC_BUS
    {
        LICHLAMVIEC_DAO ll=new LICHLAMVIEC_DAO();

        public bool CapNhatLichLamViec(int thu,int ca,string maNV)
        {
            return ll.CapNhatLichLamViec(thu, ca, maNV); ;
        }

        public List<LICHLAMVIEC_DTO> LoadDSLL()
        {
            return ll.LoadDSLL();
        }
    }
}
