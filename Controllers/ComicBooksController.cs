﻿using System;
using System.Web.Mvc;

namespace ComicBookMVC.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
            }

            //return Content("Hello from the comic books controller");

            return View();
        }
    }
}