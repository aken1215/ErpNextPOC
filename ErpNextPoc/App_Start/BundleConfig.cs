﻿using System.Web;
using System.Web.Optimization;

namespace ErpNextPoc
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                     "~/Scripts/angular.js",
                     "~/Scripts/angular-sanitize.js",
                     "~/Scripts/angular-ui-router.js"
                     ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                  //// Root
                  "~/TypeScripts/app.js",
                  //// Config
                  "~/TypeScripts/Configs/config.js",
                  "~/TypeScripts/Configs/route.config.js",
                  //// Components
                  "~/TypeScripts/Components/approve.controller.js",

                  //// Service
                  "~/TypeScripts/Services/member.service.js",
                  //// Controller/Member
                  "~/TypeScripts/Controllers/memberLogin/member.controller.js",
                  "~/TypeScripts/Base/base.controller.js",
                  "~/TypeScripts/Controllers/memberLogin/member.route.js",

                  //InfoSupport
                    "~/TypeScripts/Controllers/資訊服務單/infoSupport.edit.controller.js",
                    "~/TypeScripts/Controllers/資訊服務單/infoSupport.detail.controller.js",
                    "~/TypeScripts/Controllers/資訊服務單/infoSupport.route.js"
                  ));

        }
    }
}
