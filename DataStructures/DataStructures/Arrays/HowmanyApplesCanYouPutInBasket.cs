using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    class HowmanyApplesCanYouPutInBasket
    {
        public int MaxNumberOfApples(int[] weight)
        {
            Array.Sort(weight, (i1, i2) => i1 - i2);
            int sum = 0, count = 0;
            for (int i = 0; i < weight.Length; i++)
            {
                if (sum+weight[i] <= 5000)
                {
                    sum += weight[i];
                    count++;
                }
            }

            return count;
        }
    }
}
