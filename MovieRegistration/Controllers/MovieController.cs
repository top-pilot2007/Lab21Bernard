using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRegistration.Models;

namespace MovieRegistration.Controllers
{
    public class MovieController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult RegisteredMovie(MovieModel movieModel)
        {
            var registeredMovieModel = new RegisteredMovieModel { Title=movieModel.Title};

            return View(registeredMovieModel);
        }
    }
}