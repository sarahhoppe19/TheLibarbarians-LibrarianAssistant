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


        //Extra Tests: (isAdmin, GetBook, GetUser, etc.) - Boaz
    }
}
