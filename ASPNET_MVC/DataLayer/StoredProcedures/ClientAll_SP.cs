using System;

namespace ASPNET_MVC.DataLayer.StoredProcedures
{
    public class ClientAll_SP : StoredProcedure, IDisposable
    {
        public ClientAll_SP()
        {
            Name = "CLIENTS_ALL";
        }

        public void Dispose()
        {
        }
    }
}