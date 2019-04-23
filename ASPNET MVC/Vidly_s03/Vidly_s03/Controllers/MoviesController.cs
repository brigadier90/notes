using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Vidly_s03.Models;
using Vidly_s03.ViewModels;


namespace Vidly_s03.Controllers
{

    

    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }


        // GET: Movies
        public ActionResult Index()
        {

            var movies = _context.movies.Include(m => m.Genre).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);


        }

        public ActionResult Create()
        {
            var movieFormViewModel = new MoviesFormViewModel
            {
                Movie = new Movie(),
                Genres = _context.genres.ToList()
            };



            return View("MoviesForm", movieFormViewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.movies.SingleOrDefault(m => m.Id == id);

            var movieFormViewModel = new MoviesFormViewModel
            {
                Genres = _context.genres.ToList(),
                Movie = movie
            };

            return View("MoviesForm", movieFormViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid) //similar to if form.is_Valid on django
            {

                var movieFormViewModel = new MoviesFormViewModel
                {
                    Movie = movie,
                    Genres = _context.genres.ToList()
                
                };

                return View("MoviesForm", movieFormViewModel);
            }

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.movies.Add(movie);

            }
            else
            {
                var movieInDb = _context.movies.SingleOrDefault(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NumberInStock = movie.NumberInStock;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        //we also need to properly dispose of the dbcontext
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}