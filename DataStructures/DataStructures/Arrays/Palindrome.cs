using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class Palindrome
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            List<int> results = new List<int>();
            while (x > 0)
            {
                var remainder = x % 10;
                results.Add(remainder);
                x = x / 10;

            }
            var nums = results.ToArray();
            int start = 0; int end = nums.Length - 1;
            while (start < end)
            {
                if (nums[start] != nums[end]) return false;
                start++;
                end--;
            }

            return true;
        }


        public bool IsPalindrome2(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0)) return false;
            int rev = 0;
            while (x > rev)
            {
                rev = rev * 10 + x % 10;
                x = x / 10;
            }
            return (x == rev || x == rev / 10);
        }
    }
}
