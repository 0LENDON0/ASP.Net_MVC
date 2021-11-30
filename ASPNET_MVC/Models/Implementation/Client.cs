using ASPNET_MVC.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_MVC.Models.Implementation
{
    public class Client : IClient
    {
        public int Id { get ; set ; }
        public int UserId { get ; set ; }
        public string Firstname { get ; set ; }
        public string Middlename { get ; set ; }
        public string Lastname { get ; set ; }
        public DateTime Birthdate { get ; set ; }
        public string Gender { get ; set ; }
        public string Email { get ; set ; }
        public string ContactNumber { get ; set ; }
        public string Country { get ; set ; }
        public string Language { get ; set ; }
        public DateTime Timestamp { get ; set ; }

    }
}