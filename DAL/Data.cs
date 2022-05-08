using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Data
    {
        public SqlConnection GetConnect()
        {
            string str_conn = "Data Source=thanhcoder;Initial Catalog=qlkh;Integrated Security=True";
            return new SqlConnection(str_conn);
        }

        public object ExecuteScalar(string sql)
        {
            SqlConnection conn = GetConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            var r = cmd.ExecuteScalar();
            conn.Close();
            return r;
        }

        public SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection conn = GetConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            var r = cmd.ExecuteReader();
            conn.Close();
            return r;
        }

        public void ExecuteNonQuery(String sql)
        {
            SqlConnection conn = GetConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable GetTable(String sql)
        {
            SqlConnection conn = GetConnect();
            conn.Open();
            SqlDataAdapter myData = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            myData.Fill(dt);
            conn.Close();
            return dt;

        }
    }
}
