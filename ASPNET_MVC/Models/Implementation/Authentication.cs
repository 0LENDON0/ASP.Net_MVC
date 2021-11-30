using ASPNET_MVC.Models.Interface;
using System.ComponentModel.DataAnnotations;

namespace ASPNET_MVC.Models.Implementation
{
    public class Authentication : IAuthentication
    {
        public string Id { get; set; }

        [Display(Name = "Username or Email")]
        [Required(ErrorMessage ="Username or Email is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public string Email { get; set; }
        public int Level { get; set; }

        public Authentication()
        {
            Email = "";
        }
    }
}