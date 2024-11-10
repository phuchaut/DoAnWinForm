using QLNH_DAO;
using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_BUS
{
    public class NGUYENLIEU_DAO
    {
        List<NGUYENLIEU_DTO> dsNL;
        NGUYENLIEU_DTO nl;
        public List<NGUYENLIEU_DTO> loadDSNL()
        {
            try
            {
                dsNL = new List<NGUYENLIEU_DTO>();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select * from NguyenLieu";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    nl = new NGUYENLIEU_DTO();
                    nl.MaNguyenLieu = (int)sdr["MaNguyenLieu"];
                    nl.TenNguyenLieu = sdr["TenNguyenLieu"].ToString();
                    nl.SoLuong = (int)sdr["SoLuong"];
                    nl.DonGiaNguyenLieu = decimal.Parse(sdr["DonGiaNguyenLieu"].ToString());
                    dsNL.Add(nl);
                }
                sdr.Close();
                conn.Close();
                return dsNL;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool XoaNguyenLieu(int maNguyenLieu)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"delete NguyenLieu where MaNguyenLieu={maNguyenLieu}";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
            catch { return false; }
        }
        public bool KTNguyenLieu(int maNguyenLieu)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select count(*) from NguyenLieu where MaNguyenLieu={maNguyenLieu}";
                int kq = Dataprovider.ThucThiScarlar(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
            catch { 
                return false;
            }
        }

        public bool ThemNguyenLieu(NGUYENLIEU_DTO nl)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"insert into NguyenLieu(MaNguyenLieu,TenNguyenLieu,SoLuong,DonGiaNguyenLieu) values ({nl.MaNguyenLieu}," +
                    $"N'{nl.TenNguyenLieu}',{nl.SoLuong},{nl.DonGiaNguyenLieu})";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
           catch {
                return false;
            }
        }

        public bool CapNhatNL(NGUYENLIEU_DTO nl)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"update NguyenLieu set TenNguyenLieu=N'{nl.TenNguyenLieu}',SoLuong={nl.SoLuong},DonGiaNguyenLieu={nl.DonGiaNguyenLieu}" +
                    $" where MaNguyenLieu={nl.MaNguyenLieu}";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
           catch {
                return false;
            }
        }
    }
}
