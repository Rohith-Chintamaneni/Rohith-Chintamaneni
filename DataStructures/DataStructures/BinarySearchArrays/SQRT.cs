using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    class SQRT
    {
        public int SquareOFnumber(int x)
        {
            int low = 0, high = x, mid = 0;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (mid * mid == x) return mid;
                else if (mid * mid > x) high = mid - 1;
                else low = mid + 1;
            }
            return high;
        }
    }
}
