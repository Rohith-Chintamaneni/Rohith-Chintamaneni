using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings
{
    class ReverseAstring186
    {
        public char[] ReverseWords(char[] s)
        {
            // Three step to reverse
            // 1, reverse the whole sentence
            Reverse(s, 0, s.Length - 1);
            // 2, reverse each word
            int start = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    Reverse(s, start, i - 1);
                    start = i + 1;
                }
            }
            // 3, reverse the last word, if there is only one word this will solve the corner case
            Reverse(s, start, s.Length - 1);

            return s;
        }

        public void Reverse(char[] s, int start, int end)
        {
            while (start < end)
            {
                char temp = s[start];
                s[start] = s[end];
                s[end] = temp;
                start++;
                end--;
            }
        }

    }
   
}
