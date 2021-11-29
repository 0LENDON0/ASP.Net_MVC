using System.Web;
using System.Web.Optimization;

namespace ASPNET_MVC
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //JQUERY
            bundles.Add(new ScriptBundle("~/bundles/js/bootstrap").Include(
                    "~/Scripts/bootstrap/*.js"
                ));


            //BOOTSTRAP CSS
            bundles.Add(new StyleBundle("~/bundles/css/bootstrap").Include(
                    "~/Content/css/*.css"
                ));

            //BOOTSTRAP JS
            bundles.Add(new ScriptBundle("~/bundles/js/bootstrap").Include(
                    "~/Scripts/bootstrap/*.js"
                ));
        }
    }
}