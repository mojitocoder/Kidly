using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using FirstQuestion.Extensions;

namespace FirstQuestion
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(FirstQuestion.Api.WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            GlobalFilters.Filters.Add(new RedirectToCanonicalUrlAttribute(RouteTable.Routes.AppendTrailingSlash, RouteTable.Routes.LowercaseUrls));

#if (!DEBUG)
            GlobalFilters.Filters.Add(new RedirectToHttpsAttribute(true));
#endif
        }
    }
}