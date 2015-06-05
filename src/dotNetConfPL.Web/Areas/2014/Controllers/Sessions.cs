using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using dotNetConfPL.Web.Areas._2014.Model;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace dotNetConfPL.Web.Areas._2014.Controllers
{
    [Route("api/[controller]")]
    public class Sessions : Controller
    {
        DbContext _context = new DbContext();

        // GET: api/values
        [HttpGet]
        public IEnumerable<Session> Get()
        {
            return _context.Sessions.OrderBy(x => x.Time);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Session Get(int id)
        {            
            return _context.Sessions.SingleOrDefault(x => x.Id == id);
        }
    }
}
