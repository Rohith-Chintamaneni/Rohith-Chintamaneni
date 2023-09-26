using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.SlidingWindow.Medium
{
    public class LongestSubStringWithoutRepeatingCharactersProblem
    {
           // "abcabcbb" output 3 as "abc"
        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> prevAppearance = new Dictionary<char, int>();
            int maxSubstringLength = 0;
            int prevNonRepeatingSubstringStartIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (prevAppearance.Keys.Contains(s[i]))
                {
                    prevNonRepeatingSubstringStartIndex =
                        Math.Max(prevAppearance[s[i]] + 1, prevNonRepeatingSubstringStartIndex);
                }
                maxSubstringLength =
                    Math.Max(maxSubstringLength, i - prevNonRepeatingSubstringStartIndex + 1);
                prevAppearance[s[i]] = i; 
            }

            return maxSubstringLength;




        }

        // Brute Force
        public int LengthOfLongestSubstringBF(string s)
        {
            int maxlength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (IsUnique(s, i, j))
                    {
                        maxlength = Math.Max(maxlength, j - i + 1);
                    }
                }
            }
            return maxlength;
        }

        public int LengthOfLongestSubstringBFOptimized_O_Nsquare(string s)
        {
            int maxlength = 0;
            int j = 0;
            bool[] visited ; 

            while (j < s.Length)
            {
                visited = new bool[256];
                int i = j;
                while (i < s.Length && visited[s[i]] == false)
                {
                    maxlength = Math.Max(maxlength, i - j + 1);
                    visited[s[i]] = true;
                    i++;
                }

                visited[s[j]] = false;
                j++;
            }
            return maxlength;
        }

        public int LengthOfLongestSubstringBFOptimized_O_N(string s)
        {
            int maxlength = 0;
            int j = 0, i=0;
            HashSet<char> set = new HashSet<char>();

            while (i < s.Length && j < s.Length)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j]);
                    j++;
                    maxlength = Math.Max(maxlength, j - i);
                }
                else
                {
                    set.Remove(s[i]);
                    i++;
                }
                
            }
          
            return maxlength;
        }

        private bool IsUnique(string s, int i, int j)
        {
            bool[] visited = new bool[256];
            bool isExist = true;
            for (int k = i; k <= j; k++)
            {
                if (visited[s[k]]) isExist= false;
                else
                    visited[s[k]] = true;

            }

            return isExist;
        }



      
        public int lengthOfLongestSubstringOptimizedSLidingWindowBydirectlyskipping(String s)
            {
            Dictionary<char, int> map = new Dictionary<char, int>();
            int start = 0, len = 0;

            // abba
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (map.ContainsKey(c))
                {
                    if (map[c] >= start)
                        start = map[c] + 1;
                }
                len = Math.Max(len, i - start + 1);
                map.Add(c, i);
            }

            return len;
        }

        public int LengthOfLongestSubstring_UsingCOmprehensiveGuide(string s)
        {

            if (s.Length == 0) return 0;
            if (s.Length == 1) return 1;
            HashSet<char> list = new HashSet<char>();
            int end = 0; int start = 0, count = 0, ans = int.MinValue;
            while (end < s.Length)
            {

                if (!list.Contains(s[end]))
                {
                    list.Add(s[end]);
                    count++;
                    end++;
                    ans = Math.Max(ans, count);
                }
                else
                {


                    // perform calculations
                    while (list.Contains(s[start]) && list.Contains(s[end]))
                    {
                        list.Remove(s[start]);
                        count--;
                        ans = Math.Max(ans, count);
                        start++;
                    }
                    list.Add(s[end]);
                    end++;
                    count++;
                }
            }
            return ans;
        }

    }
}
