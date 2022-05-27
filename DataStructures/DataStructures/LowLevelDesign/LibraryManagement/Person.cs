using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LowLevelDesign.LibraryManagement
{
    public class Person
    {
        public string FN { get; set; }
        public string LN { get; set; }

        public string Email { get; set; }

        public void SearchCatalog()
        {
            Console.WriteLine("Search a Book");
        }
    }

}

