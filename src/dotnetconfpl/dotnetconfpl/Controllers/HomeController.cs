using System;
using System.Web;
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
                if (this.HttpContext.Application[CurrentStreamSessionKey] != null)
                {
                    return this.HttpContext.Application[CurrentStreamSessionKey] as string;
                }

                return string.Empty;
            }
            set
            {
                if (this.HttpContext.Application[CurrentStreamSessionKey] == null)
                {
                    this.HttpContext.Application.Add(CurrentStreamSessionKey, value);
                }
                else
                {
                    this.HttpContext.Application[CurrentStreamSessionKey] = value;
                }
            }
        }

        private string CurrentStreamType
        {
            get
            {
                if (this.HttpContext.Application[CurrentStreamTypeSessionKey] != null)
                {
                    return this.HttpContext.Application[CurrentStreamTypeSessionKey] as string;
                }

                return string.Empty;
            }
            set
            {
                if (this.HttpContext.Application[CurrentStreamTypeSessionKey] == null)
                {
                    this.HttpContext.Application.Add(CurrentStreamTypeSessionKey, value);
                }
                else
                {
                    this.HttpContext.Application[CurrentStreamTypeSessionKey] = value;
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


        [HttpGet]
        public ActionResult CheckStream(Guid password)
        {
            if (password == Guid.Parse("b641e87d-2645-4bb9-811b-3008b6bbc1ce"))
            {
                return View();
            }
            else
            {
                throw new HttpException(401, "Unauthorized access");
            }
        }


        [HttpPost]
        public ActionResult ReloadSession(string newStream, string password, string streamType)
        {
            if (PasswordCheck.HashVerified(password))
            {
                CurrentStream = newStream;
                CurrentStreamType = streamType;
            }

            return View("~/Views/Home/CheckStream.cshtml");
        }
    }
}
