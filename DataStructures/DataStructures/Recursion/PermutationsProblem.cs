using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Recursion
{
    class PermutationsProblem
    {
        IList<IList<int>> result;
        public IList<IList<int>> Permute(int[] nums)
        {
            result = new List<IList<int>>();

            DFS(nums, new List<int>());

            return result;
        }
        // think of this as tree and always remember that the tree will use DFS. So it will go all the way to build one combination and then it will come back if it fails.
        private void DFS(int[] nums, List<int> curr)
        {
            if (nums.Length == curr.Count)
                result.Add(new List<int>(curr));
           
                for (int i = 0; i < nums.Length; i++)
                {
                    if (curr.Contains(nums[i])) continue;
                    // Include
                    curr.Add(nums[i]);

                    DFS(nums, curr);
                    // Exclude
                    curr.RemoveAt(curr.Count - 1);
                }
            
        }


        public IList<IList<int>> Permute2(int[] nums)
        {
            result = new List<IList<int>>();

            GeneratePermutation(nums, new List<int>(nums), nums.Length);

            return result;
        }


        private void GeneratePermutation(int[] nums, List<int> curr, int length)
        {
            if (length ==0)
                result.Add(new List<int>(curr));

            var op1 = new List<int>(curr);
            var op2 = new List<int>(curr);


        }

    }
}
