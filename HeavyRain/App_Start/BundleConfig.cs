using System.Web.Optimization;

namespace HeavyRain
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                "~/Content/Site.css",
                "~/bootstrap/css/bootstrap.css",
                "~/bootstrap/css/bootstrap-responsive.css"));
        }
    }
}