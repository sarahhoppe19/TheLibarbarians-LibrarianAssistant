using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal static class TestInventory
    {

        // Calls all tests
        public static void RunAllTests()
        {
            TestCreateBook();
            TestBookSearch();
            TestUserSearch();
            TestisAdmin();
        }

        /// <summary>
        /// Tests Create Book
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void TestCreateBook()
        {
            Inventory testInventory = new();
            if (!testInventory.CreateBook(123, "ahaha", "advsun\neiaubnvaer", "Maas", "Penguin", "Adventure", 0, 15.00))
                throw new Exception("Create Book Test Failed");
        }

        //Book Search Tests:
        public static void TestBookSearch()
        {
            Inventory testInventory = new();
            testInventory.CreateBook(978, "Some Book", "We out here.", "Maas", "Scholastic", "Sci-Fi", 1, 10.50);
            if (!testInventory.BookSearch(978).Contains(978))
                throw new Exception("Book Search Failed (Book was not found in TestInventory)");
            if (!testInventory.BookSearch("Some Book").Contains(978))
                throw new Exception("Book Search Failed (Book was found but wrong ISBN)");
            if (!testInventory.BookSearch("We out here.").Contains(978))
                throw new Exception("Book Search Failed (Book was found but wrong Description)");
            if (!testInventory.BookSearch("Maas").Contains(978))
                throw new Exception("Book Search Failed (Book was found but wrong Author)");
            if (!testInventory.BookSearch("Scholastic").Contains(978))
                throw new Exception("Book Search Failed (Book was found but wrong Publisher)");
            if (!testInventory.BookSearch("Sci-Fi").Contains(978))
                throw new Exception("Book Search Failed (Book was found but wrong Genre)");               
        }


        //User Search tests:
        public static void TestUserSearch()
        {
            Inventory testInventory = new();
            testInventory.CreateUser(012345678, "gracecovarrubias", "ilovecoding", false);
            if (testInventory.UserSearch(012345678).Count != 1)
                throw new Exception("User Search Failed (Nothing was added to TestInventory)");
            if (testInventory.UserSearch(023456789).Contains(023456789))
                throw new Exception("User Search Failed (Found user it should not have found)");
            if (!testInventory.UserSearch(012345678).Contains(012345678))
                throw new Exception("User Search Failed (Could not find created user)");
        }
        //isAdmin test
        public static void TestisAdmin()
        {
            Inventory testInventory = new();
            testInventory.CreateUser(010101010, "davidhofsetz", "securepassword", true);
            if (!testInventory.GetUser(010101010).Admin)
                throw new Exception("Admin Check Failed (User was created as admin but returned false)");
        }

        //Extra Tests: ( GetBook, GetUser, etc.) - Boaz
    }
}
