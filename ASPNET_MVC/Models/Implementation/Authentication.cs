using ASPNET_MVC.Models.Interface;


namespace ASPNET_MVC.Models.Implementation
{
    public class Authentication : IAuthentication
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Level { get; set; }
    }
}