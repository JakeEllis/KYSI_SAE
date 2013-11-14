using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAE_CORE.Models;


namespace SAE_KYSI_PLEDGE.ViewModels
{
    public class CreateClassViewModel : Controller
    {
        //
        // GET: /CreateClassViewModel/

        List<PledgeClassModel> PledgeClassModel { get; set; }
        List<> PledgeModel { get; set; }
        

        public ActionResult Index()
        {
            return View();
        }

    }
}
