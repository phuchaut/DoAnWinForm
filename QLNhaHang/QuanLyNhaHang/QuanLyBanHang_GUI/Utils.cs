using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_GUI
{
    public class Utils
    {
        public static string MaHoaMDS(string chuoi)
        {
            string kq = "";
            MD5 md5 = MD5.Create();
            //chuyen chuoi ban dau sang mang byte
            byte[] byteChuoi = Encoding.UTF8.GetBytes(chuoi);
            //b2: dung MD5 băm mảng vừa chuyển
            byte[] bamchuoi = md5.ComputeHash(byteChuoi);
            //chuyển sang hệ 16 từng byte một
            foreach (byte b in bamchuoi)
            {
                kq += b.ToString("x2");
            }
            return kq;
        }

    }
}
