//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestConnect.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public Products()
        {
            this.OrderDetail = new HashSet<OrderDetail>();
        }
    
        public string ProductID { get; set; }
        public string NamePro { get; set; }
        public string DecriptionPro { get; set; }
        public string IDCate { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string ImagePro { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
