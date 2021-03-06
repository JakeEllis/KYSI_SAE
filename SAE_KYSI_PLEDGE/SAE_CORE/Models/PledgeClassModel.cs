﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAE_DAL;

namespace SAE_CORE.Models
{
    public class PledgeClassModel : Controller
    { 
        public int Pledge_Class_ID { get; set; }
        public string Pledge_Class_Name { get; set; }
        public string Pledge_Class_Semester { get; set; }
        public DateTime Pledge_Class_Year { get; set; }
        public int Pledge_Count { get; set; }
        public string Pledge_Educator_Last_Name { get; set; }
        public string Pledge_Educator_First_Name { get; set; }
        public string Co_Pledge_Educator_First_Name { get; set; }
        public string Co_Pledge_Educator_Last_Name { get; set; }
        public int Pledge_Initiated_Count { get; set; }
        public int Pledge_Drop_Count { get; set; }

      
     

    }
}
