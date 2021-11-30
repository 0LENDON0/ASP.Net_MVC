using System;
using System.Data;
using System.Data.SqlClient;

namespace ASPNET_MVC.DataLayer
{
    public static class DBConnection
    {
        public static SqlConnection Connection { get; set; }
        public static bool IsConnectionEstablished { get; set; }

        public static void Establish()
        {
            Connection = new SqlConnection(AppSettings.DBConnectionString.ToString());
            IsConnectionEstablished = true;
        }

        public static void Open()
        {
            if (!IsConnectionEstablished) Establish();

            if (Connection.State != System.Data.ConnectionState.Open)
                Connection.Open();
        }

        public static void Close()
        {
            Connection.Close();
        }

        public static DataTable GetData(SqlCommand cmd)
        {
            Open();

            cmd.Connection = Connection;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            cmd.Parameters.Clear();
            Close();

            return dt;
        }

        public static bool ExecuteCommand(SqlCommand cmd)
        {
            Open();

            cmd.Connection = Connection;
            int row = cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            Close();

            return row >= 1;
        }
    }
}