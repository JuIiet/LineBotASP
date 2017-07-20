using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace safeprojectname
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //System.Diagnostics.Debugger.Break();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
            if (HttpContext.Current != null)
            {
                var url = HttpContext.Current.Request.Url;
                var page = HttpContext.Current.Handler as System.Web.UI.Page;
            }
        }
    }
}
