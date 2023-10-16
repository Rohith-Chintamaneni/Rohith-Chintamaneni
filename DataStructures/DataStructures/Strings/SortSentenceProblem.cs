using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings
{
    public class SortSentenceProblem
    {
        public string SortSentence(string s)
        {
            Dictionary<int, string> list = new Dictionary<int, string>();
            string[] arr = s.Split(" ");
            foreach (var str in arr)
            {
                var length = str.Length;
                list.Add(str[length-1]-'0', str.Substring(0, length -1));
            }
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                b.Append(list[i + 1]);
                if(i+1 != list.Count)
                b.Append(" ");
            }
            return b.ToString();
        }
    }
}
