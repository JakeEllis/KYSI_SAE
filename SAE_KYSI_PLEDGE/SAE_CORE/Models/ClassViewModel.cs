using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAE_CORE;
using SAE_DAL;



namespace SAE_CORE.Models
{
 
    public class ClassViewModel
    {
        public ClassViewModel()
        {
            Classes = new List<DropDownListItem<int>>();
        }

        public List<DropDownListItem<int>> Classes { get; set; }
        public int SelectedItemID { get; set; }

    }
}
