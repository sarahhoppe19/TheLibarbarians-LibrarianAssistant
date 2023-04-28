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
        public string  username { get; set; }
        public string password { get; set; }
        //graces user search uses user id as an int
        //also called userID 'uID'
    }
}
