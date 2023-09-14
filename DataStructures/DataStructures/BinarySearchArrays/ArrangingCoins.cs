using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    class ArrangingCoins
    {

        public int ArrangeCoins(int n)
        {
            if (n == 0) return n;
            long low = 1, high = n;
            long mid = 0, currcoins = 0;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                currcoins = mid * (mid + 1) / 2; // we are checking the number of coins at the mid level. SInce the sum of n number is n(n+1)/2 we are comparing that to total coins.

                if (n == currcoins) return (int)mid;
                else if (currcoins > n) high = mid - 1;
                else low = mid + 1;


            }
            return (int)high;

        }

        // basic Idea is to have a multipler and you know that every step the of multipler it needs reduce by that;
        public int ArrangeCoins2(int n)
        {
            int multipler = 1;
            while (n >= 0)
            {
                n -= multipler;
                multipler++;
            }
            return n == 0 ? multipler - 1 : multipler - 2;

        }
    }
}
