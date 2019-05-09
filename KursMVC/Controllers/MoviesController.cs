using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.VieweModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var cutomers = new List<Customer>() {new Customer {Name="Piotr"},
                new Customer {Name="Monika"},
            };
            var viewModel = new RandomMovieViewModel { Customers = cutomers, Movie = movie };
            return View(viewModel);
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("page insex={0} and sortby={1}", pageIndex, sortBy));
        }
        public ActionResult Edit (int id)
        {
            return Content("id=" + id);
        }
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}