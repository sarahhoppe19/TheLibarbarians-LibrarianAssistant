﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Inventory
    {
        Dictionary<int, Book> Database = new Dictionary<int, Book>();
        // Creates a book from input - returns true if successful
        public bool CreateBook(int isbn, string name, string description, string author,
            string publisher, string genre, int stock, double price)
        {
            if (Database.ContainsKey(isbn))
                return false;
            Database.Add(isbn, new Book(
                isbn, name, description, author, publisher, genre, stock, price));
            return true;
        }
    }
}