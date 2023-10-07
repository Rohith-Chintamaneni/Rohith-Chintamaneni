using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sort
{
    public class HowManyNumbersSmallerThanCurrent1365
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] ans = new int[101];
            for (int i = 0; i < nums.Length; i++)
            {
                ans[nums[i]] = ans[nums[i]] + 1;
            }

            for (int i = 1; i < ans.Length; i++)
            {
                ans[i] = ans[i] + ans[i - 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    nums[i] = ans[nums[i] - 1];
            }

            return nums;
        }

        // ANother approach. Sort and use hashtable. SInce it is sorted the values inserted in Hashtable is the count.
        public int[] SmallerNumbersThanCurrent2(int[] nums)
        {

            var results = new int[nums.Length];
            var dictionary = new Dictionary<int, int>();
            var numsCopy = (int[])nums.Clone();
            Array.Sort(numsCopy);

            for (int i = 0; i < numsCopy.Length; i++)
            {
                if (!dictionary.ContainsKey(numsCopy[i])) dictionary.Add(numsCopy[i], i);
            }

            for (int i = 0; i < results.Length; i++)
            {
                results[i] = dictionary[nums[i]];
            }

            return results;
        }
    }
}
