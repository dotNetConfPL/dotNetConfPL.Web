using System.Web.Mvc;

namespace dotnetconfpl.Areas._2016
{
    public class _2016AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "2016";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "2016_default",
                "2016/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}
