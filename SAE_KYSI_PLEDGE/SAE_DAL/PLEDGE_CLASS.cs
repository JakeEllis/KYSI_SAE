//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAE_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PLEDGE_CLASS
    {
        public PLEDGE_CLASS()
        {
            this.FACTs = new HashSet<FACT>();
        }
    
        public int PLEDGE_CLASS_ID { get; set; }
        public string PLEDGE_CLASS_NAME { get; set; }
        public string PLEDGE_CLASS_SEM { get; set; }
        public string PLEDGE_CLASS_YEAR { get; set; }
        public string PLEDGE_COUNT { get; set; }
        public string INITIATED_COUNT { get; set; }
        public string PLEDGE_DROP_COUNT { get; set; }
        public string PLEDGE_ED_FIRST_NAME { get; set; }
        public string CO_PLEDGE_ED_FIRST_NAME { get; set; }
        public string PLEDGE_ED_LAST_NAME { get; set; }
        public string CO_PLEDGE_ED_LAST_NAME { get; set; }
    
        public virtual ICollection<FACT> FACTs { get; set; }
    }
}
