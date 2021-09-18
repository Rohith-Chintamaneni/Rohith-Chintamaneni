using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Arrays
{
    public class RemoveDuplicatesFromSortedArrayProblemAuxStorage
    {
        public int RemoveDuplicates(int[] nums)
        {

            var dictionary = new Dictionary<int, int>();
            int repeatedcountval = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], repeatedcountval);
                   
                }
                else
                {
                    dictionary[nums[i]] = 2;
                }
            }

            var finalcount = 0;
            foreach (var VARIABLE in dictionary.Keys)
            {
                finalcount++;
            }

            return finalcount;

            // approach 2
            //if (nums == null || nums.Length == 0)
            //    return 0;
            //else if (nums.Length == 1)
            //    return 1;

            //int index1 = 0,
            //    index2 = 1;

            //while (index2 <= nums.Length - 1)
            //    if (nums[index1] == nums[index2])
            //        index2++;
            //    else
            //        nums[++index1] = nums[index2++];

            //return ++index1;

        }
    }
}
