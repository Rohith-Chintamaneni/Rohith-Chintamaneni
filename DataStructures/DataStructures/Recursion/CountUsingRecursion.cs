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
    }
}
