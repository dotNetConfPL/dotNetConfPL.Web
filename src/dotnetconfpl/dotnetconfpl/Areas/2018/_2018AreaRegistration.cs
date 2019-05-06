using System.Web.Mvc;

namespace dotnetconfpl.Areas._2018
{
    public class _2018AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "2018";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "2018_default",
                "2018/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}
