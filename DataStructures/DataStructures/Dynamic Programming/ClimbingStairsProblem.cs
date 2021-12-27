using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Dynamic_Programming
{
    class ClimbingStairsProblem
    {
        // for memoization always remember on what is changing. Here count is changing in the climbstairshelper method.
        int[] t;
        public int ClimbStairs(int n)
        {
            t = new int[n + 1];
            //Array.Fill(t, -1);
            return ClimbStairHelper(n, 0);
        }

        // here I am increasing count
        public int ClimbStairHelper(int n, int count)
        {
            if (count > n) return 0;
            if (count == n) return 1;
            if (t[count] > 0) return t[count];
            var result = ClimbStairHelper(n, count + 1) + ClimbStairHelper(n, count + 2);
            t[count] = result;

            return result;
        }

        // Here i am going by N and reducing N. By doing this way the DP logic is also very similar to it.
        public int ClimbStairHelperUsingAnotherway(int n)
        {
            if (n < 0) return 0;
            if (n ==0) return 1;
            if (t[n] > 0) return t[n];
            var result = ClimbStairHelperUsingAnotherway(n-1) + ClimbStairHelperUsingAnotherway(n-2);
            t[n] = result;

            return result;
        }

        // bottom up 
        public int ClimbStairsUsingDP(int n)
        {
            t = new int[n + 1];
            t[0] = 0; // filling values which are need
            t[1] = 1; // filling values which are need
            t[2] = 2;  // filling values which are need
            for(int i=3; i< n+1; i++)
            {
                t[i] = t[i - 1] + t[i - 2];
            }
            return t[n];

        }

    }
}
