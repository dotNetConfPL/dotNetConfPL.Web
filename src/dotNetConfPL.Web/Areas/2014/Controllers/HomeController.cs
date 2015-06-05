using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using dotNetConfPL.Web.Areas._2014.Model;

namespace dotNetConfPL.Web.Areas._2014.Controllers
{
    [Area("2014")]
    public class HomeController : Controller
    {
        private DbContext _context = new DbContext();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Agenda()
        {
            return View(_context.Sessions.OrderBy(x => x.Time));
        }

        public IActionResult Speakers()
        {
            return View(_context.Speakers);
        }

        public IActionResult Contact(int year)
        {
            return View("/Views/Home/Contact");
        }
    }
}
