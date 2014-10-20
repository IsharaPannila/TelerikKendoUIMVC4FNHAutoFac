using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelerikMvcApp2.Configaration;
using TelerikMvcApp2.Models.Entities;

namespace TelerikMvcApp2.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

       private ISession session;

       public ProductsController(ISession session)
      {
          this.session = session;
      }
 

        public ActionResult Index()
        {
            
                var products = this.session.Query<Products>().Select(p => new Products
                {

                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock,
                    Discontinued = p.Discontinued,
                    Supplier = new Suppliers
                    {
                        SupplierID = p.Supplier.SupplierID,
                        CompanyName = p.Supplier.CompanyName
                    },

                    Category = new Categories {
                     CategoryID = p.Category .CategoryID,
                     CategoryName =p.Category .CategoryName 
                    }

                });

                return View(products);   
            }   
       

    }
}
