using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcApp2.Models.Entities
{
    public class Products
    {
        public virtual int ProductID { get;  set; }
        public virtual string ProductName { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual int UnitsInStock { get; set; }
        public virtual  bool Discontinued { get; set; }
        public virtual Suppliers Supplier { get; set; }
        public virtual Categories Category { get; set; }
    }
}