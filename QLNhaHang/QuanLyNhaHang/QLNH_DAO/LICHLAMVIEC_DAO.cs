using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_DAO
{
    public class LICHLAMVIEC_DAO
    {
        LICHLAMVIEC_DTO ll;
        List<LICHLAMVIEC_DTO> dsll;

        public bool CapNhatLichLamViec(int thu, int ca,string maNV)
        {
            try
            {
                dsll = new List<LICHLAMVIEC_DTO>();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"update LichLamViecNV set MaNhanVien='{maNV}' where Thu={thu} and ca ={ca} ";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return (kq > 0);
            }catch
            (Exception ex)
            {
                return false;
            }
        }

        public List<LICHLAMVIEC_DTO> LoadDSLL()
        {
            try
            {
                dsll=new List<LICHLAMVIEC_DTO>();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select a.Thu,a.Ca,a.MaNhanVien,b.LoaiNhanVien from LichLamViecNV a inner join NhanVien b on a.MaNhanVien=b.MaNV";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    ll=new LICHLAMVIEC_DTO();
                    ll.Thu = (int)sdr["Thu"];
                    ll.Ca = (int)sdr["Ca"];
                    ll.MaNhanVien = sdr["MaNhanVien"].ToString();
                    ll.LoaiNhanVien = sdr["LoaiNhanVien"].ToString();
                    dsll.Add(ll);
                }
                sdr.Close();
                conn.Close();
                return dsll;

            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}
