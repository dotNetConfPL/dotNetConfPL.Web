using System.Web.Mvc;

namespace dotnetconfpl.Controllers
{
    public class StreamModel
    {
        public bool IsAdmin { get; set; } 
        public string CurrentStream { get; set; } 
        public string CurrentStreamInfo { get; set; } 
    }

    public class HomeController : Controller
    {
        private static string CurrentStream { get; set; }

        private static string CurrentStreamType { get; set; }

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
            return View(new StreamModel
                {
                    CurrentStream = CurrentStream,
                    CurrentStreamInfo = StreamInfo.GetMeStreamInfo(CurrentStreamType),
                    IsAdmin = id == "Admin"
                });
        }

        [HttpPost]
        public void UpdateStream(string newStream, string password, string streamType)
        {
            if (PasswordCheck.HashVerified(password))
            {
                CurrentStream = newStream;
                CurrentStreamType = streamType;
            }
        }
    }
}
