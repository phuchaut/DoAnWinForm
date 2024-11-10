using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_DAO
{
    public static class Dataprovider
    {
        static string strKN = "Data Source=LAPTOP-CPP3LQB5\\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        public static SqlConnection TaoKetNoi()
        {
            SqlConnection conn=new SqlConnection(strKN);
            conn.Open();
            return conn;
        }
        public static SqlDataReader TruyVan(string sql,SqlConnection conn)
        {
            SqlCommand cmd=new SqlCommand(sql,conn);
            SqlDataReader sdr=cmd.ExecuteReader();
            return sdr;
        }
        public static SqlDataReader TruyVan(string sql, SqlConnection conn, SqlParameter[] pars)
        {
            SqlCommand cmd=new SqlCommand(sql,conn);
            cmd.Parameters.Add(pars);
            return cmd.ExecuteReader();
        }
        public static int ThucThiLenh(string sql,SqlConnection conn)
        {
            SqlCommand cmd=new SqlCommand(sql,conn);
            return cmd.ExecuteNonQuery();
        }
        public static int ThucThiLenh(string sql, SqlConnection conn, SqlParameter[] pars)
        {
            SqlCommand cmd=new SqlCommand(sql,conn);
            cmd.Parameters.Add(pars);
            return cmd.ExecuteNonQuery();
        }
        public static int ThucThiScarlar(string sql, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            return (int)cmd.ExecuteScalar();
        }
    }
}
