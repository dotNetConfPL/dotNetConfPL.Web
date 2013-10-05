using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace dotnetconfpl
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            RouteTable.Routes.MapHubs();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}