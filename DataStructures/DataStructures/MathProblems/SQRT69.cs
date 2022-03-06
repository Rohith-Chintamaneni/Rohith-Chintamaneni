using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.MathProblems
{
    class SQRT69
    {
        public int MySqrt(int x)
        {
            if (x < 2) return x;

            int low = 0;
            int high = x / 2;
            long num = 0;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                num = (long)mid * mid;

                if (num == x) return mid;
                else if (num > x)
                {
                    high = mid - 1;

                }
                else
                {
                    low = mid + 1;
                }


            }
            // understand why return high; check for 9. low becomes 3 but high comes to 2.
            return high;

        }
    }
}
