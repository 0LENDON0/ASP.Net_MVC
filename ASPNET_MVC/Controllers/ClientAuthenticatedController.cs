using ASPNET_MVC.Controllers.Filters;
using ASPNET_MVC.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_MVC.Controllers
{
    [UserAuthenticationFilter]
    public class ClientAuthenticatedController : Controller
    {
        [HttpGet]
        [ActionName("ClientIndex")]
        public ActionResult Index()
        {
            var dl = new ClientAuthenticatedDL();
            var data = dl.GetAllClients();

            ViewData.Model = data;

            return View();
        }
    }
}