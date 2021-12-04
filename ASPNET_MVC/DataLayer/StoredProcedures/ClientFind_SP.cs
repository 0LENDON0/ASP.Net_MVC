
namespace ASPNET_MVC.DataLayer.StoredProcedures
{
    public class ClientFind_SP : StoredProcedure
    {
        public int Id { get; set; }
        public override StoredProcedure Compile()
        {
            Name = "CLIENT_FIND";

            SqlParameters.Add(new System.Data.SqlClient.SqlParameter() { 
                ParameterName = "Id",
                DbType = System.Data.DbType.Int32,
                Value = Id
            });

            return this;
        }
    }
}