using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sort
{
    public class LargestNumber179
    {
        public string LargestNumber(int[] nums)
        {
            string[] s = new string[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                s[i] = nums[i].ToString();
            }

            StringBuilder sb = new StringBuilder("");
            Array.Sort(s, (a, b) => (b + a).CompareTo(a + b)); // custom sort logic on all array elements and finally sort them in correct order.

            foreach (string str in s)
            {
                sb.Append(str);
            }

            string result = sb.ToString();
            return result.StartsWith("0") ? "0" : result;
        }

    }
}
