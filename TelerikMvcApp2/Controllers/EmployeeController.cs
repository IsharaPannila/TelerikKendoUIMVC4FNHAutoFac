using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelerikMvcApp2.Configaration;
using TelerikMvcApp2.Entities;

namespace TelerikMvcApp2.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
         private ISession session;

         public EmployeeController(ISession session)
      {
          this.session = session;
      }

        public ActionResult Index()
        {
            
                var employees = this.session.Query<Employees>().ToList();                
                return this.Json(employees.Select (e => new { Eid= e.EmployeeID ,Name = e.FirstName +" "+ e.LastName })                    
                    , JsonRequestBehavior.AllowGet);
                   
        }

    }
}
