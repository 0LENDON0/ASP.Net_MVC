﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_MVC.Controllers
{
    public class ClientController : Controller
    {
        //
        // GET: /Client/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Features()
        {
            return View();
        }

        public ActionResult Pricing()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}