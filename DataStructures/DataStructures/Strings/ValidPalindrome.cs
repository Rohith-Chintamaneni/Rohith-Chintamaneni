using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataStructures.Strings
{
    class ValidPalindrome
    {
        
        public bool isPalindrome1(String s)
        {
            if (s == " ") return true;

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var character in s.ToCharArray())
            {
                if (char.IsLetterOrDigit(character)) stringBuilder.Append(char.ToLower(character));
            }

           
            char[] arry = stringBuilder.ToString().ToCharArray();
            int st_ptr = 0, ed_ptr = arry.Length-1;

            while (st_ptr < ed_ptr)
            {
               if (arry[st_ptr] != arry[ed_ptr])
               {
                   return false;
               }
               st_ptr++;
               ed_ptr--;
            }

            return true;
        }

        // more advanced way. Inplace comparsion
        public bool isPalindrome2(String s)
        {
            if (s == " ") return true;

            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                while (i < j && !Char.IsLetterOrDigit(s[i]))
                {
                    i++;
                }

                while (i < j && !Char.IsLetterOrDigit(s[j]))
                {
                    j--;
                }

                if (Char.ToLower(s[i]) != Char.ToLower(s[j]))
                    return false;
            }

            return true;
        }

        public bool IsPalindrome(string s)
        {
            if (s == " ") return true;
            s = s.ToLower();
            int i = 0;
            int j = s.Length - 1;
            while (i <= s.Length - 1)
            {
                if (!char.IsLetterOrDigit(s[i])) i++;
                else if (!char.IsLetterOrDigit(s[j])) j--;

                else if (s[i] == s[j])
                {
                    i++;
                    j--;
                }
                else return false;
            }

            return true;
        }


    }
}
