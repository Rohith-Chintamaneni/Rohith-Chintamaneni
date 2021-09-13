using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Recursion
{
    public class MaxUsingRecursion
    {
        public int Max(int[] a,int length)
        {
            if (length==1)
            {
               return a[0];
            }

            return Math.Max(Max(a, length - 1), a[length - 1]);


            
        }

    }
}
