using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LowLevelDesign.LibraryManagement
{
   public interface ISearch
   {
       public List<Book> SearchByAuthor(string query);
       public List<Book> SearchByTitle(string query);
       public List<Book> SearchByPublicationDate(string query);
    }
}
