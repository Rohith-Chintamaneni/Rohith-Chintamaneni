using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Dynamic_Programming
{
    class LongestCommonSubSequenceProblem
    {
        private int[,] t;
        public int LongestCommonSubsequence(string text1, string text2)
        {
            return LongestCommonSubsequence_recursion(text1, text2, text1.Length, text2.Length);
        }

        public int LongestCommonSubsequence_recursion(string text1, string text2, int n, int m)
        {
            if (n == 0 || m == 0) return 0;

            if (text1[n - 1] == text2[m - 1]) return 1+ LongestCommonSubsequence_recursion(text1, text2, n - 1, m - 1);
            else
            {
               return Math.Max(LongestCommonSubsequence_recursion(text1, text2, n, m - 1),
                    LongestCommonSubsequence_recursion(text1, text2, n - 1, m));
            }
        }

        public int LongestCommonSubsequence2(string text1, string text2)
        {
            t = new int[text1.Length + 1, text2.Length + 1];
            for (int i = 0; i < text1.Length+1; i++)
            {
                for (int j = 0; j < text2.Length+1; j++)
                {
                    t[i, j] = -1;
                }
            }
            return LongestCommonSubsequence_Memoize(text1, text2, text1.Length, text2.Length);
        }

        public int LongestCommonSubsequence_Memoize(string text1, string text2, int n, int m)
        {
            if (n == 0 || m == 0) return 0;

            if (t[n, m] != -1) return t[n, m];

            if (text1[n - 1] == text2[m - 1])
             return  t[n,m] = 1 + LongestCommonSubsequence_Memoize(text1, text2, n - 1, m - 1);
            else
            {
                return t[n, m]= Math.Max(LongestCommonSubsequence_Memoize(text1, text2, n, m - 1),
                    LongestCommonSubsequence_Memoize(text1, text2, n - 1, m));
            }
        }

        public int LongestCommonSubsequence3(string text1, string text2)
        {
            t = new int[text1.Length + 1, text2.Length + 1];

            return LongestCommonSubsequence_DP(text1, text2, text1.Length, text2.Length);
        }

        public int LongestCommonSubsequence_DP(string text1, string text2, int n, int m)
        {
            for (int i = 1; i < text1.Length + 1; i++)
            {
                for (int j = 1; j < text2.Length + 1; j++)
                {
                    if (text1[i - 1] == text2[j - 1])
                    {
                        t[i, j] = 1 + t[i - 1, j - 1];
                    }
                    else
                    {
                        t[i, j] = Math.Max(t[i, j - 1], t[i - 1, j]);
                    }
                }

            }

            return t[n, m];
        }
    }
}
