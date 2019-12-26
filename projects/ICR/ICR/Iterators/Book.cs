using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterators
{
    public class Book
    {
        private string title;
        private int year;
        private List<string> authors;

        public Book(string title, int year,params string[] authors) 
        {
            this.Title = title;
            this.Year = year;
            this.authors = new List<string>(authors);
        }

        public string Title
        {
            get => title;
            set => title = value;
        }
        public int Year
        {
            get => year;
            set => year = value;
        }
    }
}
