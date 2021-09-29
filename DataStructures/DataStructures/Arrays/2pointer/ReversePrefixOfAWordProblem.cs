using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays._2pointer
{
    public class ReversePrefixOfAWordProblem
    {
        //LeetCode 2000;
        // word : abcdefg, ch: d output : dcbaefg
        public string ReversePrefix(string word, char ch)
        {
            if (string.IsNullOrEmpty(word)) return null;
            if (ch == ' ' || ch == '\0') return null;

            int chindex = 0;
            
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ch)
                {
                    chindex = i;
                    break;
                }
            }

            var chararray = word.ToCharArray();

            for (int i = 0, m = chindex; i < m; i++, m--)
            {
                var temp = chararray[i];
                chararray[i] = chararray[m];
                chararray[m] = temp;
               
            }


            return new string(chararray);
        }
    }
}
