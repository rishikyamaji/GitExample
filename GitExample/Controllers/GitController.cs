using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitExample.Controllers
{
    public class GitController : Controller
    {
        // GET: Git
        public ActionResult Index()
        {
            ViewBag.rishi = "this is rishi";
            return View();
        }
    }
}