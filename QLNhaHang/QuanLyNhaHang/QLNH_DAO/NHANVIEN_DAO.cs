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
    public class NHANVIEN_DAO
    {
        List<NHANVIEN_DTO> dsNV;
        NHANVIEN_DTO nv;
        public NHANVIEN_DTO KiemTraDangNhap(string maNV,string matKhau)
        {
            try
            {
                NHANVIEN_DTO nv = null;
                string truyVan = $"select * from NhanVien where MaNV='{maNV}' and MatKhauMH='{matKhau}'";
                SqlConnection conn = Dataprovider.TaoKetNoi();
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                if (sdr.Read())
                {
                    nv = new NHANVIEN_DTO();
                    nv.MaNV = sdr["MaNV"].ToString();
                    nv.MatKhau = sdr["MatKhau"].ToString();
                    nv.HoTen = sdr["HoTen"].ToString();
                    nv.NgaySinh = (DateTime)sdr["NgaySinh"];
                    nv.LoaiNhanVien = sdr["LoaiNhanVien"].ToString();
                    nv.DiaChi = sdr["DiaChi"].ToString();
                    nv.Luong = decimal.Parse(sdr["Luong"].ToString());
                    nv.Phai = sdr["Phai"].ToString();
                }
                sdr.Close();
                conn.Close();
                return nv;
            }
            catch {
                return null;
            }
        }
        public List<NHANVIEN_DTO> LoadDSNV()
        {
            try
            {
                dsNV = new List<NHANVIEN_DTO>();

                string truyVan = $"select * from NhanVien where LoaiNhanVien != 'QL'";
                SqlConnection conn = Dataprovider.TaoKetNoi();
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    nv = new NHANVIEN_DTO();
                    nv.MaNV = sdr["MaNV"].ToString();
                    nv.HoTen = sdr["HoTen"].ToString();
                    nv.NgaySinh = (DateTime)sdr["NgaySinh"];
                    nv.DiaChi = sdr["DiaChi"].ToString();
                    nv.CCCD = sdr["CCCD"].ToString();
                    nv.Phai = sdr["Phai"].ToString();
                    nv.Luong = decimal.Parse(sdr["Luong"].ToString());
                    nv.MatKhau = sdr["MatKhau"].ToString();
                    nv.LoaiNhanVien = sdr["LoaiNhanVien"].ToString();
                    dsNV.Add(nv);
                }
                sdr.Close();
                conn.Close();
                return dsNV;
            }
            catch
            {
                return null;
            }
        }
        public NHANVIEN_DTO LayThongTinQL(string maNV)
        {
            try
            {
                nv = new NHANVIEN_DTO();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select * from NhanVien where LoaiNhanVien='{maNV}'";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    nv.MaNV = sdr["MaNV"].ToString();
                    nv.HoTen = sdr["HoTen"].ToString();
                    nv.NgaySinh = (DateTime)sdr["NgaySinh"];
                    nv.DiaChi = sdr["DiaChi"].ToString();
                    nv.CCCD = sdr["CCCD"].ToString();
                    nv.Phai = sdr["Phai"].ToString();
                    nv.Luong = decimal.Parse(sdr["Luong"].ToString());
                    nv.MatKhau = sdr["MatKhau"].ToString();
                    nv.LoaiNhanVien = sdr["LoaiNhanVien"].ToString();
                }
                sdr.Close();
                conn.Close();
                return nv;
            }
            catch
            {
                return null;
            }          
        }
        public NHANVIEN_DTO LayThongTinNV(string maNV)
        {
            try
            {
                nv = new NHANVIEN_DTO();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select * from NhanVien where MaNV='{maNV}'";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    nv.MaNV = sdr["MaNV"].ToString();
                    nv.HoTen = sdr["HoTen"].ToString();
                    nv.NgaySinh = (DateTime)sdr["NgaySinh"];
                    nv.DiaChi = sdr["DiaChi"].ToString();
                    nv.CCCD = sdr["CCCD"].ToString();
                    nv.Phai = sdr["Phai"].ToString();
                    nv.Luong = decimal.Parse(sdr["Luong"].ToString());
                    nv.MatKhau = sdr["MatKhau"].ToString();
                    nv.LoaiNhanVien = sdr["LoaiNhanVien"].ToString();
                }
                sdr.Close();
                conn.Close();
                return nv;
            }
            catch
            {
                return null;
            }
        }
        public bool XoaNhanVien(string maNV)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"delete NhanVien  where MaNV='{maNV}'";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return (kq > 0);
            }
           
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ThemNhanVien(NHANVIEN_DTO nv)
        {
            try
            {
                string loaiNV = "";
                switch (nv.LoaiNhanVien)
                {
                    case "Bếp Trưởng":
                        loaiNV = "BT";
                        break;
                    case "Thu Ngân":
                        loaiNV = "TN";
                        break;
                    case "Nhân Viên Bếp":
                        loaiNV = "NVB";
                        break;
                    case "Tiếp Tân":
                        loaiNV = "TT";
                        break;

                }
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"insert into NhanVien(MaNV,HoTen,NgaySinh,DiaChi,CCCD,Phai,Luong,MatKhau,LoaiNhanVien,MatKhauMH)" +
                    $"values (N'{nv.MaNV}',N'{nv.HoTen}','{nv.NgaySinh}',N'{nv.DiaChi}','{nv.CCCD}',N'{nv.Phai}','{nv.Luong}',N'{nv.MatKhau}'," +
                    $"N'{loaiNV}','{nv.MatKhauMH}')";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        public bool CapNhatTTNV(NHANVIEN_DTO nv)
        {
            try
            {
                string loaiNV = "";
                switch (nv.LoaiNhanVien)
                {
                    case "Bếp Trưởng":
                        loaiNV = "BT";
                        break;
                    case "Thu Ngân":
                        loaiNV = "TN";
                        break;
                    case "Nhân Viên Bếp":
                        loaiNV = "NVB";
                        break;
                    case "Tiếp Tân":
                        loaiNV = "TT";
                        break;
                }
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"update NhanVien set HoTen=N'{nv.HoTen}',NgaySinh='{nv.NgaySinh}',DiaChi=N'{nv.DiaChi}'," +
                    $"CCCD='{nv.CCCD}',Phai=N'{nv.Phai}',Luong='{nv.Luong}',MatKhau='{nv.MatKhau}',LoaiNhanVien=N'{loaiNV}',MatKhauMH='{nv.MatKhauMH}'" +
                    $" where MaNV='{nv.MaNV}'";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public int KiemTraMaNV(string maNV)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select count(*) from NhanVien where MaNV='{maNV}'";
                int kq = Dataprovider.ThucThiScarlar(truyVan, conn);
                conn.Close();
                return kq;
            }
           catch (Exception ex)
            {
                return -1;
            }
        }

        public bool CapNhatTTQL(NHANVIEN_DTO nvQL)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"update NhanVien set HoTen=N'{nvQL.HoTen}'" +
                    $",MatKhau='{nvQL.MatKhau}',MaNV='{nvQL.MaNV}',MatKhauMH='{nvQL.MatKhauMH}'" +
                    $"where LoaiNhanVien='QL'";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
           catch (Exception ex)
            {
                return false;
            }
        }

        public bool CapNhatThongTinProfile(NHANVIEN_DTO nvQL)
        {
            try
            {
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"update NhanVien set HoTen=N'{nvQL.HoTen}'" +
                    $",MatKhau='{nvQL.MatKhau}',MatKhauMH='{nvQL.MatKhauMH}'" +
                    $" where MaNV='{nvQL.MaNV}'";
                int kq = Dataprovider.ThucThiLenh(truyVan, conn);
                conn.Close();
                return kq > 0;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public List<NHANVIEN_DTO> TimNhanVien(string tenNV)
        {
            try
            {

                dsNV=new List<NHANVIEN_DTO>();
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select * from NhanVien where HoTen like N'%{tenNV}%'";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                while (sdr.Read())
                {
                    nv = new NHANVIEN_DTO();
                    nv.MaNV = sdr["MaNV"].ToString();
                    nv.HoTen = sdr["HoTen"].ToString();
                    nv.NgaySinh = (DateTime)sdr["NgaySinh"];
                    nv.DiaChi = sdr["DiaChi"].ToString();
                    nv.CCCD = sdr["CCCD"].ToString();
                    nv.Phai = sdr["Phai"].ToString();
                    nv.Luong = decimal.Parse(sdr["Luong"].ToString());
                    nv.MatKhau = sdr["MatKhau"].ToString();
                    nv.LoaiNhanVien = sdr["LoaiNhanVien"].ToString();
                    dsNV.Add(nv);
                }
                sdr.Close();
                conn.Close();
                return dsNV;
            }catch (Exception ex)
            {
                return null;
            }
        }

        public string LayMaNV()
        {
            try
            {
                string kq = "";
                SqlConnection conn = Dataprovider.TaoKetNoi();
                string truyVan = $"select * from NhanVien order by MaNV DESC";
                SqlDataReader sdr = Dataprovider.TruyVan(truyVan, conn);
                if (sdr.Read())
                {
                    kq = sdr["MaNV"].ToString();
                }
                sdr.Close();
                conn.Close();
                return kq;
            }catch(Exception ex)
            {
                return null;
            }
        }
    }
}
