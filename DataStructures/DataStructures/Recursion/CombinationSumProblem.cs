using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/combination-sum/
namespace DataStructures.Recursion
{
    public class CombinationSumProblem
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {

            var results = new List<List<int>>();
            CombinationSumHelper(candidates, target, results, new List<int>(), 0);
            return results.ToArray();
        }

        public void CombinationSumHelper(int[] candidates, int target, List<List<int>> results, List<int> local, int index)
        {
            // when the index is equal to array length and still target is not 0 then that combination is not correct so we return.
            if (index == candidates.Length)
            {
                if (target == 0)
                {
                    results.Add(new List<int>(local));

                }
                return;
            }


            if (candidates[index] <= target)
            {

                local.Add(candidates[index]);
                CombinationSumHelper(candidates, target - candidates[index], results, local, index);
                local.RemoveAt(local.Count - 1);


            }

            CombinationSumHelper(candidates, target, results, local, index + 1);

        }
    }
}
