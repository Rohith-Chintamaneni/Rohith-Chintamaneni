using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.SlidingWindow
{
    public class SubstringsofSizeThreewithDistinctCharacters
    {
        public int CountGoodSubstrings(string s)
        {
            int[] arr = new int[26];
            char temp = new char();
            int start = 0, end = 0;
            int ans = 0;
            while (end < s.Length)
            {
                if (end - start + 1 < 3)
                {
                    temp = s[end];
                    Add(arr, temp);
                    end++;
                }
                else
                {
                    temp = s[end];
                    Add(arr, temp);

                    // check for the answers
                    if (AreUnique(arr, 3))
                    {
                        ans++;
                    }
                    // remove oldest
                    Sutract(arr, s[start]);

                    // increment
                    start++;
                    end++;
                }
            }
            return ans;
        }

        public void Add(int[] arr, char c)
        {
            arr[c - 'a'] = arr[c - 'a']+ 1;
        }

        public void Sutract(int[] arr, char c)
        {
            arr[c - 'a'] = arr[c - 'a'] -1;
        }

        public bool AreUnique(int[] arr, int k)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 1)
                count += arr[i];
            }
            return count != k ? false : true;
        }
    }
}
