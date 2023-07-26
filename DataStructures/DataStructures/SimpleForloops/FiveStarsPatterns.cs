using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.SimpleForloops
{
    //they follow a 3 step process
    // 1) identitfy number of rows and the outer forloop must match with the number of rows
    // 2) Identify the number of columns that need to be printed on each row
    // 3) Identify what needs to be print on each row and column. It can be * or number itself etc.
   
   public class FiveStarsPatterns
    {
        /* Print following pattern
    *****
    *****
    *****
    *****
    *****
    */
        public void Print5StarsInRow(int n)
        {
            Console.WriteLine("Priting 5 stars in a Row for 5 rows");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
           
        }
            
           /* Print following pattern
            *
            **
            ***
            ****
            *****
            */
        public void PrintStarsOneInRowBasedOnlines(int n)
        {
            Console.WriteLine("Priting a star/stars in a Row based on row number");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

        }



        /* Print following pattern
         *****
         ****
         ***
         **
         *
         */
        public void Pattern3(int n)
        {
            Console.WriteLine("Priting Pattern 3");
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n-row+1; col++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

        }


        /* Print following pattern
        1
        12
        123
        1234
        12345
        */
        public void Pattern4(int n)
        {
            Console.WriteLine("Priting Pattern 4");
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }


        /* Print following pattern
        *
        **
        ***
        ****
        *****
        ****
        ***
        **
        *
        */
        public void Pattern5(int n)
        {
            Console.WriteLine("Priting Pattern 5");
            for (int row = 0; row < 2 * n ; row++)
            {
                int totalcolsinRow = row > n ? 2 * n - row: row;
                for (int col = 0; col < totalcolsinRow; col++)
                {
                    Console.Write("*");
                   // Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
        

    }
}
