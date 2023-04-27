using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public class Inventory
    {
        Dictionary<int, Book> BookDatabase = new Dictionary<int, Book>();
        Dictionary<int, User> UserDatabase = new Dictionary<int, User>();

        // Creates a book from input - returns true if successful
        public bool CreateBook(int isbn, string title, string description, string author,
            string publisher, string genre, int stock, double price)
        {
            if (BookDatabase.ContainsKey(isbn))
                return false;
            BookDatabase.Add(isbn, new Book(
                isbn, title, description, author, publisher, genre, stock, price));
            return true;
        }
        // Gets book by isbn (returns null if not found)
        public Book GetBook(int isbn) 
        {
            if (!BookDatabase.ContainsKey(isbn)) return null;
            return BookDatabase[isbn]; 
        }
        // Returns a file location as a string from save file dialog - Empty string is not found
        public string GetSaveFileLocation()
        {
            SaveFileDialog saveFileDialog2 = new ();
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog2.FileName;
            }
            return String.Empty;
        }
    }
}
