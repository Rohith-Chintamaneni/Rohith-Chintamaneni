using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/kth-largest-element-in-an-array/description/
namespace DataStructures.Sort
{
    public class KLargestElementInArray
    {
        // not working learn priority queues and implement again
        public int FindKthLargest(int[] nums, int k)
        {
            Stack<int> set = new Stack<int>();
            while (k > 0)
            {
                int max = int.MinValue;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (set.Count == 0)
                    {
                        max = Math.Max(max, nums[i]);

                    }
                    else
                    {
                        if (nums[i] > max && nums[i] < set.Peek())
                        {
                            max = Math.Max(max, nums[i]);
                        }
                       
                    }


                }
                set.Push(max);
                k--;
            }

            return set.Pop();
        }
    }
}
