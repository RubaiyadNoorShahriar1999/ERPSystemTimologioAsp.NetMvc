//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERPSystemTimologio.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkingHour
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime EntryTime { get; set; }
        public Nullable<System.DateTime> ExitTime { get; set; }
        public int UserId { get; set; }
    
        public virtual User User { get; set; }
    }
}
