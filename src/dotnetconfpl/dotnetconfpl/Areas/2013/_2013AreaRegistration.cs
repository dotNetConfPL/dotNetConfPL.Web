using System.Web.Mvc;

namespace dotnetconfpl.Areas._2013
{
    public class _2013AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "2013";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "2013_default", 
                "2013/{action}/{id}", 
                new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}
