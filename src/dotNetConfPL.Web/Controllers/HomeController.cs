using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using dotNetConfPL.Web.Model;
using Microsoft.AspNet.Http;
using RestSharp;

namespace dotNetConfPL.Web.Controllers
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

    public class HomeController : Controller
    {
        private const string CurrentStreamSessionKey = "CurrentStream";

        private StreamDocModel CurrentStream
        {
            get
            {
                //if (Context.Session.GetString(CurrentStreamSessionKey) != null)
                //{
                //    return Context.Session.Get(CurrentStreamSessionKey) as StreamDocModel;
                //}
                //else
                //{
                    var stream = this.GetStreamFromCouchDb();
                //    //this.HttpContext.Application.Add(CurrentStreamSessionKey, stream);
                    return stream;
                //}
            }
            //set
            //{
            //    this.SetStreamToCouchDb(value);

            //    if (this.HttpContext.Application[CurrentStreamSessionKey] == null)
            //    {
            //        this.HttpContext.Application.Add(CurrentStreamSessionKey, value);
            //    }
            //    else
            //    {
            //        this.HttpContext.Application[CurrentStreamSessionKey] = value;
            //    }
            //}
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

        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult Agenda()
        {
            return View(_context.Sessions.OrderBy(x => x.Time));
        }

        [Route("[action]")]
        public IActionResult Speakers()
        {
            return View(_context.Speakers.OrderBy(x => x.Name));
        }

        [Route("[action]")]
        public IActionResult Contact(int year)
        {
            return View();
        }
        
        [Route("[action]")]
        public IActionResult Live()
        {
            return View(new Stream { Url = @"https://www.youtube.com/embed/es_qdXKSh7M"});
        }
    }
}
