using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebApplication1.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                      "~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/main.css",
                      "~/Content/noscript.css"));
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                    "~/Scripts/Template.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                       "~/Content/bootstrap.min.js"
                       ));

            bundles.Add(new StyleBundle("~/bundles/font-awesome").Include(
                       "~/Content/font-awesome/css/font-awesome.css",
                       "~/Content/font-awesome/css/font-awesome.min.css",
                       "~/Content/font-awesome/css/main.css",
                       "~/Content/font-awesome/css/noscript.css"));
        }
    }
}