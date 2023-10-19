using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings
{
    public class LongestCommonPrefix14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1) return strs[0];
            Array.Sort(strs, (s1, s2) => s2.Length.CompareTo(s1.Length));
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < strs.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < strs[i].Length; j++)
                {
                    if (strs[i - 1][j] == strs[i][j])
                    {
                        count++;
                    }
                    else break;
                }
                if (sb.Length == 0 && count > 0)
                    sb.Append(strs[i].Substring(0, count));
                else
                    sb.Remove(count, (sb.Length - count));

            }


            return sb.ToString();


        }
    }
}
