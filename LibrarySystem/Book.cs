﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        Image? Cover { get; set; } // Cover will be null upon creation
        
        // Default Constructor
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
        // Overloaded Constructor
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