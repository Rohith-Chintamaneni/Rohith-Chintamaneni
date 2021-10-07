using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays._2pointer
{
    class MergeStringsAlternately
    {
        public string MergeAlternately(string word1, string word2)
        {
    

            int m = 0;
            int n = 0;
            StringBuilder res = new StringBuilder();
            while (m < word1.Length || n < word2.Length)
            {
                if (m < word1.Length)
                {
                    res.Append(word1[m]);
                }
                
                if(n < word2.Length)
                    res.Append(word2[n]);

                m++;
                n++;
            }

            return res.ToString();
        }
    }
}
