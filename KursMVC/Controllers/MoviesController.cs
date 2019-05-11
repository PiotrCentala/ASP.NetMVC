using KursMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.VieweModels;
using System.Data.Entity;
using KursMVC.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(g => g.Genre).ToList();
            return View(movies);
        }
        public ActionResult Details (int id)
        {
            var movie = _context.Movies.Include(g=>g.Genre).SingleOrDefault(m=>m.Id==id);
            return View(movie);
        }
        public ActionResult New()
        {
            var movie = new MovieFormViewModel { Genre = _context.Genre.ToList() , Movie = new Movie {DateAdded = DateTime.Now } };

            return View("MovieForm", movie);
        }
        public ActionResult Edit(int id)
        {
            var movie = new MovieFormViewModel { Genre = _context.Genre.ToList(), Movie = _context.Movies.Single(c=>c.Id ==id) };
            return View("MovieForm", movie);
        }
        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if(movie.Id==0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var movieindb = _context.Movies.Single(c => c.Id == movie.Id);
                movieindb.Name = movie.Name;
                movieindb.Genreid = movie.Genreid;
                movieindb.RealeseDate = movie.RealeseDate;
                movieindb.NumberInStock = movie.NumberInStock;

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}