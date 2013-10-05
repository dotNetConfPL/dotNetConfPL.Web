using System;
using System.Web.Mvc;

namespace dotnetconfpl.Controllers
{
    [OutputCache(CacheProfile = "CacheTime")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agenda()
        {
            return View();
        }

        public ActionResult Speakers()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
