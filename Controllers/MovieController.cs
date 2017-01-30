using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_MVC.Models;

namespace Test_MVC.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/

        public ActionResult Index()
        {
            MovieContext movieContext = new MovieContext();
            List<Movie> movies = movieContext.Movies.ToList();

            Session["Movies"] = movies;

            return View(movies);
        }

        //
        // GET: /Movie/Details/5

        public ActionResult Details(int id)
        {
            List<Movie> movies = (List<Movie>)Session["Movies"];

            foreach (Movie tmp in movies)
            {
                System.Diagnostics.Debug.WriteLine(tmp.Title);               
            }

            MovieContext movieContext = new MovieContext();
            Movie movie = movieContext.Movies.ToList().Find(x => x.Id == id);

            return View(movie);
        }

        //
        // GET: /Movie/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Movie/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                MovieContext movieContext = new MovieContext();
                
                movieContext.Movies.Add(
                    new Movie() {
                        Title = collection["Title"],
                        ReleaseYear = int.Parse(collection["ReleaseYear"]),
                        Runtime = int.Parse(collection["Runtime"])                
                    }
                );
                
                movieContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Movie/Edit/5
 
        public ActionResult Edit(int id)
        {
            MovieContext movieContext = new MovieContext();
            Movie movie = movieContext.Movies.ToList().Find(x => x.Id == id);

            return View(movie);
        }

        //
        // POST: /Movie/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Movie/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Movie/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
