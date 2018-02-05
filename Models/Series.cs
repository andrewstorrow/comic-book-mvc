using System;
namespace ComicBookMVC.Models
{
    public class Series
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionHtml { get; set; }
        public ComicBook[] Issues { get; set; }
    }
}
