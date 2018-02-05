using System;
using ComicBookMVC.Models;

namespace ComicBookMVC.Data
{
    public class ComicBookRepository
    {
        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;

            foreach (var comicBook in Data.ComicBooks)
            {
                if(comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }

            return comicBookToReturn;
        }

        public ComicBook[] GetComicBooks()
        {
            return Data.ComicBooks;
        }
    }
}
