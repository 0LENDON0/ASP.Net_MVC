using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_MVC.Controllers
{
    public class ClientAuthenticatedController : Controller
    {
        [HttpGet]
        [ActionName("ClientIndex")]
        public ActionResult Index()        
        {
            return View();
        }
    }
}