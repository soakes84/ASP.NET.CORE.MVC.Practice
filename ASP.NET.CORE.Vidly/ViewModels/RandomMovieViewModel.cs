using System;
using System.Collections.Generic;
using ASP.NET.CORE.Vidly.Models;
namespace ASP.NET.CORE.Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
