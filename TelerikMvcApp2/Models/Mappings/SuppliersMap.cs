using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcApp2.Models.Entities;

namespace TelerikMvcApp2.Models.Mappings
{
    public class SuppliersMap : ClassMap<Suppliers>
    {
        public SuppliersMap()
        {
            Id(x => x.SupplierID);
            Map(x => x.CompanyName);
        }
    }
}