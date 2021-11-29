using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ASPNET_MVC.DataLayer
{
    public class Authentication
    {
        public bool IsAuthenticated { get; set; }

        public void  Login()
        {
            SqlConnection conn = new SqlConnection(AppSettings.DBConnectionString.ToString());
            SqlCommand sqlCmd = new SqlCommand(@"dbo.Find_User", conn);

            sqlCmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "username",
                SqlDbType = SqlDbType.Char,
                Value = "drlendon"
            });

            sqlCmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "email",
                SqlDbType = SqlDbType.Char,
                Value = "lendonpalencia50@gmail.com"
            });

            sqlCmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "password",
                SqlDbType = SqlDbType.Char,
                Value = "default"
            });

            conn.Open();

            sqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = sqlCmd.ExecuteReader();

            if (dr.HasRows)
            {
                Console.WriteLine("login");
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }
    }
}