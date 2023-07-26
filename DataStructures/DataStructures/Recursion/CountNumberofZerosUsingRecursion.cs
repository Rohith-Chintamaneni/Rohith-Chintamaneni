using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Recursion
{
   public class CountNumberofZerosUsingRecursion
    {
        public int CountNumberofZeros(int n)
        {
            int count = 0;
            return CountNumberofZerosHelper1(n, count);
        }
        // my way but it fails for input when it starts with  00 at front like 000034
        private int CountNumberofZerosHelper(int n, int count)
        {
            if (n % 10 == n) return count;
           
            if (n % 10 == 0)
            {
                count++;
               
            }
             return CountNumberofZerosHelper(n / 10, count);
        }

        // His approach also fails but it is easy and this condition needs to be handled explicitly
        // this is still a special case because here the value is simply returned to all above calls.
        // the base condition only hits onces and all the above calls return the same value. 
        private int CountNumberofZerosHelper1(int n, int count)
        {
            if (n == 0) return count;

            if (n % 10 == 0)
            {
                return CountNumberofZerosHelper1(n / 10, count + 1);

            }
            return CountNumberofZerosHelper1(n / 10, count);
        }
    }
}
