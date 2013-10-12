using System.Web.Mvc;
using Newtonsoft.Json;
using RestSharp;

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
    }
}
