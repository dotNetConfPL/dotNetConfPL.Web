using System.Web.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Web;
using System.Collections.Generic;

namespace dotnetconfpl.Controllers
{
    public class StreamModel
    {
        public bool IsAdmin { get; set; } 
        public string CurrentStream { get; set; } 
        public string CurrentStreamInfo { get; set; } 
    }

    public class StreamDocModel
    {
        public string _id { get { return "current_stream"; } }
        public string stream { get; set; }
        public string type { get; set; }
    }

    [OutputCache(CacheProfile = "CacheTime")]
    public class HomeController : Controller
    {
        private const string CurrentStreamSessionKey = "CurrentStream";

        private StreamDocModel CurrentStream
        {
            get
            {
                if (this.HttpContext.Application[CurrentStreamSessionKey] != null)
                {
                    return this.HttpContext.Application[CurrentStreamSessionKey] as StreamDocModel;
                }
                else
                {
                    var stream = this.GetStreamFromCouchDb();
                    this.HttpContext.Application.Add(CurrentStreamSessionKey, stream);
                    return stream;
                }
            }
            set
            {
                this.SetStreamToCouchDb(value);

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

        private void SetStreamToCouchDb(StreamDocModel value)
        {
            var client = new RestClient(string.Format("http://mfranc.cloudant.com/dotnetconf/_design/update_stream/_update/in-place-query/current_stream?field=stream&value={0}", value.stream));
            var request = new RestRequest(Method.PUT);

            var response = client.Execute(request);
        }

        private StreamDocModel GetStreamFromCouchDb()
        {
            var client = new RestClient("http://mfranc.cloudant.com/dotnetconf/current_stream");
            var request = new RestRequest(Method.GET);
            var response = client.Execute<StreamDocModel>(request);

            return response.Data;
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
            var currentstream = CurrentStream ?? new StreamDocModel {stream = string.Empty, type = string.Empty}; 

            return View(new StreamModel
                {
                    CurrentStream = currentstream.stream,
                    CurrentStreamInfo = StreamInfo.GetMeStreamInfo(currentstream.type),
                    IsAdmin = id == "Admin"
                });
        }

        [HttpPost]
        [OutputCache(Duration = 0)]
        public void UpdateStream(string newStream, string password, string streamType)
        {
            if (PasswordCheck.HashVerified(password))
            {
                CurrentStream = new StreamDocModel {stream = newStream, type = streamType};
            }
        }

        [HttpGet]
        public ActionResult CheckStream(string password)
        {
            if (password != null && PasswordCheck.HashVerified(password))
            {
                return View(CurrentStream);
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
                CurrentStream.stream = newStream;
                CurrentStream.type = streamType;
            }

            return View("~/Views/Home/CheckStream.cshtml");
        }

        public ActionResult Data()
        {
            var sessions = new List<Session>();

            var speaker1 = new Speaker 
            {
                Name = "Maciej Aniserowicz",
                About = "MVP i najpopularniejszy blogger w polskim środowisku .NET. Miłośnik testów jednostkowych, Gita i Resharpera, zatwardziały wróg TFSa i Sharepointa. Z zawodu programista/architekt .NET w firmie Ultrico. Wcześniej pracował w firmie Predica. Przez pewien czas był także Freelancerem. Ponadto jest dwukrotnym finalistą ImagineCup i byłym redaktorem CodeGuru.pl.",
                Photo = "http://dotnetconfpl.apphb.com/Content/images/maciej_aniserowicz.jpg"
            };

            var speaker2 = new Speaker
            {
                Name = "Maciej Grabek",
                About = "MVP, blogger, głównie zajmuje się platformą Windows Phone. Prelegent na Microsoft Technology Summit w 2011 i 2012 roku, redaktor CodeGuru.pl, współtwórca serii webcastów poświęconych technologii Windows Phone 7 oraz Windows Phone 8. Ponadto współzałożyciel Toruńskiej Grupy Developerów .NET. Zajmuje się .NETem od czasów studiów i wersji 1.1.",
                Photo = "http://dotnetconfpl.apphb.com/Content/images/maciej_grabek.jpg"
            };

            var session1 = new Session
            {
                Time = "15:00 - 16:00",
                Title = "Testy jednostkowe w .NET",
                Speaker = speaker1,
                About = "Podczas sesji zaprezentowane zostanie pragmatyczne podejście do pisania testów jednostkowych w .NET. Teoria w połączeniu z praktyką zademonstrują dlaczego automatyczne testowanie oprogramowania jest niezmiernie ważne oraz... jak robić to bezboleśnie."
            };

            var session2 = new Session
            {
                Time = "16:00 - 17:00",
                Title = "Windows Phone 8 Tips & Tricks",
                Speaker = speaker2,
                About = "Windows Phone to dynamicznie rozwijająca się platforma, która zdobywa coraz większą rzeszę zwolenników i programisów. Okazuje się, że posiada również pewne arkana, o których nie wszyscy wiedzą, a które pozwalają tworzyć lepsze i bardziej przyjazne użytkownikom aplikacje. Dołącz się do konreferncji i przekonaj co jeszcze warto wiedzieć o Windows Phone."
            };

            sessions.Add(session1);
            sessions.Add(session2);

            return Json(new { Sessions = sessions }, JsonRequestBehavior.AllowGet);
        }
    }

    class Speaker
    {
        public string Name { get; set; }
        public string About { get; set; }
        public string Photo { get; set; }
    }

    class Session
    {
        public string Time { get; set; }
        public string Title { get; set; }
        public Speaker Speaker { get; set; }
        public string About { get; set; }
    }

}
