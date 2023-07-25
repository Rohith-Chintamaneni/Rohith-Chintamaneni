using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.SimpleForloops
{

    /* Print following pattern
     *****
     *****
     *****
     *****
     *****
     */
   public class FiveStarsinRow
    {
        public void Print5StarsInRow()
        {
            Console.WriteLine("Priting 5 stars in a Row for 5 rows");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
           
        }
    }
}
