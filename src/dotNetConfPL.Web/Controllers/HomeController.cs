using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using dotNetConfPL.Web.Model;

namespace dotNetConfPL.Web.Controllers
{
    public class HomeController : Controller
    {
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
            return View(_context.Speakers);
        }

        [Route("[action]")]
        public IActionResult Contact(int year)
        {
            return View();
        }
    }
}
