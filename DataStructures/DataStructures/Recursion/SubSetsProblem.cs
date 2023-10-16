using System.Collections.Generic;
using System.Linq;

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

            op2.Add(ip[length - 1]);

            //helper(ip, op1, length - 1); by just using single variable to improve performance
            helper(ip, op, length - 1);
            helper(ip, op2, length - 1);


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

            //  List<int> op1 = new List<int>(op);
            List<int> op2 = new List<int>(op);

            op2.Add(ip[length]);

            //helper(ip, op1, length - 1); by just using single variable to improve performance
            helper(ip, op, length + 1);
            helper(ip, op2, length + 1);


        }

        // understand this vs the above one. 
        // THis is backTracking approach
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

        // include exclude method which is easy to follow
        public IList<IList<int>> SubsetsIncludeExcludeMethod(int[] nums)
        {
            List<List<int>> subsets = new List<List<int>>();

            helper(nums, 0, new List<int>(), subsets);

            return subsets.ToArray();
        }

        public void helper(int[] nums, int idx, List<int> slate, List<List<int>> subsets)
        {
            if (idx == nums.Length)
            {
                subsets.Add(new List<int>(slate)); // still need to do a deep copy if not local change will modify the global value. If the changes made to arrays will be reflected. you dont want that
                return;
            }

            // Exclude the current value.
            helper(nums, idx + 1, slate, subsets);

            // Include the current value.
            slate.Add(nums[idx]);
            helper(nums, idx + 1, slate, subsets);
            slate.RemoveAt(slate.Count() - 1); // we need to clean array. Include and exclude at that level. WHen you go to a new level of hierarcy we still want array to be empty 
        }

        // iterative approach

        public IList<IList<int>> findSubsets(int[] nums)
        {
            List<List<int>> subsets = new List<List<int>>();
            // start by adding the empty subset
            subsets.Add(new List<int>());
            foreach (var currentNumber in nums)
            {
                // we will take all existing subsets and insert the current number in them to create new subsets
                int n = subsets.Count;
                for (int i = 0; i < n; i++)
                {
                    // create a new subset from the existing subset and insert the current element to it
                    List<int> set = new List<int>(subsets[i]);
                    set.Add(currentNumber);
                    subsets.Add(set);
                }
            }
            return subsets.ToArray();
        }

        // Using INclude Exclude method but creating the list inside the helper method instead of passing it as argument.
        public IList<IList<int>> Subsets4(int[] nums)
        {

            return SubsetsHelper4(nums, 0, new List<int>()).ToArray();



        }

        public List<List<int>> SubsetsHelper4(int[] nums, int l, List<int> temp)
        {

            if (l == nums.Length)
            {
                var results = new List<List<int>>();
                results.Add(new List<int>(temp));
                return results;
            }



            var leftans = SubsetsHelper4(nums, l + 1, temp);
            temp.Add(nums[l]);
            var rightans = SubsetsHelper4(nums, l + 1, temp);
            temp.RemoveAt(temp.Count - 1);

            leftans.AddRange(rightans);
            return leftans;
        }

        // Pay attention to problem type. Sometimes it can be asked on strings which could be different from the Array implementation here.

        public IList<IList<int>> Subsets5(int[] nums)
        {


            var ans = SubsetsHelper5(nums, new List<int>(), 0);
            return ans.ToArray();

        }

        public List<List<int>> SubsetsHelper5(int[] nums, List<int> local, int index)
        {

            if (index > nums.Length - 1)
            {
                var results = new List<List<int>>();
                results.Add(new List<int>(local));
                return results;
            }

            local.Add(nums[index]);
            var include = SubsetsHelper5(nums, local, index + 1);
            local.RemoveAt(local.Count - 1);

            var exclude = SubsetsHelper5(nums, local, index + 1);

            include.AddRange(exclude);

            return include;

        }
    }



}
