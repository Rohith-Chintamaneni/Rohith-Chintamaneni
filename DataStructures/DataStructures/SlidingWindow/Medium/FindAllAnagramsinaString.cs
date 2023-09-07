using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/find-all-anagrams-in-a-string/description/
namespace DataStructures.SlidingWindow.Medium
{
    public class FindAllAnagramsinaString
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            Dictionary<char, int> modfiedmap = new Dictionary<char, int>();
            foreach (var c in p)
            {
                if(map.ContainsKey(c))
                {
                    map[c]++;
                }
                else
                map.Add(c, 1);
            }
            char temp = new char();
            List<int> ans = new List<int>();
            int start = 0, end = 0;
            while (end < s.Length)
            {
                if (end - start + 1 < p.Length)
                {
                    temp = s[end];
                    if (modfiedmap.ContainsKey(temp))
                    {
                        modfiedmap[temp]++;
                    }
                    else
                    {
                        modfiedmap[temp] = 1;
                    }
                    end++;
                }
                else
                {
                    temp = s[end];
                    if(modfiedmap.ContainsKey(temp))
                        modfiedmap[temp]++;
                    else
                    {
                        modfiedmap[temp] = 1;
                    }
                    // check ans
                    if (CheckAllElementAreUsed(map, modfiedmap))
                    {
                        ans.Add(start);
                    }
                    // remove oldest
                    if (modfiedmap.ContainsKey(s[start]))
                        modfiedmap[s[start]]--;
                   

                    // increase both
                    end++;
                    start++;

                }


            }
            return ans;
        }

        public bool CheckAllElementAreUsed(Dictionary<char, int> map, Dictionary<char, int> modifiedmap)
        {
           
            bool ans = true;
            foreach (var key in map)
            {
                if (modifiedmap.ContainsKey(key.Key))
                {
                    if (modifiedmap[key.Key] != key.Value)
                    {
                        return false;
                    }
                }
                else
                    return false;
               
            }

            return ans;
        }
    }
}
