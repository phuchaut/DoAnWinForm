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
    public class HOADON_DAO
    {
        List<HOADON_DTO> dsHoaDon;
        HOADON_DTO hoaDon;
        public List< HOADON_DTO> LoadDSHoaDon()
        {
            try
            {
                DateTime t;
                dsHoaDon = new List<HOADON_DTO>();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select *from HoaDon";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    hoaDon = new HOADON_DTO();
                    hoaDon.MaHoaDon = sdr["MaHoaDon"].ToString();
                    t = (DateTime)sdr["NgayLap"];
                    hoaDon.NgayLap = t.ToString("dd/MM/yyyy");
                    if (sdr["NgayThanhToan"].ToString() != "")
                    {
                        t = (DateTime)sdr["NgayThanhToan"];
                        hoaDon.NgayThanhToan = t.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        //t = (DateTime)sdr["NgayThanhToan"];
                        hoaDon.NgayThanhToan = "";
                    }
                    hoaDon.MaNV = sdr["MaNV"].ToString();
                    hoaDon.TrangThai = sdr["TrangThai"].ToString();
                    dsHoaDon.Add(hoaDon);
                }
                sdr.Close();
                conn.Close();
                return dsHoaDon;
            }
            catch { 
                return null;
            }
        }
        public bool XoaHoaDon(string maHD)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"delete from HoaDon where MaHoaDon='{maHD}'";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool ThanhToanHD(string maHD,int maBan)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"update HoaDon set NgayThanhToan='{DateTime.Now.Date}' where MaHoaDon='{maHD}'" +
                    $"update BanAn set TrangThai=0 where MaBanAn={maBan}";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ThemHoaDon(HOADON_DTO hdDTO)
        {
            try
            {
                SqlConnection conn=Dataprovider.TaoKetNoi();
                string truyVan = $"insert into HoaDon(MaHoaDon,NgayLap,NgayThanhToan,MaNV,TrangThai) " +
                    $"values('{hdDTO.MaHoaDon}','{hdDTO.NgayLap}',NULL,'{hdDTO.MaNV}',N'{hdDTO.TrangThai}')";
                int kq=Dataprovider.ThucThiLenh(truyVan,conn);
                conn.Close() ;
                return kq > 0;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public bool SuaThongTin(HOADON_DTO hdDTO)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan;
                if (hdDTO.TrangThai=="Chưa phục vụ")
                {
                    hdDTO.NgayThanhToan = "NULL";
                    truyVan = $"update HoaDon set NgayLap ='{hdDTO.NgayLap}',NgayThanhToan ={hdDTO.NgayThanhToan}," +
                    $"MaNV ='{hdDTO.MaNV}',TrangThai =N'{hdDTO.TrangThai}' where MaHoaDon ='{hdDTO.MaHoaDon}'";
                }
                else
                {
                    truyVan = $"update HoaDon set NgayLap ='{hdDTO.NgayLap}',NgayThanhToan ='{hdDTO.NgayThanhToan}'," +
                    $"MaNV ='{hdDTO.MaNV}',TrangThai =N'{hdDTO.TrangThai}' where MaHoaDon ='{hdDTO.MaHoaDon}'";
                }
                
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int TimMaBan(string maHD)
        {
            try
            {
                SqlConnection conn=Dataprovider.TaoKetNoi();
                string truyVan = $"select Distinct b.MaBanAn from HoaDon a inner join ChiTietHoaDon b on a.MaHoaDon=b.MaHoaDon where a.MaHoaDon='{maHD}'";
                int kq=Dataprovider.ThucThiScarlar(truyVan, conn);
                conn.Close();
                return kq;
            }catch (Exception ex)
            {
                return -1;
            }
        }

        public HOADON_DTO LayThongTinHoaDon(string mahd)
        {
            try
            {
                HOADON_DTO hd = new HOADON_DTO();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string strTV = $"Select * from HoaDon where MaHoaDon='{mahd}'";
                SqlCommand cmd = new SqlCommand(strTV, conn);
                //cmd.Parameters.AddWithValue("MaHoaDon", mahd);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    hd.MaNV = dr["MaNV"].ToString();
                    hd.MaHoaDon = dr["MaHoaDon"].ToString();
                    hd.NgayLap = dr["NgayLap"].ToString();
                    hd.NgayThanhToan = dr["NgayThanhToan"].ToString();
                }
                dr.Close();
                conn.Close ();
                return hd;
            }
           catch (Exception ex)
            {
                return null;
            }
        }

        public bool KiemTraBan()
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select count(*) from BanAn where TrangThai=0";
                int kq=Dataprovider.ThucThiScarlar(truyVan,conn);
                conn.Close();
                return kq > 0;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public List<HOADON_DTO> LoadDSHoaDonChuaPhucVu()
        {
            try
            {
                DateTime t;
                dsHoaDon = new List<HOADON_DTO>();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select *from HoaDon where TrangThai=N'Chưa phục vụ'";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    hoaDon = new HOADON_DTO();
                    hoaDon.MaHoaDon = sdr["MaHoaDon"].ToString();
                    t = (DateTime)sdr["NgayLap"];
                    hoaDon.NgayLap = t.ToString("dd/MM/yyyy");
                    if (sdr["NgayThanhToan"].ToString() != "")
                    {
                        t = (DateTime)sdr["NgayThanhToan"];
                        hoaDon.NgayThanhToan = t.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        //t = (DateTime)sdr["NgayThanhToan"];
                        hoaDon.NgayThanhToan = "";
                    }
                    hoaDon.MaNV = sdr["MaNV"].ToString();
                    hoaDon.TrangThai = sdr["TrangThai"].ToString();
                    dsHoaDon.Add(hoaDon);
                }
                sdr.Close();
                conn.Close();
                return dsHoaDon;
            }
            catch
            {
                return null;
            }
        }

        public bool CapNhatPhucVu(string maHD, int maBA)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"update HoaDon set TrangThai=N'Đã phục vụ' where MaHoaDon='{maHD}'";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<HOADON_DTO> LoadDSHoaDonTT()
        {
            try
            {
                DateTime t;
                string now = (DateTime.Now).ToString("MM/dd/yyyy");
                dsHoaDon = new List<HOADON_DTO>();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select *from HoaDon where NgayLap='{now}'";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    hoaDon = new HOADON_DTO();
                    hoaDon.MaHoaDon = sdr["MaHoaDon"].ToString();
                    t = (DateTime)sdr["NgayLap"];
                    hoaDon.NgayLap = t.ToString("dd/MM/yyyy");
                    if (sdr["NgayThanhToan"].ToString() != "")
                    {
                        t = (DateTime)sdr["NgayThanhToan"];
                        hoaDon.NgayThanhToan = t.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        //t = (DateTime)sdr["NgayThanhToan"];
                        hoaDon.NgayThanhToan = "";
                    }
                    hoaDon.MaNV = sdr["MaNV"].ToString();
                    hoaDon.TrangThai = sdr["TrangThai"].ToString();
                    dsHoaDon.Add(hoaDon);
                }
                sdr.Close();
                conn.Close();
                return dsHoaDon;
            }
            catch
            {
                return null;
            }
        }

        public List<HOADON_DTO> TimHD(string ngayLap)
        {
            try
            {
                DateTime t;
                dsHoaDon = new List<HOADON_DTO>();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select *from HoaDon where NgayLap = '{ngayLap}'";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    hoaDon = new HOADON_DTO();
                    hoaDon.MaHoaDon = sdr["MaHoaDon"].ToString();
                    t = (DateTime)sdr["NgayLap"];
                    hoaDon.NgayLap = t.ToString("dd/MM/yyyy");
                    if (sdr["NgayThanhToan"].ToString() != "")
                    {
                        t = (DateTime)sdr["NgayThanhToan"];
                        hoaDon.NgayThanhToan = t.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        //t = (DateTime)sdr["NgayThanhToan"];
                        hoaDon.NgayThanhToan = "";
                    }
                    hoaDon.MaNV = sdr["MaNV"].ToString();
                    hoaDon.TrangThai = sdr["TrangThai"].ToString();
                    dsHoaDon.Add(hoaDon);
                }
                sdr.Close();
                conn.Close();
                return dsHoaDon;
            }
            catch
            {
                return null;
            }
        }
    }
}
