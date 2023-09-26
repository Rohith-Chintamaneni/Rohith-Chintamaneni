using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sort
{
    public class HeightChecker1051
    {
        public int HeightChecker(int[] heights)
        {
            int[] another = new int[heights.Length];
            int count = 0;
            for (int j = 0; j < heights.Length; j++)
            {
                another[j] = heights[j];
            }

            Array.Sort(heights);

            for (int j = 0; j < heights.Length; j++)
            {
                if (another[j] != heights[j]) count++;
            }

            return count;
        }


        private void Swap(int[] heights, int i, int corrected)
        {
            var temp = heights[i];
            heights[i] = heights[corrected];
            heights[corrected] = temp;
        }
    }
}
