using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings
{
    public class ValidPalindrome2
    {
        public bool ValidPalindrome(string s)
        {
            char[] arr = s.ToCharArray();
            int i = 0, j = s.Length - 1;

            while (i < j)
            {
                if (arr[i] != arr[j])
                {
                    return (CheckPalindrome(arr, i, j - 1) || CheckPalindrome(arr, i + 1, j));
                }
                i++;
                j--;
            }

            return true;
        }

        public bool CheckPalindrome(char[] s, int i, int j)
        {
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }

            return true;

        }
    }
}
