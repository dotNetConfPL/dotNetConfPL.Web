using System.Web.Mvc;

namespace dotnetconfpl.Controllers
{
    public class StreamModel
    {
        public bool IsAdmin { get; set; } 
        public string CurrentStream { get; set; } 
    }

    public class HomeController : Controller
    {
        private const string CurrentStreamSessionKey = "CurrentStream";

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

        public ActionResult Stream(string id)
        {
            var currentStream = string.Empty;
            if (this.HttpContext.Session[CurrentStreamSessionKey] != null)
            {
                currentStream = this.HttpContext.Session[CurrentStreamSessionKey] as string;
            }

            return View(new StreamModel
                {
                    CurrentStream = currentStream,
                    IsAdmin = id == "Admin"
                });
        }

        [HttpPost]
        public void UpdateStream(string newStream, string password)
        {
            if (PasswordCheck.HashVerified(password))
            {
                if (this.HttpContext.Session[CurrentStreamSessionKey] == null)
                {
                    this.HttpContext.Session.Add(CurrentStreamSessionKey, newStream);
                }
                else
                {
                    this.HttpContext.Session[CurrentStreamSessionKey] = newStream;
                }
            }
        }
    }
}
