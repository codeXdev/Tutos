using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutos.Database;
using Tutos.Models;

namespace Tutos.Controllers
{
    public class MoviesController : Controller
    {
        
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllMovies()
        {
            MovieDatabase _database = new MovieDatabase();

            List<Movie> movies = _database.GetAllMovies();

            return View(movies);
        }

        [Route("Movies/Movie/{name}")]
        public ActionResult Movie(string name)
        {
            MovieDatabase movieDatabase = new MovieDatabase();

            Movie movie = movieDatabase.GetMovieByName(name);
            
            return View(movie);
        }
    }
}