using ASPNET_MVC.Controllers.Attributes;
using ASPNET_MVC.Controllers.Filters;
using ASPNET_MVC.DataLayer;
using ASPNET_MVC.Models.Implementation;
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

        [HttpGet]
        [RestoreModelState]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [PreserveModelState]
        public ActionResult Add(Client client)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Add");
            }
            else
            {
                var dl = new ClientAuthenticatedDL();

                if (dl.ClientAdd(client))
                {
                    return RedirectToAction("ClientIndex", "ClientAuthenticated");
                }
                else
                {
                    ViewBag.Message = "Something went wrong...";
                }
            }


            return View();
        }

        [HttpGet]
        [RestoreModelState]
        public ActionResult Edit(int id)
        {
            using (var dl = new ClientAuthenticatedDL())
            {
                var _cl = dl.Find(id);

                if (_cl == null)
                {
                    ViewBag.Message = "Can't find in records";
                }

                return View(_cl?? new Client());
            }
        }

        [HttpPost]
        [PreserveModelState]
        public ActionResult Edit(Client clientObj)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Edit", "ClientAuthenticated", new { id = clientObj.Id });
            }
            else
            {
                using (var dl = new ClientAuthenticatedDL())
                {
                    if (dl.ClientUpdate(clientObj))
                    {
                        return RedirectToAction("ClientIndex", "ClientAuthenticated");
                    }
                    else
                    {
                        ViewBag.Message = "Something went wrong...";
                    }
                }
            }

            return View();
        }

        [HttpGet]
        [RestoreModelState]
        public ActionResult Delete(int id)
        {
            using (var dl = new ClientAuthenticatedDL())
            {
                if (dl.ClientDelete(id))
                {
                    return RedirectToAction("ClientIndex", "ClientAuthenticated");
                }
                else
                {
                    ViewBag.Message = "Something went wrong..";
                }
            }

            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();

            return RedirectToRoute("Index");
        }
    }
}