
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QuanLyDANL.DAO
{
    class DataConfig
    {
        private SqlConnection con;
        public String strConnect = @"Data Source=DESKTOP-J45K4LK;Integrated Security=SSPI;Initial Catalog=QuanLyDoAnNienLuan";

        //Khoi tao mac dinh
        public DataConfig()
        {
            Connect();
        }

        //Ham ket noi CSDL
        private void Connect()
        {
            try
            {
                con = new SqlConnection(strConnect); // khoi tao connect
                con.Open(); // mo ket noi
                if (con.State == ConnectionState.Open)
                {
                    con.Close(); //Dong ket noi
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message.ToString());
            }
        }

        //Ham getData
        public DataTable GetData(String strSQL)
        {
            DataTable result = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
            da.Fill(result);
            return result;
        }

        //Them,xoa,sua
        public int excuteNoneQuery(String sql)
        {
            int result = 0;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();// Mo ket noi
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql; //Cau lenh truy van
            result = cmd.ExecuteNonQuery();
            return result;
        }
        //Tra ve mot doi tuong nao do
        public object exeCuteScalarQuery(String sql)
        {
            object result = 0;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();// Mo ket noi
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql; //Cau lenh truy van
            result = cmd.ExecuteScalar();
            return result;
        }
    }
}