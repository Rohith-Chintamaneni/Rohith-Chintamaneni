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
                currcoins = mid * (mid + 1) / 2;

                if (n == currcoins) return (int)mid;
                else if (currcoins > n) high = mid - 1;
                else low = mid + 1;


            }
            return (int)high;

        }
    }
}
