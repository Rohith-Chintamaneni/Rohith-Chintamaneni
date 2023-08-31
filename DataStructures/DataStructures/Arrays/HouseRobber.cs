using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/house-robber/
// https://leetcode.com/problems/house-robber/solutions/156523/from-good-to-great-how-to-approach-most-of-dp-problems/
//http://www.crazyforcode.com/house-robber-dynamic-programming/
// https://www.wikihow.com/Solve-Recurrence-Relations
// DP Problems: https://leetcode.com/discuss/general-discussion/662866/Dynamic-Programming-for-Practice-Problems-Patterns-and-Sample-Solutions
namespace DataStructures.Arrays
{
    public class HouseRobber
    {
        public int Rob(int[] nums)
        {
            return RobHelper(nums, nums.Length-1);
        }

        private int RobHelper(int[] nums, int i)
        {
            if (i < 0) return 0;

            return Math.Max(RobHelper(nums, i - 2) + nums[i], RobHelper(nums, i - 1));
        }
    }
}
