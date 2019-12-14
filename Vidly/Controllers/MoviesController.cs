using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var Movie = new List<Movie>
            {
                new Movie {Id = 1 , Name = "Shreak !"},
                new Movie { Id = 2, Name = "Wall-E"}
            };
            var Customer = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}

            };

            var viewmodel = new RandomMovieViewModel
            {
                movie = Movie,
                customer = Customer

            };
        


            return View(viewmodel);
        }

        public ActionResult Edit(int Id)
        {
            return Content("Id = " + Id);
        }

        public ActionResult Index(int ? pageIndex, string SortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(SortBy))
            {
                SortBy = "release Day";

            }

            return Content(string.Format("pageIndex = {0} & SortBy = {1}", pageIndex,SortBy));
        }   

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2})}")]
        public ActionResult released(int year, int month)
        {        
                  return Content(year +"/"+ month);
        }




    }
}