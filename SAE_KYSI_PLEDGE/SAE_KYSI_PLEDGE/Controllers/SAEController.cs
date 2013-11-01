using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAE_KYSI_PLEDGE.ViewModels;
using SAE_CORE.Models;
using SAE_DAL.Repositories;
using SAE_DAL;

namespace SAE_KYSI_PLEDGE.Controllers
{
    public class SAEController : Controller
    {

        public ActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public ActionResult CreateClass()
        {
            ViewBag.Message = "Create A Class";

            return View();
        }


        [HttpPost]
        public ActionResult CreateClass(PledgeClassModel m)
        {
            if (ModelState.IsValid)
            {
                
               SAE_DB _context = new SAE_DB();
              
                
                var pledgeClass = new PLEDGE_CLASS{
                    CO_PLEDGE_ED_FIRST_NAME = m.Co_Pledge_Educator_First_Name,
                    CO_PLEDGE_ED_LAST_NAME = m.Co_Pledge_Educator_Last_Name,
                    PLEDGE_ED_FIRST_NAME = m.Pledge_Educator_First_Name,
                    PLEDGE_ED_LAST_NAME = m.Pledge_Educator_Last_Name,
                    PLEDGE_CLASS_NAME = m.Pledge_Class_Name,
                    PLEDGE_CLASS_SEM = m.Pledge_Class_Semester,
                    PLEDGE_CLASS_YEAR = m.Pledge_Class_Year,
                    PLEDGE_COUNT = m.Pledge_Count,
                    PLEDGE_CLASS_ID = m.Pledge_Class_ID,
                    PLEDGE_DROP_COUNT = m.Pledge_Drop_Count
                };

                _context.PLEDGE_CLASS.Add(pledgeClass);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
                return View("CreateClass");
            
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
