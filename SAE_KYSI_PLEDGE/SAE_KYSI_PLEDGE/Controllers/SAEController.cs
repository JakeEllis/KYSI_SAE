using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAE_KYSI_PLEDGE.ViewModels;
using SAE_CORE;
using SAE_DAL;

namespace SAE_KYSI_PLEDGE.Controllers
{
    public class SAEController : Controller
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
            ViewBag.Message = "Edit Pledge";
            
            return View();
        }

        public ActionResult EditClass()
        {
            
            return View();
        }

        [ChildActionOnly]
        public ActionResult ClassDropDownList(string type, string selected)
        {
            SAE_DB _context = new SAE_DB();

            var ddlList = (from context in _context.PLEDGE_CLASS

                           select new DropdownListItem { Text = context.PLEDGE_CLASS_NAME, Value = context.PLEDGE_CLASS_NAME }).ToList();

            var editClassVM = new EditClassViewModel(ddlList, selected);

            return PartialView("EditClassPartialView", editClassVM);

        }

        [ChildActionOnly]
        public ActionResult PledgeFirstDropDownList(string type, string selected)
        {
            SAE_DB _context = new SAE_DB();

            var ddlList = (from context in _context.PLEDGEs

                           select new DropdownListItem { Text = context.FIRST_NAME, Value = context.LAST_NAME }).ToList();

            var editPledgeVM = new EditPledgeViewModel(ddlList, selected);

            return PartialView("EditPledgePartialView", editPledgeVM);

        }

        [ChildActionOnly]
        public ActionResult PledgeLastDropDownList(string type, string selected)
        {
            SAE_DB _context = new SAE_DB();

            var ddlList = (from context in _context.PLEDGEs

                           select new DropdownListItem { Text = context.LAST_NAME, Value = context.LAST_NAME }).ToList();

            var editPledgeVM = new EditPledgeViewModel(ddlList, selected);

            return PartialView("EditPledgePartialView", editPledgeVM);

        }



        public ActionResult ManagePoints()
        {
            ViewBag.Message = "Manage Points";

            return View();
        }

    }
}
