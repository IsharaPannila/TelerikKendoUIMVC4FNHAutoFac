using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcApp2.Models.Entities;

namespace TelerikMvcApp2.Models.Mappings
{
    public class ProductsMap : ClassMap<Products>
    {
        public ProductsMap()
        {
            Id(x => x.ProductID);
            Map(x => x.ProductName);
            Map(x => x.UnitPrice);
            Map(x => x.UnitsInStock);
            Map(x => x.Discontinued);
            References(x => x.Supplier).Column("SupplierID")
             .Cascade.All();
            References(x => x.Category).Column("CategoryID")
             .Cascade.All(); 
        }

    }
}