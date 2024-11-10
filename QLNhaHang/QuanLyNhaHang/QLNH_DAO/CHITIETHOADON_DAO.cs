using QLNH_DAO;
using QLNH_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_DAO
{
    public class CHITIETHOADON_DAO
    {
        CHITIETHOADON_DTO ct;
        List<CHITIETHOADON_DTO> dsCT;
        MONAN_DTO monAn;
        List<MONAN_DTO> dsMonan;
        BANAN_DTO ba;
        List<BANAN_DTO> dsBan;

        public bool CapNhatMonAn(int maMonAn,int soLuong,string maHD)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"update ChiTietHoaDon set SoLuong=SoLuong+{soLuong} where MaMonAn={maMonAn} and MaHoaDon='{maHD}'";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq> 0;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public List<BANAN_DTO> DSBanAn()
        {
            try
            {
                dsBan = new List<BANAN_DTO>();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select * from BanAn where TrangThai=0";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    ba = new BANAN_DTO();
                    ba.MaBanAn = (int)sdr["MaBanAn"];
                    ba.SoChoNgoi =(int) sdr["SoChoNgoi"];
                    ba.TrangThai = (int)sdr["TrangThai"];
                    dsBan.Add(ba);
                }
                sdr.Close();
                conn.Close();
                return dsBan;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool GiamSL(string maHD, int maMonAn)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"update ChiTietHoaDon set SoLuong=SoLuong-1 where MaHoaDon='{maHD}' and MaMonAn={maMonAn}";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool TangSL(object maHD, object maMonAn)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"update ChiTietHoaDon set SoLuong=SoLuong+1 where MaHoaDon='{maHD}' and MaMonAn={maMonAn}";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool KTTonTai(int maMonAn, string maHD)
        {
            try
            {
                SqlConnection conn=Dataprovider.TaoKetNoi();
                string truyVan = $"select count(*) from ChiTietHoaDon where MaMonAn={maMonAn} and MaHoaDon='{maHD}'";
                int kq=Dataprovider.ThucThiScarlar(truyVan, conn);
                conn.Close() ;
                return kq> 0;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public List<CHITIETHOADON_DTO> LoadDSCT(string maHD)
        {
            try
            {
                dsCT=new List<CHITIETHOADON_DTO> ();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select a.MaHoaDon,b.TenMonAn,a.SoLuong,b.DonGia from ChiTietHoaDon a inner join MonAn b on a.MaMonAn=b.MaMonAn where MaHoaDon='{maHD}' ";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    ct=new CHITIETHOADON_DTO();
                    ct.MaHoaDon = sdr["MaHoaDon"].ToString();
                    ct.TenMonAn = sdr["TenMonAn"].ToString();
                    ct.SoLuong = (int)sdr["SoLuong"];
                    ct.MaBanAn = 0;
                    ct.DonGia = float.Parse(sdr["DonGia"].ToString());
                    dsCT.Add(ct);
                }
                sdr.Close();
                conn.Close();
                return dsCT;
            }catch (Exception ex)
            {
                return null;
            }
        }

        public List<MONAN_DTO> LoadDSMonAn()
        {
            try
            {
                dsMonan=new List<MONAN_DTO> ();
                SqlConnection conn=Dataprovider.TaoKetNoi ();
                string truyVan = $"select MaMonAn,TenMonAn from MonAn";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    monAn = new MONAN_DTO();
                    monAn.MaMonAn = (int)sdr["MaMonAn"];
                    monAn.TenMonAn = sdr["TenMonAn"].ToString();
                    monAn.MaLoaiMonAn = 0;
                    monAn.DonGia = 0;
                    monAn.TenNguyenLieu = "";
                    monAn.SoLuongNguyenLieu = 0;
                    monAn.TrangThai = 1;
                    dsMonan.Add(monAn);
                }
                sdr.Close ();
                conn.Close ();
                return dsMonan;
            }catch (Exception ex)
            {
                return null;
            }
        }

        

        public bool ThemCTHD(CHITIETHOADON_DTO ct)
        {
            try
            {
                SqlConnection conn=Dataprovider.TaoKetNoi ();
                string truyVan = $"insert into ChiTietHoaDon(MaHoaDon,MaMonAn,SoLuong,DonGia,MaBanAn) " +
                    $"values ('{ct.MaHoaDon}',{ct.MaMonAn},{ct.SoLuong},{ct.DonGia},{ct.MaBanAn})" +
                    $"update BanAn set TrangThai =1 where MaBanAn={ct.MaBanAn}";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;

            }catch (Exception ex)
            {
                return false;
            }
        }

        public int TimMaBanAn(string maHD)
        {
            try
            {
                int kq = 0;
                SqlConnection conn= Dataprovider.TaoKetNoi ();
                string truyVan = $"select MaBanAn from ChiTietHoaDon where MaHoaDon='{maHD}'";
                SqlDataReader sdr=Dataprovider.TruyVan (truyVan, conn);
                if (sdr.Read())
                {
                    kq=sdr.GetInt32(0);
                }
                conn.Close();
                return kq;
            }catch (Exception ex)
            {
                return -1;
            }
        }

        public bool XoaHD(string maHoaDon,int maBan)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"alter table ChiTietHoaDon nocheck constraint FK__ChiTietHo__MaHoa__534D60F1 delete from HoaDon where MaHoaDon='{maHoaDon}'" +
                    $" delete from ChiTietHoaDon where MaHoaDon='{maHoaDon}' delete ChiTietHoaDon where MaHoaDon='{maHoaDon}'" +
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

        public bool XoaMon(string maHD, int maMonAn)
        {
            try
            {
                SqlConnection conn=Dataprovider.TaoKetNoi();
                string truyVan = $"delete from ChiTietHoaDon where MaHoaDon='{maHD}' and MaMonAn={maMonAn}";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public bool CapNhatBanAn(string maHD,int maBA)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"update ChiTietHoaDon set MaBanAn={maBA} where MaHoaDon='{maHD}'";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<CHITIETHOADON_DTO> LayDanhSachCT(string mahd)
        {
            try
            {
                List<CHITIETHOADON_DTO> dsCT = new List<CHITIETHOADON_DTO>();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string strTV = "Select CT.*,MA.TenMonAn from ChiTietHoaDon CT inner join MonAn MA on CT.MaMonAn=MA.MaMonAn where CT.MaHoaDon=@MaHoaDon";
                SqlCommand cmd = new SqlCommand(strTV, conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", mahd);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CHITIETHOADON_DTO ct = new CHITIETHOADON_DTO();
                    ct.TenMonAn = dr["TenMonAn"].ToString();
                    ct.SoLuong = (int)dr["SoLuong"];
                    ct.DonGia = float.Parse(dr["DonGia"].ToString());
                    dsCT.Add(ct);
                }
                return dsCT;
            }
            catch { return null; }
        }

        public int CapNhatSoLuong(string tenMonAn, int soLuong)
        {
            try
            {
                string ten = layTenMonAn(tenMonAn);
                if (ten == "")
                {
                    return 0;
                }
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string strUpDate = "Update NguyenLieu set SoLuong=SoLuong+@soluong where " +
                    "TenNguyenLieu=@ten";
                SqlCommand cmd = new SqlCommand(strUpDate, conn);
                cmd.Parameters.AddWithValue("@soluong", soLuong);
                cmd.Parameters.AddWithValue("@ten", ten);
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                    return kq;
                return 0;
            }
            catch { return 0; }

        }
        public string layTenMonAn(string tenMonAn)
        {
            try
            {
                string ten = "";
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string layTenMonAn = "Select TenNguyenLieu from MonAn where TenMonAn=@TenMonAn";
                SqlCommand cmd = new SqlCommand(layTenMonAn, conn);
                cmd.Parameters.AddWithValue("TenMonAn", tenMonAn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ten = dr["TenNguyenLieu"].ToString();
                }
                dr.Close();
                conn.Close();
                return ten;
            }
            catch
            {
                return null;
            }
           
        }

        public bool ThemKhachHang(string tenKH, string sdt,string maHD)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"update ChiTietHoaDon set TenKH =N'{tenKH}',SDT ='{sdt}' where MaHoaDon = '{maHD}'" +
                    $"insert into KhachHang(HoTen,SDT) values(N'{tenKH}','{sdt}')";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
            catch { 
                return false;
            }
        }

        public CHITIETHOADON_DTO LayThongTin(string maHD)
        {
            try
            {
                SqlConnection conn=Dataprovider.TaoKetNoi();
                string truyVan = $"select * from ChiTietHoaDon where MaHoaDon='{maHD}'";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                if (sdr.Read())
                {
                    ct = new CHITIETHOADON_DTO();
                    ct.MaHoaDon = sdr["MaHoaDon"].ToString();
                    ct.TenMonAn = "";
                    ct.SoLuong = (int)sdr["SoLuong"];
                    ct.MaBanAn = 0;
                    ct.DonGia = float.Parse(sdr["DonGia"].ToString());
                    ct.TenKH = sdr["TenKH"].ToString();
                    ct.SDT = sdr["SDT"].ToString();

                }
                sdr.Close();
                conn.Close ();
                return ct;
            }
            catch
            {
                return null;
            }
        }
    }
}
