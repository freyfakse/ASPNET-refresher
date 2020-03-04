using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Landing page";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var name = "test name";
            var id = "0123";

            //using (var db = new Model1()) { }
            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}