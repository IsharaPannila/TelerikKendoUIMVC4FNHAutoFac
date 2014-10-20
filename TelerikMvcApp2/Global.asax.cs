using Autofac;
using Autofac.Integration.Mvc;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TelerikMvcApp2.Configaration;
using TelerikMvcApp2.Controllers;

namespace TelerikMvcApp2
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Products", action = "Index", id = UrlParameter.Optional }
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            var builder = new ContainerBuilder();
            // Register ISessionFactory as Singleton 
            builder.Register(x => FluentNHibernateHelper.BuildSessionFactory())
                .SingleInstance();
            // Register ISession as instance per web request
            builder.Register(x => x.Resolve<ISessionFactory>().OpenSession())
               .InstancePerHttpRequest();

            // Register c
            builder.RegisterAssemblyTypes(typeof(ProductsController).Assembly)
                .InNamespaceOf<ProductsController>()
                .AsSelf();

            // override default dependency resolver to use Autofac
            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
          
        }
    }
}