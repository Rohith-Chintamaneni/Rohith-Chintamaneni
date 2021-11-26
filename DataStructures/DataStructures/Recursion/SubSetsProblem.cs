using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Recursion
{
    class SubSetsProblem
    {
        IList<IList<int>> ans = new List<IList<int>>();
        public IList<IList<int>> Subsets(int[] nums)
        {
            // initialize the output. and pass input.
            this.helper(nums, new List<int>(), nums.Length);
            return this.ans;

        }

        public void helper(int[] ip, List<int> op, int length)
        {

            if (length == 0)
            {
                this.ans.Add(op);
                return;
            }

            //List<int> op1 = new List<int>(op);
            List<int> op2 = new List<int>(op);

             op2.Add(ip[length-1]);

            //helper(ip, op1, length - 1); by just using single variable to improve performance
            helper(ip, op, length-1);
            helper(ip, op2, length-1);


        }

        public IList<IList<int>> Subsets3(int[] nums)
        {
            // initialize the output. and pass input.
            this.GenerateSubsets(nums, new List<int>(), 0);
            return this.ans;

        }

        public void GenerateSubsets(int[] ip, List<int> op, int length)
        {

            if (length == ip.Length)
            {
                this.ans.Add(op);
                return;
            }

            List<int> op1 = new List<int>(op);
            List<int> op2 = new List<int>(op);

            op2.Add(ip[length]);

            //helper(ip, op1, length - 1); by just using single variable to improve performance
            helper(ip, op, length + 1);
            helper(ip, op2, length + 1);


        }

        // understand this vs the above one. 
        public IList<IList<int>> Subsets2(int[] nums)
        {
            var result = new List<IList<int>>();

            DFS(nums, 0, new List<int>(), result);

            return result;
        }
        private void DFS(int[] nums, int start, IList<int> curr, IList<IList<int>> result)
        {
            result.Add(new List<int>(curr));

            for (int i = start; i < nums.Length; i++)
            {
                curr.Add(nums[i]);
                DFS(nums, i + 1, curr, result);
                curr.RemoveAt(curr.Count - 1);
            }
        }

    }
    
}
