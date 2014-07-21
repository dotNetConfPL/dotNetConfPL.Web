using dotnetconfpl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dotnetconfpl.Controllers
{
    public class SpeakersController : ApiController
    {
        DbContext _context = new DbContext();
        // GET api/speakers
        public IEnumerable<Speaker> Get()
        {
            return _context.Speakers;
        }

        // GET api/speakers/5
        public Speaker Get(int id)
        {
            return _context.Speakers.SingleOrDefault(x => x.Id == id);
        }
    }
}
