using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project_y.Models;
using project_y.ViewModels;

namespace project_y.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                name = "Batman"
            };
            var customer = new List<Customer>
            {
                new Customer{name = "customer 1"},
                new Customer{name = "Customer 2"},
                new Customer{name = "sujan"},
                new Customer{name = "bulbul pandey"}
            };

            var viewmodel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customer
            };
            return View(viewmodel);
        }

        [Route("movie/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year + "/" + month);
        }



    }
}