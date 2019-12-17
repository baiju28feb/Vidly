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
        public ActionResult Movies()
        {
            var Movie = new List<Movie>
            {
                new Movie {Id = 1 , Name = "Shreak !",Genere = "Animated", year = "2011"},
                new Movie { Id = 2, Name = "Wall-E", Genere = "Animated", year = "2017"},
                new Movie {Id =3, Name = "Spider_man", Genere = "Super-Hero", year= "2019"}
            };

            var viewmodelMovies = new RandomMovieViewModel
            {
                movie = Movie

            };
            return View(viewmodelMovies);
        }

           
    }



}   

    




    
