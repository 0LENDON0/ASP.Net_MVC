using System;

namespace ASPNET_MVC.DataLayer.StoredProcedures
{
    public class ClientAll_SP : StoredProcedure, IDisposable
    {
        public override StoredProcedure Compile()
        {
            Name = "CLIENTS_ALL";

            return this;
        }

        public void Dispose()
        {
        }
    }
}