using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BitManipulation
{
    class NumberOf1bits
    {
        public int HammingWeight(uint n)
        {
            uint num = n - 1;
            int count = 0;
            while (n != 0)
            {
                n = n & num;
                num = n - 1;
                count++;
            }

            return count;
        }
    }
}
