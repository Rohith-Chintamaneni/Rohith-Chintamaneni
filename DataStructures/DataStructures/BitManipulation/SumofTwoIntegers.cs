using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BitManipulation
{
    class SumofTwoIntegers
    {
        public int GetSum(int a, int b)
        {

            int x = Math.Abs(a);
            int y = Math.Abs(b);

            if (x < y) GetSum(b, a);

            int sign = a < 0 ? -1 : 1;

            if (a * b >= 0)
            {
                while (y != 0)
                {
                    int ans = x ^ y;
                    int carry = (x & y) << 1;
                    x = ans;
                    y = carry;
                }
            }
            else
            {
                while (y != 0)
                {
                    int ans = x ^ y;
                    int borrow = ((~x) & y) << 1;
                    x = ans;
                    y = borrow;
                }

            }

            

            return sign * x;
        }

        // since C# handles the two's complement for negative numbers
        public int GetSumLanguageSpecific(int a, int b)
        {
            if (a < b) return GetSum(b, a);

            while (b != 0)
            {
                int sum = a ^ b;
                int carry = (a & b) << 1;
                a = sum;
                b = carry;
            }
            return a;
        }
    }
}
