using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/
namespace DataStructures.SlidingWindow.Medium
{
   public class MaximumVowelsInaGivenString
    {

        // Brute force with Sliding. I am awesome. Exists method is killing it
        // when k = 57573 for avery long String it timed out. 
        public int MaxVowels(string s, int k)
        {
            int[] map = new int[26];
            map['a' - 'a'] = 1;
            map['e' - 'a'] = 1;
            map['i' - 'a'] = 1;
            map['o' - 'a'] = 1;
            map['u' - 'a'] = 1;
            // char[] ans = new char[s.Length];
            int ans = int.MinValue;
            int start = 0, end = 0;
            while (end < s.Length)
            {
                if (end - start + 1 < k)
                {

                    end++;
                }
                else
                {
                    // add onemore ans


                    // calculate
                    ans = Math.Max(ans, Exists(s.Substring(start, k).ToCharArray(), map, k));
                    // remove oldest index


                    // increment
                    end++;
                    start++;
                }


            }

            return ans;

        }

        public int Exists(char[] ans, int[] map, int k)
        {
            int count = 0;
            foreach (var c in ans)
            {
                if (map[c - 'a'] == 1) count++;
            }

            return count > k? k: count;
        }



        public int MaxVowels2(string s, int k)
        {

            int ans = int.MinValue;
            int start = 0, end = 0;
            int count = 0;
            while (end < s.Length)
            {
                if (end - start + 1 < k)
                {
                    if (IsVowel(s[end])) count++;
                    end++;
                }
                else
                {
                    // add onemore ans
                    if (IsVowel(s[end])) count++;

                    // calculate
                    ans = Math.Max(ans, count);
                    // remove oldest index
                    if (IsVowel(s[start])) count--;

                    // increment
                    end++;
                    start++;
                }


            }

            return ans;

        }

        public bool IsVowel(char c)
        {

            return (c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u');
        }
    }
}
