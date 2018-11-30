using System.Linq;
using System.Web.Mvc;
using RestSharp;
using dotnetconfpl.Model;
using System;
using System.Collections;
using System.Configuration;
using System.Net;
using Microsoft.WindowsAzure.Storage;

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
            var storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings["AzureStorage"]);

            var blobClient = storageAccount.CreateCloudBlobClient();

            var container = blobClient.GetContainerReference(ConfigurationManager.AppSettings["ContainerName"]);
            container.CreateIfNotExists();
            var currentStream = container.GetBlockBlobReference("CurrentStream");
            currentStream.UploadText(Newtonsoft.Json.JsonConvert.SerializeObject(value));
        }

        private StreamDocModel GetStreamFromCouchDb()
        {
            var storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings["AzureStorage"]);

            var blobClient = storageAccount.CreateCloudBlobClient();

            var container = blobClient.GetContainerReference(ConfigurationManager.AppSettings["ContainerName"]);
            container.CreateIfNotExists();
            var currentStream = container.GetBlockBlobReference("CurrentStream");
            if (currentStream.Exists() == false)
                return new StreamDocModel{stream = "", type = ""};
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StreamDocModel>(currentStream.DownloadText());
        }

        private DbContext _context = new DbContext();

        public ActionResult Index()
        {
            return View(_context.Sessions.OrderBy(x => x.Time));
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

        public ActionResult CallForPapers()
        {
            return View();
        }

        public ActionResult OnSiteEvents()
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
        public ActionResult UpdateStream(string newStream, string password, string streamType)
        {
            if (newStream.IndexOf("youtube", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (newStream.Contains("watch?v="))
            {
                newStream = newStream.Replace("watch?v=", "embed/");
            }

            if (PasswordCheck.HashVerified(password))
            {
                CurrentStream = new StreamDocModel {stream = newStream, type = streamType};
                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }

            return new HttpUnauthorizedResult("Invalid password");
        }

        [HttpPost]
        [OutputCache(Duration = 0)]
        public void AddQuestion(string question)
        {
        }

        public ActionResult Html(string page)
        {
            return Content("google-site-verification: google518e43aa497595a5.html");
        }
    }    
}
