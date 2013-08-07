using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAE_CORE;
using SAE_DAL;
using SAE_KYSI_PLEDGE;



namespace SAE_KYSI_PLEDGE.ViewModels
{
    public class DropdownListItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

    }


    public class EditClassViewModel
    {
        private List<DropdownListItem> queryable;

        
        private List<DropdownListItem> Classes { get; set; }
        public string SelectedItemID { get; set; }


        public IEnumerable<SelectListItem> ClassList
        {
            get
            {
                var items = ClassList.Select(i => new SelectListItem { Value = i.Value, Text = i.Text});
                return DefaultItem.Concat(items);

            }
            
        }

        public EditClassViewModel()
        {

        }

        public EditClassViewModel(List<DropdownListItem> items, string selected)
        {
            Classes = items;
            SelectedItemID = selected;

            
        }

        
        public IEnumerable<SelectListItem> DefaultItem 
        {
            get
            {
                return Enumerable.Repeat(new SelectListItem
                    {
                        Value = "-1",
                        Text = "Select Pledge Class"
                    }, count: 1);
            }
        }
  


      
    }
}
