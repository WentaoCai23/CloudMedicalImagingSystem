using CloudMedicalImagingSystem.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CloudMedicalImagingSystem
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Application_BeginRequest(object sender, EventArgs e)
        {
            if (Request.Cookies != null)
            {
                if (safe_360.CookieData())
                {
                    Response.Write("The cookie data you submitted has malicious characters!");
                    Response.End();

                }

            }
            if (Request.UrlReferrer != null)
            {
                if (safe_360.referer())
                {
                    Response.Write("The Referrer data you submitted has malicious characters!");
                    Response.End();
                }
            }
            if (Request.RequestType.ToUpper() == "POST")
            {
                if (safe_360.PostData())
                {
                    Response.Write("The Post data you submitted has malicious characters!");
                    Response.End();
                }
            }
            if (Request.RequestType.ToUpper() == "GET")
            {
                if (safe_360.GetData())
                {
                    Response.Write("The Get data you submitted has malicious characters!");
                    Response.End();
                }
            }
        }
    }
}
