using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public int NumberOfPages { get; set; }

        public Book(string author, string title, string year, int numberOfPages)
        {
            this.Author = author;
            this.Title = title;
            this.Year = year;
            this.NumberOfPages = numberOfPages;
        }

    }
}
