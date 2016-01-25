using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Rf.Web.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/themes/kingadmin/js").Include(
                "~/Scripts/kingadmin/jquery/jquery-2.1.0.min.js",
                "~/Scripts/kingadmin/bootstrap/bootstrap.min.js",
                "~/Scripts/kingadmin/plugins/bootstrap-tour/bootstrap-tour.custom.js",
                "~/Scripts/kingadmin/plugins/modernizr/modernizr.js",
                "~/Scripts/kingadmin/king-common.js",
                "~/Scripts/kingadmin/plugins/stat/jquery.easypiechart.min.js",
                "~/Scripts/kingadmin/plugins/raphael/raphael-2.1.0.min.js",
                "~/Scripts/kingadmin/plugins/stat/flot/jquery.flot.min.js",
                "~/Scripts/kingadmin/plugins/stat/flot/jquery.flot.resize.min.js",
                "~/Scripts/kingadmin/plugins/stat/flot/jquery.flot.time.min.js",
                "~/Scripts/kingadmin/plugins/stat/flot/jquery.flot.pie.min.js",
                "~/Scripts/kingadmin/plugins/stat/flot/jquery.flot.tooltip.min.js",
                "~/Scripts/kingadmin/plugins/jquery-sparkline/jquery.sparkline.min.js",
                "~/Scripts/kingadmin/plugins/datatable/jquery.dataTables.min.js",
                "~/Scripts/kingadmin/plugins/datatable/dataTables.bootstrap.js",
                "~/Scripts/kingadmin/plugins/datatable/exts/dataTables.tableTools.min.js",
                "~/Scripts/kingadmin/plugins/select2/select2.min.js",
                "~/Scripts/kingadmin/plugins/bootstrap-datepicker/bootstrap-datepicker.js",
                "~/Scripts/kingadmin/king-chart-stat.js",
                "~/Scripts/kingadmin/king-table.js",
                "~/Scripts/kingadmin/king-components.js"
            ));

            bundles.Add(new StyleBundle("~/bundles/themes/kingadmin/css").Include(
                "~/Content/themes/kingadmin/css/bootstrap.css",
                "~/Content/themes/kingadmin/css/font-awesome.css",
                "~/Content/themes/kingadmin/css/main.css"
            ));
        }
    }
}