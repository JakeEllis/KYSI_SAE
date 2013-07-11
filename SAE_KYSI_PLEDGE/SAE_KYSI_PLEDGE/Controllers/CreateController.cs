using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAE_KYSI_PLEDGE.Controllers
{
    public class CreateController : Controller
    {

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult CreateClass()
        {
            ViewBag.Message = "Create Pledge Class";

            return View();
        }

        public ActionResult CreatePledge()
        {
            ViewBag.Message = "Create Pledge";

            return View();
        }

        public ActionResult EditPledge()
        {
            ViewBag.Message = "Create Pledge";

            return View();
        }

        public ActionResult EditClass()
        {
            ViewBag.Message = "Create Pledge";

            return View();
        }

        public ActionResult ManagePoints()
        {
            ViewBag.Message = "Create Pledge";

            return View();
        }

    }
}
