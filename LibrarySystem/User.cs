﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class User
    {
        //graces user search uses user id as an int
        //also called userID 'uID'
        public int ID {  get; set; }
        public string  Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        List<int> CheckedOutBooks = new();
        

        // Default constructor
        public User()
        {
            ID = 0; // this is not valid
            Name = string.Empty; 
            Email = string.Empty;
            Password = string.Empty;
        }
        //overloaded constructor
        public User(int id,  string name, string email, string password)
        {
            ID = id;
            Name = name;
            Email = email;
            Password = password;
        }
    }
}