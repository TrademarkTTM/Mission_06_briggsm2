using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission_06_briggsm2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_06_briggsm2.Controllers
{
    public class HomeController : Controller
    {
        private AddMovieContext MovieContext { get; set; }

        public HomeController(AddMovieContext amc)
        {
            MovieContext = amc;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = MovieContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(AddMovieResponce amr)
        {
            if (ModelState.IsValid)
            {
            MovieContext.Add(amr);
            MovieContext.SaveChanges();

            return View("Index");
            }
            else
            {
                ViewBag.Categories = MovieContext.Categories.ToList();

                return View();
            }

        }

        public IActionResult MovieList()
        {
            var Movies = MovieContext.Movies
                .Include(x => x.Category)
                .ToList();

            return View(Movies);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = MovieContext.Categories.ToList();

            var movie = MovieContext.Movies.Single(x => x.MovieId == movieid);

            return View("AddMovie", movie);
        }

        [HttpPost]
        public IActionResult Edit(AddMovieResponce amr)
        {
            MovieContext.Update(amr);
            MovieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete (int movieid)
        {
            var movie = MovieContext.Movies.Single(x => x.MovieId == movieid);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete (AddMovieResponce amr)
        {
            MovieContext.Movies.Remove(amr);
            MovieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
