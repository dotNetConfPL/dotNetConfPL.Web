using System.Web.Mvc;

namespace dotnetconfpl.Areas._2014
{
    public class _2014AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "2014";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "2014_default",
                "2014/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}
