//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sampleadmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class cart
    {
        public int oid { get; set; }
        public Nullable<int> cid { get; set; }
        public Nullable<int> p_id { get; set; }
        public string oname { get; set; }
        public string oimage { get; set; }
        public Nullable<int> oprice { get; set; }
        public Nullable<int> total { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual product product { get; set; }
    }
}
