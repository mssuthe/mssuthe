using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorldBuildTest.Models;

namespace HelloWorldBuildTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            HomeModel home = new HomeModel();
            return View(home);
        }

        [HttpPost]
        public ActionResult Index(HomeModel home, string name)
        {
            home.name = name;
            home.GetMessage();
            return View(home);
        }
        
    }
}
