using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAE_CORE
{
    /// <summary>
    /// Class to be used when creating items for a drop down list.
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public class DropDownListItem<TData>
    {
        public string Text { get; set; }
        public TData Value { get; set; }
    }
}