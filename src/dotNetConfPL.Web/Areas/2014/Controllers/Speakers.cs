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
    public class Speakers : Controller
    {
        DbContext _context = new DbContext();

        // GET: api/values
        [HttpGet]
        public IEnumerable<Speaker> Get()
        {
            return _context.Speakers;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Speaker Get(int id)
        {
            return _context.Speakers.SingleOrDefault(x => x.Id == id);        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
