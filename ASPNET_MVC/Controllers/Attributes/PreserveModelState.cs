using System;
using System.Web.Mvc;

namespace ASPNET_MVC.Controllers.Attributes
{
    public class PreserveModelState : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);

            context.Controller.TempData["ModelState"] = context.Controller.ViewData.ModelState;
        }
    }
}