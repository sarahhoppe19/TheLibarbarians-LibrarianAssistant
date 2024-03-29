﻿using System;
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

        /// <summary>
        /// Creates a book from input
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="author"></param>
        /// <param name="publisher"></param>
        /// <param name="genre"></param>
        /// <param name="stock"></param>
        /// <param name="price"></param>
        /// <returns>bool for success</returns>
        public bool CreateBook(int isbn, string title, string description, string author,
            string publisher, string genre, int stock, double price)
        {
            if (BookDatabase.ContainsKey(isbn))
                return false;
            BookDatabase.Add(isbn, new Book(
                isbn, title, description, author, publisher, genre, stock, price));
            return true;
        }
        public bool EditBook(int isbn, string title, string description, string author,
            string publisher, string genre, int stock, double price)
        {
            if (!BookDatabase.ContainsKey(isbn))
                return false;
            BookDatabase[isbn].ISBN = isbn;
            BookDatabase[isbn].Title = title;
            BookDatabase[isbn].Description = description;
            BookDatabase[isbn].Author = author;
            BookDatabase[isbn].Publisher = publisher;
            BookDatabase[isbn].Genre = genre;
            BookDatabase[isbn].Stock = stock;
            BookDatabase[isbn].Price = price;
            return true;
        }
        /// <summary>
        /// Gets book by isbn (returns null if not found)
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        public Book GetBook(int isbn) 
        {
            if (!BookDatabase.ContainsKey(isbn)) return null;
            return BookDatabase[isbn]; 
        }
        public void ChangeStock(int isbn, int stock)
        {
            if (BookDatabase.ContainsKey(isbn)) BookDatabase[isbn].Stock += stock;
        }
        /// <summary>
        /// Returns a file location as a string from save file dialog - Empty string is not found
        /// </summary>
        /// <returns></returns>
        public string GetSaveFileLocation()
        {
            SaveFileDialog saveFileDialog2 = new ();
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog2.FileName;
            }
            return String.Empty;
        }
        /// <summary>
        /// Search for User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Search for Book(s) via the ISBN
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns list of all users, sorted by ID
        /// </summary>
        /// <returns></returns>
        public List<int> GetUserList()
        {
            List<int> foundUsers = new();  // Store search results in a list of ints
            foreach (User u in UserDatabase.Values)
            {
                foundUsers.Add(u.ID);
            }
            foundUsers.Sort(); // Sort for easy ID access
            return foundUsers;
        }
        /// <summary>
        /// Search for Book(s) via keyword
        /// </summary>
        /// <param name="keyPhrase"></param>
        /// <returns></returns>
        public List<int> BookSearch(string keyPhrase)
        {
            List<int> foundBookTitle = new();    // Stores the search results via titles into a list of strings
            keyPhrase = keyPhrase.ToLower();
            foreach (Book b in BookDatabase.Values)
            {
                if (b.Title.ToLower().Contains(keyPhrase) || b.Publisher.ToLower().Contains(keyPhrase) ||
                    b.Author.ToLower().Contains(keyPhrase) || b.Description.ToLower().Contains(keyPhrase) || b.Genre.ToLower().Contains(keyPhrase))
                {
                    foundBookTitle.Add(b.ISBN);
                }
            }
            return foundBookTitle;
        }
        /// <summary>
        /// Checks for admin priviledge
        /// </summary>
        /// <param name="id"></param>
        /// <returns>bool for admin</returns>
        public bool isAdmin(int id)
        {
            if (UserDatabase.ContainsKey(id) && UserDatabase[id].Admin) return true;
            return false;
        }
        /// <summary>
        /// Checks for matching user and password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidateUser(string username, string password)
        {
            foreach(User u in UserDatabase.Values)
            {
                if (u.Name == username)
                {
                    if (u.Password == password)
                    {
                        return true;
                    }
                    else { return false; }
                }
            }
            return false;
        }

        public User GetUser(int id)
        {
            foreach (User u in UserDatabase.Values)
            {
                if (u.ID == id)
                {
                    return u;
                }
            }
            return null;
        }
        public int GetUserID(string username, string password)
        {
            int id = -1;
            foreach (User user in UserDatabase.Values)
            {
                if (user.Name == username && user.Password == password) id = user.ID;
            }
            return id;
        }
        public bool CreateUser(int id, string username, string password, bool Admin)
        {
            if (UserDatabase.ContainsKey(id))
                return false;
            foreach (User u in UserDatabase.Values)
            {
                if (u.Name == username) return false;
            }
            UserDatabase.Add(id, new User(id, username, password, Admin));
            if (UserDatabase.ContainsKey(id))
                return true;
            return false;
        }

        public List<int> GetCheckedOutBooks(int id)
        {
            return UserDatabase[id].CheckedOutBooks;
        }
    }
}