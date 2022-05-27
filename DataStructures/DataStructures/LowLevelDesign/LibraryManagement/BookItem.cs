using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LowLevelDesign.LibraryManagement
{
    public class BookItem : Book
    {
        public int booklimt { set; get; }
        public string barcode { get; set; }
        public Rack Physical_localtion { set; get; }


        // methods
        public void IsBorrowed()
        {

        }

        public void IsRenewed()
        {

        }

        public void IsDue()
        {

        }

        public bool IsreferenceCopy()
        {
            return false;
        }
    }
}
