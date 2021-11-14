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
        
        public bool isPalindrome(String s)
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

    
    }
}
