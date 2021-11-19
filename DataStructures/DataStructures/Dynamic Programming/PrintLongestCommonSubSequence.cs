using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Dynamic_Programming
{
    class PrintLongestCommonSubSequence
    {
        public int[,] t;
        public string PrintLongestCommonSubsequence(string text1, string text2, int n, int m)
        {
            t = new int[n + 1, m + 1];
            StringBuilder str = new StringBuilder();
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

          
            while (n > 0 && m > 0)
            {
                if (text1[n - 1] == text2[m - 1])
                {
                    str.Append(text1[n - 1]);
                    n--;
                    m--;
                }
                else
                {
                    if (t[n, m-1] > t[n-1, m]) m--;
                    else n--;



                }

            }

            var s = string.Empty;

             s= str.ToString();
             return new string(s.Reverse().ToArray());
        }
    }
}
