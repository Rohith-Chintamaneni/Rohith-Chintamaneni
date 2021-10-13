using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Recursion
{
   public class CountUsingRecursion
    {
        public int Count(int[] A, int N)
        {
            if (N <= 0)
                return 0;
            return (Count(A, N-1) + 1);
        }

        public static int CountRecursiveLocalVariables(int n)
        {
             int x = 0;
             if (n > 0)
             {
                 x = x + 1;
                return CountRecursiveLocalVariables(n - 1) + x;
             }

             return 0;

        }
        static int s = 0;
        // since s is static it will get incremented while returning 5 will be used for all recursive calls
        public static int CountRecursiveStaticVariables(int n)
        {
           
            if (n > 0)
            {
                s = s + 1;
                return CountRecursiveStaticVariables(n - 1) + s;
            }

            return 0;

        }

        // output 15: 5+4+3+2+1+0
        public static int CountRecursiveWithNoVariables(int n)
        {

            if (n > 0)
            {
               
                return CountRecursiveWithNoVariables(n - 1) + n;
            }

            return 0;

        }
    }
}
