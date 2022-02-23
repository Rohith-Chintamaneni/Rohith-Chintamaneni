using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings
{
    class FirstUniqueCharacterinaString387
    {
        public int FirstUniqChar(string s)
        {
            int index = -1;

            Dictionary<char, int> result = new Dictionary<char, int>();

            int length = s.Length;

            for (int i = 0; i < length; i++)
            {

                if (!result.ContainsKey(s[i]))
                {
                    result[s[i]] = 1;
                }
                else
                {
                    result[s[i]] = result[s[i]] + 1;
                }
            }

            for (int i = 0; i < length; i++)
            {
                if (result[s[i]] == 1) return i;
            }

            return index;
        }

        // slightly modified
        public int SecondMethod(string s)
        {
            int index = -1;

            Dictionary<char, int> result = new Dictionary<char, int>();

            int length = s.Length;

            for (int i = 0; i < length; i++)
            {

                if (!result.ContainsKey(s[i]))
                {
                    result.Add(s[i], i);
                    // result[s[i]] = 1;
                }
                else
                {
                    result[s[i]] = -1;
                }
            }

            foreach (KeyValuePair<char, int> p in result)
            {
                if (p.Value != -1) return p.Value;
            }

            return index;
        }
    }
}
