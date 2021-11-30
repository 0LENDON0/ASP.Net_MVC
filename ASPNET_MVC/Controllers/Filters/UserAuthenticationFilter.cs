using System;
using System.Web.Routing;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace ASPNET_MVC.Controllers.Filters
{
    public class UserAuthenticationFilter : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if (string.IsNullOrEmpty(Convert.ToString(filterContext.HttpContext.Session["IsAuthenticated"])))
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            if (filterContext.Result != null && filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new RedirectToRouteResult("Login", new RouteValueDictionary { { "action", "Login" }, { "controller", "Authentication" } });
            }
        }
    }
}