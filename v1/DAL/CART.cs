//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace v1.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CART
    {
        public int ID { get; set; }
        public string BILL { get; set; }
        public string PRODUCT { get; set; }
        public string PRODUCT_NAME { get; set; }
        public Nullable<int> QUANTITY { get; set; }
        public Nullable<int> PRICE { get; set; }
    
        public virtual BILL BILL1 { get; set; }
        public virtual PRODUCT PRODUCT1 { get; set; }
    }
}