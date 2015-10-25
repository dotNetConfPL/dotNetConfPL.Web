using dotNetConfPL.Web.Areas._2014.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotnetconfpl.Areas._2014.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /2014/Home/

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
            return Redirect("/Contact");
        }

    }
}
