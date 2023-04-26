using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Inventory
    {
        Dictionary<int, Book> BookDatabase = new Dictionary<int, Book>();

        // Creates a book from input - returns true if successful
        public bool CreateBook(int isbn, string name, string description, string author,
            string publisher, string genre, int stock, double price)
        {
            if (BookDatabase.ContainsKey(isbn))
                return false;
            BookDatabase.Add(isbn, new Book(
                isbn, name, description, author, publisher, genre, stock, price));
            return true;
        }
        public Book GetBook(int isbn) {  return BookDatabase[isbn]; }
    }
}
