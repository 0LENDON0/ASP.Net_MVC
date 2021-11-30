using System;
using System.ComponentModel;

namespace ASPNET_MVC.Models.Interface
{
    internal interface IClient
    {
        int Id { get; set; }
        int UserId { get; set; }
        string Firstname { get; set; }
        string Middlename { get; set; }
        string Lastname { get; set; }
        DateTime Birthdate { get; set; }
        string Gender { get; set; }
        string Email { get; set; }
        string ContactNumber { get; set; }
        string Country { get; set; }
        string Language { get; set; }

        [ReadOnly(true)]
        DateTime Timestamp { get; set; }
    }
}
