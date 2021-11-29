using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings
{
    class ValidAnagramProblem
    {
        public bool IsAnagram(string s, string t)
        {
            var m = s.ToCharArray();
            var n = t.ToCharArray();
            Array.Sort(m);
            Array.Sort(n);
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] != n[i]) return false;
            }
            return true;
        }
        public bool IsAnagramUsingArray(string s, string t)
        {
            if (s.Length != t.Length) {
                return false;
            }
            int[] counter = new int[26];
            for (int i = 0; i < s.Length; i++) {
                counter[s[i] - 'a']++;
                counter[t[i] - 'a']--;
            }
            foreach (int count in counter) {
                if (count != 0) {
                    return false;
                }
            }
            return true;
        }
    }
}
