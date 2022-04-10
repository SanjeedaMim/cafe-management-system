using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFE_management
{
    internal class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=MEAW;Initial Catalog=CafeManagementSystem;Integrated Security=True";
            return con;
        }
        public DataSet getdata(String query)
        {

            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public void setData(String query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
 
