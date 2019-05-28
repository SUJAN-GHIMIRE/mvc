using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using project_y.Models;

namespace project_y.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}