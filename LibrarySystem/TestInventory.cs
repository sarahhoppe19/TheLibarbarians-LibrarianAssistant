using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class TestInventory
    {
        Inventory testInventory = new();
        // Calls all tests
        //public void RunTests()

        /// <summary>
        /// Tests Create Book
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void TestCreateBook()
        {
            if (!testInventory.CreateBook(123, "ahaha", "advsun\neiaubnvaer", "Maas", "Penguin", "Adventure", 0, 15.00))
                throw new Exception("Create Book Test Failed");
        }

        //Book Search Tests: (Include all edge cases in different functions)  - Sarah


        //User Search tests: (Include all edge cases in different functions) - Grace
        public void TestUserSearch()
        {
            testInventory.CreateUser(012345678, "gracecovarrubias", "ilovecoding", false);
            if (testInventory.UserSearch(012345678).Count != 1)
                throw new Exception("User Search Failed (Nothing was added to TestInventory)");
            if (testInventory.UserSearch(023456789)[1] == 023456789)
                throw new Exception("User Search Failed (Found user it should not have found)");
            if (testInventory.UserSearch(01234567)[1] != 012345678)
                throw new Exception("User Search Failed (Could not find created user)");
        }


        //Extra Tests: (isAdmin, GetBook, GetUser, etc.) - Boaz
    }
}
