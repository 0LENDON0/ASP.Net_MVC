﻿using System;
using ASPNET_MVC.DataLayer.Operations;
using ASPNET_MVC.DataLayer.StoredProcedures;
using ASPNET_MVC.Models.Interface;
using ASPNET_MVC.Models.Implementation;
using System.Collections.Generic;
using System.Data;

namespace ASPNET_MVC.DataLayer
{
    public class ClientAuthenticatedDL : IDisposable
    {
        public List<Client> GetAllClients()
        {
            var dt = DBConnection.GetData(DBOperations.PrepStoredProcedure(new ClientAll_SP()));

            var _ml = new List<Client>();

            foreach (DataRow row in dt.Rows)
            {
                var _cl = new Client();
                _cl.Id = Convert.ToInt32(row["Id"]);
                _cl.UserId = Convert.ToInt32(row["UserId"]);
                _cl.Firstname = Convert.ToString(row["Firstname"]);
                _cl.Middlename = Convert.ToString(row["Middlename"]);
                _cl.Lastname = Convert.ToString(row["lastname"]);
                _cl.Birthdate = Convert.ToDateTime(row["Birthdate"]);
                _cl.Gender = Convert.ToString(row["Gender"]);
                _cl.Email = Convert.ToString(row["Email"]);
                _cl.ContactNumber = Convert.ToString(row["ContactNumber"]);
                _cl.Country = Convert.ToString(row["Country"]);
                _cl.Language = Convert.ToString(row["Language"]);
                _cl.Timestamp = Convert.ToDateTime(row["Timestamp"]);

                _ml.Add(_cl);
            }

            return _ml;
        }

        public void Dispose()
        {
        }
    }
}