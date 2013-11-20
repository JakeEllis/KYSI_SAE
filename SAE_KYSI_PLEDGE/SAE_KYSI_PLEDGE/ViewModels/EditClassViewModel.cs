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
    //public class DropdownListItem<TData> 
    //{
    //    public string Text { get; set; }
    //    public TData Value { get; set; }
    //    //public int SelectedIndex { get; set; }

    //}


    public class EditClassViewModel
    {
        public EditClassViewModel()
        {
            Classes = new List<DropDownListItem<int>>();
        }

        public List<DropDownListItem<int>> Classes { get; set; }
        public int SelectedItemID { get; set; }


        //public IEnumerable<SelectListItem> ClassList
        //{
        //    get
        //    {
        //        var items = Classes.Select(i => new SelectListItem { Value = i.Value, Text = i.Text });
        //        return items;

        //    }

        //}

        //public EditClassViewModel(List<DropdownListItem<int>> items, string selected)
        //{

        //    Classes = items;
        //    SelectedItemID = Classes.ToList().FindIndex(selected);

        //}




        //public IEnumerable<SelectListItem> DefaultItem
        //{
        //    get
        //    {
        //        return Enumerable.Repeat(new SelectListItem
        //            {
        //                Value = "-1",
        //                Text = "Select Pledge Class"
        //            }, count: 1);
        //    }
        //}
    }
}
