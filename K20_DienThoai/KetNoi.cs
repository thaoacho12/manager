using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace K20_DienThoai
{
    internal class KetNoi
    {
        public static SqlConnection getConnect()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = BX-PC\\SQLEXPRESS; Initial Catalog = K20PNM; Integrated Security = True";
            conn.Open();
            return conn;
        }
        public static DataTable getData(string text, bool tenDT)
        {
            SqlConnection conn = getConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (string.IsNullOrEmpty(text))
            {
                cmd.CommandText = "Select * from DienThoai";
            }else
                if(tenDT){
                cmd.CommandText = "Select * from DienThoai where TenDT like '%" + text + "%'";
            }
            else
            {
                cmd.CommandText = "Select * from DienThoai where HangSX like '%" + text + "%'";
            }

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }
        #region Thêm hoặc sửa 01 đối tượng ĐT vào CSDL
        public static bool Them_SuaDT(DienThoai dt, bool themDT)
        {
            if (dt != null)
            {
                SqlConnection con = getConnect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                if (themDT)
                {
                    cmd.CommandText = "INSERT INTO [DienThoai] ([MaDT],[TenDT],[HangSX],[ThongTin],[Gia]) VALUES(@ma,@ten,@hang,@thongTin,@gia)";
                } else
                {
                    cmd.CommandText = "UPDATE [DienThoai] SET [TenDT] = @ten,[HangSX] = @hang,[ThongTin] = @thongTin,[Gia] = @gia WHERE [MaDT] = @ma";
                }
                cmd.Parameters.AddWithValue("@ma", dt.MaDT);
                cmd.Parameters.AddWithValue("@ten", dt.TenDT);
                cmd.Parameters.AddWithValue("@hang", dt.HangSX);
                cmd.Parameters.AddWithValue("@thongTin", dt.ThongTin);
                cmd.Parameters.AddWithValue("@gia", dt.Gia);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        public static bool XoaDT(string maDT)
        {
            if (maDT != null)
            {
                SqlConnection conn = getConnect(); 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Delete from DienThoai Where MaDT=@ma";
                cmd.Parameters.AddWithValue("@ma", maDT);

                if(cmd.ExecuteNonQuery()>=1)
                    return true;

            }
            return false;
        }
    }
}
