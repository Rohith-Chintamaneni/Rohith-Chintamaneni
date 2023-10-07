using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sort
{
    public class GroupAnagrams49
    {
        // Brute Force
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> results = new List<IList<string>>();
            int[] anagrams = new int[strs.Length];
            List<string> localanagrams = new List<string>();
            for (int i = 0; i < strs.Length; i++)
            {
                for (int j = i + 1; j < strs.Length; j++)
                {
                   if(anagrams[j] == 0)
                    {
                        if (IsAnaGram(strs[i], strs[j]))
                        {
                            anagrams[i] = i + 1;
                            anagrams[j] = i + 1;

                        }
                    }
                       
                   

                }

                for (int m = 0; m < strs.Length; m++)
                {
                    if (anagrams[m] == i+1)
                    {
                        localanagrams.Add(strs[m]);
                      
                    }

                }
                if(localanagrams.Count> 0) results.Add(new List<string>(localanagrams));
                localanagrams.Clear();
            }

            for(int k=0; k< strs.Length; k++)
            {
                if(anagrams[k] ==0)
                {
                    localanagrams.Add(strs[k]);
                    results.Add(new List<string>(localanagrams));
                    localanagrams.Clear();
                }
            }

            return results;

        }

        public bool IsAnaGram(string str, string ptr)
        {
            if (str.Length == 0 || ptr.Length == 0) return false;

            var arr = new int[126];
          

            for (int i = 0; i < str.Length; i++)
            {
                arr[str[i] - 0] = 1;
            }

            for (int j = 0; j < ptr.Length; j++)
            {
                arr[ptr[j] - 0] = 0;
            }
            int count = 0;
            for (int m = 0; m < arr.Length; m++)
            {
                count += arr[m];

            }

            if (count > 0) return false; else return true;
        }


        public IList<IList<string>> GroupAnagrams2(string[] strs)
        {
            IList<IList<string>> results = new List<IList<string>>();

            Dictionary<string, List<string>> temp = new Dictionary<string, List<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                if (temp.ContainsKey(GetSortedString(strs[i])))
                {
                    var ans = temp[GetSortedString(strs[i])];
                    ans.Add(strs[i]);

                }
                else
                {
                    temp.Add(GetSortedString(strs[i]), new List<string> { strs[i] });
                }
            }

            foreach (var keyvalue in temp)
            {
                results.Add(keyvalue.Value);
            }

            return results;
        }

        public string GetSortedString(string str)
        {
            var arr = str.ToCharArray();
            Array.Sort(arr);
            return new String(arr);
        }

    }
}
