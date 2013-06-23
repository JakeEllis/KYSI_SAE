using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAE_CORE.Models
{
    public class PledgeClassModel : Controller
    {

        public int Class_ID { get; set; }
        public string Class_Name { get; set; }
        public string Semester { get; set; }
        public int Class_Year { get; set; }
        public string Pledge_Ed_Name { get; set; }
        public string Co_Pledge_Name { get; set; }
        public int Pledge_Count { get; set; }
        public int Initiated_Count { get; set; }
        public int Pledge_Drop_Count { get; set; }


    }
}
