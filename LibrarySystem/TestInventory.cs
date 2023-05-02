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
        public void TestCreateBook()
        {
            if (!testInventory.CreateBook(123, "ahaha", "advsun\neiaubnvaer", "Maas", "Penguin", "Adventure", 0, 15.00))
                throw new Exception("Create Book Test Failed");
        }
    }
}
