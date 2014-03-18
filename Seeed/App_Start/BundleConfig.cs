using System.Web;
using System.Web.Optimization;

namespace Seeed
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/seeed/js").Include("~/jscript/jquery-2.0.3.min.js",
                "~/jscript/jquery-ui-1.10.3.custom.min.js",
                "~/jscript/jquery.ui.touch-punch.min.js",
                "~/jscript/bootstrap.min.js"
                ));
            bundles.Add(new StyleBundle("~/seeed/css").Include("~/css/bootstrap.css",
                "~/css/flat-ui.css",
                "~/css/seeed-site.css"));




            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
