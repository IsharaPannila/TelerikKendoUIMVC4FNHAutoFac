using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcApp2.Entities
{
    public class Employees
    {
        public virtual int EmployeeID { get; protected set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
    }
}