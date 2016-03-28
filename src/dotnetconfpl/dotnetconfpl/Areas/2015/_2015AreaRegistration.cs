using System.Web.Mvc;

namespace dotnetconfpl.Areas._2015
{
    public class _2015AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "2015";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "2015_default",
                "2015/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}