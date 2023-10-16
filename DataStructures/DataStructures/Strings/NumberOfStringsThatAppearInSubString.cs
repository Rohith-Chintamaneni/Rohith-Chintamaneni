using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/number-of-strings-that-appear-as-substrings-in-word/description/
namespace DataStructures.Strings
{
    public class NumberOfStringsThatAppearInSubString
    {
        public int NumOfStrings(string[] patterns, string word)
        {
           
            List<string> substrings = GenerateAllSubstrings(word);
            int count = 0;
            foreach (var s in patterns)
            {
                if (substrings.Contains(s)) count++;
            }
            return count;
        }
        public List<string> GenerateAllSubstrings(string input)
        {
            List<string> substrings = new List<string>();

            for (int length = 1; length <= input.Length; length++)
            {
                GenerateSubstrings(input, length, 0, 0, new char[length], substrings);
            }

            return substrings;
        }
        // backtracking
        public void GenerateSubstrings(string input, int length, int startIndex, int currentIndex, char[] currentSubstring, List<string> substrings)
        {
            if (currentIndex == length)
            {
                substrings.Add(new string(currentSubstring));
                return;
            }

            for (int i = startIndex; i < input.Length; i++)
            {
                currentSubstring[currentIndex] = input[i];
                GenerateSubstrings(input, length, i + 1, currentIndex + 1, currentSubstring, substrings);
            }
        }

        // USe contains method but that is built in.
    }
}


//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        string input = "abc";
//        List<string> substrings = GenerateAllSubstrings(input);

//        // Print the list of generated substrings
//        foreach (var substring in substrings)
//        {
//            Console.WriteLine(substring);
//        }
//    }

//    static List<string> GenerateAllSubstrings(string input)
//    {
//        List<string> substrings = new List<string>();

//        for (int length = 1; length <= input.Length; length++)
//        {
//            GenerateSubstrings(input, length, 0, 0, new char[length], substrings);
//        }

//        return substrings;
//    }

//    static void GenerateSubstrings(string input, int length, int startIndex, int currentIndex, char[] currentSubstring, List<string> substrings)
//    {
//        if (currentIndex == length)
//        {
//            substrings.Add(new string(currentSubstring));
//            return;
//        }

//        for (int i = startIndex; i < input.Length; i++)
//        {
//            currentSubstring[currentIndex] = input[i];
//            GenerateSubstrings(input, length, i + 1, currentIndex + 1, currentSubstring, substrings);
//        }
//    }
//}
