using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HardikVidly.Models;

namespace HardikVidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {

            var movie = new Movie(){Name ="Die Hard"};
            return View(movie);


            //types of method you can pass in action result as per data

            // return Content("Hardik");
            //return HttpNotFound("result not found hardik");
           // return new EmptyResult();
            //return RedirectToAction("Index", "Home", "parameter 1 as parameter");
            //return Json("hardik");
    
        }
        //passing value in url mvc famework atumatically mapped to edit action method
        // GET: Movies/Edit
        public ActionResult Edit(int Id)
        {
            return Content("id = "+Id);

        }


        //intializing default value of action paramater 
        //if there is no value  provide as parameter in pageINdex or SortBy
        //Movie
        public ActionResult Index(int ? pageIndex , string sortBy)
        {

            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";

            }

            return Content(string.Format("pageIndex= {0} & sortBy= {1}", pageIndex, sortBy));

        }
        //using route attirubutes.
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year +" , "+ month);
        }


    }
}