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
        private const string CurrentStreamSessionKey = "CurrentStream";
        private const string CurrentStreamTypeSessionKey = "CurrentStreamType";

        private string CurrentStream
        {
            get
            {
                if (this.HttpContext.Session[CurrentStreamSessionKey] != null)
                {
                    return this.HttpContext.Session[CurrentStreamSessionKey] as string;
                }

                return string.Empty;
            }
            set
            {
                if (this.HttpContext.Session[CurrentStreamSessionKey] == null)
                {
                    this.HttpContext.Session.Add(CurrentStreamSessionKey, value);
                }
                else
                {
                    this.HttpContext.Session[CurrentStreamSessionKey] = value;
                }
            }
        }

        private string CurrentStreamType
        {
            get
            {
                if (this.HttpContext.Session[CurrentStreamTypeSessionKey] != null)
                {
                    return this.HttpContext.Session[CurrentStreamTypeSessionKey] as string;
                }

                return string.Empty;
            }
            set
            {
                if (this.HttpContext.Session[CurrentStreamTypeSessionKey] == null)
                {
                    this.HttpContext.Session.Add(CurrentStreamTypeSessionKey, value);
                }
                else
                {
                    this.HttpContext.Session[CurrentStreamTypeSessionKey] = value;
                }
            }
        }

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
