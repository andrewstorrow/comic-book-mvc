using System;
using System.Web.Mvc;

namespace ComicBookMVC.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            //if(DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            //{
            //    return Redirect("/");
            //}

            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.issueNumber = 700;
            ViewBag.description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

            return View();
        }
    }
}