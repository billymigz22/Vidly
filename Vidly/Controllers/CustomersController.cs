using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int Id)
        {
            var Name = "";
            if(Id == 1)
            {
                Name = "John Smith";
            }else if(Id == 2)
            {
                Name = "Mary Williams";
            }
            
            var customers = new List<Customer>
            {
                new Customer { Name = Name }
            };

            var viewModel = new ViewModels.RandomMovieViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }
    }
}