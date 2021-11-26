using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Dynamic_Programming
{
    class LongestPalindromicSubsequenceProblem
    {
        private int?[,] t;

        public int LongestPalindromeSubsequence(string s)
        {
            return CallLCS(s, new string(s.Reverse().ToArray()), s.Length, s.Length);


        }

        public int CallLCS(string s1, string s2, int n, int m)
        {
            t = new int?[n + 1, m + 1];

            for (int i = 0; i < n+1; i++)
            {
                for (int j = 0; j < m+1; j++)
                {
                    if (i == 0) t[i, j] = 0;
                    if (j == 0) t[i, j] = 0;
                }
            }

            for (int i = 1; i < s1.Length + 1; i++)
            {
                for (int j = 1; j < s2.Length + 1; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        t[i, j] = 1 + t[i - 1, j - 1];
                    }
                    else
                    {
                        t[i, j] = Math.Max(t[i, j - 1].Value, t[i - 1, j].Value);
                    }
                }

            }

            return t[n, m].Value;
        }


        public int LongestPalindromeSubsequence2(string s)
        {
            t = new int?[s.Length + 1, s.Length + 1];
            return LongestPalindromeSubsequence_memoize(s, 0, s.Length);
        }

        public int LongestPalindromeSubsequence_memoize(string s, int l, int r)
        {
            if (l == r) return 1;

            if (l > r) return 0;
            if (t[l, r] != null) return t[l, r].Value;

            if (s[l] == s[r]) t[l,r] =  2+ LongestPalindromeSubsequence_memoize(s, l + 1, r - 1);
            else
            { 
                t[l, r] = Math.Max(LongestPalindromeSubsequence_memoize(s, l, r - 1),
                    LongestPalindromeSubsequence_memoize(s, l + 1, r));
            }

            return t[l, r].Value;
        }
    }
}
