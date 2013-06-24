using System.Web.Mvc;
using dotnetconfpl.DAL;
using dotnetconfpl.Services;

namespace dotnetconfpl.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Attende newAttende)
        {
            if (ModelState.IsValid)
            {
                new RavenDbClient().AddAttende(newAttende);
                return RedirectToAction("Finish");
            }
            else
            {
                return View(newAttende);
            }
        }

        public ActionResult List()
        {
            var listOfAttendes = new RavenDbClient().List();
            return View(listOfAttendes);
        }

        public ActionResult Finish()
        {
            return View();
        }
    }
}
