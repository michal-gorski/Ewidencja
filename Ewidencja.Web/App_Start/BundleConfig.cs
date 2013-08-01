using System.Web;
using System.Web.Optimization;

namespace Ewidencja
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/lib/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //           "~/Scripts/jquery-ui-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //           "~/Scripts/jquery.unobtrusive*",
            //            "~/Scripts/jquery.validate*"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrapJS").Include("~/Scripts/lib/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/angular").Include("~/Scripts/lib/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/ewidencjaScriptServices").IncludeDirectory("~/Scripts/Services", "*.js", false));
            bundles.Add(new ScriptBundle("~/bundles/ewidencjaScript").IncludeDirectory("~/Scripts", "*.js", false));
            bundles.Add(new ScriptBundle("~/bundles/ewidencjaScriptControllers").IncludeDirectory("~/Scripts/Controllers", "*.js", false));


            bundles.Add(new Bundle("~/bundles/bootstrapCSS").Include(new []{"~/Content/bootstrap/bootstrap.css"}));
            bundles.Add(new StyleBundle("~/bundles/fontAwesome").Include(new[] {"~/Content/font-awesome.css"} ));
            bundles.Add(new Bundle("~/bundles/styles").IncludeDirectory("~/Content", "*.less", false));
           
        }
    }
}