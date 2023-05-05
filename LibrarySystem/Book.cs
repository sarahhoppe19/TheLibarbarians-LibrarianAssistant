using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public Image? CoverPhoto { get; set; } // Cover will be null upon creation
        
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Book()
        {
            ISBN = 0;
            Title = string.Empty;
            Description = string.Empty;
            Author = string.Empty;
            Publisher = string.Empty;
            Stock = 0;
            Price = 0;
            Genre = string.Empty;
        }
        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="author"></param>
        /// <param name="publisher"></param>
        /// <param name="genre"></param>
        /// <param name="stock"></param>
        /// <param name="price"></param>
        public Book(int isbn, string title, 
            string description,  string author, string publisher, string genre, int stock, double price)
        {
            ISBN = isbn;
            Title = title;
            Description = description;
            Author = author;
            Publisher = publisher;
            Genre = genre;
            Stock = stock;
            Price = price;

        }
    }
}
