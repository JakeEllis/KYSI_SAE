using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
     

    }
}
