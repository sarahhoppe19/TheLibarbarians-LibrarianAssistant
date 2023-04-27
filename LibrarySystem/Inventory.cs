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

        //Search for User
        public List<int> UserSearch(int id)
        {
            List<int> foundUsers = new();  //store search results in a list of ints
            string sId = id.ToString(); //convert target ID to string
            string tempId;
            foreach (User u in UserDatabase.Values)
            {
                tempId = u.uID.ToString(); 
                if (tempId.Contains(sId))
                    foundUsers.Add(u.uID);
            }
            foundUsers.Sort(); // Sort for easy ID access
            return foundUsers;
        }

    }
}
