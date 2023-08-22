using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.PrefixSum
{
    public class FindPivotIndex
    {

        // general naive approach to solve this problem would be on every iteration. Run 2 loops one for left sum and another for right sum
        // while using Prefix sum, you have already calculated the totalsum and lsum = totalsum-nums[i]-lsum. When you add Lsum+= nums[i] at the end.
        public int PivotIndex(int[] nums)
        {
            int sum = 0, leftsum = 0;
            for(int i=0; i<nums.Length; i++)
            {
                sum += nums[i];
            }
            for(int i=0; i< nums.Length; i++)
            {
                if (leftsum == sum - leftsum - nums[i]) return i;
                leftsum += nums[i];

            }
           
            return -1;
        }
    }
}
