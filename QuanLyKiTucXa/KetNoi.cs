using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKiTucXa
{
    class KetNoi
    {
        SqlConnection conn = null; // khai bao o ngoai dung duoc cho ca class!
        public KetNoi()
        {
            string strConnect = @"Data Source=LAPTOP-2SCORA2Q;Initial Catalog=QuanLyKyTucXaSV;Integrated Security=True";
            conn = new SqlConnection(strConnect);
            // CHAY DUOC PHAI CO CHUOI KET NOI
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public DataTable getData(string sql)
        {

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public void setData(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
