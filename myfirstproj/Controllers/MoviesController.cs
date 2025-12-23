using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myfirstproj.Models;

namespace myfirstproj.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            Movie movie = new Movie()
            { 
                Name = "shrek"
            };
            return View(movie);
            //return Content("hello world");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("index", "home", new {page="yournaem",sortBy="hellowrold"});
        }

        public ActionResult Edit(int id)
        {
            return Content("id is " + id);
        }

        public ActionResult Index(int? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrWhiteSpace(sortBy)) ;
            {
                sortBy = "Name"; 
            }
            return Content(string.Format("pageindex={0} and  sortby={1}", pageIndex, sortBy));
            
        }


        public ActionResult fetch(string name, int? age)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return Content("enter name");
            }

            else if (!age.HasValue)
            {
                return Content("enter a age");
            }

            else if (age > 17)
            {
                return Content(string.Format("hello {0} you are eligible to vote", name));
            }
            else
            {
                return Content(string.Format("hello {0} you are not eligible to vote", name));
            }
        }
    }
}   