using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAE_KYSI_PLEDGE.Controllers
{
    public class Create : Controller
    {
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

    }
}
