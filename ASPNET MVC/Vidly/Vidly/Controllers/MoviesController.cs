using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        //url structure is {controllerName}/{function} (if no function specified Index() called by default)
        //see App_Start routeConfig.cs
        public ActionResult Random()
        {
            var movie = new Movie { name = "Shrek" };

            return View(movie);

            //please note: View is a helper method which basically returns a ViewResult object
            //The ViewResult Object is part of the Controller class
            //can also do:
            //return new ViewResult(movie);

            //but it is better practice to use View helper method
            //Here are some other action results and their helper methods:


            //ACTION RESULT OBJECTS         HELPER METHODS
            /////////////////////////////////////////////////////////////////////////
            //PartialViewResult             PartialView()
            //ContentResult                 Content()
            //RedirectResult                Redirect()
            //RedirectToRoutResult          RedirectToAction()
            //JsonResult                    Json()
            //FileResult                    File()
            //HttpNotFoundResult            HttpNotFound()
            //EmptyResult (when we don't need toreturn anything - like void)
            //
            //
            //PLEASE NOTE THESE ARE ALL SUBTYPES OF ActionResult which is what this method returns
            //
            //

            //e.g(s):
            //return Content("Hello, World!"); this is simply returns the string with no html (since we are not using View())
            //return HttpNotFound() - returns standard 404 page

            //NOTE EmptyResut has no helper so do:
            //return new EmptyResult()

            //return RedirectToAction("Index", "home", {page=1, sortBy=name}) - returns home with third parameter query string objects 

        }

        //PARAMETER SOURCES EXAMPLE
        //parameters can come from url, query string (GET), or form data
        //ALL GET AUTOMATICALLY MAPPED IF THEY HAVE SAME NAME

        //if we change to movieId - no automatic mapping because if you go App_Start/routConfig.cs you see:
        //url: "{controller}/{action}/{id}",
        //default name of parameter is {id} in DEFAULT ROUTE
        //if we change to movieId here no more auto mapping

        public ActionResult edit(int id)
        {
            return Content("id = " + id);
        }

        //OPTIONAL PARAMETERS

        //this action is called when we navigato to: /Movies
        public ActionResult Index(int? pageIndex, String sortBy)
        {
            //? makes int nullable
            //String nullable by default

            if(!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";


            return Content(String.Format("PageIndex={0}, sortBy={1}", pageIndex, sortBy));

            //NOTE: we cannot embed these parameters in url because that will require custom route
        } 


        //CUSTOM ROUTE EXAMPLE
        //Add in routeConfig.cs
        public ActionResult ByReleaseDate(int year, int month)
        {

            
            return Content(year + "/" + month);

            
        }

        //ATRIBUTE ROUTING EXAMPLE (USING DIFF NAME TO KEEP OLD EXAMPLE)
        //doube backslash because this is not a verbatim sring with @
        //month is another contraint (not regex)
        //others include : minLength, maxLEangth, min, max, int, float, guid
        [Route("movies/released/{year:regex(\\d{4}):range(1990, 2018)}/{month:regex(\\d{2}):range(1,12)}")] 
        public ActionResult ByReleaseDateAttr(int year, int month)
        {


            return Content(year + "/" + month);


        }

        //other ways to pass data to views:

        //1) using view data dictionary
        //problems: must specify "movie" string here and in view (see datapassing1.cshtml)
        //also complicated syntax
        //this is old way

        public ActionResult datapassing1()
        {

            //every controller has a property called ViewData of Type ViewDataDictionary
            var movie = new Movie() { name = "shrek" };
            ViewData["movie"] = movie;

            return View();
        }


        //1) using viewbag with magic property
        //this is the new way - although no improvement

        public ActionResult datapassing2()
        {

            //same problem, must change here and in view
            var movie = new Movie() { name = "shrek" };
            ViewBag.movie = movie;

            return View();
        }

        //3) best way:
        //View Models

        //in Random View above we simple pass movie. What if we want to pass customers as well:
        //there may not be a relationship therefore we must pass 2 different models
        //must create a ViewModels folder
        public ActionResult ViewModelExample()
        {

            var movie = new Movie { name = "Shrek 2" };

            //view will use razor templating syntax to render customers list
            var customers = new List<Customer>
            {
                new Customer { name = "customer 1"},
                new Customer { name = "customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                movie = movie,
                customers = customers
            };


            return View(viewModel);

        }

        //EXERCICE:
        //SLN AT https://github.com/mosh-hamedani/vidly-mvc-5


        public ActionResult Customers()
        {
            var customersList = new List<Customer>
            {
                new Customer{ name = "Ali"},
                new Customer{ name = "Hassan"}
            };

            var customersViewModel = new CustomersViewModel
            {
                customers = customersList
            };

            return View(customersViewModel);
        }

        public ActionResult Movies()
        {
            var moviesList = new List<Movie>
            {
                new Movie{ name = "Superman"},
                new Movie{ name = "Spiderman"}
            };

            var moviesViewModel = new MoviesViewModel
            {
                movies = moviesList
            };

            return View(moviesViewModel);
        }




    }
}