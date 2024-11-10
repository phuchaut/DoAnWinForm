using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_DAO
{
    public class DoanhThuDAO
    {
        DOANHTHU_DTO dt;
        List<DOANHTHU_DTO> dsDT;
        public List<DOANHTHU_DTO> LoadDSDT(string ngayBD,string ngayKT)
        {
            try
            {
                dsDT=new List<DOANHTHU_DTO>();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select a.NgayLap,SUM(b.SoLuong*b.DonGia) as TongDoanhThu from HoaDon a inner join ChiTietHoaDon b " +
                    $"on a.MaHoaDon=b.MaHoaDon where NgayLap>='{ngayBD}' and NgayLap<='{ngayKT}' group by a.NgayLap";
                SqlDataReader sdr=Dataprovider.TruyVan(truyVan,conn);

                while(sdr.Read())
                {
                    dt = new DOANHTHU_DTO();
                    dt.Ngay = (DateTime)sdr["NgayLap"];
                    dt.TongDoanhThu = float.Parse(sdr["TongDoanhThu"].ToString());
                    dsDT.Add(dt);
                }
                sdr.Close();
                conn.Close();
                return dsDT;

            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}
