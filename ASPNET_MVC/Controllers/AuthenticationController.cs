using System.Web.Mvc;
using ASPNET_MVC.Controllers.Attributes;
using ASPNET_MVC.Controllers.Filters;
using ASPNET_MVC.DataLayer;
using ASPNET_MVC.Models.Implementation;

namespace ASPNET_MVC.Controllers
{
    [UnauthenticatedFilter]
    public class AuthenticationController : Controller
    {
        [HttpGet]
        [RestoreModelState]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [PreserveModelState]
        public ActionResult Login(Authentication authObj)
        {
            TempData["Login"] = authObj;

            if (ModelState.IsValid)
            {
                using (var _auth = new AuthenticationDL())
                {
                    if (!TempData.ContainsKey("Attempt"))
                        TempData["Attempt"] = 0;

                    _auth.NumberOfAttempts = (int)TempData["Attempt"];

                    if (_auth.Attempt(authObj))
                    {
                        Session["User_Data"] = _auth.GetUserData();
                        Session["IsAuthenticated"] = true;

                        return RedirectToAction("ClientIndex", "ClientAuthenticated", null);
                    }
                    else
                    {
                        TempData["Attempt"] = _auth.NumberOfAttempts;
                        ModelState.AddModelError("Attempt", "Username/Email or Password is incorrect. Attempt: " + _auth.NumberOfAttempts.ToString());
                        return RedirectToAction("Login");
                    }
                }
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult SignUp()
        {
            return View();
        }
    }
}