using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays._2pointer
{
    class ReverseWordsinaStringIIIProblem
    {
        // Approach 1: Leetcode 557 input : "God Ding" output:"doG gniD"
        public string ReverseWords(string s)
        {
            return null;
        }







        //approach 2: Leetcode 557 input : "God Ding" output:"doG gniD"
        //    public string ReverseWords(string s)
        //{
        //    string[] words = s.Split(' ');
        //    int wordslength = words.Length;
        //    int loopcount = 0;
        //    var stringBUilder = new StringBuilder();
        //    foreach (var word in words)
        //    {
        //        stringBUilder.Append(ReverseIndividualWords(word));
        //        if(loopcount < wordslength)
        //        stringBUilder.Append(" ");
        //        loopcount++;
        //    }

        //    return stringBUilder.ToString();
        //}

        //private string ReverseIndividualWords(string word)
        //{
        //    char[] str = word.ToCharArray();
        //    int m = 0;
        //    int n = word.Length - 1;
        //    while (m<n)
        //    {
        //        var temp = str[m];
        //        str[m] = str[n];
        //        str[n] = temp;
        //        m++;
        //        n--;
        //    }

        //    return string.Concat(str);
        //}
    }
}
