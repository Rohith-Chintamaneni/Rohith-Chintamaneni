using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/minimum-size-subarray-sum/
namespace DataStructures.SlidingWindow.VariableWindow
{
    public class MinimumSizeSubArraySum
    {

        // Idea is to use the Variable window template. So that it is unique for Fixed and Variable.
        public int MinSubArrayLen(int k, int[] nums)
        {
            int start = 0, end = 0;
            int count = int.MaxValue; int sum = 0;
            while (end < nums.Length)
            {
                sum += nums[end];
                if (sum < k)
                {
                   
                    end++;
                }
                else if (sum == k)
                {
                    count = Math.Min(count, end - start + 1); 

                    end++;
                }
                else 
                {
                    while (sum > k)
                    {
                        // Remove calculations or operations involving the element at the start index
                        sum -= nums[start];
                        count = Math.Min(count, end - start + 1);
                        start++;
                    }

                    // Check if the window size becomes equal to the desired value (k) after adjustment
                    if (sum == k)
                    {
                        count = Math.Min(count, end - start + 1);
                        // Perform calculations or operations and store the answer if necessary
                    }
                    end++;
                   
                }
            }
            if (count == int.MaxValue) return 0;
            return count;
        }
   

    // using comprehensive guide
    public int MinSubArrayLen2(int k, int[] nums)
    {
        int start = 0, end = 0;
        int count = int.MaxValue; int sum = 0;
        while (end < nums.Length)
        {

            sum += nums[end];
                //Case 1: Expand the window
                if (sum < k)
                {
                    end++;
                }

                else if (sum == k)
                {
                    count = Math.Min(count, end - start + 1);

                    end++;
                }
                else
                {
                    while (sum > k)
                    {
                        // Remove calculations or operations involving the element at the start index
                        sum -= nums[start];
                        count = Math.Min(count, end - start + 1);
                        start++;
                    }
                    if(sum == k)
                    {
                        count = Math.Min(count, end - start + 1);
                    }
                    // Check if the window size becomes equal to the desired value (k) after adjustment

                    end++;
                }
        }
        if (count == int.MaxValue) return 0;
        return count;
    }



        // using comprehensive guide. Simplified
        public int MinSubArrayLen3(int k, int[] nums)
        {
            int start = 0, end = 0;
            int count = int.MaxValue; int sum = 0;
            while (end < nums.Length)
            {

                sum += nums[end];
                //Case 1: Expand the window
                if (sum < k)
                {
                    end++;
                }

              
                else
                {
                    while (sum >= k)
                    {
                        // Remove calculations or operations involving the element at the start index
                        sum -= nums[start];
                        count = Math.Min(count, end - start + 1);
                        start++;
                    }
                   
                    // Check if the window size becomes equal to the desired value (k) after adjustment

                    end++;
                }
            }
            if (count == int.MaxValue) return 0;
            return count;
        }
    }
}
