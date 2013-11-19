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
        public int SelectedIndex { get; set; }

    }


    public class EditClassViewModel
    {

        private List<DropdownListItem> Classes { get; set; }
        public string SelectedItemID { get; set; }


        public IEnumerable<SelectListItem> ClassList
        {
            get
            {
                var items = Classes.Select(i => new SelectListItem { Value = i.Value, Text = i.Text });
                return items;

            }

        }

        public EditClassViewModel(List<DropdownListItem> items, string selected)
        {

            Classes = items;
            SelectedItemID = Classes.ToList().FindIndex(selected);

        }

        public EditClassViewModel()
        {

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
