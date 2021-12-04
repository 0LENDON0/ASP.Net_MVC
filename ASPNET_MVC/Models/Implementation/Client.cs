using ASPNET_MVC.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNET_MVC.Models.Implementation
{
    public class Client : IClient
    {
        public int Id { get ; set ; }
        public int UserId { get ; set ; }

        [Required]
        public string Firstname { get ; set ; }

        [Required]
        public string Middlename { get ; set ; }

        [Required]
        public string Lastname { get ; set ; }

        [Required]
        public DateTime Birthdate { get ; set ; }

        [Required]
        public string Gender { get ; set ; }

        [Required]
        public string Email { get ; set ; }

        [Required]
        public string ContactNumber { get ; set ; }

        [Required]
        public string Country { get ; set ; }

        [Required]
        public string Language { get ; set ; }
        public DateTime Timestamp { get ; set ; }

    }
}