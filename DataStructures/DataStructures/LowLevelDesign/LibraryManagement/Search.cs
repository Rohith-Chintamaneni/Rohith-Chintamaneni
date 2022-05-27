using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LowLevelDesign.LibraryManagement
{
    public class Search : ISearch
    {
        
        public Dictionary<string, List<Book>> BooksByAuthor;
        public Dictionary<string, List<Book>> BooksByTitle;
        public Dictionary<string, List<Book>> BooksByCategory;

        
       
        List<Book> ISearch.SearchByAuthor(string query)
        {
            return BooksByAuthor[query];
        }

        List<Book> ISearch.SearchByTitle(string query)
        {
            return BooksByTitle[query];
        }

        List<Book> ISearch.SearchByPublicationDate(string query)
        {
            return BooksByCategory[query];
        }
    }
}
