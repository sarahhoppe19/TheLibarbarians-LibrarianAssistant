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
            TestGetBook();
            TestGetUser();
        }

        /// <summary>
        /// Tests Create Book
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void TestCreateBook()
        {
            Inventory testInventory = new();
            if (!testInventory.CreateBook(123, "Some Book", "advsun\neiaubnvaer", "Maas", "Penguin", "Adventure", 0, 15.00))
                throw new Exception("Create Book Test Failed");
        }
        public static void TestEditBook()
        {
            Inventory testInventory = new();
            testInventory.CreateBook(123, "Some Book", "advsun\neiaubnvaer", "Maas", "Penguin", "Adventure", 0, 15.00);
            if (!testInventory.EditBook(123, "Another Book", "advsun\neiaubnvaer", "Maas", "Penguin", "Adventure", 0, 15.00))
                throw new Exception("Edit Book Failed: Book not found");
            if (testInventory.GetBook(123).Title != "Another Book")
                throw new Exception("Edit Book Failed: Book title not changed");
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

        public static void TestGetBook()
        {
            Inventory testInventory = new();
            Book testBook = new Book();
            testInventory.CreateBook(1, "At the Back of the North Wind", "Idk I guesss the north wind has some kind of back", "Boaz Glassberg", "A24", "Horror", 1, 3.5);
            testBook = testInventory.GetBook(1);
            if(testBook == null)
            {
                throw new Exception("Book could not be fetched");
            }
        }

        public static void TestGetUser()
        {
            Inventory testInventory = new();
            User newUser = new User();
            testInventory.CreateUser(011710418, "boazglassberg", "testpassword", false);
            newUser = testInventory.GetUser(011710418);
            if (testInventory.GetUser(011710418) == null)
            {
                throw new Exception("User could not be fetched");
            }
        }
    }
}
