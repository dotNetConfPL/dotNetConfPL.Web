using Microsoft.AspNet.Mvc;

namespace dotNetConfPL.Web.Areas._2013.Controllers
{
    [Area("2013")]
    public class HomeController : Controller
    {
        //
        // GET: /2013/Home/

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
            return View("/Views/Home/Contact");
        }

    }
}
