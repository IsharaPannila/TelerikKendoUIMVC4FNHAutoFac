using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcApp2.Models.Entities;

namespace TelerikMvcApp2.Models.Mappings
{
    public class CategoriesMap : ClassMap<Categories>
    {
        public CategoriesMap()
        {
            Id(x => x.CategoryID);
            Map(x => x.CategoryName);
                
        }
    }
}