using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sort.CyclicSort
{
    class MissingNumberProblem
    {
        public int MissingNumber(int[] nums)
        {
            int index = 0, value=-1;
            while (index < nums.Length)
            {
                if (nums[index] < nums.Length && nums[index] != index)
                {
                    var temp = nums[nums[index]];
                    nums[nums[index]] = nums[index];
                    nums[index] = temp;
                }
                    else index++;

            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i) return i;
            }


            return nums.Length;
        }
    }
}
