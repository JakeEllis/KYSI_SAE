using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAE_KYSI_PLEDGE.ViewModels;
using SAE_DAL;
using SAE_CORE;
using SAE_CORE.Models;

namespace SAE_KYSI_PLEDGE.Controllers
{
    public class SAEController : Controller
    {

        public ActionResult Index()
        {

            return View();
        }




        #region Create Class

        [HttpGet] // the create class constructor
        public ActionResult CreateClass()
        {
            ViewBag.Message = "Create A Class";

            return View();
        }


        [HttpPost] // Saving the new pledge class to the database
        public ActionResult CreateClass(PledgeClassModel m)
        {
            if (ModelState.IsValid)
            {

                SAE_DB _context = new SAE_DB();


                var pledgeClass = new PLEDGE_CLASS
                {
                    CO_PLEDGE_ED_FIRST_NAME = m.Co_Pledge_Educator_First_Name,
                    CO_PLEDGE_ED_LAST_NAME = m.Co_Pledge_Educator_Last_Name,
                    PLEDGE_ED_FIRST_NAME = m.Pledge_Educator_First_Name,
                    PLEDGE_ED_LAST_NAME = m.Pledge_Educator_Last_Name,
                    PLEDGE_CLASS_NAME = m.Pledge_Class_Name,
                    PLEDGE_CLASS_SEM = m.Pledge_Class_Semester,
                    PLEDGE_CLASS_YEAR = m.Pledge_Class_Year,
                    PLEDGE_COUNT = m.Pledge_Count,
                    PLEDGE_CLASS_ID = m.Pledge_Class_ID,
                    PLEDGE_DROP_COUNT = m.Pledge_Drop_Count,
                    INITIATED_COUNT = m.Pledge_Initiated_Count
                };

                _context.PLEDGE_CLASS.Add(pledgeClass);
                _context.SaveChanges();
                

                return RedirectToAction("CreatePledge");
            }
            return View("CreateClass");

        }
        #endregion



        #region Create Pledge

        [HttpGet] //The constructor for the create pledge view
        public ActionResult CreatePledge()
        {

            return View();
        }


        [HttpPost] //Saving the pledge information to the database
        public ActionResult CreatePledge(CreatePledgeViewModel m)
        {

            if (ModelState.IsValid)
            {
                SAE_DB _context = new SAE_DB();

                var CreatePledgeVM = new CreatePledgeViewModel();

                var pledge = new PLEDGE
                {
                    FIRST_NAME = m.FirstName,
                    LAST_NAME = m.LastName,
                    PHONE = m.PhoneNumber,
                    STREET_ADDR = m.Street_Address,
                    CITY = m.City,
                    EMAIL = m.Email,
                    ZIP = m.ZipCode,
                    BIG_BROTHER_FIRST = m.BigBro_First,
                    BIG_BROTHER_LAST = m.BigBro_Last,
                    GRAD_YEAR = m.GradYear,
                    PLEDGE_ID = m.PledgeID,

                    PLEDGE_CLASS_ID = m.Pledge_Class_Name
                };

                _context.PLEDGEs.Add(pledge);
              
                _context.SaveChanges();

                return RedirectToAction("CreatePledge");
            }
            return View("CreatePledge");
        }

        //public JsonResult PledgeList()
        //{
        //   // SAE_DB _context = new SAE_DB();

        //    return null;//Json(Data, JsonRequestBehavior.AllowGet);
        //}


        //AddPledgeToClass is to populate the readonly portion above the 

        [ChildActionOnly]                 // pledge information to display the class information they are being added to
        public ActionResult AddPledgeToClass(string type, string selected)
        {
            SAE_DB _context = new SAE_DB();

            var pledge = new PLEDGE_CLASS
            {
                //FIRST_NAME = m.FirstName,
                //LAST_NAME = m.LastName,
                //PHONE = m.PhoneNumber,
                //STREET_ADDR = m.Street_Address,
                //CITY = m.City,
                //EMAIL = m.Email,
                //ZIP = m.ZipCode,
                //BIG_BROTHER_FIRST = m.BigBro_First,
                //BIG_BROTHER_LAST = m.BigBro_Last,
                //GRAD_YEAR = m.GradYear,
                //PLEDGE_ID = m.PledgeID,
                //PLEDGE_CLASS_ID = m.Pledge_Class_ID
            };


            //var ddlList = (from context in _context.PLEDGE_CLASS

            //               select new DropdownListItem { Text = context.PLEDGE_CLASS_NAME, Value = context.PLEDGE_CLASS_NAME }).ToList();

            //var pledgeClassVM = new EditClassViewModel(ddlList, selected);

            //return PartialView("AddPledgeToPledgeClassPartialView", pledgeClassVM);
            return View();

        }

        #endregion



        #region edit pledge
        public ActionResult EditPledge()
        {
            return View();
        }
        
        [ChildActionOnly]
        public ActionResult PledgeFirstDropDownList(string type, string selected)
        {
            SAE_DB _context = new SAE_DB();

            var ddlList = (from context in _context.PLEDGEs

                           select new DropDownListItem<string>  { Text = context.FIRST_NAME, Value = context.LAST_NAME }).ToList();

            var editPledgeVM = new EditPledgeViewModel()
                {
                    SelectedItemID = selected,
                    Pledges = ddlList
                };

            return PartialView("EditPledgePartialView", editPledgeVM);

        }

        [ChildActionOnly]
        public ActionResult PledgeLastDropDownList(string type, string selected)
        {
            SAE_DB _context = new SAE_DB();

            var ddlList = (from context in _context.PLEDGEs

                           select new DropDownListItem<string> { Text = context.LAST_NAME, Value = context.LAST_NAME }).ToList();

            var editPledgeVM = new EditPledgeViewModel()
                {
                    SelectedItemID = selected,
                    Pledges = ddlList
                };

            return PartialView("EditPledgePartialView", editPledgeVM);

        }

        #endregion

        #region Edit Class
        public ActionResult EditClass()
        {

            return View();
        }


        [ChildActionOnly]
        public ActionResult ClassDropDownList(string type, int selected)
        {
            SAE_DB _context = new SAE_DB();

            var ddlList = (from context in _context.PLEDGE_CLASS

                           select new DropDownListItem<int> { Text = context.PLEDGE_CLASS_NAME, Value = context.PLEDGE_CLASS_ID }).ToList();

            var editClassVM = new EditClassViewModel()
                {
                    SelectedItemID = selected,
                    Classes = ddlList  
                };

            return PartialView("EditClassPartialView", editClassVM);

        }
        #endregion

        #region points

        public ActionResult ManagePoints()
        {
          
            return View();
        }


        public ActionResult ManagePoints(PointsModel m)
        {
            SAE_DB _Context = new SAE_DB();

            //var data = from PLEDGE select *;

            return View();
        }


        #endregion

    }
}
