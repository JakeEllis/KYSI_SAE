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
    
    public partial class POINT
    {
        public POINT()
        {
            this.PLEDGEs = new HashSet<PLEDGE>();
        }
    
        public int POINT_ID { get; set; }
        public string ATTENDANCE_PTS { get; set; }
        public string EXAM_1 { get; set; }
        public string EXAM_2 { get; set; }
        public string EXAM_3 { get; set; }
        public string EXAM_4 { get; set; }
        public string EXAM_5 { get; set; }
        public string EXAM_6 { get; set; }
        public string EXAM_7 { get; set; }
        public string EXAM_8 { get; set; }
        public string PHIL_HOURS { get; set; }
        public string INTRAMURALS { get; set; }
        public string OLYMPICS { get; set; }
        public int POINT_VAL_ID { get; set; }
    
        public virtual POINT_VALUES POINT_VALUES { get; set; }
        public virtual ICollection<PLEDGE> PLEDGEs { get; set; }
    }
}
