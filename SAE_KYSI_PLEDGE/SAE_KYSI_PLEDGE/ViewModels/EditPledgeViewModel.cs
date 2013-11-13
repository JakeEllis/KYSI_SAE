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
   
    public class EditPledgeViewModel
    {
        private List<DropdownListItem> Pledges { get; set; }
        public string SelectedItemID { get; set; }


        public IEnumerable<SelectListItem> PledgeList
        {
            get
            {
                var items = Pledges.Select(i => new SelectListItem { Value = i.Value, Text = i.Text });
                return items;

            }

        }

        public EditPledgeViewModel(List<DropdownListItem> items, string selected)
        {
            Pledges = items;
            SelectedItemID = selected;

        }


        public IEnumerable<SelectListItem> DefaultItem
        {
            get
            {
                return Enumerable.Repeat(new SelectListItem
                    {
                        Value = "1",
                        Text = "Select Pledge Class"
                    }, count: 1);
            }
        }
  


    }
}