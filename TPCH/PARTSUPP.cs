//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TPCH
{
    using System;
    using System.Collections.Generic;
    
    public partial class PARTSUPP
    {
        public int PS_PARTKEY { get; set; }
        public int PS_SUPPKEY { get; set; }
        public int PS_AVAILQTY { get; set; }
        public decimal PS_SUPPLYCOST { get; set; }
        public string PS_COMMENT { get; set; }
    
        public virtual PART PART { get; set; }
        public virtual SUPPLIER SUPPLIER { get; set; }
    }
}