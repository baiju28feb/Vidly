using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var Customer = new List<Customer>
            {
                new Customer {Name = "Customer 1",ID = 1},
                new Customer {Name = "Customer 2", ID = 2}

            };

            var viewmodelCustomert = new RandomMovieViewModel
            {
                customer = Customer
            };

            return View(viewmodelCustomert);

        }
    }
}