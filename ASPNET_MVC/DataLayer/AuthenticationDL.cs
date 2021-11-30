using System;
using System.Data;
using System.Linq;
using ASPNET_MVC.DataLayer.Operations;
using ASPNET_MVC.DataLayer.StoredProcedures;
using ASPNET_MVC.Models.Implementation;

namespace ASPNET_MVC.DataLayer
{
    public class AuthenticationDL : IDisposable
    {
        public int NumberOfAttempts { get; set; }

        DataTable UserData;
        public bool Attempt(Authentication auth)
        {
            NumberOfAttempts++;

            UserData = DBConnection.GetData(DBOperations.PrepStoredProcedure(new Authentication_SP(auth.Username, auth.Email, auth.Password)));

            return UserData != null && UserData.Rows.GetEnumerator().MoveNext();
        }

        public Authentication GetUserData()
        {
            var _row = UserData.Rows[0];

            return new Authentication()
            {
                Id = _row["Id"].ToString(),
                Username = _row["Username"].ToString(),
                Email = _row["Email"].ToString(),
                Password = _row["Password "].ToString(),
                Level = (int)_row["Level"],
            };
        }

        public void Dispose()
        {

        }
    }
}