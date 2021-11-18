using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Dynamic_Programming
{
    class LongestCommonSubstringProblem
    {
        private int count;
        public int LongestSubstring(string text1, string text2)
        {
            count = 0;
            return LongestSubstring_Memoize(text1, text2, text1.Length, text2.Length, count);
        }

        public int LongestSubstring_Memoize(string s1, string s2, int n, int m, int count)
        {
            // smallest possible valid INput
            if (n == 0 || m == 0) return count;

            if (s1[n - 1] == s2[m - 1])
            {
               count = LongestSubstring_Memoize(s1, s2, n - 1, m - 1, count+1);
                    //return count;
            }
            else
            {

                count = Math.Max(count, Math.Max(LongestSubstring_Memoize(s1, s2, n-1, m, 0), LongestSubstring_Memoize(s1, s2, n, m-1, 0)));
            }

            return count;
        }
    }

    // DP version the else part of t[i,j] = 0;

}
