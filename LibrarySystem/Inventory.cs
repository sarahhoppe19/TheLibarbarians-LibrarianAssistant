using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        //Search for User
        public List<int> UserSearch(int id)
        {
            List<int> foundUsers = new();  // Store search results in a list of ints
            string sId = id.ToString(); // Convert target ID to string
            string tempId;
            foreach (User u in UserDatabase.Values)
            {
                tempId = u.ID.ToString();
                if (tempId.Contains(sId))
                    foundUsers.Add(u.ID);
            }
            foundUsers.Sort(); // Sort for easy ID access
            return foundUsers;
        }

        // Search for Book(s) via the ISBN
        public List<int> BookSearch(int isbn)
        {
            List<int> foundBookIsbn = new();    // Stores all the search results into a list of ints for the isbn numbers
            string isbnString = isbn.ToString();     // Converts the target ID to a string
            foreach (Book b in BookDatabase.Values)
            {
                if (b.ISBN.ToString().Contains(isbnString))
                {
                    foundBookIsbn.Add(b.ISBN);
                }
            }
            foundBookIsbn.Sort();   // Sorts the results for easy ID access
            return foundBookIsbn;
        }

        // Search for Book(s) via keyword
        public List<int> BookSearch(string keyPhrase)
        {
            List<int> foundBookTitle = new();    // Stores the search results via titles into a list of strings

            foreach (Book b in BookDatabase.Values)
            {
                if (b.Title.Contains(keyPhrase) || b.Publisher.Contains(keyPhrase) ||
                    b.Author.Contains(keyPhrase) || b.Description.Contains(keyPhrase) || b.Genre.Contains(keyPhrase))
                {
                    foundBookTitle.Add(b.ISBN);
                }
            }
            return foundBookTitle;
        }
    }
}
