using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_DAO
{
    public class KHACHHANG_DAO
    {
        KHACHHANG_DTO kh;
        List<KHACHHANG_DTO> dsKH;
        public List<KHACHHANG_DTO> LoadDSKH()
        {
            try
            {
                dsKH=new List<KHACHHANG_DTO>();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select * from KhachHang";
                SqlDataReader sdr=Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    kh = new KHACHHANG_DTO();
                    kh.HoTen = sdr["HoTen"].ToString();
                    kh.SDT = sdr["SDT"].ToString();
                    dsKH.Add(kh);
                }
                sdr.Close();
                conn.Close();
                return dsKH;
            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}
