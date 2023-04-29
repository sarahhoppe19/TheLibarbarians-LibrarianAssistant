using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Admin : User
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Admin() : base() { }
        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public Admin(int id, string name, string email, string password) : base(id, name, email, password) { }
    }
}
