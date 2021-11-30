using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ASPNET_MVC.DataLayer.StoredProcedures
{
    public class AuthenticationSP : StoredProcedure, IDisposable
    {
        public AuthenticationSP(
            string username,
            string email,
            string password)
        {
            Name = "dbo.Find_User";

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "username",
                SqlDbType = SqlDbType.Char,
                Value = username
            });

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "email",
                SqlDbType = SqlDbType.Char,
                Value = email
            });

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "password",
                SqlDbType = SqlDbType.Char,
                Value = password
            });
        }

        public void Dispose()
        {
        }
    }
}