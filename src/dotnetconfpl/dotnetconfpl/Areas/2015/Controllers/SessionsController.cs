using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dotnetconfpl.Areas._2015.Model;

namespace dotnetconfpl.Areas._2015.Controllers
{
    public class SessionsController : ApiController
    {
        DbContext _context = new DbContext();
        // GET api/sessions
        public IEnumerable<Session> Get()
        {
            return _context.Sessions.OrderBy(x => x.Time);
        }

        // GET api/sessions/5
        public Session Get(int id)
        {
            return _context.Sessions.SingleOrDefault(x => x.Id == id);
        }
    }
}
