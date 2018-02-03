using System;
using System.Web.Mvc;
using ComicBookMVC.Models;
using ComicBookMVC.Data;

namespace ComicBookMVC.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRepository.GetComicBook(id.Value);

            return View(comicBook);
        }
    }
}