using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings
{
    public class Maximum_Repeating_Substring
    {
        // passed 169 testcases but could not complete fully
        public int MaxRepeating(string sequence, string word)
        {
            int i = 0, j = 0;
            int count = 0;
            while (i < sequence.Length)
            {
                while (j < word.Length)
                {
                    if (i<sequence.Length && sequence[i] == word[j])
                    {
                        j++;
                        i++;
                    }
                    else
                    {
                        i++;
                        j = 0;
                        break;
                    }

                }
                if (j == word.Length)
                {
                    j = 0;
                    count++;
                }


            }
            return count;
        }

        public int MaxRepeating2(String sequence, String word)
        {
            int c = 0;
            String add = word;
            while (sequence.Contains(word))
            {
                c += 1;
                word = word + add;
                //System.out.println(word);
            }
            return c;
        }
    }
}
