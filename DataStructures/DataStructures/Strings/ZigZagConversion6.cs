using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings
{
    class ZigZagConversion6
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;
            int n = s.ToCharArray().Length;

            List<StringBuilder> obj = new List<StringBuilder>();
            for (int i = 0; i < Math.Min(s.Length, numRows); i++)
            {
                obj.Add(new StringBuilder());
            }

            int curr = 0;
            bool goingdown = false;

            for (int i = 0; i < n; i++)
            {
                obj[curr].Append(s[i]);
                if (curr == 0 || curr == numRows - 1)
                    goingdown = !goingdown;   // when the curr is 0 you add 1 and when it reaches the rowNum you subtract one

                curr += goingdown ? 1 : -1;
            }

            StringBuilder result = new StringBuilder();

            foreach (var str in obj)
            {
                result.Append(str);
            }


            return result.ToString();
        }
    }
}
