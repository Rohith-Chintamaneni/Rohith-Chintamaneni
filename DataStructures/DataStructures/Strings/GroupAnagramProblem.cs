using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings
{
    class GroupAnagramProblem
    {
        IList<IList<string>> results;
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            
            results = new List<IList<string>>();
            Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();
            foreach (var item in strs)
            {
                var temp = item;
                var chararray = item.ToCharArray();
                Array.Sort(chararray);
                if (keyValuePairs.ContainsKey(new string(chararray)))
                {
                    var list = keyValuePairs[new string(chararray)];
                    list.Add(temp);
                    keyValuePairs[new string(chararray)] = list;
                }
                else
                keyValuePairs.Add(new string(chararray), new List<string> { temp });
            }

            foreach (var item in keyValuePairs.Values)
            {
                results.Add(item);
            }

            return results;
        }
    }
}
