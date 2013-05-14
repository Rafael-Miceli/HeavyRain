using System;
using System.Web.Optimization;

namespace HeavyRain
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                "~/bootstrap/css/bootstrap-responsive.min.css",
                "~/bootstrap/css/bootstrap.min.css"));
        }
    }
}