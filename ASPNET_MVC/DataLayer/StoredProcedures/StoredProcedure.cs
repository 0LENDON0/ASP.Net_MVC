using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ASPNET_MVC.DataLayer.StoredProcedures
{
    public abstract class StoredProcedure
    {
        public string Name { get; set; }

        public List<SqlParameter> SqlParameters { get; set; }

        public StoredProcedure()
        {
            SqlParameters = new List<SqlParameter>();
        }
    }
}