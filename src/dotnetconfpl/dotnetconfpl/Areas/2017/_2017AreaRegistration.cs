using System.Web.Mvc;

namespace dotnetconfpl.Areas._2017
{
    public class _2017AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "2017";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "2017_default",
                "2017/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}
