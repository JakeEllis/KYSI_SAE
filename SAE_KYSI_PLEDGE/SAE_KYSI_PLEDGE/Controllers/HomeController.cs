using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAE_KYSI_PLEDGE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Home Controller file";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Home Controller file";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Home Controller file";

            return View();
        }
    }
}
