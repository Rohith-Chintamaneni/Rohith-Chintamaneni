using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays._2pointer
{
    class ShortestWordDistanceProblem
    {
        public int ShortestDistance(string[] wordsDict, string word1, string word2)
        {
            int mindistance = wordsDict.Length;
            for (int i = 0; i < wordsDict.Length; i++)
            {
                if (wordsDict[i] == word1)
                {
                    for (int j = 0; j < wordsDict.Length; j++)
                    {
                        if (wordsDict[j] == word2) mindistance = Math.Min(mindistance, Math.Abs(i - j));
                    }
                }
            }

            return mindistance;
        }

        public int ShortestDistance2(string[] wordsDict, string word1, string word2)
        {
            int mindistance = wordsDict.Length;
            int i = -1, j = -1;
            for (int m = 0; m < wordsDict.Length; m++)
            {
                if (wordsDict[m] == word1) i = m;
                else if (wordsDict[m] == word2) j = m;
                if(i != -1 && j != -1)
                mindistance = Math.Min(mindistance, Math.Abs(i - j));
            }

            return mindistance;
        }
    }
}
