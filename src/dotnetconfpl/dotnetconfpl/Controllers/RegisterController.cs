using System.Web.Mvc;
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
        public ActionResult Index(string test = "")
        {
            new RavenDbClient().AddTestUser();
            return RedirectToAction("Index");
        }

        public ActionResult List()
        {
            var listOfAttendes = new RavenDbClient().List();
            return View(listOfAttendes);
        }
    }
}
