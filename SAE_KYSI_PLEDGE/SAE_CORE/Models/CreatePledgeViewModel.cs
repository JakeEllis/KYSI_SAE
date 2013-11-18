using SAE_CORE;
using SAE_CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SAE_KYSI_PLEDGE.ViewModels
{
    public class CreatePledgeViewModel : Controller
    {    
        public SelectList Pledge_Class_Name { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street_Address { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int GradYear { get; set; }
        public int PledgeID { get; set; }
        public string BigBro_First { get; set; }
        public string BigBro_Last { get; set; }
        public int Pledge_Class_ID { get; set; }

        public CreatePledgeViewModel()
        {
            
        }

     
    }
}
