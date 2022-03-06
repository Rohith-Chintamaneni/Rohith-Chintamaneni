using System;

namespace DataStructures.MathProblems
{
    class SquareRoot
    {
        public decimal FindSquareRoot(decimal n)
        {
            decimal i = 0;
            while (i < n)
            {
                if (i * i == n) return i;

                if (i * i > n) return FindSquareRootHelper(n, i, i - 1);

                i++;
            }

            return -1;
        }

        public decimal FindSquareRootHelper(decimal n, decimal j, decimal i)
        {
            decimal mid = (i + j) / 2;

            decimal mul = mid * mid;
           
                if (mul == n) return mid;

                else if (mul > n) return FindSquareRootHelper(n, mid, i);
                else
                {
                    return FindSquareRootHelper(n, j, mid);
                }

           

        }
    }
}
