using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Dynamic_Programming
{
    class MinimumNumberOfInsertionAndDeletion
    {
        private int[,] t;
        public int MinimumNumberOfInsertionAndDeletion_DP(string text1, string text2, int n, int m)
        {
            t = new int[n + 1, m + 1];
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

            // Excellent logic
            // text1.Length - LCS gives you deletion
            // text2.Length - LCS gives you insertion
            return (text1.Length - t[n, m]) + (text2.Length - t[n, m]);
        }
    }
}
