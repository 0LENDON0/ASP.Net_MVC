using ASPNET_MVC.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ASPNET_MVC.DataLayer.StoredProcedures
{
    public class Authentication_SP : StoredProcedure, IDisposable
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public override StoredProcedure Compile()
        {
            Name = "dbo.Find_User";

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "username",
                SqlDbType = SqlDbType.Char,
                Value = CommonMethods.NotNull(Username)
            });

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "email",
                SqlDbType = SqlDbType.Char,
                Value = CommonMethods.NotNull(Email)
            });

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "password",
                SqlDbType = SqlDbType.Char,
                Value = CommonMethods.NotNull(Password)
            });

            return this;
        }

        public void Dispose()
        {
        }
    }
}