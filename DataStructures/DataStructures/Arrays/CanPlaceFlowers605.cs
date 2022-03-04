using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    class CanPlaceFlowers605
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {

            int j = 0, len = flowerbed.Length - 1;
            int count = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    if ((i == j || flowerbed[i - 1] == 0) && (i == len || flowerbed[i + 1] == 0))
                    {
                        flowerbed[i] = 1;
                        count++;
                    }
                }
            }
            //Console.WriteLine(count);
            return count >= n;
        }
    }
}
