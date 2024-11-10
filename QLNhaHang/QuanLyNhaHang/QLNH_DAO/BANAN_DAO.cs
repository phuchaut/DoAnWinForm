using QLNH_DAO;
using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_DAO
{
    public class BANAN_DAO
    {
        List<BANAN_DTO> dsBanAn;
        BANAN_DTO banAn;

        public bool CapNhatTTBA(BANAN_DTO ba)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"update BanAn set SoChoNgoi={ba.SoChoNgoi},TrangThai={ba.TrangThai} where MaBanAn={ba.MaBanAn}";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public int KiemTraBanAN(string maBanAn)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select COUNT(*) from BanAn where MaBanAn={maBanAn}";
                int kq = Dataprovider.ThucThiScarlar(truyVan, conn);
                conn.Close();
                return kq;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public List<BANAN_DTO> LoadDSBanAn()
        {
            try
            {
                dsBanAn = new List<BANAN_DTO>();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select * from BanAn";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    banAn = new BANAN_DTO();
                    banAn.MaBanAn = (int)sdr["MaBanAn"];
                    banAn.SoChoNgoi = (int)sdr["SoChoNgoi"];
                    banAn.TrangThai = (int)sdr["TrangThai"];
                    dsBanAn.Add(banAn);
                }
                sdr.Close();
                conn.Close();
                return dsBanAn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool ThemBanAn(BANAN_DTO ba)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"insert into BanAn(MaBanAn,SoChoNgoi,TrangThai) values ({ba.MaBanAn},{ba.SoChoNgoi},{ba.TrangThai})";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
           catch(Exception ex)
            {
                return false;
            }
        }

        public bool XoaBanAn(int maBA)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"delete from BanAn where MaBanAn='{maBA}'";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }catch (Exception ex)
            {
                return false;
            }
            
        }
    }
}
