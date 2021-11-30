using System;
using System.Web.Mvc;

namespace ASPNET_MVC.Controllers.Attributes
{
    public class RestoreModelState : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            if (context.Controller.TempData.ContainsKey("ModelState"))
            {
                context.Controller.ViewData.ModelState.Merge(
                    context.Controller.TempData["ModelState"] as ModelStateDictionary);
            }
        }
    }
}