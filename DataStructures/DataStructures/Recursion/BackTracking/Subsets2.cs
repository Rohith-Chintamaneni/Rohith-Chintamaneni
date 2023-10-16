using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/subsets-ii/submissions/
namespace DataStructures.Recursion.BackTracking
{
    public class Subsets2
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            var results = new List<List<int>>();
            Array.Sort(nums);
            SubsetswithDupHelper(nums, results, 0, new List<int>());
            return results.ToArray();
        }

        public void SubsetswithDupHelper(int[] nums, List<List<int>> results, int index, List<int> local)
        {
            results.Add(new List<int>(local));

            for (int i = index; i < nums.Length; i++)
            {
                if (i > index && nums[i] == nums[i - 1]) continue;

                local.Add(nums[i]);
                SubsetswithDupHelper(nums, results, i + 1, local);
                local.RemoveAt(local.Count - 1);
            }
        }
    }
}
