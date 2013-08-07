using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAE_DAL;

namespace SAE_CORE.Models
{
    public class PledgeClassModel : Controller
    {
        public string Pledge_Class_ID { get; set; }
        public string Pledge_Class_Name { get; set; }
        public string Pledge_Class_Semester { get; set; }
        public string Pledge_Class_Year { get; set; }
        public string Pledge_Count { get; set; }
        public string Pledge_Educator { get; set; }
        public string Co_Pledge_Educator { get; set; }
        public string Pledge_Initiated_Count { get; set; }
        public string Pledge_Drop_Count { get; set; }

        //public List<SelectListItem> Classes { get; set; }

        //private List<SelectListItem> GetClasses()
        //{
        //    SAE_DB _context = new SAE_DB();

        //    var query = from context in _context.PLEDGE_CLASS
        //                orderby context.PLEDGE_CLASS_NAME ascending
        //                select context.PLEDGE_CLASS_NAME;

        //    Classes = (List<SelectListItem>)query;

        //    return Classes;
        //}
     

    }
}
