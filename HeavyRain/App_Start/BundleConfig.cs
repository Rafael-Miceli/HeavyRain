using System.Web.Optimization;

namespace HeavyRain
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                "~/bootstrap/css/bootstrap.css",
                "~/Content/Site.css"));

            bundles.Add(new ScriptBundle("~/javascript/bootstrap").Include(
                "~/bootstrap/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/css/carousel").Include(
                "~/Content/Carousel/css/Carousel.css"));

            bundles.Add(new ScriptBundle("~/javascript/carousel").Include(
                "~/Content/Carousel/javascript/Carousel.js",
                "~/Content/Carousel/javascript/jquery.ba-throttle-debounce.min.js",
                "~/Content/Carousel/javascript/jquery.carouFredSel-6.2.1-packed.js",
                "~/Content/Carousel/javascript/jquery.mousewheel.min.js",
                "~/Content/Carousel/javascript/jquery.touchSwipe.min.js",
                "~/Content/Carousel/javascript/jquery.transit.min.js"));
        }
    }
}