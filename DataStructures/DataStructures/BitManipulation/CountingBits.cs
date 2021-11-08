using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BitManipulation
{
    class CountingBits
    {
        // Time COmplexity O(nlogn) need to do in O(n) which needs DP. will revisit after reading DP
        public int[] CountBits(int n)
        {
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = CountNumberofOne(i);
            }

            
            return result;
        }

        public int CountNumberofOne(int n)
        { 
            int count = 0;
           while (n != 0)
           {
               count++;
                n = n & (n - 1);
              
           }

           return count;
        }
    }
}
