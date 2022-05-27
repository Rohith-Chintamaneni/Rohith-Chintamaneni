using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LowLevelDesign.LibraryManagement
{
    public class Book
    {
        public string BookTitle { get; set; }

        public DateTime PublicationDate { get; set; }


        public string Category { get; set; }

        public Person Author { get; set; }


    }
}
