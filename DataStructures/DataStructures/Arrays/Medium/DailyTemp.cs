using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Medium
{
    public class DailyTemp
    {
        // using a hashmap
        public int[] DailyTemperatures(int[] temperatures)
        {
            //make dict
            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 30; i < 101; i++)
            {
                d.Add(i, -1);
            }
            // iterate reversed
            int min;
            for (int i = temperatures.Length - 1; i > -1; i--)
            {
                // for each single temp iterate from it to 100 checking the warmer and git the min dist 
                d[temperatures[i]] = i;
                min = Int32.MaxValue;
                for (int j = temperatures[i] + 1; j < 101; j++)
                {
                    if (d[j] > i)
                        if (d[j] - i < min)
                            min = d[j] - i;
                }
                temperatures[i] = min == Int32.MaxValue ? 0 : min;
            }
            return temperatures;
        }

        // using Stack: Better implementation
        // If the current element in loop is greater than or equal to previous element in stack then pop it.
        // WHen count is not equal to 0. you should update the array.
        public int[] DailyTemperatures2(int[] temperatures)
        {
            int[] res = new int[temperatures.Length];
            Stack<int> stack = new Stack<int>();
            for (int i = temperatures.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && temperatures[stack.Peek()] <= temperatures[i])
                {
                    stack.Pop();
                }

                if (stack.Count != 0)
                {
                    res[i] = stack.Peek() - i;
                }
                stack.Push(i);

            }
            return res;
        }

        // Brute force:
        public int[] DailyTemperatures3(int[] temperatures)
        {
            int n = temperatures.Length;
            int[] ans = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (temperatures[i] < temperatures[j])
                    {
                        ans[i] = j - i;
                        break;
                    }

                }
            }
            return ans;
        }
    }
}
