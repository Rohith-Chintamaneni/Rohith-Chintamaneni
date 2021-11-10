using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BitManipulation
{
    class ReversingBits
    {
        public uint ReverseBitsUsingBitManipulation(uint n)
        {
            uint result = 0;
            int power = 31;
            while (n != 0)
            {
                result += (n & 1) << power;
                n = n >> 1;
                power = power - 1;
            }
            return result;
        }
    }
}
