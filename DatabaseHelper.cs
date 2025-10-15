using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Time_Capsule
{
    public class DatabaseHelper
    {
        private readonly string connectionString =
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=W:\subject\dotnet\Time_Capsule\TimeCapsuleDB.mdf;Integrated Security=True;Connect Timeout=30";


        public DataTable GetDataTable(string query, SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                con.Open();
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result;
            }
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();
                return result;
            }
        }
    }
}
