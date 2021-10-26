using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    class ContainsDuplicate
    {
        public bool ContainsDuplicateProblem(int[] nums)
        {
            bool flag = false;
            HashSet<int> duplist = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (duplist.Contains(nums[i]))
                {
                    flag = true;
                }
                duplist.Add(nums[i]);
            }
            return flag;
        }
    }
}
