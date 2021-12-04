using ASPNET_MVC.Common;
using ASPNET_MVC.Models.Implementation;
using System;
using System.Data.SqlClient;

namespace ASPNET_MVC.DataLayer.StoredProcedures
{
    public class ClientEdit_SP : StoredProcedure
    {
        public Client Client { get; set; }
        public int Id { get; set; }

        public override StoredProcedure Compile()
        {
            Name = "CLIENT_UPDATE";

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "Id",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = Id
            });

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "UserId",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = Client.UserId
            });

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "Firstname",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = Client.Firstname.NotNull()
            });

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "Middlename",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = Client.Middlename.NotNull()
            });

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "Lastname",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = Client.Lastname.NotNull()
            });

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "Birthdate",
                SqlDbType = System.Data.SqlDbType.DateTime,
                Value = Client.Birthdate
            });

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "Gender",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = Client.Gender
            });

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "Email",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = Client.Email.NotNull()
            });

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "ContactNumber",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = Client.ContactNumber.NotNull()
            });

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "Country",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = Client.Country.NotNull()
            });

            SqlParameters.Add(new SqlParameter()
            {
                ParameterName = "Language",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = Client.Language.NotNull()
            });


            return this;
        }
    }
}