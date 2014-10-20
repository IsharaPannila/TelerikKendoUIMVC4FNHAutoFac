using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcApp2.Mappings;

namespace TelerikMvcApp2.Configaration
{
    public class FluentNHibernateHelper
    {
        public static ISessionFactory BuildSessionFactory()
        {
            return  Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                .ConnectionString(c=>c.FromConnectionStringWithKey("MVCConnetionString")))
                .Mappings(m => m.FluentMappings
                .AddFromAssemblyOf<EmployeesMap>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, false))   
              .BuildSessionFactory();
        }
    }
}