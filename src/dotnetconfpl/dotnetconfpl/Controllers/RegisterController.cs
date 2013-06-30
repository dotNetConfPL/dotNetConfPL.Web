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
            var client = new RavenDbClient();

            if (ModelState.IsValid)
            {
                if (!client.DoesAttendeExist(newAttende.Mail))
                {
                    client.AddAttende(newAttende);
                    return RedirectToAction("Finish");
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty ,"Użytkownik o podanym mailu został już dodany.");
                    return View(newAttende);
                }
            }
            else
            {
                return View(newAttende);
            }
        }

        public ActionResult Finish()
        {
            return View();
        }
    }
}
