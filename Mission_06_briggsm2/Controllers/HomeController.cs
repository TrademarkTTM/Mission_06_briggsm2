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
        private readonly ILogger<HomeController> _logger;
        private AddMovieContext MovieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, AddMovieContext amc)
        {
            _logger = logger;
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
                return View();
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
