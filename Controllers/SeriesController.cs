﻿using System;
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

        // GET: Series/Detail/1
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var series = _seriesRepository.GetSeriesDetail((int)id);

            return View(series);
        }
    }


}
