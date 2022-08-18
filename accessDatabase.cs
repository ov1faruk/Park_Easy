using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Park_Easy
{
    class accessDatabase
    {
        private static SqlConnection con;
        public static SqlConnection conOpen()
        {
            if (con == null)
            {
                con = new SqlConnection(@"Data Source=DESKTOP-USM56V1\SQLEXPRESS;Initial Catalog=parkeasyDB;Integrated Security=True");
            }

            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            return con;
        }

        public static bool InsertUpdateDelete(string query)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(query , conOpen()))
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows>0)
                        {
                        return true;
                        }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static DataTable Select(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                
                using (SqlDataAdapter sqda = new SqlDataAdapter(query, conOpen()))
                {
                    sqda.Fill(dt);
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }

    }
}
