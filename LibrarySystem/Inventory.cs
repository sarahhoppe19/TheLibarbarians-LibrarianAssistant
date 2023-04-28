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

        //Search for Book(s) via the ISBN
        public List<int> BookIsbnSearch(int isbn)
        {
            List<int> foundBookIsbn = new();    //stores all the search results into a list of ints for the isbn numbers
            string isId = isbn.ToString();     //the "is" before the Id stands for ISBN Search just we have different labels for everything
                                             //this line ^ also converts the target ID to a string
            string tempId;
            foreach (Book b in BookDatabase.Values)
            {
                tempId = b.Id.ToString();
                if (tempId.Contains(isId) || tempId.Contains(b.Description) || tempId.Contains(b.Author) || tempId.Contains(b.Genre) || tempId.Contains(b.Publisher) || tempId.Contains(b.ISBN))
                {
                    foundBookIsbn.Add(b.Id);
                }
                foundBookIsbn.Sort();   //Sorts the results for easy ID access
                return foundBookIsbn;
            }
        }

        //Search for Book(s) via the title
        public List<int> BookTitleSearch(string title)
        {
            List<string> foundBookTitle = new();    //stores the search results via titles into a list of strings
            string tsId = title.ToString();         //not sure if needed as our list will contain strings, so there's no need to convert string to string
            string tempId;

            foreach (Book b in BookDatabase.Values)
            {
                tempId = b.Id.ToString();
                if (tempId.Contains(tsId) || tempId.Contains(b.Description) || tempId.Contains(b.Author) || tempId.Contains(b.Genre) || tempId.Contains(b.Publisher) || tempId.Contains(b.ISBN))
                {
                    foundBookTitle.Add(b.Id);
                }
                foundBookTitle.Sort();      //Sorts the results for easy ID access
                return foundBookTitle;
            }
        }
    }
}
