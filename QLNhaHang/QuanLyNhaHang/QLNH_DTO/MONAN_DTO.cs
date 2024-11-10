using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_DTO
{
    public class MONAN_DTO
    {
      public int MaMonAn{get;set;}
      public string TenMonAn{get;set;}
        public string TenLoaiMonAn { get;set;}
      public int MaLoaiMonAn{get;set;}
      public decimal DonGia{get;set;}
      public string TenNguyenLieu{get;set;}
      public int SoLuongNguyenLieu{get;set;}
      public int TrangThai { get; set; }
    }
}
