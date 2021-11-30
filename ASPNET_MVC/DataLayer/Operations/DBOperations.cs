using System.Linq;
using System.Data.SqlClient;
using ASPNET_MVC.DataLayer.StoredProcedures;
using System.Data;

namespace ASPNET_MVC.DataLayer.Operations
{
    public static class DBOperations
    {
        public static SqlCommand PrepStoredProcedure(StoredProcedure sp)
        {
            SqlCommand cmd = new SqlCommand(sp.Name);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(sp.SqlParameters.ToArray());

            return cmd;
        }
    }
}