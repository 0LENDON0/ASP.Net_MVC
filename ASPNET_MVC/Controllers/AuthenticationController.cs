using System.Web.Mvc;
using ASPNET_MVC.DataLayer;

namespace ASPNET_MVC.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Login()
        {
            Authentication _auth = new Authentication();
            _auth.Login();

            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }
    }
}