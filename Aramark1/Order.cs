//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aramark1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string Pizza { get; set; }
        public double Price { get; set; }
        public System.DateTime Date { get; set; }
        public string Placed { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
