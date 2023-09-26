using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sort.CyclicSort
{
    public class CyclicSortImplementation
    {
        public void SortCyclic(int[] nums)
        {
            int i = 0;
            while(i < nums.Length)
            {
                int correct = nums[i] - 1;
                if (nums[i] != nums[correct])
                {
                    Swap(nums, i, correct);
                }
                else i++;
            }
        }

        private void Swap(int[] heights, int i, int corrected)
        {
            var temp = heights[i];
            heights[i] = heights[corrected];
            heights[corrected] = temp;
        }
    }

   
}
