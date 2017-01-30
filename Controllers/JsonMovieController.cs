using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_MVC.Models;

namespace Test_MVC.Controllers
{
    public class JsonMovieController : Controller
    {
        //
        // GET: /JsonMovie/

        public JsonResult Index()
        {
            MovieContext movieContext = new MovieContext();
            List<Movie> movies = movieContext.Movies.ToList();

            return Json(movies, JsonRequestBehavior.AllowGet);
        }

    }
}
