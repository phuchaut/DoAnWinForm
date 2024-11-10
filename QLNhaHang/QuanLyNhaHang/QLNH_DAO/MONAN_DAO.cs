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
    public class MONAN_DAO
    {
        List<MONAN_DTO> dsMonAn;
        MONAN_DTO monAn;
        public List<MONAN_DTO> LoadDSMonAn()
        {
            try
            {
                dsMonAn = new List<MONAN_DTO>();

                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select * from MonAn a inner join LoaiMonAn b on a.MaLoaiMonAn=b.MaLoaiMA";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    monAn = new MONAN_DTO();
                    monAn.MaMonAn = (int)sdr["MaMonAn"];
                    monAn.TenMonAn = sdr["TenMonAn"].ToString();
                    monAn.MaLoaiMonAn = (int)sdr["MaLoaiMonAn"];
                    monAn.TenLoaiMonAn = sdr["TenLoaiMA"].ToString();
                    monAn.DonGia = decimal.Parse(sdr["DonGia"].ToString());
                    monAn.TenNguyenLieu = sdr["TenNguyenLieu"].ToString();
                    monAn.SoLuongNguyenLieu = (int)sdr["SoLuongNguyenLieu"];
                    monAn.TrangThai = (int)sdr["TrangThai"];
                    dsMonAn.Add(monAn);
                }
                sdr.Close();
                conn.Close();
                return dsMonAn;
            }
            catch { 
                return null;
            }
        }
        public bool XoaMonAn(int maMA)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"delete MonAn where MaMonAn={maMA}";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
           catch (Exception ex)
            {
                return false;
            }
        }
        public bool ThemMonAn(MONAN_DTO ma)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"alter table MonAn nocheck constraint fk_MonAn_Menu insert" +
                    $" into MonAn(MaMonAn,TenMonAn,MaLoaiMonAn,TenNguyenLieu,DonGia,SoLuongNguyenLieu,TrangThai)" +
                    $"values ({ma.MaMonAn},N'{ma.TenMonAn}',{ma.MaLoaiMonAn + 1},N'{ma.TenNguyenLieu}','{ma.DonGia}',N'{ma.SoLuongNguyenLieu}','{ma.TrangThai}') alter table MonAn " +
                    $"check constraint fk_MonAn_Menu";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }catch (Exception ex)
            {
                return false;
            }
            
        }
        public bool CapNhatMonAn(MONAN_DTO ma)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"update MonAn set TenMonAn=N'{ma.TenMonAn}',MaLoaiMonAn={ma.MaLoaiMonAn},DonGia={ma.DonGia}," +
                    $"TenNguyenLieu=N'{ma.TenNguyenLieu}',SoLuongNguyenLieu=N'{ma.SoLuongNguyenLieu}',TrangThai={ma.TrangThai} where MaMonAn={ma.MaMonAn}";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool CheckTonTai(int maMA)
        {
            try
            {
                SqlConnection conn=Dataprovider.TaoKetNoi(); 
                string truyVan = $"select count(*) from MonAn where MaMonAn={maMA}";
                int kq=Dataprovider.ThucThiScarlar(truyVan,conn);
                conn.Close();
                return kq > 0;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public float LayDonGia(int maMonAn)
        {
            try
            {
                float kq;
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select DonGia from MonAn where MaMonAn={maMonAn}";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                if (sdr.Read())
                {
                    kq = float.Parse(sdr["DonGia"].ToString());
                    sdr.Close();
                    return kq;
                }
                else
                {
                    sdr.Close();
                    return 0;
                }
            }catch (Exception ex)
            {
                return 0;
            }
        }

        public int LaySoLuong(string maHD, int maMonAn)
        {
            try
            {
                int kq;
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select SoLuong from ChiTietHoaDon where MaHoaDon='{maHD}' and MaMonAn={maMonAn}";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                if (sdr.Read())
                {
                    kq = (int)sdr["SoLuong"];
                    sdr.Close();
                    return kq;
                }
                else
                {
                    sdr.Close();
                    return -1;
                }
            }
            catch
            {
                return -1;
            }
        }

        public int KiemTraNguyenLieu(string tenMA)
        {
            try
            {
                int kq = 0;
                SqlConnection conn=Dataprovider.TaoKetNoi();
                string truyVan = $"select b.SoLuong from MonAn a inner join NguyenLieu b on a.TenNguyenLieu=b.TenNguyenLieu where a.TenMonAn=N'{tenMA}'";
                SqlDataReader sdr=Dataprovider.TruyVan(truyVan, conn);
                if (sdr.Read())
                {
                    kq = int.Parse(sdr["SoLuong"].ToString());
                    sdr.Close();
                    return kq;
                }
                else
                {
                    sdr.Close();
                    return -1;
                }
            }catch (Exception ex)
            {
                return -1;
            }
        }

        public int LayMaNguyenLieu(int maMA)
        {
            try
            {
                int kq = 0;
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select b.MaNguyenLieu from MonAn a inner join NguyenLieu b on a.TenNguyenLieu=b.TenNguyenLieu where MaMonAn={maMA}";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan,conn);
                if (sdr.Read())
                {
                    kq = int.Parse(sdr["MaNguyenLieu"].ToString());
                    sdr.Close();
                    return kq;
                }
                else
                {
                    sdr.Close();
                    return -1;
                }
            }catch (Exception ex)
            {
                return -1;
            }
        }

        public bool CapNhatNguyenLieu(int maNL,string thaoTac,int soLuong=1)
        {
            try
            {
                string truyVan ="";
                SqlConnection conn=Dataprovider.TaoKetNoi();
                switch (thaoTac)
                {
                    case "Them":
                        truyVan = $"update NguyenLieu set SoLuong=SoLuong-{soLuong} where MaNguyenLieu={maNL}";
                        break;
                    case "Xoa":
                        truyVan = $"update NguyenLieu set SoLuong=SoLuong+{soLuong} where MaNguyenLieu={maNL}";
                        break;
                } 
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public List<MONAN_DTO> TimMonAn(string tenMA)
        {
            try
            {
                dsMonAn = new List<MONAN_DTO>();

                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select * from MonAn a inner join LoaiMonAn b on a.MaLoaiMonAn=b.MaLoaiMA where TenMonAn like N'%{tenMA}%'";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    monAn = new MONAN_DTO();
                    monAn.MaMonAn = (int)sdr["MaMonAn"];
                    monAn.TenMonAn = sdr["TenMonAn"].ToString();
                    monAn.MaLoaiMonAn = (int)sdr["MaLoaiMonAn"];
                    monAn.TenLoaiMonAn = sdr["TenLoaiMA"].ToString();
                    monAn.DonGia = decimal.Parse(sdr["DonGia"].ToString());
                    monAn.TenNguyenLieu = sdr["TenNguyenLieu"].ToString();
                    monAn.SoLuongNguyenLieu = (int)sdr["SoLuongNguyenLieu"];
                    monAn.TrangThai = (int)sdr["TrangThai"];
                    dsMonAn.Add(monAn);
                }
                sdr.Close();
                conn.Close();
                return dsMonAn;
            }
            catch
            {
                return null;
            }
        }
    }
}
