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
    
    public partial class ORDER
    {
        public int O_ORDERKEY { get; set; }
        public int O_CUSTKEY { get; set; }
        public string O_ORDERSTATUS { get; set; }
        public decimal O_TOTALPRICE { get; set; }
        public System.DateTime O_ORDERDATE { get; set; }
        public string O_ORDERPRIORITY { get; set; }
        public string O_CLERK { get; set; }
        public int O_SHIPPRIORITY { get; set; }
        public string O_COMMENT { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
    }
}