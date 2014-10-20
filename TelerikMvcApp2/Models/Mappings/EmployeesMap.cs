using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcApp2.Entities;

namespace TelerikMvcApp2.Mappings
{
    public class EmployeesMap : ClassMap<Employees>
    {
        public EmployeesMap()
        {
            Id(x => x.EmployeeID);
            Map(x => x.FirstName);
            Map(x => x.LastName);
        }
    }
}