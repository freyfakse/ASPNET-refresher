using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DNDController : Controller
    {
        // GET: DND
        public ActionResult NameGenerator()
        {
            ViewBag.Message = "Name generator";
            return View();
        }

        public ActionResult AbilityScoreGenerator()
        {
            ViewBag.Message = "Ability score generator";
            return View();
        }
    }
}