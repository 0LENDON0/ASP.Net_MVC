using System.Web;
using System.Web.Optimization;

namespace ASPNET_MVC
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //JQUERY
            bundles.Add(new ScriptBundle("~/bundles/js/jquery").Include(
                    "~/Scripts/jquery-{version}.min.js"
                ));

            //BOOTSTRAP CSS
            bundles.Add(new StyleBundle("~/bundles/css/bootstrap").Include(
                    "~/Content/css/bootstrap.min.css"
                ));

            //BOOTSTRAP JS
            bundles.Add(new ScriptBundle("~/bundles/js/bootstrap").Include(
                    "~/Scripts/bootstrap/bootstrap.min.js"
                ));
        }
    }
}