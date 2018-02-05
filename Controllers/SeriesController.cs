using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookMVC.Models;
using ComicBookMVC.Data;

namespace ComicBookMVC.Controllers
{
    public class SeriesController : Controller
    {
        private SeriesRepository _seriesRepository = null;

        public SeriesController()
        {
            _seriesRepository = new SeriesRepository();
        }

        // GET: Series
        public ActionResult Index()
        {
            var series = _seriesRepository.GetSeries();

            return View(series);
        }
    }
}
