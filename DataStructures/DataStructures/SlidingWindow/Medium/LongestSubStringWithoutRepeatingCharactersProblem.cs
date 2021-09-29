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

    }
}
