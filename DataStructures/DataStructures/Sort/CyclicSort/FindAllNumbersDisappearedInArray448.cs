using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sort.CyclicSort
{
    class FindAllNumbersDisappearedInArray448
    {
        public List<int> FindDisappearedNumbers(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] == i + 1 || nums[i] == nums[nums[i] - 1])
                {
                    i++;
                    continue;
                }
                int tmp = nums[i];
                nums[i] = nums[nums[i] - 1];
                nums[tmp - 1] = tmp;

            }
            List<int> result = new List<int>();
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != j + 1)
                    result.Add(j + 1);
            }
            return result;
        }
    }
}
