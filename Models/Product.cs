//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LTWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int CategoryID { get; set; }
        public int ProductID { get; set; }
        public string Img { get; set; }
        public string ProductName { get; set; }
        public Nullable<double> Price { get; set; }
    }
}
