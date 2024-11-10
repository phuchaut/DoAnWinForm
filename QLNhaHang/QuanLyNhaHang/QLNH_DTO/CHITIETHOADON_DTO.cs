using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_DTO
{
    public class CHITIETHOADON_DTO
    {
      public string MaHoaDon{get;set;}
      public int MaMonAn { get; set; }
      public int SoLuong {get;set;}
      public float DonGia{get;set;}
      public int MaBanAn {get;set;}
      public string TenMonAn { get; set; }
        public string TenKH { get;set;}
        public string SDT { get;set;}
      public float ThanhTien { get { return SoLuong * DonGia; } }
    }
}
