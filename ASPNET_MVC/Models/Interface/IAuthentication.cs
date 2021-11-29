using System;

namespace ASPNET_MVC.Models.Interface
{
    internal interface IAuthentication
    {
        string Id { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        int Level { get; set; }
    }
}
