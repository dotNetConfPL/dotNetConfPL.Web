using System;
using System.Linq;
using System.Web.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Web;
using System.Collections.Generic;
using dotnetconfpl.Model;
using JustGiving.EventStore.Http.Client;

namespace dotnetconfpl.Controllers
{
    public class StreamModel
    {
        public bool IsAdmin { get; set; } 
        public string CurrentStream { get; set; } 
        public string CurrentStreamInfo { get; set; }
        public bool CanVote { get; set; }
    }

    public class StreamDocModel
    {
        public string _id { get { return "current_stream"; } }
        public string stream { get; set; }
        public string type { get; set; }
        public string talkId { get; set; }
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

        private DbContext _context = new DbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agenda()
        {
            return View(_context.Sessions.OrderBy(x => x.Time));
        }

        public ActionResult Speakers()
        {
            return View(_context.Speakers);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Stream(string id)
        {
            var currentstream = CurrentStream ?? new StreamDocModel {stream = string.Empty, type = string.Empty};

            var cookieData = this.HttpContext.Request.Cookies["dotnetconfpl_magic_cookie"];

            return View(new StreamModel
                {
                    CurrentStream = currentstream.stream,
                    CurrentStreamInfo = StreamInfo.GetMeStreamInfo(currentstream.type),
                    IsAdmin = id == "Admin",
                    CanVote = cookieData == null || cookieData.Values[currentstream.talkId] == null
                });
        }

        [HttpPost]
        [OutputCache(Duration = 0)]
        public void UpdateStream(string newStream, string password, string streamType)
        {
            //if (PasswordCheck.HashVerified(password))
            //{
                CurrentStream = new StreamDocModel {stream = newStream, type = streamType};
            //}
        }

        [HttpPost]
        public void Vote(string votetype, string comment, int talkId)
        {
            //TODO: Store the info if someone voted in the cookie ? ( we dont have to make it really bullet proof )
            //TODO: but there will be multiple votes per id
            //TODO: its allways like that , idea is simple and everything gets complicated
            //TODO: this code will be refactored later now its only POC

            if (this.HttpContext.Request.Cookies["dotnetconfpl_magic_cookie"] == null)
            {
                var magicCookie = new System.Web.HttpCookie("dotnetconfpl_magic_cookie");
                this.HttpContext.Request.Cookies.Add(magicCookie);
            }

            var cookieData = this.HttpContext.Request.Cookies["dotnetconfpl_magic_cookie"];

            if (cookieData.Values[talkId.ToString()] != null)
            {
                //TODO: inject config value for external store
                var eventStoreClient = EventStoreHttpConnection.Create("http://localhost:2113");
                var testEvent = new UserVotedV2 {Type = votetype, Comment = comment, Id = talkId};
                var result = eventStoreClient.AppendToStreamAsync("Vote", testEvent);

                if (result.IsFaulted)
                {
                    throw new Exception($"Oops - {result.Exception?.InnerException.Message}");
                }
                cookieData.Values.Add(talkId.ToString(), "true");
                this.HttpContext.Request.Cookies.Set(cookieData);
            }

        }
    }

    public class UserVotedV2
    {
        public string Type { get; set; }
        public string Comment { get; set; }
        public int Id { get; set; }
    }
}
