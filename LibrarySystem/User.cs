using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class User
    {
        public int ID {  get; set; }
        public string  Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<int> CheckedOutBooks = new();
        

        /// <summary>
        /// Default constructor
        /// </summary>
        public User()
        {
            ID = 0; // this is not valid
            Name = string.Empty; 
            Email = string.Empty;
            Password = string.Empty;
        }
        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public User(int id,  string name, string email, string password)
        {
            ID = id;
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
