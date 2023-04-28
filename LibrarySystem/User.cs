using System;
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
        public int UID {  get; set; }
        public string  Name { get; set; }
        public string Email { get; set; }
        public bool ExistingUser { get; set; }
        List<Book> CheckedOutBooks { get; set; }
        

        //Default constructor
        public User()
        {
            UID = 0; //this is not valid
            Name = string.Empty; 
            Email = string.Empty;
            CheckedOutBooks = new List<Book>();
        }
        //overloaded constructor
        public User(int uID,  string name, string email, bool existingUser)
        {
            UID = uID;
            Name = name;
            Email = email;
            ExistingUser = existingUser;
        }
    }
}
