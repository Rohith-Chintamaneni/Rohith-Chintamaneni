using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/reverse-words-in-a-string-iii/
namespace DataStructures.Strings
{
    public class ReverseWordsInString
    {
        public string ReverseWords(string s)
        {
            StringBuilder Sb = new StringBuilder();
            String[] str = s.Split(" ");
            for (int i = 0; i < str.Length; i++)
            {
                char[] arr = str[i].ToCharArray();
                Array.Reverse(arr);
                Sb.Append(new string(arr));
                if (i < str.Length - 1) Sb.Append(" ");
            }

            return Sb.ToString();
        }
    }
}
